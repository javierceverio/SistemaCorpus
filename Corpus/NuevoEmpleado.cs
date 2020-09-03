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
    public partial class NuevoEmpleado : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public NuevoEmpleado(string usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CrearEmpleado()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into Empleados (Nombre, TelFijo, TelMovil, Mail, Observaciones, UsuCre, FechaCre) VALUES ('" + nombreTextBox.Text.Replace("'", "") + "', '" + telFijoTextBox.Text.Replace("'", "") + "', '" + telMovilTextBox.Text.Replace("'", "") + "', '" + mailTextBox.Text.Replace("'", "") + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "', '" + DateTime.Now + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                DataTable dt = empleadosTableAdapter1.GetData();
                int aux = 0; // Para saber si el empleado no esta en la BD
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    object[] array = dt.Rows[i].ItemArray;
                    if (nombreTextBox.Text.ToString() == array[1].ToString())
                    {
                        MessageBox.Show("Ya existe un Profesional Interno " + nombreTextBox.Text + " en la Base de Datos");
                        nombreTextBox.Clear();
                        nombreTextBox.Focus();
                        aux = 1;
                    }
                }
                if (aux == 0)
                {
                    CrearEmpleado();
                    MessageBox.Show("El Profesional Interno " + nombreTextBox.Text + " se ha creado de manera satisfactoria");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos obligatorios");
            }
        }

        private void NuevoEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
