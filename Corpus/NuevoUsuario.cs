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
using System.Security.Cryptography;

namespace Corpus
{
    public partial class NuevoUsuario : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public NuevoUsuario(String usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CrearUsuario()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into Usuarios (Nombre, Usuario, Pass, Nivel, UsuCre, FechaCre) VALUES ('" + nombreTextBox.Text.Replace("'", "") + "', '" + usuarioTextBox.Text + "', '" + passTextBox.Text + "', '" + nivelComboBox.Text + "', '" + user.Text + "', '" + DateTime.Now + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EncriptarContraseña()
        {
            String TextoaEncriptar2 = passTextBox.ToString();
            SHA512 shaM512 = new SHA512Managed();
            byte[] data5 = ASCIIEncoding.Default.GetBytes(TextoaEncriptar2);
            byte[] rresultado5 = shaM512.ComputeHash(data5);
            String resultado7 = Convert.ToBase64String(rresultado5);
            passTextBox.Text = resultado7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text == "" || usuarioTextBox.Text == "" || passTextBox.Text == "" || nivelComboBox.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos obligatorios");
            }
            else
            {
                EncriptarContraseña();

                DataTable dt = usuariosTableAdapter1.GetData();
                int aux = 0; // Para saber si el usuario no esta en la BD
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    object[] array = dt.Rows[i].ItemArray;
                    if (nombreTextBox.Text == array[1].ToString())
                    {
                        MessageBox.Show("Ya existe el Usuario " + nombreTextBox.Text + " en la Base de Datos");
                        nombreTextBox.Clear();
                        aux = 1;
                    }
                }
                if (aux == 0)
                {
                    CrearUsuario();
                    MessageBox.Show("El Usuario " + nombreTextBox.Text + " se ha creado de manera satisfactoria");
                    Close();
                }
            }
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            this.empleadosTableAdapter.Fill(this.corpusDataSet.Empleados);
        }

        private void AsignarProfesional_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = empleadosDataGridView.CurrentRow;
                nombreTextBox.Text = Convert.ToString(row.Cells["Nombre"].Value);
            }
            catch
            {
                MessageBox.Show("No hay Profesional seleccionado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (NuevoEmpleado frm1 = new NuevoEmpleado(user.Text))
            {
                frm1.ShowDialog();
            }
            this.empleadosTableAdapter.Fill(this.corpusDataSet.Empleados);
            empleadosDataGridView.CurrentCell = empleadosDataGridView.Rows[empleadosDataGridView.Rows.Count - 1].Cells[1]; // me posiciono en la ultima fila
        }
    }
}
