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
using System.Security.Cryptography;

namespace Corpus
{
    public partial class Usuarios : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public Usuarios(string usuario)
        {
            InitializeComponent();
            user.Text = usuario;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.corpusDataSet.Usuarios);
            nomusuario.Text = usuarioTextBox.Text; // Guardo el nombre de usuario por si, al cambiarlo, chequear que no se repita con otro de la BD
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NuevoUsuario frm1 = new NuevoUsuario(user.Text))
            {
                frm1.ShowDialog();
            }
            CargarDatos();
        }

        public void EliminarUsuario()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Usuarios WHERE (Id_Usuario = " + id_UsuarioTextBox.Text + ")";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id_UsuarioTextBox.Text == "")
            {
                MessageBox.Show("No hay Usuario seleccionado");
            }
            else
            {
                if (nombreTextBox.Text != "CREISYS" && nombreTextBox.Text != "GUILLERMO ARIEL CABRAL" && nombreTextBox.Text != "MARCELO EDUARDO BERRIDI" && nombreTextBox.Text != "JORGE IGNACIO BIDEGORRY")
                {
                    DialogResult dr = MessageBox.Show("¿Esta seguro que quiere Eliminar el Usuario " + nombreTextBox.Text + "?", "ELIMINAR USUARIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        EliminarUsuario();
                        MessageBox.Show("Se ha Eliminado el Usuario");
                        CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("No puede Eliminar al Usuario " + nombreTextBox.Text + " por ser Categoria SUPER ADMINISTRADOR");
                }
            }
        }

        public void ActualizarUsuario()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Usuarios SET Usuario = '" + usuarioTextBox.Text.Replace("'", "") + "', Nivel = '" + nivelComboBox.Text + "', UsuMod = '" + user.Text + "', FechaMod = '" + DateTime.Now + "' WHERE (Id_Usuario = " + id_UsuarioTextBox.Text + ")";
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id_UsuarioTextBox.Text == "")
            {
                MessageBox.Show("No hay Usuario seleccionado");
            }
            else
            {
                if (usuarioTextBox.Text != "" && nivelComboBox.Text != "")
                {
                    ActualizarUsuario();
                    MessageBox.Show("Los datos del Usuario se han actualizado de manera satisfactoria");
                    nomusuario.Text = usuarioTextBox.Text;
                    string fila = usuariosDataGridView.CurrentRow.Index.ToString(); // guardo la fila donde estoy
                    usuariosDataGridView.Rows[0].Selected = true;
                    int filaNumero = Convert.ToInt16(fila);
                    CargarDatos();
                    usuariosDataGridView.CurrentCell = usuariosDataGridView.Rows[filaNumero].Cells[1]; // me posiciono nuevamente en la fila donde estaba
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos obligatorios");
                }
            }
        }

        public void CargarDatos()
        {
            if (textBox1.Text != "")
            {
                this.usuariosTableAdapter.FillBy((this.corpusDataSet.Usuarios), textBox1.Text);
            }
            else
            {
                this.usuariosTableAdapter.Fill(this.corpusDataSet.Usuarios);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            using (ModificarPass frm1 = new ModificarPass(id_UsuarioTextBox.Text))
            {
                frm1.ShowDialog();
            }
            this.usuariosTableAdapter.Fill(this.corpusDataSet.Usuarios);
        }
    }
}
