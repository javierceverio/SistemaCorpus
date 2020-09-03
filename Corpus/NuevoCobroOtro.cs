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
    public partial class NuevoCobroOtro : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public NuevoCobroOtro(String usuario, String trabajo, String saldo)
        {
            InitializeComponent();
            user.Text = usuario;
            numTrabajoTextBox.Text = trabajo;
            lblSaldoOtros.Text = saldo;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ConocerElProximoIdDeCobrosOtros()
        {
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.Text;
            string monto2 = Convert.ToString(montoTextBox.Text.Replace(',', '.'));
            cmd2.CommandText = "SELECT IDENT_CURRENT('CobrosOtros') AS Current_Identity";
            cmd2.Connection = conexion;
            conexion.Open();
            ultimoCobro.Text = (cmd2.ExecuteScalar()).ToString();
            Int64 aux = Convert.ToInt64(ultimoCobro.Text);
            aux += 1;
            ultimoCobro.Text = aux.ToString();
            conexion.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (montoTextBox.Text != "" && fechaDateTimePicker.Text != "")
            {
                if (Convert.ToDecimal(montoTextBox.Text) > Convert.ToDecimal(lblSaldoOtros.Text))
                {
                    MessageBox.Show("El Monto no puede ser mayor a $ " + lblSaldoOtros.Text);
                    montoTextBox.Focus();
                }
                else
                {
                    try
                    {
                        decimal aux = Convert.ToDecimal(montoTextBox.Text);

                        try
                        {
                            ConocerElProximoIdDeCobrosOtros();
                            Int64 auxiliar = Convert.ToInt64(ultimoCobro.Text); // Compruebo que la consulta del Id a Insertar en Cobros se realizo con exito

                            string monto = Convert.ToString(montoTextBox.Text.Replace(',', '.'));
                            string sql1 = "INSERT into CobrosOtros (NumTrabajo, Monto, Fecha, Observaciones, UsuCre, FechaCre) VALUES ('" + numTrabajoTextBox.Text + "', " + monto + ", '" + fechaDateTimePicker.Text + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "', '" + DateTime.Now + "')";
                            string sql2 = "INSERT into Balance (Nombre, Id_CobroOtro, Concepto, Referencia, Monto, Fecha, Observaciones, UsuCre) VALUES ('" + "TRABAJO" + "', '" + ultimoCobro.Text + "', '" + "Cobro de Otros por Trabajo" + "', '" + numTrabajoTextBox.Text + "', " + monto + ", '" + fechaDateTimePicker.Text + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "')";
                            string sql3 = "INSERT into APagarOtros (Id_CobroOtro, NumTrabajo, Monto, Fecha, Observaciones, UsuCre, FechaCre) VALUES (" + ultimoCobro.Text + ", '" + numTrabajoTextBox.Text + "', " + monto + ", '" + fechaDateTimePicker.Text + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "', '" + DateTime.Now + "')";
                            SqlCommand command1 = new SqlCommand(sql1, conexion);
                            SqlCommand command2 = new SqlCommand(sql2, conexion);
                            SqlCommand command3 = new SqlCommand(sql3, conexion);
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
                                MessageBox.Show("El Cobro de $ " + monto + " por Otros del Trabajo Nº " + numTrabajoTextBox.Text + " se ha creado de manera satisfactoria");
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
                            MessageBox.Show("Error en la Tabla CobrosOtros, no se pudo conocer el proximo Id. Intentelo mas tarde y en caso de repetirse esta advertencia, comunicarse con CreISys");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("El Monto debe ser un numero");
                        montoTextBox.Clear();
                        montoTextBox.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos obligatorios");
            }
        }
    }
}
