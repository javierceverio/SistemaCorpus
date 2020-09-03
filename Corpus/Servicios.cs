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
    public partial class Servicios : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public Servicios(String usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        public bool VerSiEstaEnPresupuesto()
        {
            bool verificar = false;

            DataTable dt = presupuestosTableAdapter1.GetData();
            int aux = 0; // Para saber si el servicio esta en algun Presupuesto
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
            button7.Enabled = false;
            observacionesTextBox.Enabled = false;
        }

        public void HabilitarEntradas()
        {
            nombreTextBox.Enabled = true;
            nombreActualizado.Enabled = true;
            monto.Enabled = true;
            dateTimePicker1.Enabled = true;
            button7.Enabled = true;
            observacionesTextBox.Enabled = true;
        }

        private void Impuestos_Load(object sender, EventArgs e)
        {
            this.impuestosTableAdapter.Fill(this.corpusDataSet.Impuestos);
            nombreActualizado.Text = nombreTextBox.Text;
            if (id_ImpTextBox.Text == "")
            {
                DeshabilitarEntradas();
            }
        }

        public void EliminarServicio()
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere Eliminar el Servicio " + nombreTextBox.Text + "?", "ELIMINAR SERVICIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Impuestos WHERE (Id_Imp = " + id_ImpTextBox.Text + ")";
                cmd.Connection = conexion;
                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se ha Eliminado el Servicio");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id_ImpTextBox.Text == "")
            {
                MessageBox.Show("No hay Servicio seleccionado");
            }
            else
            {
                if (VerSiEstaEnPresupuesto())
                {
                    MessageBox.Show("El Servicio no se puede Eliminar por estar asignado en al menos un Presupuesto. A tener en cuenta: podra modificar su nombre y automaticamente cambiara en cada uno de los Presupuestos, Cobros y Pagos en los que este asignado.");
                }
                else
                {
                    EliminarServicio();
                    CargarDatos();
                    if (id_ImpTextBox.Text == "" && textBox1.Text == "")
                    {
                        DeshabilitarEntradas();
                    }
                }
            }
        }

        public void ActualizarServicio()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Impuestos SET Nombre = '" + nombreActualizado.Text.Replace("'", "") + "', Observaciones = '" + observacionesTextBox.Text.Replace("'", "") + "', UsuMod = '" + user.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_Imp = " + id_ImpTextBox.Text + ")";
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
            if (id_ImpTextBox.Text == "")
            {
                MessageBox.Show("No hay Servicio seleccionado");
            }
            else
            {
                if (nombreActualizado.Text != "")
                {
                    DataTable dt = impuestosTableAdapter.GetData();
                    int aux = 0; // Para saber si el impuesto no esta en la BD
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        object[] array = dt.Rows[i].ItemArray;
                        if (nombreActualizado.Text == array[1].ToString() && id_ImpTextBox.Text != array[0].ToString())
                        {
                            MessageBox.Show("Ya existe un Servicio con el Nombre " + nombreActualizado.Text + " en la Base de Datos");
                            nombreActualizado.Text = nombreTextBox.Text;
                            nombreActualizado.Focus();
                            aux = 1;
                        }
                    }
                    if (aux == 0)
                    {
                        ActualizarServicio();
                        if (nombreTextBox.Text != nombreActualizado.Text)
                        {
                            ActualizarPresupuestos();
                        }
                        MessageBox.Show("Los datos del Servicio se han actualizado de manera satisfactoria");
                        string fila = impuestosDataGridView.CurrentRow.Index.ToString(); // guardo la fila donde estoy
                        impuestosDataGridView.Rows[0].Selected = true;
                        int filaNumero = Convert.ToInt16(fila);
                        CargarDatos();
                        impuestosDataGridView.CurrentCell = impuestosDataGridView.Rows[filaNumero].Cells[1]; // me posiciono nuevamente en la fila donde estaba
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
            using (NuevoServicio frm1 = new NuevoServicio(user.Text))
            {
                frm1.ShowDialog();
            }
            CargarDatos();
            if (id_ImpTextBox.Text != "")
            {
                HabilitarEntradas();
                impuestosDataGridView.CurrentCell = impuestosDataGridView.Rows[impuestosDataGridView.Rows.Count - 1].Cells[1]; // me posiciono en la ultima fila
            }
        }

        public void InsertarEnBalance()
        {
            decimal auxiliar = Convert.ToDecimal(monto.Text);
            if (auxiliar > 0)
            {
                SqlCommand cmd4 = new SqlCommand();  // Insertamos el Pago en Balance
                cmd4.CommandType = CommandType.Text;
                string montoAPagar = Convert.ToString(monto.Text.Replace(",", "."));
                cmd4.CommandText = "INSERT into Balance (Nombre, Concepto, Monto, Fecha, Observaciones, UsuCre) VALUES ('" + nombreTextBox.Text.Replace("'", "") + "', '" + "Pago de un Servicio" + "', " + "-" + montoAPagar + ", '" + dateTimePicker1.Text + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "')";
                cmd4.Connection = conexion;
                conexion.Open();
                cmd4.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se pago el Servicio " + nombreTextBox.Text + " por un monto de $ " + monto.Text);
            }
            else
            {
                SqlCommand cmd4 = new SqlCommand();  // Insertamos el Pago en Balance
                cmd4.CommandType = CommandType.Text;
                auxiliar = Math.Abs(auxiliar);
                monto.Text = auxiliar.ToString();
                string montoAPagar = Convert.ToString(monto.Text.Replace(",", "."));
                cmd4.CommandText = "INSERT into Balance (Nombre, Concepto, Monto, Fecha, Observaciones, UsuCre) VALUES ('" + nombreTextBox.Text.Replace("'", "") + "', '" + "Reintegro de un Servicio" + "', " + montoAPagar + ", '" + dateTimePicker1.Text + "', '" + observacionesTextBox.Text.Replace("'", "") + "', '" + user.Text + "')";
                cmd4.Connection = conexion;
                conexion.Open();
                cmd4.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se pago el Reintegro del Servicio " + nombreTextBox.Text + " por un monto de $ " + monto.Text);
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
                        dr = MessageBox.Show("¿Esta seguro que quiere Pagar el Servicio " + nombreTextBox.Text + " por un monto de $ " + monto.Text + "?", "PAGAR UN SERVICIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    else
                    {
                        dr = MessageBox.Show("¿Esta seguro que quiere Pagar el Reintegro del Servicio " + nombreTextBox.Text + " por un monto de $ " + monto.Text + "?", "REINTEGRO DE UN SERVICIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                MessageBox.Show("Antes de poder Pagar un Servicio debe completar los campos Monto y Fecha");
            }
        }

        public void CargarDatos()
        {
            if (textBox1.Text != "")
            {
                this.impuestosTableAdapter.FillBy((this.corpusDataSet.Impuestos), textBox1.Text);
            }
            else
            {
                this.impuestosTableAdapter.Fill(this.corpusDataSet.Impuestos);
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
    }
}
