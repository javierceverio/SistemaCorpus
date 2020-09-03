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
    public partial class EmpleadosExternos : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public EmpleadosExternos(String usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        public bool VerSiEstaEnPresupuesto()
        {
            bool verificar = false;

            DataTable dt = presupuestosTableAdapter1.GetData();
            int aux = 0; // Para saber si el empleado externo esta en algun Presupuesto
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
            telFijoTextBox.Enabled = false;
            telMovilTextBox.Enabled = false;
            mailTextBox.Enabled = false;
            observacionesTextBox.Enabled = false;
        }

        public void HabilitarEntradas()
        {
            nombreTextBox.Enabled = true;
            nombreActualizado.Enabled = true;
            telFijoTextBox.Enabled = true;
            telMovilTextBox.Enabled = true;
            mailTextBox.Enabled = true;
            observacionesTextBox.Enabled = true;
        }

        private void EmpleadosExternos_Load(object sender, EventArgs e)
        {
            this.empleadosExternosTableAdapter.Fill(this.corpusDataSet.EmpleadosExternos);
            nombreActualizado.Text = nombreTextBox.Text;
            if (id_EmpleadoExternoTextBox.Text == "")
            {
                DeshabilitarEntradas();
            }
        }

        public void EliminarEmpleadoExterno()
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere Eliminar el Profesional Externo " + nombreTextBox.Text + "?", "ELIMINAR PROFESIONAL EXTERNO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM EmpleadosExternos WHERE (Id_EmpleadoExterno = " + id_EmpleadoExternoTextBox.Text + ")";
                cmd.Connection = conexion;
                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se ha Eliminado el Profesional Externo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id_EmpleadoExternoTextBox.Text == "")
            {
                MessageBox.Show("No hay Profesional Externo seleccionado");
            }
            else
            {
                if (VerSiEstaEnPresupuesto())
                {
                    MessageBox.Show("El Profesional Externo no se puede Eliminar por estar asignado en al menos un Presupuesto. A tener en cuenta: podra modificar su nombre y automaticamente cambiara en cada uno de los Presupuestos, Cobros y Pagos en los que este asignado.");
                }
                else
                {
                    EliminarEmpleadoExterno();
                    CargarDatos();

                    if (id_EmpleadoExternoTextBox.Text == "" && textBox1.Text == "")
                    {
                        DeshabilitarEntradas();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NuevoEmpleadoExterno frm1 = new NuevoEmpleadoExterno(user.Text))
            {
                frm1.ShowDialog();
            }
            CargarDatos();
            if (id_EmpleadoExternoTextBox.Text != "")
            {
                HabilitarEntradas();
                empleadosExternosDataGridView.CurrentCell = empleadosExternosDataGridView.Rows[empleadosExternosDataGridView.Rows.Count - 1].Cells[1]; // me posiciono en la ultima fila
            }
        }

        public void ActualizarEmpleadoExterno()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE EmpleadosExternos SET Nombre = '" + nombreActualizado.Text.Replace("'", "") + "', TelFijo = '" + telFijoTextBox.Text.Replace("'", "") + "', TelMovil = '" + telMovilTextBox.Text.Replace("'", "") + "', Mail = '" + mailTextBox.Text.Replace("'", "") + "', Observaciones = '" + observacionesTextBox.Text.Replace("'", "") + "', UsuMod = '" + user.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_EmpleadoExterno = " + id_EmpleadoExternoTextBox.Text + ")";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Los datos del Profesional Externo se han actualizado de manera satisfactoria");
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

        public void ActualizarCobrosEmpleadosExternos()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE CobrosEmpleadosExternos SET Nombre = '" + nombreActualizado.Text.Replace("'", "") + "' WHERE (Nombre = '" + nombreTextBox.Text + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id_EmpleadoExternoTextBox.Text == "")
            {
                MessageBox.Show("No hay Profesional Externo seleccionado");
            }
            else
            {
                if (nombreActualizado.Text != "")
                {
                    DataTable dt = empleadosExternosTableAdapter.GetData();
                    int aux = 0; // Para saber si el empleado externo no esta en la BD
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        object[] array = dt.Rows[i].ItemArray;
                        if (nombreActualizado.Text == array[1].ToString() && id_EmpleadoExternoTextBox.Text != array[0].ToString())
                        {
                            MessageBox.Show("Ya existe un Profesional Externo con el Nombre " + nombreActualizado.Text + " en la Base de Datos");
                            nombreActualizado.Text = nombreTextBox.Text;
                            nombreActualizado.Focus();
                            aux = 1;
                        }
                    }
                    if (aux == 0)
                    {
                        ActualizarEmpleadoExterno();
                        if (nombreTextBox.Text != nombreActualizado.Text)
                        {
                            ActualizarPresupuestos();
                            ActualizarCobrosEmpleadosExternos();
                        }
                        string fila = empleadosExternosDataGridView.CurrentRow.Index.ToString(); // guardo la fila donde estoy
                        empleadosExternosDataGridView.Rows[0].Selected = true;
                        int filaNumero = Convert.ToInt16(fila);
                        CargarDatos();
                        empleadosExternosDataGridView.CurrentCell = empleadosExternosDataGridView.Rows[filaNumero].Cells[1]; // me posiciono nuevamente en la fila donde estaba
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios");
                }
            }
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

        public void CargarDatos()
        {
            if (textBox1.Text != "")
            {
                this.empleadosExternosTableAdapter.FillBy((this.corpusDataSet.EmpleadosExternos), textBox1.Text);
            }
            else
            {
                this.empleadosExternosTableAdapter.Fill(this.corpusDataSet.EmpleadosExternos);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void detallePagosCobros_Click_1(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                using (DetallesEmpleadosExternos frm1 = new DetallesEmpleadosExternos(nombreTextBox.Text))
                {
                    frm1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay un Profesional Externo seleccionado");
            }
        }

        private void aCobrar_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                using (EmpleadosExternosTotalACobrar frm1 = new EmpleadosExternosTotalACobrar(nombreTextBox.Text))
                {
                    frm1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay un Profesional Externo seleccionado");
            }
        }

        private void InformeACobrarPorTrabajo_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                using (InformeEmpleadoExterno frm1 = new InformeEmpleadoExterno(nombreTextBox.Text))
                {
                    frm1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay un Profesional Externo seleccionado");
            }
        }

        private void InformeTodosLosCobros_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                using (InformeCobrosEmpleadosExternos frm1 = new InformeCobrosEmpleadosExternos(nombreTextBox.Text))
                {
                    frm1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay un Profesional Externo seleccionado");
            }
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            nombreActualizado.Text = nombreTextBox.Text;
        }
    }
}
