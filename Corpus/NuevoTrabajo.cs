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

    public partial class NuevoTrabajo : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public NuevoTrabajo(String usuario, int trabajos)
        {
            InitializeComponent();
            user.Text = usuario;
            int aux = trabajos + 1;
            numTrabajoTextBox.Text = aux.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevoTrabajo_Load(object sender, EventArgs e)
        {
            this.trabajosTableAdapter1.Fill(this.corpusDataSet.Trabajos);
            this.clientesTableAdapter.Fill(this.corpusDataSet.Clientes);
        }

        public void CrearTrabajo()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into Trabajos (NumTrabajo, Id_Cliente, Nombre, Estado, Tipo, CantMeses, FechaFin, Observaciones, UsuCre, FechaCre) VALUES ('" + numTrabajoTextBox.Text + "', " + id_ClienteComboBox1.Text + ", '" + nombreTextBox.Text.Replace("'", "") + "', '" + "A PRESUPUESTAR" + "', '" + tipoComboBox.Text + "', '" + cantMesesTextBox.Text + "', '" + fechaFinDateTimePicker.Text + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "', '" + DateTime.Now + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "" && id_ClienteComboBox.Text != "" && tipoComboBox.Text != "")
            {
                try
                {
                    if (cantMesesTextBox.Text != "")
                    {
                        int aux = Convert.ToInt16(cantMesesTextBox.Text);
                    }
                    CrearTrabajo();
                    MessageBox.Show("El Trabajo numero " + numTrabajoTextBox.Text + " se ha creado de manera satisfactoria");
                    Close();
                }
                catch
                {
                    MessageBox.Show("El campo Cantidad de Meses solo debe completarse con numeros");
                    cantMesesTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos obligatorios");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (NuevoCliente frm1 = new NuevoCliente(user.Text))
            {
                frm1.ShowDialog();
            }
            this.clientesTableAdapter.Fill(this.corpusDataSet.Clientes);
            clientesDataGridView.CurrentCell = clientesDataGridView.Rows[clientesDataGridView.Rows.Count - 1].Cells[4]; // me posiciono en la ultima fila
        }

        private static bool solonumeros(string validacion)
        {
            Regex rx = new Regex(@"^\s*[0-9]+\s*$");

            if (rx.IsMatch(validacion))
            {
                return true;
            }
            return false;
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
