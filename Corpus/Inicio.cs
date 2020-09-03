using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corpus
{
    public partial class Inicio : Form
    {
        public Inicio(String nombre)
        {
            InitializeComponent();
            user.Text = nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Usuarios frm1 = new Usuarios(user.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Ayuda().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Backup().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Clientes frm1 = new Clientes(user.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Empleados frm1 = new Empleados(user.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (Servicios frm1 = new Servicios(user.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (EmpleadosExternos frm1 = new EmpleadosExternos(user.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (Gastos frm1 = new Gastos(user.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (Otros frm1 = new Otros(user.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Pagos frm1 = new Pagos(user.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Trabajos frm1 = new Trabajos(user.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (Balance frm1 = new Balance(user.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (APagar frm1 = new APagar(user.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            using (Impuestos frm1 = new Impuestos(user.Text))
            {
                frm1.ShowDialog();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            using (InformeCorpus frm1 = new InformeCorpus())
            {
                frm1.ShowDialog();
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
