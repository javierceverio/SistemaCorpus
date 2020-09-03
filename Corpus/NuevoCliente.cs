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
using System.Text.RegularExpressions;

namespace Corpus
{
    public partial class NuevoCliente : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public NuevoCliente(string usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        public void CrearCliente()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into Clientes (Cuit1, DNI, Cuit2, Nombre, Domicilio, TelFijo, TelMovil, Mail, Observaciones, UsuCre, FechaCre) VALUES ('" + cuit1TextBox.Text + "', '" + dNITextBox.Text + "', '" + cuit2TextBox.Text + "', '" + nombreTextBox.Text.Replace("'", "") + "', '" + domicilioTextBox.Text.Replace("'", "") + "', '" + telFijoTextBox.Text.Replace("'", "") + "', '" + telMovilTextBox.Text.Replace("'", "") + "', '" + mailTextBox.Text.Replace("'", "") + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "', '" + DateTime.Now + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "" && dNITextBox.Text != "")
            {
                DataTable dt = clientesTableAdapter1.GetData();
                int aux = 0; // Para saber si el cliente no esta en la BD
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    object[] array = dt.Rows[i].ItemArray;
                    if (dNITextBox.Text.ToString() == array[2].ToString())
                    {
                        MessageBox.Show("Ya existe un Cliente con el DNI " + dNITextBox.Text + " en la Base de Datos");
                        dNITextBox.Clear();
                        dNITextBox.Focus();
                        aux = 1;
                    }
                }
                if (aux == 0)
                {
                    try
                    {
                        if (cuit1TextBox.Text != "" || cuit2TextBox.Text != "")
                        {
                            int auxiliar = Convert.ToInt16(cuit1TextBox.Text);
                            int auxiliar3 = Convert.ToInt16(cuit2TextBox.Text);
                        }
                        if (dNITextBox.Text != "")
                        {
                            int auxiliar2 = Convert.ToInt32(dNITextBox.Text);
                        }
                        CrearCliente();
                        MessageBox.Show("El Cliente " + nombreTextBox.Text + " se ha creado de manera satisfactoria");
                        Close();
                    }
                    catch
                    {
                        MessageBox.Show("Los campos de CUIT / DNI solo admiten numeros");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos obligatorios");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static bool solomail(string validacion)
        {
            Regex rx = new Regex(@"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})$");
            if (rx.IsMatch(validacion))
            {
                return true;
            }
            return false;
        }

        private void mailTextBox_Leave(object sender, EventArgs e)
        {
            if (mailTextBox.Text != "")
            {
                if (solomail(mailTextBox.Text) == false)
                {
                    DialogResult dlgRes;
                    dlgRes = MessageBox.Show("Formato de mail incorrecto verifique su mail, se permiten @ Letras, Números, _ , . , .");
                    mailTextBox.Clear();
                    mailTextBox.Focus();
                }
            }
        }
    }
}
