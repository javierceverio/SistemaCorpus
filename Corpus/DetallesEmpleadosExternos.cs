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
    public partial class DetallesEmpleadosExternos : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public DetallesEmpleadosExternos(String empleadoExterno)
        {
            InitializeComponent();
            nombreEmpleado.Text = empleadoExterno;
        }

        private void DetallesEmpleadosExternos_Load(object sender, EventArgs e)
        {
            ConsultaPresupuesto();
            SeleccionarNumTrabajo();
            this.cobrosEmpleadosExternosTableAdapter.FillBy((this.corpusDataSet.CobrosEmpleadosExternos), nombreEmpleado.Text, numeroTrabajo.Text);
            TotalCobrado();
            SeleccionarNumeroACobrar();
            FaltaCobrar();
        }

        public void TotalCobrado()
        {
            try
            {
                if (cobrosEmpleadosExternosDataGridView.Rows.Count.ToString() != "0")
                {
                    decimal total = 0;
                    foreach (DataGridViewRow row in cobrosEmpleadosExternosDataGridView.Rows)
                    {
                        total += Convert.ToDecimal(row.Cells["Cobrado"].Value);
                    }
                    yaCobrado.Text = total.ToString("N");
                }
                else
                {
                    yaCobrado.Text = "0,00";
                }
            }
            catch
            {

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

        public void ConsultaPresupuesto()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Nombre AS 'Empleado Externo', NumTrabajo AS 'Trabajo Nº', FORMAT(Total, '#,###.00') AS 'Total a Cobrar', (SELECT Estado FROM Trabajos WHERE Trabajos.NumTrabajo = Presupuestos.NumTrabajo) AS 'Estado del Trabajo' FROM Presupuestos WHERE Nombre = '" + nombreEmpleado.Text + "' ORDER BY Numtrabajo", conexion);
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

        public void ConsultarPresupuestoFiltrado()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT P.Nombre AS 'Empleado Externo', P.NumTrabajo AS 'Trabajo Nº', FORMAT(P.Total, '#,###.00')) AS 'Total a Cobrar', T.Estado AS 'Estado del Trabajo' FROM Presupuestos P INNER JOIN Trabajos T ON P.NumTrabajo = T.NumTrabajo WHERE P.Nombre = '" + nombreEmpleado.Text + "' AND T.Estado = '" + estados.Text + "' ORDER BY P.Numtrabajo", conexion);
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

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
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

        private void estados_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ConsultarPresupuestoFiltrado();
            }
        }

        private void DGVPresupuestos_SelectionChanged_1(object sender, EventArgs e)
        {
            SeleccionarNumTrabajo();
            this.cobrosEmpleadosExternosTableAdapter.FillBy((this.corpusDataSet.CobrosEmpleadosExternos), nombreEmpleado.Text, numeroTrabajo.Text);
            TotalCobrado();
            SeleccionarNumeroACobrar();
            FaltaCobrar();
        }
    }
}
