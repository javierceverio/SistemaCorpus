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
    public partial class NuevoCobro : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public NuevoCobro(String usuario, String trabajo, String total, String saldoTrabajo)
        {
            InitializeComponent();
            user.Text = usuario;
            numTrabajoTextBox.Text = trabajo;
            decimal aux = Convert.ToDecimal(total);
            precioTrabajo.Text = aux.ToString();
            lblSaldoTrabajo.Text = saldoTrabajo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ConocerElProximoIdDeCobros()
        {
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.Text;
            string monto2 = Convert.ToString(montoTextBox.Text.Replace(',', '.'));
            cmd2.CommandText = "SELECT IDENT_CURRENT('Cobros') AS Current_Identity";
            cmd2.Connection = conexion;
            conexion.Open();
            ultimoCobro.Text = (cmd2.ExecuteScalar()).ToString();
            Int64 aux = Convert.ToInt64(ultimoCobro.Text);
            aux += 1;
            ultimoCobro.Text = aux.ToString();
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (montoTextBox.Text != "" && fechaDateTimePicker.Text != "")
            {
                try
                {
                    decimal aux = Convert.ToDecimal(montoTextBox.Text);

                    if (aux <= Convert.ToDecimal(lblSaldoTrabajo.Text))   // Verificar que el monto no sea mayor al Saldo
                    {
                        try
                        {
                            ConocerElProximoIdDeCobros();
                            Int64 auxiliar = Convert.ToInt64(ultimoCobro.Text); // Compruebo que la consulta del Id a Insertar en Cobros se realizo con exito

                            string monto = Convert.ToString(montoTextBox.Text.Replace(',', '.'));
                            string montoTotal = Convert.ToString(precioTrabajo.Text.Replace(',', '.'));
                            string sql1 = "INSERT into Cobros (NumTrabajo, Monto, Fecha, Observaciones, UsuCre, FechaCre) VALUES ('" + numTrabajoTextBox.Text + "', " + monto + ", '" + fechaDateTimePicker.Text + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "', '" + DateTime.Now + "')";
                            string sql2 = "INSERT into Balance (Nombre, Id_Cobro, Concepto, Referencia, Monto, Fecha, Observaciones, UsuCre) VALUES ('" + "TRABAJO" + "', '" + ultimoCobro.Text + "', '" + "Cobro por Trabajo" + "', '" + numTrabajoTextBox.Text + "', " + monto + ", '" + fechaDateTimePicker.Text + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "')";
                            string sql3 = "INSERT into APagar (Id_Cobro, NumTrabajo, Monto, Fecha, Total, Observaciones, UsuCre, FechaCre) VALUES (" + ultimoCobro.Text + ", '" + numTrabajoTextBox.Text + "', " + monto + ", '" + fechaDateTimePicker.Text + "', " + montoTotal + ", '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "', '" + DateTime.Now + "')";
                            SqlCommand command1 = new SqlCommand(sql1, conexion);
                            SqlCommand command3 = new SqlCommand(sql3, conexion);
                            SqlCommand command2 = new SqlCommand(sql2, conexion);
                            SqlTransaction transaccion = null;
                            conexion.Open();
                            transaccion = conexion.BeginTransaction(IsolationLevel.RepeatableRead);
                            command1.Transaction = transaccion;
                            command2.Transaction = transaccion;
                            command3.Transaction = transaccion;
                            try
                            {
                                command1.ExecuteNonQuery();
                                command2.ExecuteNonQuery();
                                command3.ExecuteNonQuery();

                                transaccion.Commit();
                                MessageBox.Show("El Cobro de $ " + monto + " del Trabajo Nº " + numTrabajoTextBox.Text + " se ha creado de manera satisfactoria");
                            }
                            catch (Exception)
                            {
                                transaccion.Rollback();
                                MessageBox.Show("La Transaccion no se pudo realizar. Por favor intentelo mas tarde. En caso de que este mensaje se repita, por favor comuniquese con CreISys.");
                            }
                            conexion.Close();

                            Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error en la Tabla Cobros, no se pudo conocer el proximo Id. Intentelo mas tarde y en caso de repetirse esta advertencia, comunicarse con CreISys");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Monto no debe superar los $ " + lblSaldoTrabajo.Text);
                        montoTextBox.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("El Monto debe ser un numero");
                    montoTextBox.Clear();
                    montoTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos obligatorios");
            }
        }
    }
}
