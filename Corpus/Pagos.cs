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
    public partial class Pagos : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public Pagos(String usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        public void ConsultarMontoACobrarPorOtros() // Para saber cual era el monto antes de sobreescribirlo, pues necesito saber si va a sobrepasar el Saldo o no
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

        public void CargarDetalleDelPresupuesto()
        {
            ConsultarMontoACobrarPorOtros();
            string monto = Convert.ToString(montoTextBox.Text.Replace(',', '.'));  // preparo el numero decimal, el que trae de la base de datos esta mal siempre por las comas y puntos
            string total = Convert.ToString(lblTotalACobrar.Text.Replace(',', '.'));
            SqlCommand cmd = new SqlCommand("SELECT Nombre, Total AS 'Monto Total del Trabajo', FORMAT((Total * " + monto + " * 100 / " + total + " / 100), '#,###.00') AS 'Monto Pagado' FROM Presupuestos WHERE NumTrabajo = " + numTrabajoTextBox.Text + " AND Nombre in (SELECT Nombre FROM Empleados UNION SELECT Nombre FROM EmpleadosExternos)", conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV.DataSource = dt;
            conexion.Close();
            DataGridViewColumn column = DGV.Columns[0];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void VerSiCargoPresupuesto()
        {
            if (id_PagoTextBox.Text != "")
            {
                if (referenciaTextBox.Text == "Pago de Beneficio")
                {
                    DetalleDeBeneficio();
                    MontoApagar();
                }
                else if (referenciaTextBox.Text == "Otros")
                {
                    DGV.DataSource = "";
                    decimal aux = Convert.ToDecimal(montoTextBox.Text); // Paso a Decimal para luego obtener el Formato con . en los Miles
                    totalApagar.Text = aux.ToString("N");
                }
                else
                {
                    CargarDetalleDelPresupuesto();
                    MontoApagar();
                }
            }
            else
            {
                DGV.DataSource = "";
            }
        }

        private void Pagos_Load(object sender, EventArgs e)
        {
            this.pagosTableAdapter.Fill(this.corpusDataSet.Pagos);
            VerSiCargoPresupuesto();
        }

        public void MontoApagar()
        {
            decimal sumar = 0; // sumo para ver cuanto tengo que pagar, puede que sea diferente al dinero del cobro por los impuestos cuando es en blanco
            foreach (DataGridViewRow row in DGV.Rows)
            {
                sumar += Convert.ToDecimal(row.Cells["Monto Pagado"].Value);
            }
            totalApagar.Text = sumar.ToString("N");
        }

        public void DetalleDeBeneficio()
        {
            string monto = Convert.ToString(montoTextBox.Text.Replace(',', '.'));  // preparo el numero decimal, el que trae de la base de datos esta mal siempre por las comas y puntos
            SqlCommand cmd = new SqlCommand("SELECT Nombre, FORMAT((" + monto + " / 3), '#,###.00') AS 'Monto Pagado' FROM Empleados WHERE (Nombre = '" + "MARCELO EDUARDO BERRIDI" + "' OR Nombre = '" + "GUILLERMO ARIEL CABRAL" + "' OR Nombre = '" + "JORGE IGNACIO BIDEGORRY" + "')", conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV.DataSource = dt;
            conexion.Close();
            DataGridViewColumn column = DGV.Columns[0];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void pagosDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            VerSiCargoPresupuesto();
        }

        public void Filtrar()
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    MessageBox.Show("La Fecha desde no debe ser mayor a hasta");
                    checkBox1.CheckState = CheckState.Unchecked;
                }
                else
                {
                    this.pagosTableAdapter.FillByTrabajoFechas(this.corpusDataSet.Pagos, dateTimePicker2.Text, dateTimePicker1.Text, numeroTrabajo.Text);
                    VerSiCargoPresupuesto();
                }
            }
            else if (checkBox1.Checked == true)
            {
                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    MessageBox.Show("La Fecha desde no debe ser mayor a hasta");
                    checkBox1.CheckState = CheckState.Unchecked;
                }
                else
                {
                    this.pagosTableAdapter.FillByFechas(this.corpusDataSet.Pagos, dateTimePicker2.Text, dateTimePicker1.Text);
                    VerSiCargoPresupuesto();
                }
            }
            else if (checkBox2.Checked == true)
            {
                this.pagosTableAdapter.FillByNumTrabajo(this.corpusDataSet.Pagos, numeroTrabajo.Text);
                VerSiCargoPresupuesto();
            }
            else
            {
                this.pagosTableAdapter.Fill(this.corpusDataSet.Pagos);
                VerSiCargoPresupuesto();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void numeroTrabajo_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id_PagoTextBox.Text != "")
            {
                if (referenciaTextBox.Text == "Pago de Beneficio")
                {
                    MessageBox.Show("No se puede generar un Informe del Pago de un Beneficio");
                }
                else if (referenciaTextBox.Text == "Otros")
                {
                    MessageBox.Show("No se puede generar un Informe del Pago Otros");
                }
                else
                {
                    ConsultarMontoACobrarPorOtros();
                    using (InformePagos frm1 = new InformePagos(montoTextBox.Text, lblTotalACobrar.Text, numTrabajoTextBox.Text, fechaDateTimePicker.Text, totalApagar.Text))
                    {
                        frm1.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay un Pago seleccionado");
            }
        }
    }
}
