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
    public partial class Clientes : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public Clientes(string usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.corpusDataSet.Clientes);
            if (id_ClienteTextBox.Text == "")
            {
                DeshabilitarEntradas();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id_ClienteTextBox.Text == "")
            {
                MessageBox.Show("No hay Cliente seleccionado");
            }
            else
            {
                EliminarCliente();
                CargarDatos();
                if (id_ClienteTextBox.Text == "" && textBox1.Text == "")
                {
                    DeshabilitarEntradas();
                }
            }
        }

        public void DeshabilitarEntradas()
        {
            cuit1TextBox.Enabled = false;
            dNITextBox.Enabled = false;
            cuit2TextBox.Enabled = false;
            nombreTextBox.Enabled = false;
            domicilioTextBox.Enabled = false;
            telFijoTextBox.Enabled = false;
            telMovilTextBox.Enabled = false;
            mailTextBox.Enabled = false;
            observacionesTextBox.Enabled = false;
        }

        public void HabilitarEntradas()
        {
            cuit1TextBox.Enabled = true;
            dNITextBox.Enabled = true;
            cuit2TextBox.Enabled = true;
            nombreTextBox.Enabled = true;
            domicilioTextBox.Enabled = true;
            telFijoTextBox.Enabled = true;
            telMovilTextBox.Enabled = true;
            mailTextBox.Enabled = true;
            observacionesTextBox.Enabled = true;
        }

        public bool VerSiClienteEstaEnTrabajo()
        {
            bool verificar = false;

            DataTable dt = trabajosTableAdapter1.GetData();
            int aux = 0; // Para saber si el cliente esta en algun Trabajo
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                object[] array = dt.Rows[i].ItemArray;
                if (id_ClienteTextBox.Text == array[2].ToString())
                {
                    verificar = true;
                    aux = 1;
                }
            }
            if (aux == 0)
            {
                verificar = false;
            }

            return verificar;
        }

        public void EliminarCliente()
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere Eliminar el Cliente " + nombreTextBox.Text + "?", "ELIMINAR CLIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (!VerSiClienteEstaEnTrabajo())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Clientes WHERE (Id_Cliente = " + id_ClienteTextBox.Text + ")";
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Se ha Eliminado el Cliente");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No puede Eliminar al Cliente " + nombreTextBox.Text + " porque esta asignado a un Trabajo");
                }
            }
        }

        public void ActualizarCliente()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Clientes SET Cuit1 = '" + cuit1TextBox.Text.Replace("'", "") + "', DNI = '" + dNITextBox.Text.Replace("'", "") + "', Cuit2 = '" + cuit2TextBox.Text.Replace("'", "") + "', Nombre = '" + nombreTextBox.Text.Replace("'", "") + "', Domicilio = '" + domicilioTextBox.Text.Replace("'", "") + "', TelFijo = '" + telFijoTextBox.Text.Replace("'", "") + "', TelMovil = '" + telMovilTextBox.Text.Replace("'", "") + "', Mail = '" + mailTextBox.Text.Replace("'", "") + "', Observaciones = '" + observacionesTextBox.Text.Replace("'", "") + "', UsuMod = '" + user.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_Cliente = " + id_ClienteTextBox.Text + ")";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (id_ClienteTextBox.Text == "")
            {
                MessageBox.Show("No hay Cliente seleccionado");
            }
            else
            {
                if (nombreTextBox.Text != "" && dNITextBox.Text != "")
                {
                    DataTable dt = clientesTableAdapter.GetData();
                    int aux = 0; // Para saber si el cliente no esta en la BD
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        object[] array = dt.Rows[i].ItemArray;
                        if (dNITextBox.Text == array[2].ToString() && id_ClienteTextBox.Text != array[0].ToString())
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
                            ActualizarCliente();
                            MessageBox.Show("Los datos del Cliente se han actualizado de manera satisfactoria");
                            string fila = clientesDataGridView.CurrentRow.Index.ToString(); // guardo la fila donde estoy
                            clientesDataGridView.Rows[0].Selected = true;
                            int filaNumero = Convert.ToInt16(fila);
                            CargarDatos();
                            clientesDataGridView.CurrentCell = clientesDataGridView.Rows[filaNumero].Cells[4]; // me posiciono nuevamente en la fila donde estaba
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NuevoCliente frm1 = new NuevoCliente(user.Text))
            {
                frm1.ShowDialog();
            }
            CargarDatos();
            if (id_ClienteTextBox.Text != "")
            {
                HabilitarEntradas();
                clientesDataGridView.CurrentCell = clientesDataGridView.Rows[clientesDataGridView.Rows.Count - 1].Cells[4]; // me posiciono en la ultima fila
            }
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
