namespace Corpus
{
    partial class EmpleadosTotalACobrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.faltaCobrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVPresupuestos = new System.Windows.Forms.DataGridView();
            this.YaCobrado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aCobrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombreEmpleado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cobrosEmpleadosDataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCobroEmpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cobrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuCreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobrosEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corpusDataSet = new Corpus.CorpusDataSet();
            this.cobrosEmpleadosTableAdapter = new Corpus.CorpusDataSetTableAdapters.CobrosEmpleadosTableAdapter();
            this.tableAdapterManager = new Corpus.CorpusDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPresupuestos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosEmpleadosDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.faltaCobrar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DGVPresupuestos);
            this.groupBox1.Controls.Add(this.YaCobrado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.aCobrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nombreEmpleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cobrosEmpleadosDataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 511);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion";
            // 
            // faltaCobrar
            // 
            this.faltaCobrar.BackColor = System.Drawing.Color.White;
            this.faltaCobrar.Enabled = false;
            this.faltaCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faltaCobrar.ForeColor = System.Drawing.Color.Black;
            this.faltaCobrar.Location = new System.Drawing.Point(711, 425);
            this.faltaCobrar.Name = "faltaCobrar";
            this.faltaCobrar.Size = new System.Drawing.Size(203, 23);
            this.faltaCobrar.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(614, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 82;
            this.label4.Text = "Saldo:";
            // 
            // DGVPresupuestos
            // 
            this.DGVPresupuestos.AllowUserToAddRows = false;
            this.DGVPresupuestos.AllowUserToDeleteRows = false;
            this.DGVPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPresupuestos.Location = new System.Drawing.Point(23, 77);
            this.DGVPresupuestos.Name = "DGVPresupuestos";
            this.DGVPresupuestos.ReadOnly = true;
            this.DGVPresupuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPresupuestos.Size = new System.Drawing.Size(561, 276);
            this.DGVPresupuestos.TabIndex = 76;
            // 
            // YaCobrado
            // 
            this.YaCobrado.BackColor = System.Drawing.Color.White;
            this.YaCobrado.Enabled = false;
            this.YaCobrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YaCobrado.ForeColor = System.Drawing.Color.Black;
            this.YaCobrado.Location = new System.Drawing.Point(711, 367);
            this.YaCobrado.Name = "YaCobrado";
            this.YaCobrado.Size = new System.Drawing.Size(203, 20);
            this.YaCobrado.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Total Cobrado:";
            // 
            // aCobrar
            // 
            this.aCobrar.BackColor = System.Drawing.Color.White;
            this.aCobrar.Enabled = false;
            this.aCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCobrar.ForeColor = System.Drawing.Color.Black;
            this.aCobrar.Location = new System.Drawing.Point(117, 367);
            this.aCobrar.Name = "aCobrar";
            this.aCobrar.Size = new System.Drawing.Size(203, 20);
            this.aCobrar.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Total a Cobrar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(19, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "A Cobrar por Trabajo:";
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.AutoSize = true;
            this.nombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEmpleado.Location = new System.Drawing.Point(124, 30);
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.Size = new System.Drawing.Size(103, 13);
            this.nombreEmpleado.TabIndex = 75;
            this.nombreEmpleado.Text = "nombreEmpleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Profesional Interno:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(613, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 73;
            this.label9.Text = "Detalle de Cobros:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(1042, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 125);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar Total a Cobrar";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.Color.Red;
            this.checkBox3.Location = new System.Drawing.Point(15, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(110, 17);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.Text = "Filtrar por Fechas:";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(15, 94);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker2.TabIndex = 29;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "hasta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(12, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "desde";
            // 
            // cobrosEmpleadosDataGridView1
            // 
            this.cobrosEmpleadosDataGridView1.AllowUserToAddRows = false;
            this.cobrosEmpleadosDataGridView1.AllowUserToDeleteRows = false;
            this.cobrosEmpleadosDataGridView1.AutoGenerateColumns = false;
            this.cobrosEmpleadosDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cobrosEmpleadosDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCobroEmpDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.numTrabajoDataGridViewTextBoxColumn,
            this.Cobrado,
            this.Fecha,
            this.usuCreDataGridViewTextBoxColumn});
            this.cobrosEmpleadosDataGridView1.DataSource = this.cobrosEmpleadosBindingSource;
            this.cobrosEmpleadosDataGridView1.Location = new System.Drawing.Point(617, 77);
            this.cobrosEmpleadosDataGridView1.Name = "cobrosEmpleadosDataGridView1";
            this.cobrosEmpleadosDataGridView1.ReadOnly = true;
            this.cobrosEmpleadosDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cobrosEmpleadosDataGridView1.Size = new System.Drawing.Size(561, 276);
            this.cobrosEmpleadosDataGridView1.TabIndex = 71;
            // 
            // idCobroEmpDataGridViewTextBoxColumn
            // 
            this.idCobroEmpDataGridViewTextBoxColumn.DataPropertyName = "Id_CobroEmp";
            this.idCobroEmpDataGridViewTextBoxColumn.HeaderText = "Id_CobroEmp";
            this.idCobroEmpDataGridViewTextBoxColumn.Name = "idCobroEmpDataGridViewTextBoxColumn";
            this.idCobroEmpDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCobroEmpDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 69;
            // 
            // numTrabajoDataGridViewTextBoxColumn
            // 
            this.numTrabajoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numTrabajoDataGridViewTextBoxColumn.DataPropertyName = "NumTrabajo";
            this.numTrabajoDataGridViewTextBoxColumn.HeaderText = "Trabajo Nº";
            this.numTrabajoDataGridViewTextBoxColumn.Name = "numTrabajoDataGridViewTextBoxColumn";
            this.numTrabajoDataGridViewTextBoxColumn.ReadOnly = true;
            this.numTrabajoDataGridViewTextBoxColumn.Width = 83;
            // 
            // Cobrado
            // 
            this.Cobrado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cobrado.DataPropertyName = "Cobrado";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Cobrado.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cobrado.HeaderText = "Cobrado";
            this.Cobrado.Name = "Cobrado";
            this.Cobrado.ReadOnly = true;
            this.Cobrado.Width = 72;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 62;
            // 
            // usuCreDataGridViewTextBoxColumn
            // 
            this.usuCreDataGridViewTextBoxColumn.DataPropertyName = "UsuCre";
            this.usuCreDataGridViewTextBoxColumn.HeaderText = "UsuCre";
            this.usuCreDataGridViewTextBoxColumn.Name = "usuCreDataGridViewTextBoxColumn";
            this.usuCreDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuCreDataGridViewTextBoxColumn.Visible = false;
            // 
            // cobrosEmpleadosBindingSource
            // 
            this.cobrosEmpleadosBindingSource.DataMember = "CobrosEmpleados";
            this.cobrosEmpleadosBindingSource.DataSource = this.corpusDataSet;
            // 
            // corpusDataSet
            // 
            this.corpusDataSet.DataSetName = "CorpusDataSet";
            this.corpusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cobrosEmpleadosTableAdapter
            // 
            this.cobrosEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APagarOtrosTableAdapter = null;
            this.tableAdapterManager.APagarTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BalanceTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.CobrosEmpleadosExternosTableAdapter = null;
            this.tableAdapterManager.CobrosEmpleadosTableAdapter = this.cobrosEmpleadosTableAdapter;
            this.tableAdapterManager.CobrosOtrosTableAdapter = null;
            this.tableAdapterManager.CobrosTableAdapter = null;
            this.tableAdapterManager.EmpleadosExternosTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.FijosTableAdapter = null;
            this.tableAdapterManager.GastosTableAdapter = null;
            this.tableAdapterManager.ImpuestosTableAdapter = null;
            this.tableAdapterManager.InformeCorpusTableAdapter = null;
            this.tableAdapterManager.OtrosTableAdapter = null;
            this.tableAdapterManager.PagosTableAdapter = null;
            this.tableAdapterManager.PresupuestosTableAdapter = null;
            this.tableAdapterManager.TrabajosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Corpus.CorpusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // EmpleadosTotalACobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1226, 540);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmpleadosTotalACobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total a Cobrar";
            this.Load += new System.EventHandler(this.EmpleadosTotalACobrar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPresupuestos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosEmpleadosDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView cobrosEmpleadosDataGridView1;
        private CorpusDataSet corpusDataSet;
        private System.Windows.Forms.BindingSource cobrosEmpleadosBindingSource;
        private CorpusDataSetTableAdapters.CobrosEmpleadosTableAdapter cobrosEmpleadosTableAdapter;
        private CorpusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label nombreEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVPresupuestos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox aCobrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YaCobrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox faltaCobrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCobroEmpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cobrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuCreDataGridViewTextBoxColumn;
    }
}