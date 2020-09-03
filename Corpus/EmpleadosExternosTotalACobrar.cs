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
    public partial class EmpleadosExternosTotalACobrar : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public EmpleadosExternosTotalACobrar(String empleadoExterno)
        {
            InitializeComponent();
            nombreEmpleado.Text = empleadoExterno;
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
                MessageBox.Show("No hay Profesionales Externos asignados en ningun Presupuesto");
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
                aCobrar.Text = "$ " + total.ToString("N");
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
                foreach (DataGridViewRow row in cobrosEmpleadosExternosDataGridView.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Cobrado"].Value);
                }
                YaCobrado.Text = "$ " + total.ToString("N");
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
                    this.cobrosEmpleadosExternosTableAdapter.FillByNombreFechas((this.corpusDataSet.CobrosEmpleadosExternos), dateTimePicker2.Text, dateTimePicker1.Text, nombreEmpleado.Text);
                }
            }
            else
            {
                this.cobrosEmpleadosExternosTableAdapter.FillByNombre((this.corpusDataSet.CobrosEmpleadosExternos), nombreEmpleado.Text);
            }
        }

        private void EmpleadosExternosTotalACobrar_Load(object sender, EventArgs e)
        {
            this.cobrosEmpleadosExternosTableAdapter.FillByNombre((this.corpusDataSet.CobrosEmpleadosExternos), nombreEmpleado.Text);
            ConsultaPresupuesto();
            TotalACobrar();
            TotalCobrado();
            FaltaCobrar();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
            TotalCobrado();
            FaltaCobrar();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Filtrar();
            TotalCobrado();
            FaltaCobrar();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
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
