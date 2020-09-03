namespace Corpus
{
    partial class DetallesEmpleadosExternos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVPresupuestos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cobrosEmpleadosExternosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cobrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobrosEmpleadosExternosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corpusDataSet = new Corpus.CorpusDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.faltaCobrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.estados = new System.Windows.Forms.ComboBox();
            this.yaCobrado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreEmpleado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeroTrabajo = new System.Windows.Forms.TextBox();
            this.paraCobrar = new System.Windows.Forms.TextBox();
            this.cobrosEmpleadosExternosTableAdapter = new Corpus.CorpusDataSetTableAdapters.CobrosEmpleadosExternosTableAdapter();
            this.tableAdapterManager = new Corpus.CorpusDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPresupuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosEmpleadosExternosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosEmpleadosExternosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVPresupuestos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cobrosEmpleadosExternosDataGridView);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.faltaCobrar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.estados);
            this.groupBox1.Controls.Add(this.yaCobrado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nombreEmpleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numeroTrabajo);
            this.groupBox1.Controls.Add(this.paraCobrar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1209, 485);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion";
            // 
            // DGVPresupuestos
            // 
            this.DGVPresupuestos.AllowUserToAddRows = false;
            this.DGVPresupuestos.AllowUserToDeleteRows = false;
            this.DGVPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPresupuestos.Location = new System.Drawing.Point(29, 77);
            this.DGVPresupuestos.Name = "DGVPresupuestos";
            this.DGVPresupuestos.ReadOnly = true;
            this.DGVPresupuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPresupuestos.Size = new System.Drawing.Size(561, 305);
            this.DGVPresupuestos.TabIndex = 62;
            this.DGVPresupuestos.SelectionChanged += new System.EventHandler(this.DGVPresupuestos_SelectionChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Total a Cobrar por el Trabajo:";
            // 
            // cobrosEmpleadosExternosDataGridView
            // 
            this.cobrosEmpleadosExternosDataGridView.AllowUserToAddRows = false;
            this.cobrosEmpleadosExternosDataGridView.AllowUserToDeleteRows = false;
            this.cobrosEmpleadosExternosDataGridView.AutoGenerateColumns = false;
            this.cobrosEmpleadosExternosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cobrosEmpleadosExternosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Cobrado,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.cobrosEmpleadosExternosDataGridView.DataSource = this.cobrosEmpleadosExternosBindingSource;
            this.cobrosEmpleadosExternosDataGridView.Location = new System.Drawing.Point(612, 77);
            this.cobrosEmpleadosExternosDataGridView.Name = "cobrosEmpleadosExternosDataGridView";
            this.cobrosEmpleadosExternosDataGridView.ReadOnly = true;
            this.cobrosEmpleadosExternosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cobrosEmpleadosExternosDataGridView.Size = new System.Drawing.Size(561, 305);
            this.cobrosEmpleadosExternosDataGridView.TabIndex = 68;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_CobroEmpExt";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_CobroEmpExt";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 69;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NumTrabajo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Trabajo Nº";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 83;
            // 
            // Cobrado
            // 
            this.Cobrado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cobrado.DataPropertyName = "Cobrado";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Cobrado.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cobrado.HeaderText = "Cobrado";
            this.Cobrado.Name = "Cobrado";
            this.Cobrado.ReadOnly = true;
            this.Cobrado.Width = 72;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 62;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UsuCre";
            this.dataGridViewTextBoxColumn6.HeaderText = "UsuCre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // cobrosEmpleadosExternosBindingSource
            // 
            this.cobrosEmpleadosExternosBindingSource.DataMember = "CobrosEmpleadosExternos";
            this.cobrosEmpleadosExternosBindingSource.DataSource = this.corpusDataSet;
            // 
            // corpusDataSet
            // 
            this.corpusDataSet.DataSetName = "CorpusDataSet";
            this.corpusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(608, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "Cobrado por Trabajo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(25, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "A Cobrar por Trabajo:";
            // 
            // faltaCobrar
            // 
            this.faltaCobrar.BackColor = System.Drawing.Color.White;
            this.faltaCobrar.Enabled = false;
            this.faltaCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faltaCobrar.ForeColor = System.Drawing.Color.Black;
            this.faltaCobrar.Location = new System.Drawing.Point(681, 441);
            this.faltaCobrar.Name = "faltaCobrar";
            this.faltaCobrar.Size = new System.Drawing.Size(203, 23);
            this.faltaCobrar.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(609, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Saldo:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(449, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 17);
            this.checkBox1.TabIndex = 61;
            this.checkBox1.Text = "Filtrar por Estado del Trabajo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // estados
            // 
            this.estados.FormattingEnabled = true;
            this.estados.Items.AddRange(new object[] {
            "A PRESUPUESTAR",
            "PRESUPUESTADO",
            "ACEPTADO",
            "INICIADO",
            "FINALIZADO",
            "CERRADO"});
            this.estados.Location = new System.Drawing.Point(616, 23);
            this.estados.Name = "estados";
            this.estados.Size = new System.Drawing.Size(161, 21);
            this.estados.TabIndex = 60;
            this.estados.SelectedIndexChanged += new System.EventHandler(this.estados_SelectedIndexChanged_1);
            // 
            // yaCobrado
            // 
            this.yaCobrado.BackColor = System.Drawing.Color.White;
            this.yaCobrado.Enabled = false;
            this.yaCobrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yaCobrado.ForeColor = System.Drawing.Color.Black;
            this.yaCobrado.Location = new System.Drawing.Point(681, 399);
            this.yaCobrado.Name = "yaCobrado";
            this.yaCobrado.Size = new System.Drawing.Size(203, 20);
            this.yaCobrado.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Ya Cobrado:";
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.AutoSize = true;
            this.nombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEmpleado.Location = new System.Drawing.Point(139, 26);
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.Size = new System.Drawing.Size(103, 13);
            this.nombreEmpleado.TabIndex = 53;
            this.nombreEmpleado.Text = "nombreEmpleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Profesional Externo:";
            // 
            // numeroTrabajo
            // 
            this.numeroTrabajo.Location = new System.Drawing.Point(377, 144);
            this.numeroTrabajo.Name = "numeroTrabajo";
            this.numeroTrabajo.Size = new System.Drawing.Size(100, 20);
            this.numeroTrabajo.TabIndex = 63;
            // 
            // paraCobrar
            // 
            this.paraCobrar.BackColor = System.Drawing.Color.White;
            this.paraCobrar.Enabled = false;
            this.paraCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paraCobrar.ForeColor = System.Drawing.Color.Black;
            this.paraCobrar.Location = new System.Drawing.Point(387, 399);
            this.paraCobrar.Name = "paraCobrar";
            this.paraCobrar.Size = new System.Drawing.Size(203, 20);
            this.paraCobrar.TabIndex = 66;
            // 
            // cobrosEmpleadosExternosTableAdapter
            // 
            this.cobrosEmpleadosExternosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APagarOtrosTableAdapter = null;
            this.tableAdapterManager.APagarTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BalanceTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.CobrosEmpleadosExternosTableAdapter = this.cobrosEmpleadosExternosTableAdapter;
            this.tableAdapterManager.CobrosEmpleadosTableAdapter = null;
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
            // DetallesEmpleadosExternos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1238, 509);
            this.Controls.Add(this.groupBox1);
            this.Name = "DetallesEmpleadosExternos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de los Cobros";
            this.Load += new System.EventHandler(this.DetallesEmpleadosExternos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPresupuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosEmpleadosExternosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosEmpleadosExternosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGVPresupuestos;
        private System.Windows.Forms.TextBox faltaCobrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox estados;
        private System.Windows.Forms.TextBox yaCobrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nombreEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeroTrabajo;
        private System.Windows.Forms.TextBox paraCobrar;
        private CorpusDataSet corpusDataSet;
        private System.Windows.Forms.BindingSource cobrosEmpleadosExternosBindingSource;
        private CorpusDataSetTableAdapters.CobrosEmpleadosExternosTableAdapter cobrosEmpleadosExternosTableAdapter;
        private CorpusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cobrosEmpleadosExternosDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cobrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}