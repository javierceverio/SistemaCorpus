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
    public partial class InformeEmpleadoExterno : Form
    {
        public InformeEmpleadoExterno(String empleado)
        {
            InitializeComponent();
            nombreEmpleado.Text = empleado;
        }

        private void InformeEmpleadoExterno_Load(object sender, EventArgs e)
        {
            this.InformeEmpleadoExternoTableAdapter.Fill(this.CorpusDataSet.InformeEmpleadoExterno, nombreEmpleado.Text);
            this.reportViewer1.RefreshReport();
        }

        public void FiltrarPorEstado()
        {
            if (checkBox1.Checked && comboBox1.Text != "")
            {
                this.InformeEmpleadoExternoTableAdapter.FillBy(this.CorpusDataSet.InformeEmpleadoExterno, nombreEmpleado.Text, comboBox1.Text);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.InformeEmpleadoExternoTableAdapter.Fill(this.CorpusDataSet.InformeEmpleadoExterno, nombreEmpleado.Text);
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
