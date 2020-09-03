namespace Corpus
{
    partial class Pagos
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
            System.Windows.Forms.Label id_PagoLabel;
            System.Windows.Forms.Label id_CobroLabel;
            System.Windows.Forms.Label numTrabajoLabel;
            System.Windows.Forms.Label referenciaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label montoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label usuCreLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numeroTrabajo = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalApagar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.id_PagoTextBox = new System.Windows.Forms.TextBox();
            this.id_CobroTextBox = new System.Windows.Forms.TextBox();
            this.numTrabajoTextBox = new System.Windows.Forms.TextBox();
            this.referenciaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.usuCreTextBox = new System.Windows.Forms.TextBox();
            this.pagosDataGridView = new System.Windows.Forms.DataGridView();
            this.user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTotalACobrar = new System.Windows.Forms.Label();
            this.pagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corpusDataSet = new Corpus.CorpusDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagosTableAdapter = new Corpus.CorpusDataSetTableAdapters.PagosTableAdapter();
            this.tableAdapterManager = new Corpus.CorpusDataSetTableAdapters.TableAdapterManager();
            this.impuestosTableAdapter1 = new Corpus.CorpusDataSetTableAdapters.ImpuestosTableAdapter();
            this.gastosTableAdapter1 = new Corpus.CorpusDataSetTableAdapters.GastosTableAdapter();
            this.otrosTableAdapter1 = new Corpus.CorpusDataSetTableAdapters.OtrosTableAdapter();
            id_PagoLabel = new System.Windows.Forms.Label();
            id_CobroLabel = new System.Windows.Forms.Label();
            numTrabajoLabel = new System.Windows.Forms.Label();
            referenciaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            usuCreLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // id_PagoLabel
            // 
            id_PagoLabel.AutoSize = true;
            id_PagoLabel.Location = new System.Drawing.Point(23, 65);
            id_PagoLabel.Name = "id_PagoLabel";
            id_PagoLabel.Size = new System.Drawing.Size(47, 13);
            id_PagoLabel.TabIndex = 43;
            id_PagoLabel.Text = "Id Pago:";
            // 
            // id_CobroLabel
            // 
            id_CobroLabel.AutoSize = true;
            id_CobroLabel.Location = new System.Drawing.Point(23, 91);
            id_CobroLabel.Name = "id_CobroLabel";
            id_CobroLabel.Size = new System.Drawing.Size(50, 13);
            id_CobroLabel.TabIndex = 45;
            id_CobroLabel.Text = "Id Cobro:";
            // 
            // numTrabajoLabel
            // 
            numTrabajoLabel.AutoSize = true;
            numTrabajoLabel.Location = new System.Drawing.Point(23, 117);
            numTrabajoLabel.Name = "numTrabajoLabel";
            numTrabajoLabel.Size = new System.Drawing.Size(101, 13);
            numTrabajoLabel.TabIndex = 47;
            numTrabajoLabel.Text = "Numero de Trabajo:";
            // 
            // referenciaLabel
            // 
            referenciaLabel.AutoSize = true;
            referenciaLabel.Location = new System.Drawing.Point(23, 143);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(62, 13);
            referenciaLabel.TabIndex = 49;
            referenciaLabel.Text = "Referencia:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(23, 169);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 51;
            nombreLabel.Text = "Nombre:";
            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Location = new System.Drawing.Point(23, 195);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(40, 13);
            montoLabel.TabIndex = 53;
            montoLabel.Text = "Monto:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(23, 222);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 55;
            fechaLabel.Text = "Fecha:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(23, 273);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 57;
            observacionesLabel.Text = "Observaciones:";
            // 
            // usuCreLabel
            // 
            usuCreLabel.AutoSize = true;
            usuCreLabel.Location = new System.Drawing.Point(23, 376);
            usuCreLabel.Name = "usuCreLabel";
            usuCreLabel.Size = new System.Drawing.Size(75, 13);
            usuCreLabel.TabIndex = 59;
            usuCreLabel.Text = "Realizado por:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(23, 245);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(123, 13);
            label3.TabIndex = 70;
            label3.Text = "Precio Total del Trabajo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalACobrar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.totalApagar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.totalTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DGV);
            this.groupBox1.Controls.Add(id_PagoLabel);
            this.groupBox1.Controls.Add(this.id_PagoTextBox);
            this.groupBox1.Controls.Add(id_CobroLabel);
            this.groupBox1.Controls.Add(this.id_CobroTextBox);
            this.groupBox1.Controls.Add(numTrabajoLabel);
            this.groupBox1.Controls.Add(this.numTrabajoTextBox);
            this.groupBox1.Controls.Add(referenciaLabel);
            this.groupBox1.Controls.Add(this.referenciaTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(montoLabel);
            this.groupBox1.Controls.Add(this.montoTextBox);
            this.groupBox1.Controls.Add(fechaLabel);
            this.groupBox1.Controls.Add(this.fechaDateTimePicker);
            this.groupBox1.Controls.Add(observacionesLabel);
            this.groupBox1.Controls.Add(this.observacionesTextBox);
            this.groupBox1.Controls.Add(usuCreLabel);
            this.groupBox1.Controls.Add(this.usuCreTextBox);
            this.groupBox1.Controls.Add(this.pagosDataGridView);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 551);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de los Pagos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::Corpus.Properties.Resources.INFORMACION;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(943, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 66);
            this.button1.TabIndex = 74;
            this.button1.Text = "Informe";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numeroTrabajo);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(26, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 129);
            this.groupBox3.TabIndex = 73;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // numeroTrabajo
            // 
            this.numeroTrabajo.Location = new System.Drawing.Point(30, 42);
            this.numeroTrabajo.Name = "numeroTrabajo";
            this.numeroTrabajo.Size = new System.Drawing.Size(100, 20);
            this.numeroTrabajo.TabIndex = 32;
            this.numeroTrabajo.TextChanged += new System.EventHandler(this.numeroTrabajo_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.Red;
            this.checkBox2.Location = new System.Drawing.Point(30, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 17);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "Trabajo Nº";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(180, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Fechas";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(180, 94);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker2.TabIndex = 29;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(177, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(177, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "desde";
            // 
            // totalApagar
            // 
            this.totalApagar.Enabled = false;
            this.totalApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalApagar.Location = new System.Drawing.Point(680, 468);
            this.totalApagar.Name = "totalApagar";
            this.totalApagar.Size = new System.Drawing.Size(190, 23);
            this.totalApagar.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(569, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Total Pagado";
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagosBindingSource, "Total", true));
            this.totalTextBox.Enabled = false;
            this.totalTextBox.Location = new System.Drawing.Point(147, 242);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalTextBox.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(378, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Detalle del Pago de un Cobro por Trabajo";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(381, 265);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(637, 178);
            this.DGV.TabIndex = 67;
            // 
            // id_PagoTextBox
            // 
            this.id_PagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagosBindingSource, "Id_Pago", true));
            this.id_PagoTextBox.Enabled = false;
            this.id_PagoTextBox.Location = new System.Drawing.Point(147, 60);
            this.id_PagoTextBox.Name = "id_PagoTextBox";
            this.id_PagoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_PagoTextBox.TabIndex = 44;
            // 
            // id_CobroTextBox
            // 
            this.id_CobroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagosBindingSource, "Id_Cobro", true));
            this.id_CobroTextBox.Enabled = false;
            this.id_CobroTextBox.Location = new System.Drawing.Point(147, 86);
            this.id_CobroTextBox.Name = "id_CobroTextBox";
            this.id_CobroTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_CobroTextBox.TabIndex = 46;
            // 
            // numTrabajoTextBox
            // 
            this.numTrabajoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagosBindingSource, "NumTrabajo", true));
            this.numTrabajoTextBox.Enabled = false;
            this.numTrabajoTextBox.Location = new System.Drawing.Point(147, 112);
            this.numTrabajoTextBox.Name = "numTrabajoTextBox";
            this.numTrabajoTextBox.Size = new System.Drawing.Size(200, 20);
            this.numTrabajoTextBox.TabIndex = 48;
            // 
            // referenciaTextBox
            // 
            this.referenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagosBindingSource, "Referencia", true));
            this.referenciaTextBox.Enabled = false;
            this.referenciaTextBox.Location = new System.Drawing.Point(147, 138);
            this.referenciaTextBox.Name = "referenciaTextBox";
            this.referenciaTextBox.Size = new System.Drawing.Size(200, 20);
            this.referenciaTextBox.TabIndex = 50;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagosBindingSource, "Nombre", true));
            this.nombreTextBox.Enabled = false;
            this.nombreTextBox.Location = new System.Drawing.Point(147, 164);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 52;
            // 
            // montoTextBox
            // 
            this.montoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagosBindingSource, "Monto", true));
            this.montoTextBox.Enabled = false;
            this.montoTextBox.Location = new System.Drawing.Point(147, 190);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(200, 20);
            this.montoTextBox.TabIndex = 54;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pagosBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Enabled = false;
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(147, 216);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 56;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.BackColor = System.Drawing.Color.White;
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagosBindingSource, "Observaciones", true));
            this.observacionesTextBox.Location = new System.Drawing.Point(147, 268);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ReadOnly = true;
            this.observacionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacionesTextBox.Size = new System.Drawing.Size(200, 97);
            this.observacionesTextBox.TabIndex = 58;
            // 
            // usuCreTextBox
            // 
            this.usuCreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagosBindingSource, "UsuCre", true));
            this.usuCreTextBox.Enabled = false;
            this.usuCreTextBox.Location = new System.Drawing.Point(147, 371);
            this.usuCreTextBox.Name = "usuCreTextBox";
            this.usuCreTextBox.Size = new System.Drawing.Size(200, 20);
            this.usuCreTextBox.TabIndex = 60;
            // 
            // pagosDataGridView
            // 
            this.pagosDataGridView.AllowUserToAddRows = false;
            this.pagosDataGridView.AllowUserToDeleteRows = false;
            this.pagosDataGridView.AutoGenerateColumns = false;
            this.pagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.pagosDataGridView.DataSource = this.pagosBindingSource;
            this.pagosDataGridView.Location = new System.Drawing.Point(381, 29);
            this.pagosDataGridView.Name = "pagosDataGridView";
            this.pagosDataGridView.ReadOnly = true;
            this.pagosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pagosDataGridView.Size = new System.Drawing.Size(637, 200);
            this.pagosDataGridView.TabIndex = 43;
            this.pagosDataGridView.SelectionChanged += new System.EventHandler(this.pagosDataGridView_SelectionChanged);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(108, 29);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(148, 13);
            this.user.TabIndex = 43;
            this.user.Text = "Nombre y Apellido del Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Usuario Activo:";
            // 
            // lblTotalACobrar
            // 
            this.lblTotalACobrar.AutoSize = true;
            this.lblTotalACobrar.Location = new System.Drawing.Point(296, 16);
            this.lblTotalACobrar.Name = "lblTotalACobrar";
            this.lblTotalACobrar.Size = new System.Drawing.Size(79, 13);
            this.lblTotalACobrar.TabIndex = 3;
            this.lblTotalACobrar.Text = "lblTotalACobrar";
            this.lblTotalACobrar.Visible = false;
            // 
            // pagosBindingSource
            // 
            this.pagosBindingSource.DataMember = "Pagos";
            this.pagosBindingSource.DataSource = this.corpusDataSet;
            // 
            // corpusDataSet
            // 
            this.corpusDataSet.DataSetName = "CorpusDataSet";
            this.corpusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Pago";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Pago";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Cobro";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Cobro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NumTrabajo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Numero de Trabajo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 113;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Referencia";
            this.dataGridViewTextBoxColumn4.HeaderText = "Referencia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 84;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 69;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Monto";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 62;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 62;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Observaciones";
            this.dataGridViewTextBoxColumn8.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "UsuCre";
            this.dataGridViewTextBoxColumn9.HeaderText = "UsuCre";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // pagosTableAdapter
            // 
            this.pagosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APagarOtrosTableAdapter = null;
            this.tableAdapterManager.APagarTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BalanceTableAdapter = null;
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
            this.tableAdapterManager.PagosTableAdapter = this.pagosTableAdapter;
            this.tableAdapterManager.PresupuestosTableAdapter = null;
            this.tableAdapterManager.TrabajosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Corpus.CorpusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // impuestosTableAdapter1
            // 
            this.impuestosTableAdapter1.ClearBeforeFill = true;
            // 
            // gastosTableAdapter1
            // 
            this.gastosTableAdapter1.ClearBeforeFill = true;
            // 
            // otrosTableAdapter1
            // 
            this.otrosTableAdapter1.ClearBeforeFill = true;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1075, 578);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label1;
        private CorpusDataSet corpusDataSet;
        private System.Windows.Forms.BindingSource pagosBindingSource;
        private CorpusDataSetTableAdapters.PagosTableAdapter pagosTableAdapter;
        private CorpusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pagosDataGridView;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TextBox id_PagoTextBox;
        private System.Windows.Forms.TextBox id_CobroTextBox;
        private System.Windows.Forms.TextBox numTrabajoTextBox;
        private System.Windows.Forms.TextBox referenciaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.TextBox usuCreTextBox;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox totalApagar;
        private System.Windows.Forms.Label label4;
        private CorpusDataSetTableAdapters.ImpuestosTableAdapter impuestosTableAdapter1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox numeroTrabajo;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private CorpusDataSetTableAdapters.GastosTableAdapter gastosTableAdapter1;
        private CorpusDataSetTableAdapters.OtrosTableAdapter otrosTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotalACobrar;
    }
}