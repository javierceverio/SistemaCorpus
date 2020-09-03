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
    public partial class EmpleadosTotalACobrar : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public EmpleadosTotalACobrar(String empleado)
        {
            InitializeComponent();
            nombreEmpleado.Text = empleado;
        }

        private void EmpleadosTotalACobrar_Load(object sender, EventArgs e)
        {
            this.cobrosEmpleadosTableAdapter.FillByNombre((this.corpusDataSet.CobrosEmpleados), nombreEmpleado.Text);
            ConsultaPresupuesto();
            TotalACobrar();
            TotalCobrado();
            FaltaCobrar();
        }

        public void ConsultaPresupuesto()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Nombre AS Empleado, NumTrabajo AS 'Trabajo Nº', FORMAT(Total, '#,###.00') AS 'Total a Cobrar', (SELECT Estado FROM Trabajos WHERE Trabajos.NumTrabajo = Presupuestos.NumTrabajo) AS 'Estado del Trabajo' FROM Presupuestos WHERE Nombre = '" + nombreEmpleado.Text + "' ORDER BY Numtrabajo", conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DGVPresupuestos.DataSource = dt;
                conexion.Close();
                DataGridViewColumn Empleado = DGVPresupuestos.Columns[0];
                Empleado.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DataGridViewColumn Trabajo = DGVPresupuestos.Columns[1];
                Trabajo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DataGridViewColumn Monto = DGVPresupuestos.Columns[2];
                Monto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch
            {
                MessageBox.Show("No hay Profesionales Internos asignados en ningun Presupuesto");
            }
        }

        public void TotalACobrar()
        {
            try
            {
                decimal total = 0;
                foreach (DataGridViewRow row in DGVPresupuestos.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Total a Cobrar"].Value);
                }
                aCobrar.Text = total.ToString("N");
            }
            catch
            {

            }
        }

        public void TotalCobrado()
        {
            try
            {
                decimal total = 0;
                foreach (DataGridViewRow row in cobrosEmpleadosDataGridView1.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Cobrado"].Value);
                }
                YaCobrado.Text = total.ToString("N"); ;
            }
            catch
            {

            }
        }

        public void Filtrar()
        {
            if (checkBox3.Checked)
            {
                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    MessageBox.Show("La Fecha desde no debe ser mayor a hasta");
                    checkBox3.CheckState = CheckState.Unchecked;
                }
                else
                {
                    this.cobrosEmpleadosTableAdapter.FillByNombreFechas((this.corpusDataSet.CobrosEmpleados), dateTimePicker2.Text, dateTimePicker1.Text, nombreEmpleado.Text);
                }
            }
            else
            {
                this.cobrosEmpleadosTableAdapter.FillByNombre((this.corpusDataSet.CobrosEmpleados), nombreEmpleado.Text);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
            TotalCobrado();
            FaltaCobrar();
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            Filtrar();
            TotalCobrado();
            FaltaCobrar();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            Filtrar();
            TotalCobrado();
            FaltaCobrar();
        }

        public void FaltaCobrar()
        {
            try
            {
                decimal aux = Convert.ToDecimal(aCobrar.Text);
                decimal aux2 = Convert.ToDecimal(YaCobrado.Text);
                decimal aux3 = aux - aux2;
                faltaCobrar.Text = "$ " + aux3.ToString("N");
            }
            catch
            {

            }
        }
    }
}
