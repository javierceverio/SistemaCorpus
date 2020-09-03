namespace Corpus
{
    partial class InformeACobrar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InformeACobrarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CorpusDataSet = new Corpus.CorpusDataSet();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InformeACobrarTableAdapter = new Corpus.CorpusDataSetTableAdapters.InformeACobrarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InformeACobrarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // InformeACobrarBindingSource
            // 
            this.InformeACobrarBindingSource.DataMember = "InformeACobrar";
            this.InformeACobrarBindingSource.DataSource = this.CorpusDataSet;
            // 
            // CorpusDataSet
            // 
            this.CorpusDataSet.DataSetName = "CorpusDataSet";
            this.CorpusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(445, 49);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "lblUsuario";
            this.lblUsuario.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "InformeACobrar";
            reportDataSource1.Value = this.InformeACobrarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Corpus.InformeACobrar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 1;
            // 
            // InformeACobrarTableAdapter
            // 
            this.InformeACobrarTableAdapter.ClearBeforeFill = true;
            // 
            // InformeACobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblUsuario);
            this.Name = "InformeACobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrados a Pagar";
            this.Load += new System.EventHandler(this.InformeACobrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InformeACobrarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InformeACobrarBindingSource;
        private CorpusDataSet CorpusDataSet;
        private CorpusDataSetTableAdapters.InformeACobrarTableAdapter InformeACobrarTableAdapter;
    }
}