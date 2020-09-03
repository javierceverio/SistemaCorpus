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
    public partial class NuevoServicio : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public NuevoServicio(String usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CrearServicio()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into Impuestos (Nombre, Observaciones, UsuCre, FechaCre) VALUES ('" + nombreTextBox.Text.Replace("'", "") + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "', '" + DateTime.Now + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                DataTable dt = impuestosTableAdapter1.GetData();
                int aux = 0; // Para saber si el impuesto no esta en la BD
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    object[] array = dt.Rows[i].ItemArray;
                    if (nombreTextBox.Text.ToString() == array[1].ToString())
                    {
                        MessageBox.Show("Ya existe un Servicio con el Nombre " + nombreTextBox.Text + " en la Base de Datos");
                        nombreTextBox.Clear();
                        nombreTextBox.Focus();
                        aux = 1;
                    }
                }
                if (aux == 0)
                {
                    CrearServicio();
                    MessageBox.Show("El Servicio " + nombreTextBox.Text + " se ha creado de manera satisfactoria");
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
