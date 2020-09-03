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
    public partial class NuevoOtro : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public NuevoOtro(String usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CrearOtro()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into Otros (Nombre, Observaciones, UsuCre, FechaCre) VALUES ('" + nombreTextBox.Text.Replace("'", "") + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "', '" + DateTime.Now + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                DataTable dt = otrosTableAdapter1.GetData();
                int aux = 0; // Para saber si el otro no esta en la BD
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    object[] array = dt.Rows[i].ItemArray;
                    if (nombreTextBox.Text.ToString() == array[1].ToString())
                    {
                        MessageBox.Show("Ya existe un Otro con el Nombre " + nombreTextBox.Text + " en la Base de Datos");
                        nombreTextBox.Clear();
                        nombreTextBox.Focus();
                        aux = 1;
                    }
                }
                if (aux == 0)
                {
                    CrearOtro();
                    MessageBox.Show("El Otro " + nombreTextBox.Text + " se ha creado de manera satisfactoria");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos obligatorios");
            }
        }
    }
}
