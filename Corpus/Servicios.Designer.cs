namespace Corpus
{
    partial class Servicios
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
            System.Windows.Forms.Label id_ImpLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label usuCreLabel;
            System.Windows.Forms.Label fechaCreLabel;
            System.Windows.Forms.Label usuModLabel;
            System.Windows.Forms.Label fechaModLabel;
            this.impuestosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corpusDataSet = new Corpus.CorpusDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombreActualizado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_ImpTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.usuCreTextBox = new System.Windows.Forms.TextBox();
            this.fechaCreDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.usuModTextBox = new System.Windows.Forms.TextBox();
            this.fechaModDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.impuestosTableAdapter = new Corpus.CorpusDataSetTableAdapters.ImpuestosTableAdapter();
            this.tableAdapterManager = new Corpus.CorpusDataSetTableAdapters.TableAdapterManager();
            this.presupuestosTableAdapter1 = new Corpus.CorpusDataSetTableAdapters.PresupuestosTableAdapter();
            id_ImpLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            usuCreLabel = new System.Windows.Forms.Label();
            fechaCreLabel = new System.Windows.Forms.Label();
            usuModLabel = new System.Windows.Forms.Label();
            fechaModLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.impuestosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_ImpLabel
            // 
            id_ImpLabel.AutoSize = true;
            id_ImpLabel.Location = new System.Drawing.Point(32, 83);
            id_ImpLabel.Name = "id_ImpLabel";
            id_ImpLabel.Size = new System.Drawing.Size(88, 17);
            id_ImpLabel.TabIndex = 1;
            id_ImpLabel.Text = "Nº Impuesto:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(32, 109);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(32, 199);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(107, 17);
            observacionesLabel.TabIndex = 5;
            observacionesLabel.Text = "Observaciones:";
            // 
            // usuCreLabel
            // 
            usuCreLabel.AutoSize = true;
            usuCreLabel.Location = new System.Drawing.Point(32, 282);
            usuCreLabel.Name = "usuCreLabel";
            usuCreLabel.Size = new System.Drawing.Size(83, 17);
            usuCreLabel.TabIndex = 7;
            usuCreLabel.Text = "Creado por:";
            // 
            // fechaCreLabel
            // 
            fechaCreLabel.AutoSize = true;
            fechaCreLabel.Location = new System.Drawing.Point(32, 309);
            fechaCreLabel.Name = "fechaCreLabel";
            fechaCreLabel.Size = new System.Drawing.Size(131, 17);
            fechaCreLabel.TabIndex = 9;
            fechaCreLabel.Text = "Fecha de Creacion:";
            // 
            // usuModLabel
            // 
            usuModLabel.AutoSize = true;
            usuModLabel.Location = new System.Drawing.Point(32, 334);
            usuModLabel.Name = "usuModLabel";
            usuModLabel.Size = new System.Drawing.Size(105, 17);
            usuModLabel.TabIndex = 11;
            usuModLabel.Text = "Modificado por:";
            // 
            // fechaModLabel
            // 
            fechaModLabel.AutoSize = true;
            fechaModLabel.Location = new System.Drawing.Point(32, 361);
            fechaModLabel.Name = "fechaModLabel";
            fechaModLabel.Size = new System.Drawing.Size(153, 17);
            fechaModLabel.TabIndex = 13;
            fechaModLabel.Text = "Fecha de Modificacion:";
            // 
            // impuestosDataGridView
            // 
            this.impuestosDataGridView.AllowUserToAddRows = false;
            this.impuestosDataGridView.AllowUserToDeleteRows = false;
            this.impuestosDataGridView.AutoGenerateColumns = false;
            this.impuestosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.impuestosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.impuestosDataGridView.DataSource = this.impuestosBindingSource;
            this.impuestosDataGridView.Location = new System.Drawing.Point(449, 137);
            this.impuestosDataGridView.Name = "impuestosDataGridView";
            this.impuestosDataGridView.ReadOnly = true;
            this.impuestosDataGridView.Size = new System.Drawing.Size(287, 177);
            this.impuestosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Imp";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Imp";
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
            this.dataGridViewTextBoxColumn2.Width = 83;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Observaciones";
            this.dataGridViewTextBoxColumn3.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UsuCre";
            this.dataGridViewTextBoxColumn4.HeaderText = "UsuCre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaCre";
            this.dataGridViewTextBoxColumn5.HeaderText = "FechaCre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UsuMod";
            this.dataGridViewTextBoxColumn6.HeaderText = "UsuMod";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FechaMod";
            this.dataGridViewTextBoxColumn7.HeaderText = "FechaMod";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // impuestosBindingSource
            // 
            this.impuestosBindingSource.DataMember = "Impuestos";
            this.impuestosBindingSource.DataSource = this.corpusDataSet;
            // 
            // corpusDataSet
            // 
            this.corpusDataSet.DataSetName = "CorpusDataSet";
            this.corpusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nombreActualizado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.monto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(id_ImpLabel);
            this.groupBox1.Controls.Add(this.id_ImpTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(observacionesLabel);
            this.groupBox1.Controls.Add(this.observacionesTextBox);
            this.groupBox1.Controls.Add(usuCreLabel);
            this.groupBox1.Controls.Add(this.usuCreTextBox);
            this.groupBox1.Controls.Add(fechaCreLabel);
            this.groupBox1.Controls.Add(this.fechaCreDateTimePicker);
            this.groupBox1.Controls.Add(usuModLabel);
            this.groupBox1.Controls.Add(this.usuModTextBox);
            this.groupBox1.Controls.Add(fechaModLabel);
            this.groupBox1.Controls.Add(this.fechaModDateTimePicker);
            this.groupBox1.Controls.Add(this.impuestosDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 482);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de los Servicios";
            // 
            // nombreActualizado
            // 
            this.nombreActualizado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreActualizado.Location = new System.Drawing.Point(191, 106);
            this.nombreActualizado.Name = "nombreActualizado";
            this.nombreActualizado.Size = new System.Drawing.Size(200, 23);
            this.nombreActualizado.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Image = global::Corpus.Properties.Resources.Dinero;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(520, 356);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 81);
            this.button7.TabIndex = 59;
            this.button7.Text = "PAGAR el Servicio";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Monto:";
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(191, 134);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(200, 23);
            this.monto.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(397, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 31);
            this.label5.TabIndex = 45;
            this.label5.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(449, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 90);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por Nombre";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(34, 41);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = global::Corpus.Properties.Resources.Eliminar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(277, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 43;
            this.button3.Text = "Eliminar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::Corpus.Properties.Resources.Actualizar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(168, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 55);
            this.button2.TabIndex = 42;
            this.button2.Text = "Actualizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::Corpus.Properties.Resources.Nuevo;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(74, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 41;
            this.button1.Text = "Nuevo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(141, 36);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(199, 17);
            this.user.TabIndex = 39;
            this.user.Text = "Nombre y Apellido del Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Usuario Activo:";
            // 
            // id_ImpTextBox
            // 
            this.id_ImpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.impuestosBindingSource, "Id_Imp", true));
            this.id_ImpTextBox.Enabled = false;
            this.id_ImpTextBox.Location = new System.Drawing.Point(191, 79);
            this.id_ImpTextBox.Name = "id_ImpTextBox";
            this.id_ImpTextBox.Size = new System.Drawing.Size(200, 23);
            this.id_ImpTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.impuestosBindingSource, "Nombre", true));
            this.nombreTextBox.Enabled = false;
            this.nombreTextBox.Location = new System.Drawing.Point(191, 106);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 23);
            this.nombreTextBox.TabIndex = 4;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.impuestosBindingSource, "Observaciones", true));
            this.observacionesTextBox.Location = new System.Drawing.Point(191, 195);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacionesTextBox.Size = new System.Drawing.Size(200, 77);
            this.observacionesTextBox.TabIndex = 6;
            // 
            // usuCreTextBox
            // 
            this.usuCreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.impuestosBindingSource, "UsuCre", true));
            this.usuCreTextBox.Enabled = false;
            this.usuCreTextBox.Location = new System.Drawing.Point(191, 278);
            this.usuCreTextBox.Name = "usuCreTextBox";
            this.usuCreTextBox.Size = new System.Drawing.Size(200, 23);
            this.usuCreTextBox.TabIndex = 8;
            // 
            // fechaCreDateTimePicker
            // 
            this.fechaCreDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.impuestosBindingSource, "FechaCre", true));
            this.fechaCreDateTimePicker.Enabled = false;
            this.fechaCreDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCreDateTimePicker.Location = new System.Drawing.Point(191, 304);
            this.fechaCreDateTimePicker.Name = "fechaCreDateTimePicker";
            this.fechaCreDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.fechaCreDateTimePicker.TabIndex = 10;
            // 
            // usuModTextBox
            // 
            this.usuModTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.impuestosBindingSource, "UsuMod", true));
            this.usuModTextBox.Enabled = false;
            this.usuModTextBox.Location = new System.Drawing.Point(191, 330);
            this.usuModTextBox.Name = "usuModTextBox";
            this.usuModTextBox.Size = new System.Drawing.Size(200, 23);
            this.usuModTextBox.TabIndex = 12;
            // 
            // fechaModDateTimePicker
            // 
            this.fechaModDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.impuestosBindingSource, "FechaMod", true));
            this.fechaModDateTimePicker.Enabled = false;
            this.fechaModDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaModDateTimePicker.Location = new System.Drawing.Point(191, 356);
            this.fechaModDateTimePicker.Name = "fechaModDateTimePicker";
            this.fechaModDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.fechaModDateTimePicker.TabIndex = 14;
            // 
            // impuestosTableAdapter
            // 
            this.impuestosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APagarTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BalanceTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.CobrosEmpleadosExternosTableAdapter = null;
            this.tableAdapterManager.CobrosEmpleadosTableAdapter = null;
            this.tableAdapterManager.CobrosTableAdapter = null;
            this.tableAdapterManager.EmpleadosExternosTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.FijosTableAdapter = null;
            this.tableAdapterManager.GastosTableAdapter = null;
            this.tableAdapterManager.ImpuestosTableAdapter = this.impuestosTableAdapter;
            this.tableAdapterManager.InformeCorpusTableAdapter = null;
            this.tableAdapterManager.OtrosTableAdapter = null;
            this.tableAdapterManager.PagosTableAdapter = null;
            this.tableAdapterManager.PresupuestosTableAdapter = null;
            this.tableAdapterManager.TrabajosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Corpus.CorpusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // presupuestosTableAdapter1
            // 
            this.presupuestosTableAdapter1.ClearBeforeFill = true;
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(849, 555);
            this.Controls.Add(this.groupBox1);
            this.Name = "Servicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Impuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.impuestosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CorpusDataSet corpusDataSet;
        private System.Windows.Forms.BindingSource impuestosBindingSource;
        private CorpusDataSetTableAdapters.ImpuestosTableAdapter impuestosTableAdapter;
        private CorpusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView impuestosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox id_ImpTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.TextBox usuCreTextBox;
        private System.Windows.Forms.DateTimePicker fechaCreDateTimePicker;
        private System.Windows.Forms.TextBox usuModTextBox;
        private System.Windows.Forms.DateTimePicker fechaModDateTimePicker;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox nombreActualizado;
        private CorpusDataSetTableAdapters.PresupuestosTableAdapter presupuestosTableAdapter1;
    }
}