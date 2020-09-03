using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Configuration;

namespace Corpus
{
    public partial class ModificarPass : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public ModificarPass(string id_Usuario)
        {
            InitializeComponent();
            label2.Text = id_Usuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ActualizarContraseña()
        {
           SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Usuarios SET Pass = '" + textBox1.Text + "' WHERE (Id_Usuario = '" + label2.Text + "')";
            cmd.Connection = conexion;

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EncriptarContraseña()
        {
            String TextoaEncriptar2 = textBox1.ToString();
            SHA512 shaM512 = new SHA512Managed();
            byte[] data5 = ASCIIEncoding.Default.GetBytes(TextoaEncriptar2);
            byte[] rresultado5 = shaM512.ComputeHash(data5);
            String resultado7 = Convert.ToBase64String(rresultado5);
            textBox1.Text = resultado7;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox1.Text == textBox2.Text)
            {
                EncriptarContraseña();

                ActualizarContraseña();

                MessageBox.Show("La Contraseña se actualizo de manera satisfactoria");
                this.Close();
            }
            else{
                MessageBox.Show("Debe escribir las contraseñas y deben coincidir");
                textBox1.Focus();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.UseSystemPasswordChar == true)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }
    }
}
