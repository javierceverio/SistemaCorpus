namespace Corpus
{
    partial class Balance
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
            System.Windows.Forms.Label id_BalanceLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label conceptoLabel;
            System.Windows.Forms.Label referenciaLabel;
            System.Windows.Forms.Label montoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label usuCreLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label id_CobroLabel;
            System.Windows.Forms.Label usuModLabel;
            System.Windows.Forms.Label id_CobroOtroLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.id_BalanceTextBox = new System.Windows.Forms.TextBox();
            this.balanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corpusDataSet = new Corpus.CorpusDataSet();
            this.id_CobroOtroTextBox = new System.Windows.Forms.TextBox();
            this.usuCreTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.usuModTextBox = new System.Windows.Forms.TextBox();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.id_CobroTextBox = new System.Windows.Forms.TextBox();
            this.referenciaTextBox = new System.Windows.Forms.TextBox();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.conceptoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.balanceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.balanceTableAdapter = new Corpus.CorpusDataSetTableAdapters.BalanceTableAdapter();
            this.tableAdapterManager = new Corpus.CorpusDataSetTableAdapters.TableAdapterManager();
            id_BalanceLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            conceptoLabel = new System.Windows.Forms.Label();
            referenciaLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            usuCreLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            id_CobroLabel = new System.Windows.Forms.Label();
            usuModLabel = new System.Windows.Forms.Label();
            id_CobroOtroLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_BalanceLabel
            // 
            id_BalanceLabel.AutoSize = true;
            id_BalanceLabel.Location = new System.Drawing.Point(30, 22);
            id_BalanceLabel.Name = "id_BalanceLabel";
            id_BalanceLabel.Size = new System.Drawing.Size(61, 13);
            id_BalanceLabel.TabIndex = 45;
            id_BalanceLabel.Text = "Id Balance:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(30, 48);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 47;
            nombreLabel.Text = "Nombre:";
            // 
            // conceptoLabel
            // 
            conceptoLabel.AutoSize = true;
            conceptoLabel.Location = new System.Drawing.Point(30, 126);
            conceptoLabel.Name = "conceptoLabel";
            conceptoLabel.Size = new System.Drawing.Size(56, 13);
            conceptoLabel.TabIndex = 49;
            conceptoLabel.Text = "Concepto:";
            // 
            // referenciaLabel
            // 
            referenciaLabel.AutoSize = true;
            referenciaLabel.Location = new System.Drawing.Point(30, 152);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(62, 13);
            referenciaLabel.TabIndex = 51;
            referenciaLabel.Text = "Referencia:";
            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Location = new System.Drawing.Point(30, 178);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(40, 13);
            montoLabel.TabIndex = 53;
            montoLabel.Text = "Monto:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(30, 207);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 55;
            fechaLabel.Text = "Fecha:";
            // 
            // usuCreLabel
            // 
            usuCreLabel.AutoSize = true;
            usuCreLabel.Location = new System.Drawing.Point(30, 322);
            usuCreLabel.Name = "usuCreLabel";
            usuCreLabel.Size = new System.Drawing.Size(68, 13);
            usuCreLabel.TabIndex = 57;
            usuCreLabel.Text = "Cargado por:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(30, 230);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 58;
            observacionesLabel.Text = "Observaciones:";
            // 
            // id_CobroLabel
            // 
            id_CobroLabel.AutoSize = true;
            id_CobroLabel.Location = new System.Drawing.Point(30, 74);
            id_CobroLabel.Name = "id_CobroLabel";
            id_CobroLabel.Size = new System.Drawing.Size(50, 13);
            id_CobroLabel.TabIndex = 59;
            id_CobroLabel.Text = "Id Cobro:";
            // 
            // usuModLabel
            // 
            usuModLabel.AutoSize = true;
            usuModLabel.Location = new System.Drawing.Point(30, 348);
            usuModLabel.Name = "usuModLabel";
            usuModLabel.Size = new System.Drawing.Size(80, 13);
            usuModLabel.TabIndex = 60;
            usuModLabel.Text = "Modificado por:";
            // 
            // id_CobroOtroLabel
            // 
            id_CobroOtroLabel.AutoSize = true;
            id_CobroOtroLabel.Location = new System.Drawing.Point(30, 100);
            id_CobroOtroLabel.Name = "id_CobroOtroLabel";
            id_CobroOtroLabel.Size = new System.Drawing.Size(73, 13);
            id_CobroOtroLabel.TabIndex = 66;
            id_CobroOtroLabel.Text = "Id Cobro Otro:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.total);
            this.groupBox1.Controls.Add(this.balanceDataGridView);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 671);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Balance";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::Corpus.Properties.Resources.INFORMACION;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(602, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 66);
            this.button1.TabIndex = 66;
            this.button1.Text = "Informe";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(696, 416);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 179);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.Red;
            this.checkBox2.Location = new System.Drawing.Point(68, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(121, 17);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "Filtrar por Concepto:";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(68, 69);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Filtrar por Fechas:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(68, 144);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker2.TabIndex = 29;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(65, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(65, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "desde";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cobro por Trabajo",
            "Cobro de Otros por Trabajo",
            "Pago de un Cobro de Otro",
            "Pago de un Servicio",
            "Pago de un Gasto",
            "Pago de Otros",
            "Pago de un Impuesto",
            "Pago del Beneficio",
            "Pago de un Cobro",
            "Reintegro de Otros",
            "Reintegro de un Impuesto",
            "Reintegro de un Servicio",
            "Reintegro de un Gasto"});
            this.comboBox1.Location = new System.Drawing.Point(68, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(id_CobroOtroLabel);
            this.groupBox2.Controls.Add(this.id_BalanceTextBox);
            this.groupBox2.Controls.Add(this.id_CobroOtroTextBox);
            this.groupBox2.Controls.Add(this.usuCreTextBox);
            this.groupBox2.Controls.Add(usuCreLabel);
            this.groupBox2.Controls.Add(usuModLabel);
            this.groupBox2.Controls.Add(this.fechaDateTimePicker);
            this.groupBox2.Controls.Add(this.usuModTextBox);
            this.groupBox2.Controls.Add(fechaLabel);
            this.groupBox2.Controls.Add(id_CobroLabel);
            this.groupBox2.Controls.Add(this.montoTextBox);
            this.groupBox2.Controls.Add(this.id_CobroTextBox);
            this.groupBox2.Controls.Add(montoLabel);
            this.groupBox2.Controls.Add(observacionesLabel);
            this.groupBox2.Controls.Add(this.referenciaTextBox);
            this.groupBox2.Controls.Add(this.observacionesTextBox);
            this.groupBox2.Controls.Add(referenciaLabel);
            this.groupBox2.Controls.Add(id_BalanceLabel);
            this.groupBox2.Controls.Add(this.conceptoTextBox);
            this.groupBox2.Controls.Add(conceptoLabel);
            this.groupBox2.Controls.Add(nombreLabel);
            this.groupBox2.Controls.Add(this.nombreTextBox);
            this.groupBox2.Location = new System.Drawing.Point(696, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 382);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del Asiento";
            // 
            // id_BalanceTextBox
            // 
            this.id_BalanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balanceBindingSource, "Id_Balance", true));
            this.id_BalanceTextBox.Enabled = false;
            this.id_BalanceTextBox.Location = new System.Drawing.Point(117, 19);
            this.id_BalanceTextBox.Name = "id_BalanceTextBox";
            this.id_BalanceTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_BalanceTextBox.TabIndex = 46;
            // 
            // balanceBindingSource
            // 
            this.balanceBindingSource.DataMember = "Balance";
            this.balanceBindingSource.DataSource = this.corpusDataSet;
            // 
            // corpusDataSet
            // 
            this.corpusDataSet.DataSetName = "CorpusDataSet";
            this.corpusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_CobroOtroTextBox
            // 
            this.id_CobroOtroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balanceBindingSource, "Id_CobroOtro", true));
            this.id_CobroOtroTextBox.Enabled = false;
            this.id_CobroOtroTextBox.Location = new System.Drawing.Point(117, 97);
            this.id_CobroOtroTextBox.Name = "id_CobroOtroTextBox";
            this.id_CobroOtroTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_CobroOtroTextBox.TabIndex = 67;
            // 
            // usuCreTextBox
            // 
            this.usuCreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balanceBindingSource, "UsuCre", true));
            this.usuCreTextBox.Enabled = false;
            this.usuCreTextBox.Location = new System.Drawing.Point(117, 319);
            this.usuCreTextBox.Name = "usuCreTextBox";
            this.usuCreTextBox.Size = new System.Drawing.Size(200, 20);
            this.usuCreTextBox.TabIndex = 58;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.balanceBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Enabled = false;
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(117, 201);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 56;
            // 
            // usuModTextBox
            // 
            this.usuModTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balanceBindingSource, "UsuMod", true));
            this.usuModTextBox.Enabled = false;
            this.usuModTextBox.Location = new System.Drawing.Point(117, 345);
            this.usuModTextBox.Name = "usuModTextBox";
            this.usuModTextBox.Size = new System.Drawing.Size(200, 20);
            this.usuModTextBox.TabIndex = 61;
            // 
            // montoTextBox
            // 
            this.montoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balanceBindingSource, "Monto", true));
            this.montoTextBox.Enabled = false;
            this.montoTextBox.Location = new System.Drawing.Point(117, 175);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(200, 20);
            this.montoTextBox.TabIndex = 54;
            // 
            // id_CobroTextBox
            // 
            this.id_CobroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balanceBindingSource, "Id_Cobro", true));
            this.id_CobroTextBox.Enabled = false;
            this.id_CobroTextBox.Location = new System.Drawing.Point(117, 71);
            this.id_CobroTextBox.Name = "id_CobroTextBox";
            this.id_CobroTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_CobroTextBox.TabIndex = 60;
            // 
            // referenciaTextBox
            // 
            this.referenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balanceBindingSource, "Referencia", true));
            this.referenciaTextBox.Enabled = false;
            this.referenciaTextBox.Location = new System.Drawing.Point(117, 149);
            this.referenciaTextBox.Name = "referenciaTextBox";
            this.referenciaTextBox.Size = new System.Drawing.Size(200, 20);
            this.referenciaTextBox.TabIndex = 52;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balanceBindingSource, "Observaciones", true));
            this.observacionesTextBox.Location = new System.Drawing.Point(117, 227);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ReadOnly = true;
            this.observacionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacionesTextBox.Size = new System.Drawing.Size(200, 86);
            this.observacionesTextBox.TabIndex = 59;
            // 
            // conceptoTextBox
            // 
            this.conceptoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balanceBindingSource, "Concepto", true));
            this.conceptoTextBox.Enabled = false;
            this.conceptoTextBox.Location = new System.Drawing.Point(117, 123);
            this.conceptoTextBox.Name = "conceptoTextBox";
            this.conceptoTextBox.Size = new System.Drawing.Size(200, 20);
            this.conceptoTextBox.TabIndex = 50;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.balanceBindingSource, "Nombre", true));
            this.nombreTextBox.Enabled = false;
            this.nombreTextBox.Location = new System.Drawing.Point(117, 45);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(694, 619);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 31);
            this.label2.TabIndex = 63;
            this.label2.Text = "Balance:";
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(828, 616);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(213, 38);
            this.total.TabIndex = 62;
            // 
            // balanceDataGridView
            // 
            this.balanceDataGridView.AllowUserToAddRows = false;
            this.balanceDataGridView.AllowUserToDeleteRows = false;
            this.balanceDataGridView.AutoGenerateColumns = false;
            this.balanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Monto,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.balanceDataGridView.DataSource = this.balanceBindingSource;
            this.balanceDataGridView.Location = new System.Drawing.Point(25, 40);
            this.balanceDataGridView.Name = "balanceDataGridView";
            this.balanceDataGridView.ReadOnly = true;
            this.balanceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.balanceDataGridView.Size = new System.Drawing.Size(562, 542);
            this.balanceDataGridView.TabIndex = 45;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Balance";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Balance";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 69;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Concepto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Concepto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 78;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Referencia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Nº de Trabajo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 98;
            // 
            // Monto
            // 
            this.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Monto.DefaultCellStyle = dataGridViewCellStyle4;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 62;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fecha";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 62;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "UsuCre";
            this.dataGridViewTextBoxColumn7.HeaderText = "UsuCre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(107, 18);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(148, 13);
            this.user.TabIndex = 45;
            this.user.Text = "Nombre y Apellido del Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Usuario Activo:";
            // 
            // balanceTableAdapter
            // 
            this.balanceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APagarOtrosTableAdapter = null;
            this.tableAdapterManager.APagarTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BalanceTableAdapter = this.balanceTableAdapter;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.CobrosEmpleadosExternosTableAdapter = null;
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
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1097, 696);
            this.Controls.Add(this.groupBox1);
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label1;
        private CorpusDataSet corpusDataSet;
        private System.Windows.Forms.BindingSource balanceBindingSource;
        private CorpusDataSetTableAdapters.BalanceTableAdapter balanceTableAdapter;
        private CorpusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView balanceDataGridView;
        private System.Windows.Forms.TextBox id_BalanceTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox conceptoTextBox;
        private System.Windows.Forms.TextBox referenciaTextBox;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox usuCreTextBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.TextBox id_CobroTextBox;
        private System.Windows.Forms.TextBox usuModTextBox;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox id_CobroOtroTextBox;
    }
}