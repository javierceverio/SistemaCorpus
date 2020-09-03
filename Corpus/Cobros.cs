using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Corpus
{
    public partial class Cobros : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public Cobros(String usuario, String trabajo, String aCobrar)
        {
            InitializeComponent();
            user.Text = usuario;
            nTrabajo.Text = trabajo;
            decimal aux = Convert.ToDecimal(aCobrar);   // Paso a decimal para luego darle el formato
            tCobrar.Text = aux.ToString("N");    // Doy formato
            ConsultarTotalOtros();
            try
            {
                decimal totalOtros = Convert.ToDecimal(lblTotalOtros.Text);
            }
            catch (Exception)
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            CalcularTotales();
        }

        public void CalcularSaldoTrabajo()
        {
            if (totalPresupuesto.Text != "")
            {
                lblSaldoTrabajo.Text = (Convert.ToDecimal(lblTotalTrabajo.Text) - Convert.ToDecimal(totalPresupuesto.Text)).ToString();
            }
            else
            {
                lblSaldoTrabajo.Text = lblTotalTrabajo.Text;
            }
            decimal aux = Convert.ToDecimal(lblSaldoTrabajo.Text);    // Lo paso a decimal para reconvertir a String con Formato correcto
            lblSaldoPresupuesto.Text = "$ " + aux.ToString("N");
        }

        public void CalcularSaldoOtros()
        {
            lblSaldoOtros.Text = (Convert.ToDecimal(lblTotalOtros.Text) - Convert.ToDecimal(totalOtros.Text)).ToString();
            decimal aux = Convert.ToDecimal(lblSaldoOtros.Text);    // Lo paso a decimal para reconvertir a String con Formato correcto
            lblSaldoParaOtros.Text = "$ " + aux.ToString("N");
        }

        public void CalcularTotales()
        {
            try
            {
                decimal totalTrabajo = Convert.ToDecimal(tCobrar.Text) - Convert.ToDecimal(lblTotalOtros.Text);
                lblTotalTrabajo.Text = totalTrabajo.ToString();
            }
            catch (Exception)
            {
                decimal aux = Convert.ToDecimal(tCobrar.Text);
                lblTotalTrabajo.Text = aux.ToString();
            }
        }

        public void ConsultarTotalOtros()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(Total) AS Total FROM Presupuestos WHERE NumTrabajo = '" + nTrabajo.Text + "' AND Nombre IN (SELECT Nombre FROM Otros)";
            cmd.Connection = conexion;
            conexion.Open();
            lblTotalOtros.Text = cmd.ExecuteScalar().ToString();
            conexion.Close();
        }

        public void DeshabilitarEntradasOtros()
        {
            montoTextBox1.Enabled = false;
            fechaDateTimePicker1.Enabled = false;
            observacionesTextBox1.Enabled = false;
        }

        public void HabilitarEntradasOtros()
        {
            montoTextBox1.Enabled = true;
            fechaDateTimePicker1.Enabled = true;
            observacionesTextBox1.Enabled = true;
        }

        public void DeshabilitarEntradas()
        {
            montoTextBox.Enabled = false;
            fechaDateTimePicker.Enabled = false;
            observacionesTextBox.Enabled = false;
        }

        public void HabilitarEntradas()
        {
            montoTextBox.Enabled = true;
            fechaDateTimePicker.Enabled = true;
            observacionesTextBox.Enabled = true;
        }

        public void SumarLosCobros()
        {
            decimal Presupuesto = 0;
            decimal Otros = 0;
            foreach (DataGridViewRow row in cobrosDataGridView.Rows)
            {
                Presupuesto += Convert.ToDecimal(row.Cells["Monto"].Value);
            }
            foreach (DataGridViewRow row in cobrosOtrosDataGridView.Rows)
            {
                Otros += Convert.ToDecimal(row.Cells["MontoOtro"].Value);
            }
            totalPresupuesto.Text = Presupuesto.ToString("N");
            totalOtros.Text = Otros.ToString("N");
            montoTotal.Text = (Presupuesto + Otros).ToString("N"); //Sumo los totales del presupuesto y de otros
            decimal aux = Convert.ToDecimal(tCobrar.Text);
            fCobrar.Text = (aux - (Presupuesto + Otros)).ToString("N");
        }

        private void Cobros_Load(object sender, EventArgs e)
        {
            this.cobrosOtrosTableAdapter.FillBy((this.corpusDataSet.CobrosOtros), nTrabajo.Text);
            this.cobrosTableAdapter.FillBy((this.corpusDataSet.Cobros), nTrabajo.Text);
            if (id_CobrosOtroTextBox.Text == "")
            {
                DeshabilitarEntradasOtros();
            }
            if (id_CobroTextBox.Text == "")
            {
                DeshabilitarEntradas();
            }
            SumarLosCobros();
            try
            {
                Convert.ToDecimal(lblTotalOtros.Text);
                CalcularSaldoOtros();
            }
            catch (Exception)
            {
                gbOtros.Visible = false;
            }
            CalcularSaldoTrabajo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id_CobroTextBox.Text == "")
            {
                MessageBox.Show("No hay Cobro seleccionado");
            }
            else
            {
                DialogResult dr = MessageBox.Show("¿Esta seguro que quiere Eliminar el Cobro del Trabajo Nº " + numTrabajoTextBox.Text + "?", "ELIMINAR COBRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    string sql3 = "DELETE FROM APagar WHERE (Id_Cobro = " + id_CobroTextBox.Text + ")";
                    string sql1 = "DELETE FROM Balance WHERE (Id_Cobro = " + id_CobroTextBox.Text + ")";
                    string sql2 = "DELETE FROM Cobros WHERE (Id_Cobro = " + id_CobroTextBox.Text + ")";
                    SqlCommand command1 = new SqlCommand(sql1, conexion);
                    SqlCommand command3 = new SqlCommand(sql3, conexion);
                    SqlCommand command2 = new SqlCommand(sql2, conexion);
                    SqlTransaction transaccion = null;
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(IsolationLevel.RepeatableRead);
                    command1.Transaction = transaccion;
                    command2.Transaction = transaccion;
                    command3.Transaction = transaccion;
                    try
                    {
                        command1.ExecuteNonQuery();
                        command3.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                        transaccion.Commit();
                        MessageBox.Show("Se ha Eliminado el Cobro");
                        this.cobrosTableAdapter.FillBy((this.corpusDataSet.Cobros), nTrabajo.Text);
                        SumarLosCobros();
                        CalcularSaldoTrabajo();
                        if (id_CobroTextBox.Text == "")
                        {
                            DeshabilitarEntradas();
                        }
                    }
                    catch (Exception)
                    {
                        transaccion.Rollback();
                        MessageBox.Show("La Transaccion no se pudo realizar. Por favor intentelo mas tarde. En caso de que este mensaje se repita, por favor comuniquese con CreISys.");
                    }
                    conexion.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularSaldoTrabajo();
            if (Convert.ToDecimal(lblSaldoTrabajo.Text) == 0)
            {
                MessageBox.Show("El Trabajo Nº " + numTrabajoTextBox.Text + " ya ha sido cobrado en su Totalidad.");
            }
            else
            {
                using (NuevoCobro frm1 = new NuevoCobro(user.Text, nTrabajo.Text, tCobrar.Text, lblSaldoTrabajo.Text))
                {
                    frm1.ShowDialog();
                }
                this.cobrosTableAdapter.FillBy((this.corpusDataSet.Cobros), nTrabajo.Text);
                if (id_CobroTextBox.Text != "")
                {
                    HabilitarEntradas();
                    SumarLosCobros();
                    CalcularSaldoTrabajo();
                    cobrosDataGridView.CurrentCell = cobrosDataGridView.Rows[cobrosDataGridView.Rows.Count - 1].Cells[2]; // me posiciono en la ultima fila
                }
            }
        }

        public void ConsultarMontoParaActualizar() // Para saber cual era el monto antes de sobreescribirlo, pues necesito saber si va a sobrepasar el Saldo o no
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Monto FROM Cobros WHERE Id_Cobro = '" + id_CobroTextBox.Text + "'";
            cmd.Connection = conexion;
            conexion.Open();
            lblMontoAnterior.Text = cmd.ExecuteScalar().ToString();
            conexion.Close();
        }

        public void ConsultarMontoOtroParaActualizar() // Para saber cual era el monto antes de sobreescribirlo, pues necesito saber si va a sobrepasar el Saldo o no
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Monto FROM CobrosOtros WHERE Id_CobrosOtro = '" + id_CobrosOtroTextBox.Text + "'";
            cmd.Connection = conexion;
            conexion.Open();
            lblMontoOtroAnterior.Text = cmd.ExecuteScalar().ToString();
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id_CobroTextBox.Text == "")
            {
                MessageBox.Show("No hay Cobro seleccionado");
            }
            else
            {
                if (montoTextBox.Text != "" && fechaDateTimePicker.Text != "")
                {
                    CalcularSaldoTrabajo();
                    ConsultarMontoParaActualizar();
                    decimal saldoReal = (Convert.ToDecimal(lblSaldoTrabajo.Text) + Convert.ToDecimal(lblMontoAnterior.Text));  // Obtengo el Saldo - el Monto que figuraba anteriormente en este Cobro
                    if (Convert.ToDecimal(montoTextBox.Text) > saldoReal)
                    {
                        MessageBox.Show("El Monto no debe ser mayor a $ " + saldoReal.ToString());
                        string fila = cobrosDataGridView.CurrentRow.Index.ToString(); // guardo la fila donde estoy
                        cobrosDataGridView.Rows[0].Selected = true;
                        int filaNumero = Convert.ToInt16(fila);
                        this.cobrosTableAdapter.FillBy((this.corpusDataSet.Cobros), nTrabajo.Text);
                        cobrosDataGridView.CurrentCell = cobrosDataGridView.Rows[filaNumero].Cells[2]; // me posiciono nuevamente en la fila donde estaba
                        montoTextBox.Focus();
                    }
                    else
                    {
                        try
                        {
                            decimal aux = Convert.ToDecimal(montoTextBox.Text);

                            string monto = Convert.ToString(montoTextBox.Text.Replace(',', '.'));
                            string sql3 = "UPDATE Cobros SET Monto = " + monto + ", Fecha = '" + fechaDateTimePicker.Text + "', Observaciones = '" + observacionesTextBox.Text.Replace("'", "") + "', UsuMod = '" + user.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_Cobro = " + id_CobroTextBox.Text + ")";
                            string sql1 = "UPDATE APagar SET Monto = " + monto + ", Fecha = '" + fechaDateTimePicker.Text + "', Observaciones = '" + observacionesTextBox.Text.Replace("'", "") + "', UsuMod = '" + user.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_Cobro = " + id_CobroTextBox.Text + ")";
                            string sql2 = "UPDATE Balance SET Monto = " + monto + ", Fecha = '" + fechaDateTimePicker.Text + "', Observaciones = '" + observacionesTextBox.Text.Replace("'", "") + "', UsuMod = '" + user.Text + "' WHERE (Id_Cobro = " + id_CobroTextBox.Text + ")";
                            SqlCommand command1 = new SqlCommand(sql1, conexion);
                            SqlCommand command3 = new SqlCommand(sql3, conexion);
                            SqlCommand command2 = new SqlCommand(sql2, conexion);
                            SqlTransaction transaccion = null;
                            conexion.Open();
                            transaccion = conexion.BeginTransaction(IsolationLevel.RepeatableRead);
                            command1.Transaction = transaccion;
                            command2.Transaction = transaccion;
                            command3.Transaction = transaccion;
                            try
                            {
                                command1.ExecuteNonQuery();
                                command3.ExecuteNonQuery();
                                command2.ExecuteNonQuery();
                                transaccion.Commit();
                                MessageBox.Show("Los datos del Cobro del Trabajo Nº " + numTrabajoTextBox.Text + " se han actualizado de manera satisfactoria");
                                string fila = cobrosDataGridView.CurrentRow.Index.ToString(); // guardo la fila donde estoy
                                cobrosDataGridView.Rows[0].Selected = true;
                                int filaNumero = Convert.ToInt16(fila);
                                this.cobrosTableAdapter.FillBy((this.corpusDataSet.Cobros), nTrabajo.Text);
                                cobrosDataGridView.CurrentCell = cobrosDataGridView.Rows[filaNumero].Cells[2]; // me posiciono nuevamente en la fila donde estaba
                                SumarLosCobros();
                                CalcularSaldoTrabajo();
                            }
                            catch (Exception)
                            {
                                transaccion.Rollback();
                                MessageBox.Show("La Transaccion no se pudo realizar. Por favor intentelo mas tarde. En caso de que este mensaje se repita, por favor comuniquese con CreISys.");
                            }
                            conexion.Close();

                        }
                        catch
                        {
                            MessageBox.Show("El campo Monto solo admite numeros");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios");
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            CalcularSaldoOtros();
            if (Convert.ToDecimal(lblSaldoOtros.Text) == 0)
            {
                MessageBox.Show("Los Otros del Trabajo Nº " + numTrabajoTextBox.Text + " han sido cobrados en su Totalidad.");
            }
            else
            {
                using (NuevoCobroOtro frm1 = new NuevoCobroOtro(user.Text, nTrabajo.Text, lblSaldoOtros.Text))
                {
                    frm1.ShowDialog();
                }
                this.cobrosOtrosTableAdapter.FillBy((this.corpusDataSet.CobrosOtros), nTrabajo.Text);
                if (id_CobrosOtroTextBox.Text != "")
                {
                    HabilitarEntradasOtros();
                    SumarLosCobros();
                    CalcularSaldoOtros();
                    cobrosOtrosDataGridView.CurrentCell = cobrosOtrosDataGridView.Rows[cobrosOtrosDataGridView.Rows.Count - 1].Cells[2]; // me posiciono en la ultima fila
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (id_CobrosOtroTextBox.Text == "")
            {
                MessageBox.Show("No hay Cobro de Otro seleccionado");
            }
            else
            {
                if (montoTextBox1.Text != "" && fechaDateTimePicker1.Text != "")
                {
                    CalcularSaldoOtros();
                    ConsultarMontoOtroParaActualizar();
                    decimal saldoOtrosReal = (Convert.ToDecimal(lblSaldoOtros.Text) + Convert.ToDecimal(lblMontoOtroAnterior.Text));  // Obtengo el Saldo de Otros + el Monto que figuraba anteriormente en este Cobro de Otros
                    if (Convert.ToDecimal(montoTextBox1.Text) > saldoOtrosReal)
                    {
                        MessageBox.Show("El Monto no debe ser mayor a $ " + saldoOtrosReal.ToString());
                        string fila = cobrosOtrosDataGridView.CurrentRow.Index.ToString(); // guardo la fila donde estoy
                        cobrosOtrosDataGridView.Rows[0].Selected = true;
                        int filaNumero = Convert.ToInt16(fila);
                        this.cobrosOtrosTableAdapter.FillBy((this.corpusDataSet.CobrosOtros), nTrabajo.Text);
                        cobrosOtrosDataGridView.CurrentCell = cobrosOtrosDataGridView.Rows[filaNumero].Cells[2]; // me posiciono nuevamente en la fila donde estaba
                        montoTextBox1.Focus();
                    }
                    else
                    {
                        try
                        {
                            decimal aux = Convert.ToDecimal(montoTextBox1.Text);
                            string monto = Convert.ToString(montoTextBox1.Text.Replace(',', '.'));
                            string sql3 = "UPDATE CobrosOtros SET Monto = " + monto + ", Fecha = '" + fechaDateTimePicker1.Text + "', Observaciones = '" + observacionesTextBox1.Text.Replace("'", "") + "', UsuMod = '" + user.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_CobrosOtro = " + id_CobrosOtroTextBox.Text + ")";
                            string sql1 = "UPDATE APagarOtros SET Monto = " + monto + ", Fecha = '" + fechaDateTimePicker1.Text + "', Observaciones = '" + observacionesTextBox1.Text.Replace("'", "") + "', UsuMod = '" + user.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_CobroOtro = " + id_CobrosOtroTextBox.Text + ")";
                            string sql2 = "UPDATE Balance SET Monto = " + monto + ", Fecha = '" + fechaDateTimePicker1.Text + "', Observaciones = '" + observacionesTextBox1.Text.Replace("'", "") + "', UsuMod = '" + user.Text + "' WHERE (Id_CobroOtro = " + id_CobrosOtroTextBox.Text + ")";
                            SqlCommand command1 = new SqlCommand(sql1, conexion);
                            SqlCommand command3 = new SqlCommand(sql3, conexion);
                            SqlCommand command2 = new SqlCommand(sql2, conexion);
                            SqlTransaction transaccion = null;
                            conexion.Open();
                            transaccion = conexion.BeginTransaction(IsolationLevel.RepeatableRead);
                            command1.Transaction = transaccion;
                            command2.Transaction = transaccion;
                            command3.Transaction = transaccion;
                            try
                            {
                                command1.ExecuteNonQuery();
                                command3.ExecuteNonQuery();
                                command2.ExecuteNonQuery();
                                transaccion.Commit();
                                MessageBox.Show("Los datos del Cobro de Otros del Trabajo Nº " + numTrabajoTextBox.Text + " se han actualizado de manera satisfactoria");
                                string fila = cobrosOtrosDataGridView.CurrentRow.Index.ToString(); // guardo la fila donde estoy
                                cobrosOtrosDataGridView.Rows[0].Selected = true;
                                int filaNumero = Convert.ToInt16(fila);
                                this.cobrosOtrosTableAdapter.FillBy((this.corpusDataSet.CobrosOtros), nTrabajo.Text);
                                cobrosOtrosDataGridView.CurrentCell = cobrosOtrosDataGridView.Rows[filaNumero].Cells[2]; // me posiciono nuevamente en la fila donde estaba
                                SumarLosCobros();
                                CalcularSaldoOtros();
                            }
                            catch (Exception)
                            {
                                transaccion.Rollback();
                                MessageBox.Show("La Transaccion no se pudo realizar. Por favor intentelo mas tarde. En caso de que este mensaje se repita, por favor comuniquese con CreISys.");
                            }
                            conexion.Close();
                        }
                        catch
                        {
                            MessageBox.Show("El campo Monto solo admite numeros");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios");
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (id_CobrosOtroTextBox.Text == "")
            {
                MessageBox.Show("No hay Cobro de Otro seleccionado");
            }
            else
            {
                DialogResult dr = MessageBox.Show("¿Esta seguro que quiere Eliminar el Cobro de Otro del Trabajo Nº " + numTrabajoTextBox.Text + "?", "ELIMINAR COBRO DE OTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    string sql3 = "DELETE FROM APagarOtros WHERE (Id_CobroOtro = " + id_CobrosOtroTextBox.Text + ")";
                    string sql1 = "DELETE FROM Balance WHERE (Id_CobroOtro = " + id_CobrosOtroTextBox.Text + ")";
                    string sql2 = "DELETE FROM CobrosOtros WHERE (Id_CobrosOtro = " + id_CobrosOtroTextBox.Text + ")";
                    SqlCommand command1 = new SqlCommand(sql1, conexion);
                    SqlCommand command3 = new SqlCommand(sql3, conexion);
                    SqlCommand command2 = new SqlCommand(sql2, conexion);
                    SqlTransaction transaccion = null;
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(IsolationLevel.RepeatableRead);
                    command1.Transaction = transaccion;
                    command2.Transaction = transaccion;
                    command3.Transaction = transaccion;
                    try
                    {
                        command1.ExecuteNonQuery();
                        command3.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                        transaccion.Commit();
                        MessageBox.Show("Se ha Eliminado el Cobro de Otro");
                        this.cobrosOtrosTableAdapter.FillBy((this.corpusDataSet.CobrosOtros), nTrabajo.Text);
                        SumarLosCobros();
                        CalcularSaldoOtros();
                        if (id_CobrosOtroTextBox.Text == "")
                        {
                            DeshabilitarEntradasOtros();
                        }
                    }
                    catch (Exception)
                    {
                        transaccion.Rollback();
                        MessageBox.Show("La Transaccion no se pudo realizar. Por favor intentelo mas tarde. En caso de que este mensaje se repita, por favor comuniquese con CreISys.");
                    }
                    conexion.Close();
                }
            }
        }
    }
}
