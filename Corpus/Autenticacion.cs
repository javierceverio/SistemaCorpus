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
using System.Text.RegularExpressions;

namespace Corpus
{
    public partial class Autenticacion : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public Autenticacion()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ActualizarPermiso()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Fijos SET Permitir = '" + "False" + "'";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataTable dtVence = fijosTableAdapter1.GetData();    // Este codigo sirve para bloquear el Sistema a partir de una determinada fecha
            object[] arrayVence = dtVence.Rows[0].ItemArray;
            if ((DateTime.Parse(arrayVence[5].ToString()) < DateTime.Parse(DateTime.Now.ToString())) || arrayVence[6].ToString() != "True")
            {
                ActualizarPermiso();
                MessageBox.Show("SU LICENCIA HA CADUCADO - POR FAVOR COMUNIQUESE CON CREISYS");
                this.Close();
            }
            else
            {
                String TextoaEncriptar2 = textPass.ToString();
                SHA512 shaM512 = new SHA512Managed();
                byte[] data5 = ASCIIEncoding.Default.GetBytes(TextoaEncriptar2);
                byte[] rresultado5 = shaM512.ComputeHash(data5);
                String resultado7 = Convert.ToBase64String(rresultado5);
                textPass.Text = resultado7;

                DataTable dt = usuariosTableAdapter.GetData();
                int aux = 0; // Para saber si el usuario no esta en la BD
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    object[] array = dt.Rows[i].ItemArray;
                    if (textUser.Text == array[2].ToString() && textPass.Text == array[3].ToString())
                    {
                        aux = 1;
                        textUser.Clear();
                        textPass.Clear();
                        string nombre = array[1].ToString();
                        string id = array[0].ToString();
                        bool permiso;
                        if (array[4].ToString() == "Usuario" && nombre == "RICHARD CAMACHO FERNANDEZ")
                        {
                            permiso = true;
                            using (InicioParaUsuarios frm1 = new InicioParaUsuarios(nombre, id, permiso))
                            {
                                frm1.ShowDialog();
                            }
                        }
                        else if (array[4].ToString() == "Usuario")
                        {
                            permiso = false;
                            using (InicioParaUsuarios frm1 = new InicioParaUsuarios(nombre, id, permiso))
                            {
                                frm1.ShowDialog();
                            }
                        }
                        else
                        {
                            using (Inicio frm1 = new Inicio(nombre))
                            {
                                frm1.ShowDialog();
                            }
                        }
                    }
                }
                if (aux == 0)
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos");
                    textUser.Clear();
                    textPass.Clear();
                    textUser.Focus();
                }
            }
        }
    }
}
