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
    public partial class InformeCorpus : Form
    {
        public InformeCorpus()
        {
            InitializeComponent();
        }

        private void InformeCorpus_Load(object sender, EventArgs e)
        {
            this.InformeCorpusTableAdapter.Fill(this.CorpusDataSet.InformeCorpus);
            this.reportViewer1.RefreshReport();
        }

        public void Filtrar()
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                if (comboBox1.Text != "" && comboBox2.Text != "")
                {
                    this.InformeCorpusTableAdapter.FillByEstadoTipo(this.CorpusDataSet.InformeCorpus, comboBox1.Text, comboBox2.Text);
                    this.reportViewer1.RefreshReport();
                }
                else if (comboBox1.Text == "" && comboBox2.Text != "")
                {
                    this.InformeCorpusTableAdapter.FillByTipo(this.CorpusDataSet.InformeCorpus, comboBox2.Text);
                    this.reportViewer1.RefreshReport();
                }
                else if (comboBox1.Text != "" && comboBox2.Text == "")
                {
                    this.InformeCorpusTableAdapter.FillByEstado(this.CorpusDataSet.InformeCorpus, comboBox1.Text);
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    this.InformeCorpusTableAdapter.Fill(this.CorpusDataSet.InformeCorpus);
                    this.reportViewer1.RefreshReport();
                }
            }
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
                if (comboBox2.Text != "")
                {
                    this.InformeCorpusTableAdapter.FillByTipo(this.CorpusDataSet.InformeCorpus, comboBox2.Text);
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    this.InformeCorpusTableAdapter.Fill(this.CorpusDataSet.InformeCorpus);
                    this.reportViewer1.RefreshReport();
                }
            }
            else if (checkBox1.Checked && !checkBox2.Checked)
            {
                if (comboBox1.Text != "")
                {
                    this.InformeCorpusTableAdapter.FillByEstado(this.CorpusDataSet.InformeCorpus, comboBox1.Text);
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    this.InformeCorpusTableAdapter.Fill(this.CorpusDataSet.InformeCorpus);
                    this.reportViewer1.RefreshReport();
                }
            }
            else
            {
                this.InformeCorpusTableAdapter.Fill(this.CorpusDataSet.InformeCorpus);
                this.reportViewer1.RefreshReport();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}
