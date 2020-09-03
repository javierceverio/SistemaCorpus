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
    public partial class PresupuestosComenzaronCobros : Form
    {
        public PresupuestosComenzaronCobros(String usuario, String trabajo)
        {
            InitializeComponent();
            lblNTrabajo.Text = trabajo;
            lblUsuario.Text = usuario;
        }

        public void SumarItemsPresupuesto()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in presupuestosDataGridView.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Total"].Value);
            }
            txtTotal.Text = "$ " + total.ToString("N");
        }

        private void PresupuestosComenzaronCobros_Load(object sender, EventArgs e)
        {
            this.presupuestosTableAdapter.FillBy((this.corpusDataSet.Presupuestos), lblNTrabajo.Text);
            SumarItemsPresupuesto();
        }
    }
}
