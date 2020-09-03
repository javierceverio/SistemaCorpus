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
    public partial class InformeBalance : Form
    {
        public InformeBalance()
        {
            InitializeComponent();
        }

        private void InformeBalance_Load(object sender, EventArgs e)
        {
            this.balanceTableAdapter.Fill(this.corpusDataSet.Balance);
            this.reportViewer1.RefreshReport();
        }

        public void Filtrar()
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    MessageBox.Show("La Fecha desde no debe ser mayor a hasta");
                    checkBox1.CheckState = CheckState.Unchecked;
                }
                else
                {
                    this.balanceTableAdapter.FillByConceptoFecha(this.corpusDataSet.Balance, dateTimePicker2.Text, dateTimePicker1.Text, comboBox1.Text);
                    this.reportViewer1.RefreshReport();
                }
            }
            else if (checkBox1.Checked == true)
            {
                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    MessageBox.Show("La Fecha desde no debe ser mayor a hasta");
                    checkBox1.CheckState = CheckState.Unchecked;
                }
                else
                {
                    this.balanceTableAdapter.FillByFechas(this.corpusDataSet.Balance, dateTimePicker2.Text, dateTimePicker1.Text);
                    this.reportViewer1.RefreshReport();
                }
            }
            else if (checkBox2.Checked == true)
            {
                this.balanceTableAdapter.FillBy(this.corpusDataSet.Balance, comboBox1.Text);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.balanceTableAdapter.Fill(this.corpusDataSet.Balance);
                this.reportViewer1.RefreshReport();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
