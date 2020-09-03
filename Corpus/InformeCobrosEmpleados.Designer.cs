namespace Corpus
{
    partial class InformeCobrosEmpleados
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
            this.CobrosEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CorpusDataSet = new Corpus.CorpusDataSet();
            this.empleadoNombre = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numeroTrabajo = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CobrosEmpleadosTableAdapter = new Corpus.CorpusDataSetTableAdapters.CobrosEmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CobrosEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CobrosEmpleadosBindingSource
            // 
            this.CobrosEmpleadosBindingSource.DataMember = "CobrosEmpleados";
            this.CobrosEmpleadosBindingSource.DataSource = this.CorpusDataSet;
            // 
            // CorpusDataSet
            // 
            this.CorpusDataSet.DataSetName = "CorpusDataSet";
            this.CorpusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoNombre
            // 
            this.empleadoNombre.AutoSize = true;
            this.empleadoNombre.Location = new System.Drawing.Point(198, 71);
            this.empleadoNombre.Name = "empleadoNombre";
            this.empleadoNombre.Size = new System.Drawing.Size(90, 13);
            this.empleadoNombre.TabIndex = 1;
            this.empleadoNombre.Text = "empleadoNombre";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "InformeCobrosEmpleados";
            reportDataSource1.Value = this.CobrosEmpleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Corpus.InformeCobrosEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1098, 450);
            this.reportViewer1.TabIndex = 2;
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
            this.groupBox3.Location = new System.Drawing.Point(710, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 187);
            this.groupBox3.TabIndex = 66;
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
            // CobrosEmpleadosTableAdapter
            // 
            this.CobrosEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // InformeCobrosEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1098, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.empleadoNombre);
            this.Name = "InformeCobrosEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Informe de todos los Cobros del Profesional Interno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InformeCobrosEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CobrosEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorpusDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label empleadoNombre;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CobrosEmpleadosBindingSource;
        private CorpusDataSet CorpusDataSet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numeroTrabajo;
        private CorpusDataSetTableAdapters.CobrosEmpleadosTableAdapter CobrosEmpleadosTableAdapter;
    }
}