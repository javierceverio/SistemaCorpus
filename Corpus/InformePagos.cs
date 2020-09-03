using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Corpus
{
    public partial class InformePagos : Form
    {
        public InformePagos(string monto, string total, string trabajo, string fecha, string pagar)
        {
            InitializeComponent();
            montotxt.Text = monto.Replace(',', '.');
            totaltxt.Text = total.Replace(',', '.');
            trabajotxt.Text = trabajo;
            fechatxt.Text = fecha;
            totalAPagar.Text = pagar.Replace(',', '.');
        }

        private void InformePagos_Load(object sender, EventArgs e)
        {
            //Array que contendrá los parámetros
            ReportParameter[] parameters = new ReportParameter[3];
            //Establecemos el valor de los parámetros
            parameters[0] = new ReportParameter("NumTrabajo", trabajotxt.Text);
            parameters[1] = new ReportParameter("Fecha", fechatxt.Text);
            parameters[2] = new ReportParameter("Pagar", totalAPagar.Text);
            this.InformePagosTableAdapter.Fill(this.CorpusDataSet.InformePagos, montotxt.Text, totaltxt.Text, trabajotxt.Text);
            //Pasamos el array de los parámetros al ReportViewer
            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
