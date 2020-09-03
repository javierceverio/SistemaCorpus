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
    public partial class InformeACobrar : Form
    {
        public InformeACobrar(String usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void InformeACobrar_Load(object sender, EventArgs e)
        {
            this.InformeACobrarTableAdapter.Fill(this.CorpusDataSet.InformeACobrar, lblUsuario.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
