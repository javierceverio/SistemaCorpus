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
    public partial class CambiarCliente : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public CambiarCliente(String Id_Trabajo, String usuario)
        {
            InitializeComponent();
            id_Trabajo.Text = Id_Trabajo;
            user.Text = usuario;
        }

        private void CambiarCliente_Load(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.corpusDataSet.Clientes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id_ClienteTextBox.Text == "")
            {
                MessageBox.Show("No hay Cliente seleccionado");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Trabajos SET Id_Cliente = " + id_ClienteTextBox.Text + " WHERE (Id_Trabajo = " + id_Trabajo.Text + ")";
                cmd.Connection = conexion;

                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("El Cliente se actualizo de manera satisfactoria");
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (NuevoCliente frm1 = new NuevoCliente(user.Text))
            {
                frm1.ShowDialog();
            }
            this.clientesTableAdapter.Fill(this.corpusDataSet.Clientes);
        }

        public void CargarDatos()
        {
            if (textBox1.Text != "")
            {
                this.clientesTableAdapter.FillBy((this.corpusDataSet.Clientes), textBox1.Text);
            }
            else
            {
                this.clientesTableAdapter.Fill(this.corpusDataSet.Clientes);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
