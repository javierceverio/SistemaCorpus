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
    public partial class InicioParaUsuarios : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public InicioParaUsuarios(String empleado, String id, bool permiso)
        {
            InitializeComponent();
            empleadoNombre.Text = empleado;
            idEmpleado.Text = id;
            if (permiso)
            {
                button8.Visible = true;
            }
        }

        private void InicioParaUsuarios_Load(object sender, EventArgs e)
        {
            this.empleadosTableAdapter.FillBy(this.corpusDataSet.Empleados, empleadoNombre.Text);
            nombreActualizado.Text = nombreTextBox.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Backup().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (DetallesEmpleados frm1 = new DetallesEmpleados(nombreTextBox.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (EmpleadosTotalACobrar frm1 = new EmpleadosTotalACobrar(nombreTextBox.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (InformeEmpleado frm1 = new InformeEmpleado(nombreTextBox.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (InformeCobrosEmpleados frm1 = new InformeCobrosEmpleados(nombreTextBox.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            nombreActualizado.Text = nombreTextBox.Text;
        }

        public void ActualizarEmpleado()
        {
            if (nombreTextBox.Text != "RICHARD CAMACHO FERNANDEZ")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Empleados SET Nombre = '" + nombreActualizado.Text.Replace("'", "") + "', TelFijo = '" + telFijoTextBox.Text.Replace("'", "") + "', TelMovil = '" + telMovilTextBox.Text.Replace("'", "") + "', Mail = '" + mailTextBox.Text.Replace("'", "") + "', UsuMod = '" + nombreActualizado.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_Empleado = " + id_EmpleadoTextBox.Text + ")";
                cmd.Connection = conexion;
                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Los datos del Profesional Interno se han actualizado de manera satisfactoria");
            }
            else if (nombreTextBox.Text == "RICHARD CAMACHO FERNANDEZ" && nombreTextBox.Text == nombreActualizado.Text)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Empleados SET TelFijo = '" + telFijoTextBox.Text.Replace("'", "") + "', TelMovil = '" + telMovilTextBox.Text.Replace("'", "") + "', Mail = '" + mailTextBox.Text.Replace("'", "") + "', UsuMod = '" + nombreActualizado.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_Empleado = " + id_EmpleadoTextBox.Text + ")";
                cmd.Connection = conexion;
                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Los datos del Profesional Interno se han actualizado de manera satisfactoria");
            }
            else
            {
                MessageBox.Show("No se puede modificar el Nombre y Apellido del Profesional " + nombreTextBox.Text + " por razones de Seguridad del Sistema. Ante cualquier duda comuniquese con CreISys.");
                nombreActualizado.Text = nombreTextBox.Text;
            }
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
            if (nombreActualizado.Text != "")
            {
                DataTable dt = empleadosTableAdapter.GetData(); // Para saber si el empleado no esta en la BD
                int aux = 0; 
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
                    ActualizarEmpleado();
                    if (nombreTextBox.Text != nombreActualizado.Text)
                    {
                        ActualizarPresupuestos();
                        ActualizarUsuarios();
                        ActualizarCobrosEmpleados();
                        empleadoNombre.Text = nombreActualizado.Text;
                    }
                    this.empleadosTableAdapter.FillBy(this.corpusDataSet.Empleados, empleadoNombre.Text);
                    nombreActualizado.Text = nombreTextBox.Text;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (ModificarPass frm1 = new ModificarPass(idEmpleado.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            using (Percibido frm1 = new Percibido(nombreTextBox.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            new Ayuda().ShowDialog();
        }
    }
}
