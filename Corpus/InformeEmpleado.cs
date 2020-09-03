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
    public partial class InformeEmpleado : Form
    {
        public InformeEmpleado(String empleado)
        {
            InitializeComponent();
            nombreEmpleado.Text = empleado;
        }

        private void InformeEmpleado_Load(object sender, EventArgs e)
        {
            this.InformeEmpleadoTableAdapter.Fill(this.CorpusDataSet.InformeEmpleado, nombreEmpleado.Text);
            this.reportViewer1.RefreshReport();
        }

        public void FiltrarPorEstado()
        {
            if (checkBox1.Checked && comboBox1.Text != "")
            {
                this.InformeEmpleadoTableAdapter.FillBy(this.CorpusDataSet.InformeEmpleado, nombreEmpleado.Text, comboBox1.Text);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.InformeEmpleadoTableAdapter.Fill(this.CorpusDataSet.InformeEmpleado, nombreEmpleado.Text);
                this.reportViewer1.RefreshReport();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarPorEstado();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarPorEstado();
        }
    }
}
