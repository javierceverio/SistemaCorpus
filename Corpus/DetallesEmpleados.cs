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
    public partial class DetallesEmpleados : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public DetallesEmpleados(String empleado)
        {
            InitializeComponent();
            nombreEmpleado.Text = empleado;
        }

        public void TotalCobrado()
        {
            if (cobrosEmpleadosDataGridView.Rows.Count.ToString() != "0")
            {
                decimal total = 0;
                foreach (DataGridViewRow row in cobrosEmpleadosDataGridView.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Cobrado"].Value);
                }
                yaCobrado.Text = total.ToString("N"); ;
            }
            else
            {
                yaCobrado.Text = "0,00";
            }
        }

        public void SeleccionarNumTrabajo()
        {
            try
            {
                DataGridViewRow row = DGVPresupuestos.CurrentRow;
                numeroTrabajo.Text = Convert.ToString(row.Cells["Trabajo Nº"].Value);
            }
            catch
            {

            }
        }

        public void SeleccionarNumeroACobrar()
        {
            try
            {
                DataGridViewRow row = DGVPresupuestos.CurrentRow;
                paraCobrar.Text = Convert.ToString(row.Cells["Total a Cobrar"].Value);
            }
            catch
            {

            }
        }

        public void FaltaCobrar()
        {
            try
            {
                decimal aux = Convert.ToDecimal(paraCobrar.Text);
                decimal aux2 = Convert.ToDecimal(yaCobrado.Text);
                decimal aux3 = aux - aux2;
                faltaCobrar.Text = "$ " + aux3.ToString("N");
            }
            catch
            {

            }
        }

        private void DetallesEmpleados_Load(object sender, EventArgs e)
        {
            ConsultaPresupuesto();
            SeleccionarNumTrabajo();
            this.cobrosEmpleadosTableAdapter.FillBy((this.corpusDataSet.CobrosEmpleados), nombreEmpleado.Text, numeroTrabajo.Text);
            TotalCobrado();
            SeleccionarNumeroACobrar();
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

        public void ConsultarPresupuestoFiltrado()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT P.Nombre AS Empleado, P.NumTrabajo AS 'Trabajo Nº', FORMAT(P.Total, '#,###.00') AS 'Total a Cobrar', T.Estado AS 'Estado del Trabajo' FROM Presupuestos P INNER JOIN Trabajos T ON P.NumTrabajo = T.NumTrabajo WHERE P.Nombre = '" + nombreEmpleado.Text + "' AND T.Estado = '" + estados.Text + "' ORDER BY P.Numtrabajo", conexion);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ConsultarPresupuestoFiltrado();
            }
            else
            {
                ConsultaPresupuesto();
            }
        }

        private void estados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ConsultarPresupuestoFiltrado();
            }
        }

        private void DGVPresupuestos_SelectionChanged(object sender, EventArgs e)
        {
            SeleccionarNumTrabajo();
            this.cobrosEmpleadosTableAdapter.FillBy((this.corpusDataSet.CobrosEmpleados), nombreEmpleado.Text, numeroTrabajo.Text);
            TotalCobrado();
            SeleccionarNumeroACobrar();
            FaltaCobrar();
        }
    }
}
