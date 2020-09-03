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
    public partial class Otros : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public Otros(String usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        public bool VerSiEstaEnPresupuesto()
        {
            bool verificar = false;

            DataTable dt = presupuestosTableAdapter1.GetData();
            int aux = 0; // Para saber si el otro esta en algun Presupuesto
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                object[] array = dt.Rows[i].ItemArray;
                if (nombreTextBox.Text == array[2].ToString())
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

        public void DeshabilitarEntradas()
        {
            nombreTextBox.Enabled = false;
            nombreActualizado.Enabled = false;
            monto.Enabled = false;
            dateTimePicker1.Enabled = false;
            observacionesTextBox.Enabled = false;
        }

        public void HabilitarEntradas()
        {
            nombreTextBox.Enabled = true;
            nombreActualizado.Enabled = true;
            monto.Enabled = true;
            dateTimePicker1.Enabled = true;
            observacionesTextBox.Enabled = true;
        }

        private void Otros_Load(object sender, EventArgs e)
        {
            this.otrosTableAdapter.Fill(this.corpusDataSet.Otros);
            nombreActualizado.Text = nombreTextBox.Text;
            if (id_OtroTextBox.Text == "")
            {
                DeshabilitarEntradas();
            }
        }

        public void EliminarOtro()
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere Eliminar el Otro " + nombreTextBox.Text + "?", "ELIMINAR OTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Otros WHERE (Id_Otro = " + id_OtroTextBox.Text + ")";
                cmd.Connection = conexion;
                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se ha Eliminado el Otro");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id_OtroTextBox.Text == "")
            {
                MessageBox.Show("No hay Otro seleccionado");
            }
            else
            {
                if (VerSiEstaEnPresupuesto())
                {
                    MessageBox.Show("El " + nombreTextBox.Text + " no se puede Eliminar por estar asignado en al menos un Presupuesto. A tener en cuenta: podra modificar su nombre y automaticamente cambiara en cada uno de los Presupuestos, Cobros y Pagos en los que este asignado.");
                }
                else
                {
                    EliminarOtro();
                    CargarDatos();
                    if (id_OtroTextBox.Text == "" && textBox1.Text == "")
                    {
                        DeshabilitarEntradas();
                    }
                }
            }
        }

        public void ActualizarOtro()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Otros SET Nombre = '" + nombreActualizado.Text.Replace("'", "") + "', Observaciones = '" + observacionesTextBox.Text.Replace("'", "") + "', UsuMod = '" + user.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_Otro = " + id_OtroTextBox.Text + ")";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ActualizarPresupuestos()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Presupuestos SET Nombre = '" + nombreActualizado.Text.Replace("'", "") + "' WHERE (Nombre = '" + nombreTextBox.Text + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id_OtroTextBox.Text == "")
            {
                MessageBox.Show("No hay Otro seleccionado");
            }
            else
            {
                if (nombreActualizado.Text != "")
                {
                    DataTable dt = otrosTableAdapter.GetData();
                    int aux = 0; // Para saber si el otro no esta en la BD
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        object[] array = dt.Rows[i].ItemArray;
                        if (nombreActualizado.Text == array[1].ToString() && id_OtroTextBox.Text != array[0].ToString())
                        {
                            MessageBox.Show("Ya existe un Otro con el Nombre " + nombreActualizado.Text + " en la Base de Datos");
                            nombreActualizado.Text = nombreTextBox.Text;
                            nombreActualizado.Focus();
                            aux = 1;
                        }
                    }
                    if (aux == 0)
                    {
                        ActualizarOtro();
                        if (nombreTextBox.Text != nombreActualizado.Text)
                        {
                            ActualizarPresupuestos();
                        }
                        MessageBox.Show("Los datos del Otro se han actualizado de manera satisfactoria");
                        string fila = otrosDataGridView.CurrentRow.Index.ToString(); // guardo la fila donde estoy
                        otrosDataGridView.Rows[0].Selected = true;
                        int filaNumero = Convert.ToInt16(fila);
                        CargarDatos();
                        otrosDataGridView.CurrentCell = otrosDataGridView.Rows[filaNumero].Cells[1]; // me posiciono nuevamente en la fila donde estaba
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
            using (NuevoOtro frm1 = new NuevoOtro(user.Text))
            {
                frm1.ShowDialog();
            }
            CargarDatos();
            if (id_OtroTextBox.Text != "")
            {
                HabilitarEntradas();
                otrosDataGridView.CurrentCell = otrosDataGridView.Rows[otrosDataGridView.Rows.Count - 1].Cells[1]; // me posiciono en la ultima fila
            }
        }

        public void CargarDatos()
        {
            if (textBox1.Text != "")
            {
                this.otrosTableAdapter.FillBy((this.corpusDataSet.Otros), textBox1.Text);
            }
            else
            {
                this.otrosTableAdapter.Fill(this.corpusDataSet.Otros);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            nombreActualizado.Text = nombreTextBox.Text;
        }

        public void InsertarEnBalance()
        {
            decimal auxiliar = Convert.ToDecimal(monto.Text);
            if (auxiliar > 0)
            {
                SqlCommand cmd4 = new SqlCommand();  // Insertamos el Pago en Balance
                cmd4.CommandType = CommandType.Text;
                string montoAPagar = Convert.ToString(monto.Text.Replace(",", "."));
                cmd4.CommandText = "INSERT into Balance (Nombre, Concepto, Monto, Fecha, Observaciones, UsuCre) VALUES ('" + nombreTextBox.Text.Replace("'", "") + "', '" + "Pago de Otros" + "', " + "-" + montoAPagar + ", '" + dateTimePicker1.Text + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "')";
                cmd4.Connection = conexion;
                conexion.Open();
                cmd4.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se pago " + nombreTextBox.Text + " por un monto de $ " + monto.Text);
            }
            else
            {
                SqlCommand cmd4 = new SqlCommand();  // Insertamos el Pago en Balance
                cmd4.CommandType = CommandType.Text;
                auxiliar = Math.Abs(auxiliar);
                monto.Text = auxiliar.ToString();
                string montoAPagar = Convert.ToString(monto.Text.Replace(",", "."));
                cmd4.CommandText = "INSERT into Balance (Nombre, Concepto, Monto, Fecha, Observaciones, UsuCre) VALUES ('" + nombreTextBox.Text.Replace("'", "") + "', '" + "Reintegro de Otros" + "', " + montoAPagar + ", '" + dateTimePicker1.Text + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "')";
                cmd4.Connection = conexion;
                conexion.Open();
                cmd4.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se pago el Reintegro de " + nombreTextBox.Text + " por un monto de $ " + monto.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (monto.Text != "" && dateTimePicker1.Text != "")
            {
                try
                {
                    decimal auxiliar = Convert.ToDecimal(monto.Text);
                    DialogResult dr;
                    if (auxiliar > 0)
                    {
                        dr = MessageBox.Show("¿Esta seguro que quiere Pagar " + nombreTextBox.Text + " por un monto de $ " + monto.Text + "?", "PAGAR OTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    else
                    {
                        dr = MessageBox.Show("¿Esta seguro que quiere Pagar el Reintegro de " + nombreTextBox.Text + " por un monto de $ " + monto.Text + "?", "REINTEGRO OTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    if (dr == DialogResult.Yes)
                    {
                        InsertarEnBalance();
                        monto.Clear();
                    }
                }
                catch
                {
                    MessageBox.Show("El campo Monto solo admite numeros, permite decimales y negativos en caso de tener que hacer alguna correccion en el Balance");
                }
            }
            else
            {
                MessageBox.Show("Antes de poder Pagar debe completar los campos Monto y Fecha");
            }
        }
    }
}
