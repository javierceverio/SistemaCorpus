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
    public partial class Gastos : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public Gastos(String usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        public bool VerSiEstaEnPresupuesto()
        {
            bool verificar = false;

            DataTable dt = presupuestosTableAdapter1.GetData();
            int aux = 0; // Para saber si el gasto esta en algun Presupuesto
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

        private void Gastos_Load(object sender, EventArgs e)
        {
            this.gastosTableAdapter.Fill(this.corpusDataSet.Gastos);
            nombreActualizado.Text = nombreTextBox.Text;
            if (id_GastoTextBox.Text == "")
            {
                DeshabilitarEntradas();
            }
        }

        public void EliminarGasto()
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere Eliminar el Gasto " + nombreTextBox.Text + "?", "ELIMINAR GASTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Gastos WHERE (Id_Gasto = " + id_GastoTextBox.Text + ")";
                cmd.Connection = conexion;
                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se ha Eliminado el Gasto");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id_GastoTextBox.Text == "")
            {
                MessageBox.Show("No hay Gasto seleccionado");
            }
            else
            {
                if (VerSiEstaEnPresupuesto())
                {
                    MessageBox.Show("El Gasto " + nombreTextBox.Text + " no se puede Eliminar por estar asignado en al menos un Presupuesto. A tener en cuenta: podra modificar su nombre y automaticamente cambiara en cada uno de los Presupuestos, Cobros y Pagos en los que este asignado.");
                }
                else
                {
                    EliminarGasto();
                    CargarDatos();
                    if (id_GastoTextBox.Text == "" && textBox1.Text == "")
                    {
                        DeshabilitarEntradas();
                    }
                }
            }
        }

        public void ActualizarGastos()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Gastos SET Nombre = '" + nombreActualizado.Text.Replace("'", "") + "', Observaciones = '" + observacionesTextBox.Text.Replace("'", "") + "', UsuMod = '" + user.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_Gasto = " + id_GastoTextBox.Text + ")";
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
            if (id_GastoTextBox.Text == "")
            {
                MessageBox.Show("No hay Gasto seleccionado");
            }
            else
            {
                if (nombreActualizado.Text != "")
                {
                    DataTable dt = gastosTableAdapter.GetData();
                    int aux = 0; // Para saber si el gasto no esta en la BD
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        object[] array = dt.Rows[i].ItemArray;
                        if (nombreActualizado.Text == array[1].ToString() && id_GastoTextBox.Text != array[0].ToString())
                        {
                            MessageBox.Show("Ya existe un Gasto con el Nombre " + nombreActualizado.Text + " en la Base de Datos");
                            nombreActualizado.Text = nombreTextBox.Text;
                            nombreActualizado.Focus();
                            aux = 1;
                        }
                    }
                    if (aux == 0)
                    {
                        ActualizarGastos();
                        if (nombreTextBox.Text != nombreActualizado.Text)
                        {
                            ActualizarPresupuestos();
                        }
                        MessageBox.Show("Los datos del Gasto se han actualizado de manera satisfactoria");
                        string fila = gastosDataGridView.CurrentRow.Index.ToString(); // guardo la fila donde estoy
                        gastosDataGridView.Rows[0].Selected = true;
                        int filaNumero = Convert.ToInt16(fila);
                        CargarDatos();
                        gastosDataGridView.CurrentCell = gastosDataGridView.Rows[filaNumero].Cells[1]; // me posiciono nuevamente en la fila donde estaba
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
            using (NuevoGasto frm1 = new NuevoGasto(user.Text))
            {
                frm1.ShowDialog();
            }
            CargarDatos();
            if (id_GastoTextBox.Text != "")
            {
                HabilitarEntradas();
                gastosDataGridView.CurrentCell = gastosDataGridView.Rows[gastosDataGridView.Rows.Count - 1].Cells[1]; // me posiciono en la ultima fila
            }
        }

        public void CargarDatos()
        {
            if (textBox1.Text != "")
            {
                this.gastosTableAdapter.FillBy((this.corpusDataSet.Gastos), textBox1.Text);
            }
            else
            {
                this.gastosTableAdapter.Fill(this.corpusDataSet.Gastos);
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
                cmd4.CommandText = "INSERT into Balance (Nombre, Concepto, Monto, Fecha, Observaciones, UsuCre) VALUES ('" + nombreTextBox.Text.Replace("'", "") + "', '" + "Pago de un Gasto" + "', " + "-" + montoAPagar + ", '" + dateTimePicker1.Text + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "')";
                cmd4.Connection = conexion;
                conexion.Open();
                cmd4.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se pago el Gasto " + nombreTextBox.Text + " por un monto de $ " + monto.Text);
            }
            else
            {
                SqlCommand cmd4 = new SqlCommand();  // Insertamos el Pago en Balance
                cmd4.CommandType = CommandType.Text;
                auxiliar = Math.Abs(auxiliar);
                monto.Text = auxiliar.ToString();
                string montoAPagar = Convert.ToString(monto.Text.Replace(",", "."));
                cmd4.CommandText = "INSERT into Balance (Nombre, Concepto, Monto, Fecha, Observaciones, UsuCre) VALUES ('" + nombreTextBox.Text.Replace("'", "") + "', '" + "Reintegro de un Gasto" + "', " + montoAPagar + ", '" + dateTimePicker1.Text + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "')";
                cmd4.Connection = conexion;
                conexion.Open();
                cmd4.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se pago el Reintegro del Gasto " + nombreTextBox.Text + " por un monto de $ " + monto.Text);
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
                        dr = MessageBox.Show("¿Esta seguro que quiere Pagar el Gasto " + nombreTextBox.Text + " por un monto de $ " + monto.Text + "?", "PAGAR UN GASTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    else
                    {
                        dr = MessageBox.Show("¿Esta seguro que quiere Pagar el Reintegro del Gasto " + nombreTextBox.Text + " por un monto de $ " + monto.Text + "?", "REINTEGRO DE UN GASTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                MessageBox.Show("Antes de poder Pagar un Gasto debe completar los campos Monto y Fecha");
            }
        }
    }
}
