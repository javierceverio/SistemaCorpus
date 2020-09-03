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
    public partial class Backup : Form
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Corpus.Properties.Settings.CorpusConnectionString"].ConnectionString);

        public Backup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;
                button2.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string database = conexion.Database.ToString();
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            try
            {
                string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, conexion);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + textBox2.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, conexion);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, conexion);
                bu4.ExecuteNonQuery();

                MessageBox.Show("La Base de Datos se Restauro de manera satisfactoria !!!");
                conexion.Close();

                button3.Enabled = false;
                textBox2.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "RESTAURAR LA BASE DE DATOS";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dlg.FileName;
                button3.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string database = conexion.Database.ToString();
            try
            {
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, ingrese la ubicacion del archivo de Base de Datos");
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + textBox1.Text + "\\" + "Base de Datos de Corpus" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, conexion))
                    {
                        if (conexion.State != ConnectionState.Open)
                        {
                            conexion.Open();
                        }
                        command.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("El Backup de la Base de Datos se realizo de manera satisfactoria !!!");
                        button2.Enabled = false;
                        textBox1.Text = "";
                    }
                }

            }
            catch
            {

            }
        }
    }
}
