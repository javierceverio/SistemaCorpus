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
using System.Text.RegularExpressions;

namespace Corpus
{
    public partial class Presupuestos : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public Presupuestos(String usuario, String trabajo, String total)
        {
            InitializeComponent();
            user.Text = usuario;
            nTrabajo.Text = trabajo;
            precioSinImpuestos.Text = total.Replace(".", ",");
        }

        public void SumarItemsPresupuesto()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in presupuestosDataGridView.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Total"].Value);
            }
            //montoTotal.Text = Convert.ToString(total);
            montoTotal.Text = total.ToString("N");
            decimal totalFacturas = 0;
            foreach (DataGridViewRow row in presupuestosDataGridView.Rows) // Tambien Suma los Items con Factura
            {
                if (Convert.ToBoolean(row.Cells["Factura"].Value) == true)
                {
                    totalFacturas += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }
            //montoFactura.Text = Convert.ToString(totalFacturas);
            montoFactura.Text = totalFacturas.ToString("N");
        }

        private void Presupuestos_Load(object sender, EventArgs e)
        {
            this.fijosTableAdapter.Fill(this.corpusDataSet.Fijos);
            this.otrosTableAdapter.Fill(this.corpusDataSet.Otros);
            this.impuestosTableAdapter.Fill(this.corpusDataSet.Impuestos);
            this.gastosTableAdapter.Fill(this.corpusDataSet.Gastos);
            this.empleadosExternosTableAdapter.Fill(this.corpusDataSet.EmpleadosExternos);
            this.empleadosTableAdapter.Fill(this.corpusDataSet.Empleados);
            this.presupuestosTableAdapter.FillBy((this.corpusDataSet.Presupuestos), nTrabajo.Text);
            SumarItemsPresupuesto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (NuevoEmpleado frm1 = new NuevoEmpleado(user.Text))
            {
                frm1.ShowDialog();
            }
            this.empleadosTableAdapter.Fill(this.corpusDataSet.Empleados);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (NuevoEmpleadoExterno frm1 = new NuevoEmpleadoExterno(user.Text))
            {
                frm1.ShowDialog();
            }
            this.empleadosExternosTableAdapter.Fill(this.corpusDataSet.EmpleadosExternos);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (NuevoServicio frm1 = new NuevoServicio(user.Text))
            {
                frm1.ShowDialog();
            }
            this.impuestosTableAdapter.Fill(this.corpusDataSet.Impuestos);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (NuevoGasto frm1 = new NuevoGasto(user.Text))
            {
                frm1.ShowDialog();
            }
            this.gastosTableAdapter.Fill(this.corpusDataSet.Gastos);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (NuevoOtro frm1 = new NuevoOtro(user.Text))
            {
                frm1.ShowDialog();
            }
            this.otrosTableAdapter.Fill(this.corpusDataSet.Otros);
        }

        public void InsertarEmpleadoEnPresupuesto()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            decimal monto2 = Convert.ToDecimal(montoEmpleado.Text);
            monto2 = Math.Abs(monto2);
            int meses2 = Convert.ToInt16(mesEmpleado.Text);
            meses2 = Math.Abs(meses2);
            string monto = Convert.ToString(monto2.ToString().Replace(',', '.'));
            string meses = Convert.ToString(meses2.ToString());
            string totalemp = Convert.ToString(totalEmpleado.Text.Replace(',', '.'));
            bool conOsinFactura;
            if (facturaEmpleado.Checked)
            {
                conOsinFactura = true;
            }
            else
            {
                conOsinFactura = false;
            }
            cmd.CommandText = "INSERT into Presupuestos (NumTrabajo, Nombre, Monto, Meses, Total, Factura, UsuCre, FechaCre) VALUES ('" + nTrabajo.Text + "', '" + nombreEmpleadoComboBox.Text + "', " + monto + ", " + meses + ", " + totalemp + ", '" + conOsinFactura + "', '" + user.Text + "', '" + DateTime.Now + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool completoTodo = true;
            if (nombreEmpleadoComboBox.Text != "" && montoEmpleado.Text != "" && mesEmpleado.Text != "")
            {
                try
                {
                    decimal monto = Convert.ToDecimal(montoEmpleado.Text);
                    monto = Math.Abs(monto);
                    int meses = Convert.ToInt16(mesEmpleado.Text);
                    meses = Math.Abs(meses);
                    totalEmpleado.Text = (monto * meses).ToString();
                    DataTable dt = presupuestosTableAdapter.GetData();
                    int aux = 0; // Para saber si el cliente no esta en la BD
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        object[] array = dt.Rows[i].ItemArray;
                        if (nombreEmpleadoComboBox.Text.ToString() == array[2].ToString() && nTrabajo.Text.ToString() == array[1].ToString())
                        {
                            MessageBox.Show("Ya existe el Profesional Interno " + nombreEmpleadoComboBox.Text + " en el Presupuesto");
                            aux = 1;
                        }
                    }
                    if (aux == 0)
                    {
                        InsertarEmpleadoEnPresupuesto();
                        facturaEmpleado.Checked = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Verifique que el monto o la cantidad de meses cumplen con el formato de numeros");
                    montoEmpleado.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al Profesional Interno, completar el Monto y la cantidad de Meses");
                completoTodo = false;
            }
            if (completoTodo)
            {
                this.presupuestosTableAdapter.FillBy((this.corpusDataSet.Presupuestos), nTrabajo.Text);

                SumarItemsPresupuesto();

                montoEmpleado.Clear();
                mesEmpleado.Clear();
                totalEmpleado.Clear();
            }
        }

        public void InsertarEmpleadoExternoEnPresupuesto()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            decimal monto2 = Convert.ToDecimal(montoEmpleadoExterno.Text);
            monto2 = Math.Abs(monto2);
            int meses2 = Convert.ToInt16(mesEmpleadoExterno.Text);
            meses2 = Math.Abs(meses2);
            string monto = Convert.ToString(monto2.ToString().Replace(',', '.'));
            string meses = Convert.ToString(meses2.ToString());
            string totalemp = Convert.ToString(totalEmpleadoExterno.Text.Replace(',', '.'));
            bool conOsinFactura;
            if (facturaEmpleadoExterno.Checked)
            {
                conOsinFactura = true;
            }
            else
            {
                conOsinFactura = false;
            }
            cmd.CommandText = "INSERT into Presupuestos (NumTrabajo, Nombre, Monto, Meses, Total, Factura, UsuCre, FechaCre) VALUES ('" + nTrabajo.Text + "', '" + nombreEmpleadoExternoComboBox1.Text + "', " + monto + ", " + meses + ", " + totalemp + ", '" + conOsinFactura + "', '" + user.Text + "', '" + DateTime.Now + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool completoTodo = true;
            if (nombreEmpleadoExternoComboBox1.Text != "" && montoEmpleadoExterno.Text != "" && mesEmpleadoExterno.Text != "")
            {
                try
                {
                    decimal monto = Convert.ToDecimal(montoEmpleadoExterno.Text);
                    monto = Math.Abs(monto);
                    int meses = Convert.ToInt16(mesEmpleadoExterno.Text);
                    meses = Math.Abs(meses);
                    totalEmpleadoExterno.Text = (monto * meses).ToString();
                    DataTable dt = presupuestosTableAdapter.GetData();
                    int aux = 0; // Para saber si el cliente no esta en la BD
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        object[] array = dt.Rows[i].ItemArray;
                        if (nombreEmpleadoExternoComboBox1.Text.ToString() == array[2].ToString() && nTrabajo.Text.ToString() == array[1].ToString())
                        {
                            MessageBox.Show("Ya existe el Profesional Externo " + nombreEmpleadoExternoComboBox1.Text + " en el Presupuesto");
                            aux = 1;
                        }
                    }
                    if (aux == 0)
                    {
                        InsertarEmpleadoExternoEnPresupuesto();
                        facturaEmpleadoExterno.Checked = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Verifique que el monto o la cantidad de meses cumplen con el formato de numeros");
                    montoEmpleadoExterno.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al Profesional Externo, completar el Monto y la cantidad de Meses");
                completoTodo = false;
            }
            if (completoTodo)
            {
                this.presupuestosTableAdapter.FillBy((this.corpusDataSet.Presupuestos), nTrabajo.Text);

                SumarItemsPresupuesto();

                montoEmpleadoExterno.Clear();
                mesEmpleadoExterno.Clear();
                totalEmpleadoExterno.Clear();
            }
        }

        public void InsertarServicioEnPresupuesto()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            decimal auxiliar = Convert.ToDecimal(montoImpuesto.Text);
            auxiliar = Math.Abs(auxiliar);
            string monto = Convert.ToString(auxiliar.ToString().Replace(',', '.'));
            cmd.CommandText = "INSERT into Presupuestos (NumTrabajo, Nombre, Monto, Meses, Total, Factura, UsuCre, FechaCre) VALUES ('" + nTrabajo.Text + "', '" + nombreImpuestoComboBox3.Text + "', " + monto + ", " + 1 + ", " + monto + ", '" + false + "', '" + user.Text + "', '" + DateTime.Now + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (nombreImpuestoComboBox3.Text != "" && montoImpuesto.Text != "")
            {
                try
                {
                    decimal auxiliar = Convert.ToDecimal(montoImpuesto.Text);
                    auxiliar = Math.Abs(auxiliar);
                    DataTable dt = presupuestosTableAdapter.GetData();
                    int aux = 0; // Para saber si el cliente no esta en la BD
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        object[] array = dt.Rows[i].ItemArray;
                        if (nombreImpuestoComboBox3.Text.ToString() == array[2].ToString() && nTrabajo.Text.ToString() == array[1].ToString())
                        {
                            MessageBox.Show("Ya existe el Servicio " + nombreImpuestoComboBox3.Text + " en el Presupuesto");
                            aux = 1;
                        }
                    }
                    if (aux == 0)
                    {
                        InsertarServicioEnPresupuesto();
                    }
                }
                catch
                {
                    MessageBox.Show("Verifique que el monto cumple con el formato de numeros");
                    montoImpuesto.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el Servicio y completar el Monto");
            }
            this.presupuestosTableAdapter.FillBy((this.corpusDataSet.Presupuestos), nTrabajo.Text);

            SumarItemsPresupuesto();

            montoImpuesto.Clear();
        }

        public void InsertarGastoEnPresupuesto()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            decimal auxiliar = Convert.ToDecimal(montoGasto.Text);
            auxiliar = Math.Abs(auxiliar);
            string monto = Convert.ToString(auxiliar.ToString().Replace(',', '.'));
            bool conOsinFactura;
            if (facturaGastos.Checked)
            {
                conOsinFactura = true;
            }
            else
            {
                conOsinFactura = false;
            }
            cmd.CommandText = "INSERT into Presupuestos (NumTrabajo, Nombre, Monto, Meses, Total, Factura, UsuCre, FechaCre) VALUES ('" + nTrabajo.Text + "', '" + nombreGastoComboBox2.Text + "', " + monto + ", " + 1 + ", " + monto + ", '" + conOsinFactura + "', '" + user.Text + "', '" + DateTime.Now + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (nombreGastoComboBox2.Text != "" && montoGasto.Text != "")
            {
                try
                {
                    decimal auxiliar = Convert.ToDecimal(montoGasto.Text);
                    auxiliar = Math.Abs(auxiliar);
                    DataTable dt = presupuestosTableAdapter.GetData();
                    int aux = 0; // Para saber si el cliente no esta en la BD
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        object[] array = dt.Rows[i].ItemArray;
                        if (nombreGastoComboBox2.Text.ToString() == array[2].ToString() && nTrabajo.Text.ToString() == array[1].ToString())
                        {
                            MessageBox.Show("Ya existe el Gasto " + nombreGastoComboBox2.Text + " en el Presupuesto");
                            aux = 1;
                        }
                    }
                    if (aux == 0)
                    {
                        InsertarGastoEnPresupuesto();
                        facturaGastos.Checked = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Verifique que el monto cumple con el formato de numeros");
                    montoGasto.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el Gasto y completar el Monto");
            }
            this.presupuestosTableAdapter.FillBy((this.corpusDataSet.Presupuestos), nTrabajo.Text);
            
            SumarItemsPresupuesto();

            montoGasto.Clear();
        }

        public void InsertarOtroEnPresupuesto()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            decimal auxiliar = Convert.ToDecimal(montoOtro.Text);
            auxiliar = Math.Abs(auxiliar);
            string monto = Convert.ToString(auxiliar.ToString().Replace(',', '.'));
            cmd.CommandText = "INSERT into Presupuestos (NumTrabajo, Nombre, Monto, Meses, Total, Factura, UsuCre, FechaCre) VALUES ('" + nTrabajo.Text + "', '" + nombreOtroComboBox4.Text + "', " + monto + ", " + 1 + ", " + monto + ", '" + false + "', '" + user.Text + "', '" + DateTime.Now + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (nombreOtroComboBox4.Text != "" && montoOtro.Text != "")
            {
                try
                {
                    decimal auxiliar = Convert.ToDecimal(montoOtro.Text);
                    auxiliar = Math.Abs(auxiliar);
                    DataTable dt = presupuestosTableAdapter.GetData();
                    int aux = 0; // Para saber si el cliente no esta en la BD
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        object[] array = dt.Rows[i].ItemArray;
                        if (nombreOtroComboBox4.Text.ToString() == array[2].ToString() && nTrabajo.Text.ToString() == array[1].ToString())
                        {
                            MessageBox.Show("Ya existe el Otro " + nombreOtroComboBox4.Text + " en el Presupuesto");
                            aux = 1;
                        }
                    }
                    if (aux == 0)
                    {
                        InsertarOtroEnPresupuesto();
                    }
                }
                catch
                {
                    MessageBox.Show("Verifique que el monto cumple con el formato de numeros");
                    montoOtro.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el Otro y completar el Monto");
            }
            this.presupuestosTableAdapter.FillBy((this.corpusDataSet.Presupuestos), nTrabajo.Text);

            SumarItemsPresupuesto();

            montoOtro.Clear();
        }

        public void EliminarItemDelPresupuesto()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Presupuestos WHERE (Id_Presupuesto = " + id_PresupuestoTextBox.Text + ")";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (id_PresupuestoTextBox.Text == "")
            {
                MessageBox.Show("No hay Item del Presupuesto seleccionado");
            }
            else
            {
                DialogResult dr = MessageBox.Show("¿Esta seguro que quiere Eliminar del Presupuesto el Item " + nombreTextBox.Text + "?", "ELIMINAR ITEM DEL PRESUPUESTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    EliminarItemDelPresupuesto();
                    MessageBox.Show("Se ha Eliminado el Item correctamente");
                    this.presupuestosTableAdapter.FillBy((this.corpusDataSet.Presupuestos), nTrabajo.Text);

                    SumarItemsPresupuesto();
                }
            }
        }

        public void ActualizarItemDelPresupuesto()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            decimal monto2 = Convert.ToDecimal(montoTextBox.Text);
            monto2 = Math.Abs(monto2);
            int meses2 = Convert.ToInt16(mesesTextBox.Text);
            meses2 = Math.Abs(meses2);
            string monto = monto2.ToString().Replace(',', '.');
            string meses = meses2.ToString();
            string montoTotales = Convert.ToString(totalTextBox.Text.Replace(',', '.'));
            bool EstadoFactura;
            if (facturaCheckBox.Checked)
            {
                EstadoFactura = true;
            }
            else
            {
                EstadoFactura = false;
            }
            cmd.CommandText = "UPDATE Presupuestos SET Monto = " + monto + ", Meses = '" + meses + "', Total = " + montoTotales + ", Factura = '" + EstadoFactura + "', Observaciones = '" + observacionesTextBox.Text.Replace("'", "") + "', UsuMod = '" + user.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_Presupuesto = " + id_PresupuestoTextBox.Text + ")";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (id_PresupuestoTextBox.Text == "")
            {
                MessageBox.Show("No hay Item del Presupuesto seleccionado");
            }
            else
            {
                if (nombreTextBox.Text != "" && montoTextBox.Text != "" && mesesTextBox.Text != "")
                {
                    try
                    {
                        decimal monto = Convert.ToDecimal(montoTextBox.Text);
                        monto = Math.Abs(monto);
                        int meses = Convert.ToInt16(mesesTextBox.Text);
                        meses = Math.Abs(meses);
                        totalTextBox.Text = (monto * meses).ToString();
                        DataTable dt = presupuestosTableAdapter.GetData();
                        int aux = 0; // Para saber si el item esta en el presupuesto no esta en la BD
                        for (int i = 0; i <= dt.Rows.Count - 1; i++)
                        {
                            object[] array = dt.Rows[i].ItemArray;
                            if (nombreTextBox.Text == array[1].ToString() && id_PresupuestoTextBox.Text != array[0].ToString())
                            {
                                MessageBox.Show("Ya existe el Item con el Nombre " + nombreTextBox.Text + " en el Presupuesto");
                                nombreTextBox.Clear();
                                nombreTextBox.Focus();
                                aux = 1;
                            }
                        }
                        if (aux == 0)
                        {
                            ActualizarItemDelPresupuesto();

                            MessageBox.Show("Los datos del Item " + nombreTextBox.Text + " se han actualizado de manera satisfactoria");
                            string fila = presupuestosDataGridView.CurrentRow.Index.ToString(); // guardo la fila donde estoy
                            presupuestosDataGridView.Rows[1].Selected = true;
                            int filaNumero = Convert.ToInt16(fila);
                            this.presupuestosTableAdapter.FillBy((this.corpusDataSet.Presupuestos), nTrabajo.Text);
                            presupuestosDataGridView.CurrentCell = presupuestosDataGridView.Rows[filaNumero].Cells[4]; // me posiciono nuevamente en la fila donde estaba
                            SumarItemsPresupuesto();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Verifique que el monto y los meses cumple con el formato de numeros");
                        montoTextBox.Focus();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios");
                }
            }
        }

        public void ActualizarMontosEnTrabajo()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            decimal aux1 = Convert.ToDecimal(precioSinImpuestos.Text);
            string monto = Convert.ToString(aux1).Replace(",", ".");
            decimal aux2 = Convert.ToDecimal(precioSinIva.Text);
            string montoSinIVA = Convert.ToString(aux2).Replace(",", ".");
            decimal aux3 = Convert.ToDecimal(precioConIva.Text);
            string montoIVA = Convert.ToString(aux3).Replace(",", ".");
            decimal aux4 = Convert.ToDecimal(beneficio.Text);
            string benef = Convert.ToString(aux4).Replace(",", ".");
            cmd.CommandText = "UPDATE Trabajos SET Monto = " + monto + ", MontoSinIva = " + montoSinIVA + ", MontoConIva = " + montoIVA + ", Beneficio = " + benef + ", UsuMod = '" + user.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (NumTrabajo = " + nTrabajo.Text + ")";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (precioSinImpuestos.Text == "" || precioSinIva.Text == "")
            {
                MessageBox.Show("Falta completar el Precio sin Impuestos o Calcular los Precios con o sin IVA");
            }
            else
            {
                ActualizarMontosEnTrabajo();
                MessageBox.Show("El Precio del Trabajo Nº " + nTrabajo.Text + " se actualizo de manera satisfactoria");
            }
        }

        private void montoTotal_TextChanged(object sender, EventArgs e)
        {
            string monto = Convert.ToString(montoTotal.Text);
            decimal aux = Convert.ToDecimal(monto);
            decimal aux2 = aux + (aux * 21 / 100);
            precioSinIva.Text = aux2.ToString();
        }

        private void montoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (montoTextBox.Text != "" && mesesTextBox.Text != "")
            {
                decimal monto = Convert.ToDecimal(montoTextBox.Text);
                int meses = Convert.ToInt16(mesesTextBox.Text);
                totalTextBox.Text = (monto * meses).ToString();
            }
        }

        private void mesesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (montoTextBox.Text != "" && mesesTextBox.Text != "")
            {
                decimal monto = Convert.ToDecimal(montoTextBox.Text);
                int meses = Convert.ToInt16(mesesTextBox.Text);
                totalTextBox.Text = (monto * meses).ToString();
            }
        }

        public void ActualizarImpuestos()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            string IVA = Convert.ToString(iVATextBox.Text.Replace(',', '.'));
            string cheque = Convert.ToString(imp_ChequeTextBox.Text.Replace(',', '.'));
            string iibb = Convert.ToString(iIBBTextBox.Text.Replace(',', '.'));
            string ganancias = Convert.ToString(gananciasTextBox.Text.Replace(',', '.'));
            cmd.CommandText = "UPDATE Fijos SET IVA = " + IVA + ", Imp_Cheque = " + cheque + ", IIBB = " + iibb + ", Ganancias = " + ganancias + ", UsuMod = '" + user.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_Fijo = " + 1 + ")";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (iVATextBox.Text != "" && imp_ChequeTextBox.Text != "" && iIBBTextBox.Text != "" && gananciasTextBox.Text != "")
            {
                DialogResult dr = MessageBox.Show("¿Esta seguro que quiere Actualizar los Impuestos?", "ACTUALIZAR IMPUESTOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    ActualizarImpuestos();
                    MessageBox.Show("Los datos de los Impuestos se han actualizado de manera satisfactoria");
                    this.fijosTableAdapter.Fill(this.corpusDataSet.Fijos);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los Impuestos antes de Actualizar");
            }
        }

        public void CalcularYsumarImpuestos()
        {
            if (precioSinImpuestos.Text != "")
            {
                decimal iva = Convert.ToDecimal(iVATextBox.Text);
                decimal cheque = Convert.ToDecimal(imp_ChequeTextBox.Text);
                decimal iibb = Convert.ToDecimal(iIBBTextBox.Text);
                decimal ganancias = Convert.ToDecimal(gananciasTextBox.Text);
                decimal total = Convert.ToDecimal(precioSinImpuestos.Text);
                decimal factura = Convert.ToDecimal(montoFactura.Text);

                decimal totalParcial = (total + (total * iibb / 100) + ((total - factura) * ganancias / 100) + (total * cheque / 100));
                precioSinIva.Text = totalParcial.ToString("N");
                decimal precioFinal = totalParcial + (totalParcial * iva / 100);
                precioConIva.Text = precioFinal.ToString("N");

                decimal todosLosItems = Convert.ToDecimal(montoTotal.Text);
                beneficio.Text = (total - todosLosItems).ToString("N");
            }
            else
            {
                precioSinIva.Text = "0";
                precioConIva.Text = "0";
            }
        }

        private void nuevoTotal_TextChanged(object sender, EventArgs e)
        {
            CalcularYsumarImpuestos();
        }

        private void mesesTextBox_Leave(object sender, EventArgs e)
        {
            if (mesesTextBox.Text == "")
            {
                MessageBox.Show("Este campo no puede quedar vacio");
            }
        }

        private void montoTextBox_Leave(object sender, EventArgs e)
        {
            if (mesesTextBox.Text == "")
            {
                MessageBox.Show("Este campo no puede quedar vacio");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                decimal aux = Convert.ToDecimal(precioSinImpuestos.Text);
                CalcularYsumarImpuestos();
            }
            catch
            {
                MessageBox.Show("El campo Precio sin Impuestos solo admite numeros (permite decimales)");
                precioSinImpuestos.Focus();
            }
        }

        private void nombreEmpleadoComboBox_Click(object sender, EventArgs e)
        {
            this.empleadosTableAdapter.Fill(this.corpusDataSet.Empleados);
        }

        private void nombreEmpleadoExternoComboBox1_Click(object sender, EventArgs e)
        {
            this.empleadosExternosTableAdapter.Fill(this.corpusDataSet.EmpleadosExternos);
        }

        private void nombreImpuestoComboBox3_Click(object sender, EventArgs e)
        {
            this.impuestosTableAdapter.Fill(this.corpusDataSet.Impuestos);
        }

        private void nombreGastoComboBox2_Click(object sender, EventArgs e)
        {
            this.gastosTableAdapter.Fill(this.corpusDataSet.Gastos);
        }

        private void nombreOtroComboBox4_Click(object sender, EventArgs e)
        {
            this.otrosTableAdapter.Fill(this.corpusDataSet.Otros);
        }

        private void montoTextBox_Leave_1(object sender, EventArgs e)
        {
            try
            {
                decimal aux = Convert.ToDecimal(montoTextBox.Text);
            }
            catch
            {
                MessageBox.Show("El Monto Mensual solo admite numeros (admite decimales)");
            }
        }

        private void mesesTextBox_Leave_1(object sender, EventArgs e)
        {
            try
            {
                int aux = Convert.ToInt16(mesesTextBox.Text);
            }
            catch
            {
                MessageBox.Show("El campo Meses solo admite numeros (sin decimales)");
            }
        }

        private void iVATextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal aux = Convert.ToDecimal(iVATextBox.Text);
            }
            catch
            {
                MessageBox.Show("El IVA solo admite numeros");
            }
        }

        private void imp_ChequeTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal aux = Convert.ToDecimal(imp_ChequeTextBox.Text);
            }
            catch
            {
                MessageBox.Show("El Impuesto al Cheque solo admite numeros");
            }
        }

        private void iIBBTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal aux = Convert.ToDecimal(iIBBTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Ingresos Brutos solo admite numeros");
            }
        }

        private void gananciasTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                decimal aux = Convert.ToDecimal(gananciasTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Ganancias solo admite numeros");
            }
        }
    }
}
