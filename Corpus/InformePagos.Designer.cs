namespace Corpus
{
    partial class InformePagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InformePagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CorpusDataSet = new Corpus.CorpusDataSet();
            this.montotxt = new System.Windows.Forms.TextBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.trabajotxt = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InformePagosTableAdapter = new Corpus.CorpusDataSetTableAdapters.InformePagosTableAdapter();
            this.fechatxt = new System.Windows.Forms.TextBox();
            this.totalAPagar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.InformePagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // InformePagosBindingSource
            // 
            this.InformePagosBindingSource.DataMember = "InformePagos";
            this.InformePagosBindingSource.DataSource = this.CorpusDataSet;
            // 
            // CorpusDataSet
            // 
            this.CorpusDataSet.DataSetName = "CorpusDataSet";
            this.CorpusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // montotxt
            // 
            this.montotxt.Location = new System.Drawing.Point(652, 120);
            this.montotxt.Name = "montotxt";
            this.montotxt.Size = new System.Drawing.Size(100, 20);
            this.montotxt.TabIndex = 1;
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(652, 146);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(100, 20);
            this.totaltxt.TabIndex = 3;
            // 
            // trabajotxt
            // 
            this.trabajotxt.Location = new System.Drawing.Point(652, 172);
            this.trabajotxt.Name = "trabajotxt";
            this.trabajotxt.Size = new System.Drawing.Size(100, 20);
            this.trabajotxt.TabIndex = 4;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "InformePagos";
            reportDataSource4.Value = this.InformePagosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Corpus.InformePagos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 5;
            // 
            // InformePagosTableAdapter
            // 
            this.InformePagosTableAdapter.ClearBeforeFill = true;
            // 
            // fechatxt
            // 
            this.fechatxt.Location = new System.Drawing.Point(652, 198);
            this.fechatxt.Name = "fechatxt";
            this.fechatxt.Size = new System.Drawing.Size(100, 20);
            this.fechatxt.TabIndex = 6;
            // 
            // totalAPagar
            // 
            this.totalAPagar.Location = new System.Drawing.Point(652, 224);
            this.totalAPagar.Name = "totalAPagar";
            this.totalAPagar.Size = new System.Drawing.Size(100, 20);
            this.totalAPagar.TabIndex = 7;
            // 
            // InformePagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.totalAPagar);
            this.Controls.Add(this.fechatxt);
            this.Controls.Add(this.trabajotxt);
            this.Controls.Add(this.totaltxt);
            this.Controls.Add(this.montotxt);
            this.Name = "InformePagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Informe de los Pagos Realizados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InformePagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InformePagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox montotxt;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.TextBox trabajotxt;
        private System.Windows.Forms.BindingSource InformePagosBindingSource;
        private CorpusDataSet CorpusDataSet;
        private CorpusDataSetTableAdapters.InformePagosTableAdapter InformePagosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox fechatxt;
        private System.Windows.Forms.TextBox totalAPagar;
    }
}