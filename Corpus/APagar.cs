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
    public partial class APagar : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public APagar(String usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        public void ConsultaPresupuesto()
        {
            ConsultarMontoACobrarPorOtros();
            string monto = Convert.ToString(montoTextBox.Text.Replace(',', '.'));  // preparo el numero decimal, el que trae de la base de datos esta mal siempre por las comas y puntos
            string total = Convert.ToString(lblTotalACobrar.Text.Replace(',', '.'));
            SqlCommand cmd = new SqlCommand("SELECT Nombre, FORMAT(Total, '#,###.00') AS 'Monto Total del Trabajo', FORMAT((Total * " + monto + " * 100 / " + total + " / 100), '#,###.00') AS 'Monto Cobrado a Pagar' FROM Presupuestos WHERE NumTrabajo = " + numTrabajoTextBox.Text + " AND Nombre IN (SELECT Nombre FROM Empleados UNION SELECT Nombre FROM EmpleadosExternos)", conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV.DataSource = dt;
            conexion.Close();
            DataGridViewColumn column = DGV.Columns[0];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void MontoApagar()
        {
            decimal sumar = 0; // sumo para ver cuanto tengo que pagar, puede que sea diferente al dinero del cobro por los impuestos cuando es en blanco
            decimal totalACobrarProfesionales = 0;
            foreach (DataGridViewRow row in DGV.Rows)
            {
                sumar += Convert.ToDecimal(row.Cells["Monto Cobrado a Pagar"].Value);
                totalACobrarProfesionales += Convert.ToDecimal(row.Cells["Monto Total del Trabajo"].Value);
            }
            totalApagar.Text = sumar.ToString("N");
        }

        private void APagar_Load(object sender, EventArgs e)
        {
            this.aPagarOtrosTableAdapter.Fill(this.corpusDataSet.APagarOtros);
            this.aPagarTableAdapter.Fill(this.corpusDataSet.APagar);

            if (id_APagarTextBox.Text != "")
            {
                ConsultaPresupuesto();
                MontoApagar();
            }
        }

        public void ConsultarMontoACobrarPorOtros () // Para saber cual era el monto antes de sobreescribirlo, pues necesito saber si va a sobrepasar el Saldo o no
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT SUM(Total) FROM Presupuestos WHERE NumTrabajo = " + numTrabajoTextBox.Text + " AND Nombre IN (SELECT Nombre FROM Otros)";
            cmd.Connection = conexion;
            try
            {
                conexion.Open();
                lblTotalACobrar.Text = cmd.ExecuteScalar().ToString();
                conexion.Close();
                decimal auxiliar = Convert.ToDecimal(totalTextBox.Text) - Convert.ToDecimal(lblTotalACobrar.Text);
                lblTotalACobrar.Text = auxiliar.ToString();
            }
            catch (Exception)
            {
                lblTotalACobrar.Text = totalTextBox.Text;
            }
        }

        public void InsertarCobroEnPagos()
        {
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text
            };  // Primero insertamos el Cobro en Pagos Realizados
            string monto = Convert.ToString(montoTextBox.Text.Replace(',', '.'));
            string preciototal = Convert.ToString(totalTextBox.Text.Replace(',', '.'));
            cmd.CommandText = "INSERT into Pagos (Id_Cobro, NumTrabajo, Referencia, Nombre, Monto, Fecha, Total, Observaciones, UsuCre) VALUES ('" + id_CobroTextBox.Text + "', '" + numTrabajoTextBox.Text + "', '" + "Trabajo" + "', '" + "Pago" + "', " + monto + ", '" + DateTime.Now + "', " + preciototal + ", '" + observacionesTextBox.Text + "', '" + user.Text + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("El Cobro del Trabajo Nº " + numTrabajoTextBox.Text + " se ha Pagado de manera satisfactoria");
        }

        public void InsertarCobroEnBalance()
        {
            SqlCommand cmd4 = new SqlCommand
            {
                CommandType = CommandType.Text
            };  // Segundo, insertamos el Cobro en Balance
            decimal aux = Convert.ToDecimal(totalApagar.Text); // Hago conversiones para que el numero no tenga puntos entre los miles
            string montoApagar = aux.ToString().Replace(',', '.');
            cmd4.CommandText = "INSERT into Balance (Nombre, Id_Cobro, Concepto, Referencia, Monto, Fecha, Observaciones, UsuCre) VALUES ('" + "TRABAJO" + "', '" + id_CobroTextBox.Text + "', '" + "Pago de un Cobro" + "', '" + numTrabajoTextBox.Text + "', " + "-" + montoApagar + ", '" + DateTime.Now + "', '" + observacionesTextBox.Text + "', '" + user.Text + "')";
            cmd4.Connection = conexion;
            conexion.Open();
            cmd4.ExecuteNonQuery();
            conexion.Close();
        }

        public void BorrarCobro()
        {
            SqlCommand cmd2 = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "DELETE FROM APagar WHERE (Id_APagar = " + id_APagarTextBox.Text + ")", Connection = conexion};  // Tercero, borramos el Cobro de A Pagar
            conexion.Open();
            cmd2.ExecuteNonQuery();
            conexion.Close();
        }

        public void VaciarTablaDetalles()
        {
            if (montoTextBox.Text != "")
            {
                ConsultaPresupuesto();
            }
            else
            {
                DGV.DataSource = "";
                totalApagar.Clear();
            }
        }

        public void InsertarEnCobrosEmpleados()
        {
            foreach (DataGridViewRow row in DGV.Rows)
            {
                String Empleado = row.Cells["Nombre"].Value.ToString();
                String Monto = Convert.ToString(row.Cells["Monto Cobrado a Pagar"].Value.ToString());
                DataTable dt = empleadosTableAdapter1.GetData();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    object[] array = dt.Rows[i].ItemArray;
                    if (Empleado == array[1].ToString())
                    {
                        SqlCommand cmd4 = new SqlCommand
                        {
                            CommandType = CommandType.Text
                        };  // Mandar a la tabla cobros de empleados
                        decimal aux = Convert.ToDecimal(Monto); // Hago conversiones para que el numero no tenga puntos entre los miles
                        string montoApagar = aux.ToString().Replace(',', '.');
                        cmd4.CommandText = "INSERT into CobrosEmpleados (Nombre, NumTrabajo, Cobrado, Fecha, UsuCre) VALUES ('" + Empleado + "', '" + numTrabajoTextBox.Text + "', " + montoApagar + ", '" + DateTime.Now + "', '" + user.Text + "')";
                        cmd4.Connection = conexion;
                        conexion.Open();
                        cmd4.ExecuteNonQuery();
                        conexion.Close();
                    }
                }
            }
        }

        public void InsertarEnCobrosEmpleadosExternos()
        {
            foreach (DataGridViewRow row in DGV.Rows)
            {
                String Empleado = row.Cells["Nombre"].Value.ToString();
                String Monto = Convert.ToString(row.Cells["Monto Cobrado a Pagar"].Value.ToString());
                DataTable dt = empleadosExternosTableAdapter1.GetData();
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    object[] array = dt.Rows[i].ItemArray;
                    if (Empleado == array[1].ToString())
                    {
                        SqlCommand cmd4 = new SqlCommand
                        {
                            CommandType = CommandType.Text
                        };  // Mandar a la tabla cobros de empleados externos
                        decimal aux = Convert.ToDecimal(Monto); // Hago conversiones para que el numero no tenga puntos entre los miles
                        string montoApagar = aux.ToString().Replace(',', '.');
                        cmd4.CommandText = "INSERT into CobrosEmpleadosExternos (Nombre, NumTrabajo, Cobrado, Fecha, UsuCre) VALUES ('" + Empleado + "', '" + numTrabajoTextBox.Text + "', " + montoApagar + ", '" + DateTime.Now + "', '" + user.Text + "')";
                        cmd4.Connection = conexion;
                        conexion.Open();
                        cmd4.ExecuteNonQuery();
                        conexion.Close();
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (id_APagarTextBox.Text != "")
            {
                DialogResult dr = MessageBox.Show("¿Esta seguro que quiere Efectivizar el Pago del Cobro del Trabajo Nº " + numTrabajoTextBox.Text + "?", "PAGAR UN COBRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    InsertarCobroEnPagos();

                    InsertarCobroEnBalance();

                    InsertarEnCobrosEmpleados();

                    InsertarEnCobrosEmpleadosExternos();

                    BorrarCobro();

                    this.aPagarTableAdapter.Fill(this.corpusDataSet.APagar);

                    conexion.Close();

                    VaciarTablaDetalles();
                }
            }
            else
            {
                MessageBox.Show("No hay Cobro para Pagar");
            }
        }

        private void APagarDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ConsultaPresupuesto();

            MontoApagar();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (id_APagarOtroTextBox.Text != "")
            {
                DialogResult dr = MessageBox.Show("¿Esta seguro que quiere Efectivizar el Pago del Cobro de Otros del Trabajo Nº " + numTrabajoTextBox1.Text + "?", "PAGAR UN COBRO DE OTROS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    string monto = Convert.ToString(montoTextBox1.Text.Replace(',', '.'));
                    string sql1 = "INSERT into Pagos (Id_Cobro, NumTrabajo, Referencia, Nombre, Monto, Fecha, Observaciones, UsuCre) VALUES ('" + id_CobroOtroTextBox.Text + "', '" + numTrabajoTextBox1.Text + "', '" + "Otros" + "', '" + "Pago de Otro" + "', " + monto + ", '" + DateTime.Now + "', '" + observacionesTextBox1.Text + "', '" + user.Text + "')";
                    string sql2 = "INSERT into Balance (Nombre, Id_CobroOtro, Concepto, Referencia, Monto, Fecha, Observaciones, UsuCre) VALUES ('" + "TRABAJO" + "', '" + id_CobroOtroTextBox.Text + "', '" + "Pago de un Cobro de Otro" + "', '" + numTrabajoTextBox1.Text + "', " + "-" + monto + ", '" + DateTime.Now + "', '" + observacionesTextBox1.Text + "', '" + user.Text + "')";
                    string sql3 = "DELETE FROM APagarOtros WHERE (Id_APagarOtro = " + id_APagarOtroTextBox.Text + ")";
                    SqlCommand command1 = new SqlCommand(sql1, conexion);
                    SqlCommand command2 = new SqlCommand(sql2, conexion);
                    SqlCommand command3 = new SqlCommand(sql3, conexion);
                    SqlTransaction transaccion = null;
                    conexion.Open();
                    transaccion = conexion.BeginTransaction(IsolationLevel.RepeatableRead);
                    command1.Transaction = transaccion;
                    command2.Transaction = transaccion;
                    command3.Transaction = transaccion;
                    try
                    {
                        command1.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                        command3.ExecuteNonQuery();
                        transaccion.Commit();
                        MessageBox.Show("El Cobro de Otro del Trabajo Nº " + numTrabajoTextBox1.Text + " se ha Pagado de manera satisfactoria");
                    }
                    catch (Exception)
                    {
                        transaccion.Rollback();
                        MessageBox.Show("La Transaccion no se pudo realizar. Por favor intentelo mas tarde. En caso de que este mensaje se repita, por favor comuniquese con CreISys.");
                    }
                    conexion.Close();

                    this.aPagarOtrosTableAdapter.Fill(this.corpusDataSet.APagarOtros);
                }
            }
            else
            {
                MessageBox.Show("No hay Cobro de Otros para Pagar");
            }
        }
    }
}
