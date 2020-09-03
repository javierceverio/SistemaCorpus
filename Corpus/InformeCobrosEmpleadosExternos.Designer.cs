namespace Corpus
{
    partial class InformeCobrosEmpleadosExternos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CobrosEmpleadosExternosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CorpusDataSet = new Corpus.CorpusDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nombreEmpleado = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numeroTrabajo = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CobrosEmpleadosExternosTableAdapter = new Corpus.CorpusDataSetTableAdapters.CobrosEmpleadosExternosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CobrosEmpleadosExternosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CobrosEmpleadosExternosBindingSource
            // 
            this.CobrosEmpleadosExternosBindingSource.DataMember = "CobrosEmpleadosExternos";
            this.CobrosEmpleadosExternosBindingSource.DataSource = this.CorpusDataSet;
            // 
            // CorpusDataSet
            // 
            this.CorpusDataSet.DataSetName = "CorpusDataSet";
            this.CorpusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "CobrosEmpleadosExternos";
            reportDataSource5.Value = this.CobrosEmpleadosExternosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Corpus.InformeCobrosEmpleadosExternos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1060, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.AutoSize = true;
            this.nombreEmpleado.Location = new System.Drawing.Point(243, 96);
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.Size = new System.Drawing.Size(89, 13);
            this.nombreEmpleado.TabIndex = 1;
            this.nombreEmpleado.Text = "nombreEmpleado";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.numeroTrabajo);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(713, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 187);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // numeroTrabajo
            // 
            this.numeroTrabajo.Location = new System.Drawing.Point(18, 42);
            this.numeroTrabajo.Name = "numeroTrabajo";
            this.numeroTrabajo.Size = new System.Drawing.Size(100, 20);
            this.numeroTrabajo.TabIndex = 32;
            this.numeroTrabajo.TextChanged += new System.EventHandler(this.numeroTrabajo_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.Red;
            this.checkBox2.Location = new System.Drawing.Point(18, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 17);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "por Trabajo Nº:";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(18, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "por Fechas:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(18, 143);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker2.TabIndex = 29;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(15, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "desde";
            // 
            // CobrosEmpleadosExternosTableAdapter
            // 
            this.CobrosEmpleadosExternosTableAdapter.ClearBeforeFill = true;
            // 
            // InformeCobrosEmpleadosExternos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.nombreEmpleado);
            this.Name = "InformeCobrosEmpleadosExternos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Informe de todos los Cobros del Profesional Externo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InformeCobrosEmpleadosExternos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CobrosEmpleadosExternosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label nombreEmpleado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox numeroTrabajo;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource CobrosEmpleadosExternosBindingSource;
        private CorpusDataSet CorpusDataSet;
        private CorpusDataSetTableAdapters.CobrosEmpleadosExternosTableAdapter CobrosEmpleadosExternosTableAdapter;
    }
}