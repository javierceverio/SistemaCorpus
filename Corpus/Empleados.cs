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
    public partial class Empleados : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public Empleados(string usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        public bool VerSiEstaEnPresupuesto()
        {
            bool verificar = false;

            DataTable dt = presupuestosTableAdapter.GetData();
            int aux = 0; // Para saber si el empleado esta en algun Presupuesto
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

        private void Empleados_Load(object sender, EventArgs e)
        {
            this.empleadosTableAdapter.Fill(this.corpusDataSet.Empleados);
            if (id_EmpleadoTextBox.Text == "")
            {
                DeshabilitarEntradas();
            }
            nombreActualizado.Text = nombreTextBox.Text;
        }

        public void DeshabilitarEntradas()
        {
            nombreTextBox.Enabled = false;
            telFijoTextBox.Enabled = false;
            telMovilTextBox.Enabled = false;
            mailTextBox.Enabled = false;
            observacionesTextBox.Enabled = false;
        }

        public void HabilitarEntradas()
        {
            nombreTextBox.Enabled = true;
            telFijoTextBox.Enabled = true;
            telMovilTextBox.Enabled = true;
            mailTextBox.Enabled = true;
            observacionesTextBox.Enabled = true;
        }

        public void EliminarEmpleado()
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que quiere Eliminar el Profesional Interno " + nombreTextBox.Text + "?", "ELIMINAR PROFESIONAL INTERNO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Empleados WHERE (Id_Empleado = " + id_EmpleadoTextBox.Text + ")";
                cmd.Connection = conexion;

                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se ha Eliminado el Profesional Interno");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id_EmpleadoTextBox.Text == "")
            {
                MessageBox.Show("No hay Cliente seleccionado");
            }
            else if (nombreTextBox.Text == "MARCELO EDUARDO BERRIDI" || nombreTextBox.Text == "GUILLERMO ARIEL CABRAL" || nombreTextBox.Text == "JORGE IGNACIO BIDEGORRY" || nombreTextBox.Text == "RICHARD CAMACHO FERNANDEZ")
            {
                MessageBox.Show("El Profesional Interno " + nombreTextBox.Text + " no se puede Eliminar del Sistema. Cualquier inconveniente comuniquese con CreISys");
            }
            else
            {
                if (VerSiEstaEnPresupuesto())
                {
                    MessageBox.Show("El Profesional Interno no se puede Eliminar por estar asignado en al menos un Presupuesto. A tener en cuenta: podra modificar su nombre y automaticamente cambiara en cada uno de los Presupuestos, Cobros y Pagos en los que este asignado.");
                }
                else
                {
                    EliminarEmpleado();
                    CargarDatos();
                    if (id_EmpleadoTextBox.Text == "" && textBox1.Text == "")
                    {
                        DeshabilitarEntradas();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NuevoEmpleado frm1 = new NuevoEmpleado(user.Text))
            {
                frm1.ShowDialog();
            }
            CargarDatos();
            if (id_EmpleadoTextBox.Text != "")
            {
                HabilitarEntradas();
                empleadosDataGridView.CurrentCell = empleadosDataGridView.Rows[empleadosDataGridView.Rows.Count - 1].Cells[1]; // me posiciono en la ultima fila
            }
        }

        public void ActualizarEmpleado()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Empleados SET Nombre = '" + nombreActualizado.Text.Replace("'", "") + "', TelFijo = '" + telFijoTextBox.Text.Replace("'", "") + "', TelMovil = '" + telMovilTextBox.Text.Replace("'", "") + "', Mail = '" + mailTextBox.Text.Replace("'", "") + "', Observaciones = '" + observacionesTextBox.Text.Replace("'", "") + "', UsuMod = '" + user.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_Empleado = " + id_EmpleadoTextBox.Text + ")";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Los datos del Profesional Interno se han actualizado de manera satisfactoria");
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

        public void ActualizarCobrosEmpleados()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE CobrosEmpleados SET Nombre = '" + nombreActualizado.Text.Replace("'", "") + "' WHERE (Nombre = '" + nombreTextBox.Text + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ActualizarUsuarios()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Usuarios SET Nombre = '" + nombreActualizado.Text.Replace("'", "") + "' WHERE (Nombre = '" + nombreTextBox.Text + "')";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id_EmpleadoTextBox.Text == "")
            {
                MessageBox.Show("No hay Profesional Interno seleccionado");
            }
            else
            {
                if (nombreActualizado.Text != "")
                {
                    DataTable dt = empleadosTableAdapter.GetData();
                    int aux = 0; // Para saber si el empleado no esta en la BD
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        object[] array = dt.Rows[i].ItemArray;
                        if (nombreActualizado.Text == array[1].ToString() && id_EmpleadoTextBox.Text != array[0].ToString())
                        {
                            MessageBox.Show("Ya existe un Profesional Interno " + nombreActualizado.Text + " en la Base de Datos");
                            nombreActualizado.Text = nombreTextBox.Text;
                            nombreActualizado.Focus();
                            aux = 1;
                        }
                    }
                    if (aux == 0)
                    {
                        if ((nombreTextBox.Text == "MARCELO EDUARDO BERRIDI" || nombreTextBox.Text == "GUILLERMO ARIEL CABRAL" || nombreTextBox.Text == "JORGE IGNACIO BIDEGORRY" || nombreTextBox.Text == "RICHARD CAMACHO FERNANDEZ") && nombreActualizado.Text != nombreTextBox.Text)
                        {
                            MessageBox.Show("No se puede modificar el Nombre y Apellido del Profesional " + nombreTextBox.Text + " por razones de Seguridad del Sistema. Ante cualquier duda comuniquese con CreISys.");
                            nombreActualizado.Text = nombreTextBox.Text;
                        }
                        else
                        {
                            ActualizarEmpleado();
                            if (nombreTextBox.Text != nombreActualizado.Text)
                            {
                                ActualizarPresupuestos();
                                ActualizarUsuarios();
                                ActualizarCobrosEmpleados();
                            }
                            string fila = empleadosDataGridView.CurrentRow.Index.ToString(); // guardo la fila donde estoy
                            empleadosDataGridView.Rows[0].Selected = true;
                            int filaNumero = Convert.ToInt16(fila);
                            CargarDatos();
                            empleadosDataGridView.CurrentCell = empleadosDataGridView.Rows[filaNumero].Cells[1]; // me posiciono nuevamente en la fila donde estaba
                        }
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

        private void detallePagosCobros_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                using (DetallesEmpleados frm1 = new DetallesEmpleados(nombreTextBox.Text))
                {
                    frm1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay un Profesional Interno seleccionado");
            }
        }

        public void CargarDatos()
        {
            if (textBox1.Text != "")
            {
                this.empleadosTableAdapter.FillBy((this.corpusDataSet.Empleados), textBox1.Text);
            }
            else
            {
                this.empleadosTableAdapter.Fill(this.corpusDataSet.Empleados);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void aCobrar_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                using (EmpleadosTotalACobrar frm1 = new EmpleadosTotalACobrar(nombreTextBox.Text))
                {
                    frm1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay un Profesional Interno seleccionado");
            }
        }

        private void InformeACobrarPorTrabajo_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                using (InformeEmpleado frm1 = new InformeEmpleado(nombreTextBox.Text))
                {
                    frm1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay un Profesional Interno seleccionado");
            }
        }

        private void InformeTodosLosCobros_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                using (InformeCobrosEmpleados frm1 = new InformeCobrosEmpleados(nombreTextBox.Text))
                {
                    frm1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay un Profesional Interno seleccionado");
            }
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            nombreActualizado.Text = nombreTextBox.Text;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text != "")
            {
                using (Percibido frm1 = new Percibido(nombreTextBox.Text))
                {
                    frm1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay un Profesional Interno seleccionado");
            }
        }
    }
}
