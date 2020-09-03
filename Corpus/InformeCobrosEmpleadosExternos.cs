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
    public partial class InformeCobrosEmpleadosExternos : Form
    {
        public InformeCobrosEmpleadosExternos(String empleado)
        {
            InitializeComponent();
            nombreEmpleado.Text = empleado;
        }

        private void InformeCobrosEmpleadosExternos_Load(object sender, EventArgs e)
        {
            this.CobrosEmpleadosExternosTableAdapter.FillByNombre(this.CorpusDataSet.CobrosEmpleadosExternos, nombreEmpleado.Text);
            this.reportViewer1.RefreshReport();
        }

        public void Filtrar()
        {
            if (checkBox2.Checked && checkBox1.Checked)
            {
                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    MessageBox.Show("La Fecha desde no debe ser mayor a hasta");
                    checkBox1.CheckState = CheckState.Unchecked;
                }
                else
                {
                    this.CobrosEmpleadosExternosTableAdapter.FillByCompleto(this.CorpusDataSet.CobrosEmpleadosExternos, dateTimePicker2.Text, dateTimePicker1.Text, nombreEmpleado.Text, numeroTrabajo.Text);
                    this.reportViewer1.RefreshReport();
                }
            }
            else if (checkBox2.Checked && !checkBox1.Checked)
            {
                this.CobrosEmpleadosExternosTableAdapter.FillBy(this.CorpusDataSet.CobrosEmpleadosExternos, nombreEmpleado.Text, numeroTrabajo.Text);
                this.reportViewer1.RefreshReport();
            }
            else if (!checkBox2.Checked && checkBox1.Checked)
            {
                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    MessageBox.Show("La Fecha desde no debe ser mayor a hasta");
                    checkBox1.CheckState = CheckState.Unchecked;
                }
                else
                {
                    this.CobrosEmpleadosExternosTableAdapter.FillByNombreFechas((this.CorpusDataSet.CobrosEmpleadosExternos), dateTimePicker2.Text, dateTimePicker1.Text, nombreEmpleado.Text);
                    this.reportViewer1.RefreshReport();
                }
            }
            else
            {
                this.CobrosEmpleadosExternosTableAdapter.FillByNombre(this.CorpusDataSet.CobrosEmpleadosExternos, nombreEmpleado.Text);
                this.reportViewer1.RefreshReport();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void numeroTrabajo_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}
