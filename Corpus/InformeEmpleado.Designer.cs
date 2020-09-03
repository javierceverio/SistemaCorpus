namespace Corpus
{
    partial class InformeEmpleado
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
            this.InformeEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CorpusDataSet = new Corpus.CorpusDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nombreEmpleado = new System.Windows.Forms.Label();
            this.InformeEmpleadoTableAdapter = new Corpus.CorpusDataSetTableAdapters.InformeEmpleadoTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.InformeEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // InformeEmpleadoBindingSource
            // 
            this.InformeEmpleadoBindingSource.DataMember = "InformeEmpleado";
            this.InformeEmpleadoBindingSource.DataSource = this.CorpusDataSet;
            // 
            // CorpusDataSet
            // 
            this.CorpusDataSet.DataSetName = "CorpusDataSet";
            this.CorpusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "InformeEmpleado";
            reportDataSource1.Value = this.InformeEmpleadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Corpus.InformeEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.AutoSize = true;
            this.nombreEmpleado.Location = new System.Drawing.Point(534, 73);
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.Size = new System.Drawing.Size(89, 13);
            this.nombreEmpleado.TabIndex = 1;
            this.nombreEmpleado.Text = "nombreEmpleado";
            // 
            // InformeEmpleadoTableAdapter
            // 
            this.InformeEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(322, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Filtrar por Estado del Trabajo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PRESUPUESTADO",
            "ACEPTADO",
            "INICIADO",
            "FINALIZADO",
            "CERRADO"});
            this.comboBox1.Location = new System.Drawing.Point(322, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // InformeEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.nombreEmpleado);
            this.Name = "InformeEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Informe de Cobros del Profesional Interno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InformeEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InformeEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label nombreEmpleado;
        private System.Windows.Forms.BindingSource InformeEmpleadoBindingSource;
        private CorpusDataSet CorpusDataSet;
        private CorpusDataSetTableAdapters.InformeEmpleadoTableAdapter InformeEmpleadoTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}