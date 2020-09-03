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
    public partial class Percibido : Form
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public Percibido(String usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        public void ConsultarPresupuesto()
        {
            SqlCommand cmd = new SqlCommand("SELECT AP.NumTrabajo AS 'Trabajo Nº', AP.Fecha AS 'Fecha de Cobro', FORMAT((P.Total * AP.Monto / (AP.Total - (SELECT ISNULL(SUM(Total), 0) FROM Presupuestos WHERE NumTrabajo = AP.NumTrabajo AND Nombre IN (SELECT Nombre FROM Otros)))), '#,###.00') AS 'Monto a Cobrar' FROM APagar AP JOIN Presupuestos P ON P.NumTrabajo = AP.NumTrabajo WHERE P.Nombre = '" + user.Text + "'", conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGV.DataSource = dt;
            conexion.Close();
            DataGridViewColumn column = DGV.Columns[0];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void Sumar()
        {
            decimal sumar = 0; // total a Cobrar
            foreach (DataGridViewRow row in DGV.Rows)
            {
                sumar += Convert.ToDecimal(row.Cells["Monto a Cobrar"].Value);
            }
            txtTotal.Text = "$ " + sumar.ToString("N"); ;
        }

        private void Percibido_Load(object sender, EventArgs e)
        {
            ConsultarPresupuesto();
            Sumar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (InformeACobrar frm1 = new InformeACobrar(user.Text))
            {
                frm1.ShowDialog();
            }
        }
    }
}
