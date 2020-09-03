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
    public partial class InformeCobrosEmpleados : Form
    {
        public InformeCobrosEmpleados(String empleado)
        {
            InitializeComponent();
            empleadoNombre.Text = empleado;
        }

        private void InformeCobrosEmpleados_Load(object sender, EventArgs e)
        {
            this.CobrosEmpleadosTableAdapter.FillByNombre(this.CorpusDataSet.CobrosEmpleados, empleadoNombre.Text);
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
                    this.CobrosEmpleadosTableAdapter.FillByCompleto(this.CorpusDataSet.CobrosEmpleados, dateTimePicker2.Text, dateTimePicker1.Text, empleadoNombre.Text, numeroTrabajo.Text);
                    this.reportViewer1.RefreshReport();
                }
            }
            else if (checkBox2.Checked && !checkBox1.Checked)
            {
                this.CobrosEmpleadosTableAdapter.FillBy(this.CorpusDataSet.CobrosEmpleados, empleadoNombre.Text, numeroTrabajo.Text);
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
                    this.CobrosEmpleadosTableAdapter.FillByNombreFechas((this.CorpusDataSet.CobrosEmpleados), dateTimePicker2.Text, dateTimePicker1.Text, empleadoNombre.Text);
                    this.reportViewer1.RefreshReport();
                }
            }
            else
            {
                this.CobrosEmpleadosTableAdapter.FillByNombre(this.CorpusDataSet.CobrosEmpleados, empleadoNombre.Text);
                this.reportViewer1.RefreshReport();
            }
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void numeroTrabajo_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}
