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
    public partial class Impuestos : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public Impuestos(String usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        private void Impuestos_Load(object sender, EventArgs e)
        {

        }

        public void InsertarEnBalance()
        {
            decimal aux = Convert.ToDecimal(textBox1.Text.Replace(",", "."));
            if (aux > 0)
            {
                SqlCommand cmd4 = new SqlCommand();  // Insertamos el Pago en Balance
                cmd4.CommandType = CommandType.Text;
                string montoAPagar = Convert.ToString(textBox1.Text.Replace(",", "."));
                cmd4.CommandText = "INSERT into Balance (Nombre, Concepto, Monto, Fecha, Observaciones, UsuCre) VALUES ('" + comboBox1.Text + "', '" + "Pago de un Impuesto" + "', " + "-" + montoAPagar + ", '" + dateTimePicker1.Text + "', '" + textBox2.Text.Replace("'", "") + "', '" + user.Text + "')";
                cmd4.Connection = conexion;
                conexion.Open();
                cmd4.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se ha Pagado el Impuesto " + comboBox1.Text + " por un monto de $ " + textBox1.Text);
            }
            else
            {
                SqlCommand cmd4 = new SqlCommand();  // Insertamos el Reintegro en Balance
                cmd4.CommandType = CommandType.Text;
                aux = Math.Abs(aux);
                textBox1.Text = aux.ToString();
                string montoAPagar = Convert.ToString(textBox1.Text.Replace(",", "."));
                cmd4.CommandText = "INSERT into Balance (Nombre, Concepto, Monto, Fecha, Observaciones, UsuCre) VALUES ('" + comboBox1.Text + "', '" + "Reintegro de un Impuesto" + "', " + montoAPagar + ", '" + dateTimePicker1.Text + "', '" + textBox2.Text.Replace("'", "") + "', '" + user.Text + "')";
                cmd4.Connection = conexion;
                conexion.Open();
                cmd4.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se Pagao el Reintegro del Impuesto " + comboBox1.Text + " por un monto de $ " + textBox1.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Pagar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && textBox1.Text != "")
            {
                try
                {
                    decimal aux = Convert.ToDecimal(textBox1.Text.Replace(",", "."));
                    DialogResult dr;
                    if (aux > 0)
                    {
                        dr = MessageBox.Show("¿Esta seguro que quiere Pagar el Impuesto " + comboBox1.Text + " por un monto de $ " + textBox1.Text + "?", "PAGAR UN IMPUESTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    else
                    {
                        dr = MessageBox.Show("¿Esta seguro que quiere Pagar el Reitegro del Impuesto " + comboBox1.Text + " por un monto de $ " + textBox1.Text + "?", "REINTEGRO DE UN IMPUESTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    if (dr == DialogResult.Yes)
                    {
                        InsertarEnBalance();
                    }
                }
                catch
                {
                    MessageBox.Show("El campo Monto solo admite numeros, permite decimales");
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el Impuesto a Pagar y completar el Monto");
            }
        }
    }
}
