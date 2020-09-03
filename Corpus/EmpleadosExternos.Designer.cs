namespace Corpus
{
    partial class EmpleadosExternos
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
            System.Windows.Forms.Label id_EmpleadoExternoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label usuCreLabel;
            System.Windows.Forms.Label fechaCreLabel;
            System.Windows.Forms.Label usuModLabel;
            System.Windows.Forms.Label fechaModLabel;
            System.Windows.Forms.Label telFijoLabel;
            System.Windows.Forms.Label telMovilLabel;
            System.Windows.Forms.Label mailLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombreActualizado = new System.Windows.Forms.TextBox();
            this.InformeTodosLosCobros = new System.Windows.Forms.Button();
            this.InformeACobrarPorTrabajo = new System.Windows.Forms.Button();
            this.aCobrar = new System.Windows.Forms.Button();
            this.detallePagosCobros = new System.Windows.Forms.Button();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.empleadosExternosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corpusDataSet = new Corpus.CorpusDataSet();
            this.telMovilTextBox = new System.Windows.Forms.TextBox();
            this.telFijoTextBox = new System.Windows.Forms.TextBox();
            this.id_EmpleadoExternoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.usuCreTextBox = new System.Windows.Forms.TextBox();
            this.fechaCreDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.usuModTextBox = new System.Windows.Forms.TextBox();
            this.fechaModDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.empleadosExternosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empleadosExternosTableAdapter = new Corpus.CorpusDataSetTableAdapters.EmpleadosExternosTableAdapter();
            this.tableAdapterManager = new Corpus.CorpusDataSetTableAdapters.TableAdapterManager();
            this.presupuestosTableAdapter1 = new Corpus.CorpusDataSetTableAdapters.PresupuestosTableAdapter();
            id_EmpleadoExternoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            usuCreLabel = new System.Windows.Forms.Label();
            fechaCreLabel = new System.Windows.Forms.Label();
            usuModLabel = new System.Windows.Forms.Label();
            fechaModLabel = new System.Windows.Forms.Label();
            telFijoLabel = new System.Windows.Forms.Label();
            telMovilLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosExternosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosExternosDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_EmpleadoExternoLabel
            // 
            id_EmpleadoExternoLabel.AutoSize = true;
            id_EmpleadoExternoLabel.Location = new System.Drawing.Point(24, 56);
            id_EmpleadoExternoLabel.Name = "id_EmpleadoExternoLabel";
            id_EmpleadoExternoLabel.Size = new System.Drawing.Size(113, 13);
            id_EmpleadoExternoLabel.TabIndex = 45;
            id_EmpleadoExternoLabel.Text = "Id Profesional Externo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(24, 85);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 47;
            nombreLabel.Text = "Nombre:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(24, 201);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 49;
            observacionesLabel.Text = "Observaciones:";
            // 
            // usuCreLabel
            // 
            usuCreLabel.AutoSize = true;
            usuCreLabel.Location = new System.Drawing.Point(24, 304);
            usuCreLabel.Name = "usuCreLabel";
            usuCreLabel.Size = new System.Drawing.Size(62, 13);
            usuCreLabel.TabIndex = 51;
            usuCreLabel.Text = "Creado por:";
            // 
            // fechaCreLabel
            // 
            fechaCreLabel.AutoSize = true;
            fechaCreLabel.Location = new System.Drawing.Point(24, 334);
            fechaCreLabel.Name = "fechaCreLabel";
            fechaCreLabel.Size = new System.Drawing.Size(100, 13);
            fechaCreLabel.TabIndex = 53;
            fechaCreLabel.Text = "Fecha de Creacion:";
            // 
            // usuModLabel
            // 
            usuModLabel.AutoSize = true;
            usuModLabel.Location = new System.Drawing.Point(24, 362);
            usuModLabel.Name = "usuModLabel";
            usuModLabel.Size = new System.Drawing.Size(80, 13);
            usuModLabel.TabIndex = 55;
            usuModLabel.Text = "Modificado por:";
            // 
            // fechaModLabel
            // 
            fechaModLabel.AutoSize = true;
            fechaModLabel.Location = new System.Drawing.Point(24, 392);
            fechaModLabel.Name = "fechaModLabel";
            fechaModLabel.Size = new System.Drawing.Size(118, 13);
            fechaModLabel.TabIndex = 57;
            fechaModLabel.Text = "Fecha de Modificacion:";
            // 
            // telFijoLabel
            // 
            telFijoLabel.AutoSize = true;
            telFijoLabel.Location = new System.Drawing.Point(24, 114);
            telFijoLabel.Name = "telFijoLabel";
            telFijoLabel.Size = new System.Drawing.Size(71, 13);
            telFijoLabel.TabIndex = 58;
            telFijoLabel.Text = "Telefono Fijo:";
            // 
            // telMovilLabel
            // 
            telMovilLabel.AutoSize = true;
            telMovilLabel.Location = new System.Drawing.Point(24, 143);
            telMovilLabel.Name = "telMovilLabel";
            telMovilLabel.Size = new System.Drawing.Size(80, 13);
            telMovilLabel.TabIndex = 59;
            telMovilLabel.Text = "Telefono Movil:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(24, 172);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(29, 13);
            mailLabel.TabIndex = 60;
            mailLabel.Text = "Mail:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nombreActualizado);
            this.groupBox1.Controls.Add(this.InformeTodosLosCobros);
            this.groupBox1.Controls.Add(this.InformeACobrarPorTrabajo);
            this.groupBox1.Controls.Add(this.aCobrar);
            this.groupBox1.Controls.Add(this.detallePagosCobros);
            this.groupBox1.Controls.Add(mailLabel);
            this.groupBox1.Controls.Add(this.mailTextBox);
            this.groupBox1.Controls.Add(telMovilLabel);
            this.groupBox1.Controls.Add(this.telMovilTextBox);
            this.groupBox1.Controls.Add(telFijoLabel);
            this.groupBox1.Controls.Add(this.telFijoTextBox);
            this.groupBox1.Controls.Add(id_EmpleadoExternoLabel);
            this.groupBox1.Controls.Add(this.id_EmpleadoExternoTextBox);
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
            this.groupBox1.Controls.Add(this.empleadosExternosDataGridView);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 518);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de los Profesionales Externos";
            // 
            // nombreActualizado
            // 
            this.nombreActualizado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreActualizado.Location = new System.Drawing.Point(172, 82);
            this.nombreActualizado.Name = "nombreActualizado";
            this.nombreActualizado.Size = new System.Drawing.Size(201, 20);
            this.nombreActualizado.TabIndex = 67;
            // 
            // InformeTodosLosCobros
            // 
            this.InformeTodosLosCobros.BackColor = System.Drawing.Color.White;
            this.InformeTodosLosCobros.Image = global::Corpus.Properties.Resources.INFORMACION;
            this.InformeTodosLosCobros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InformeTodosLosCobros.Location = new System.Drawing.Point(726, 27);
            this.InformeTodosLosCobros.Name = "InformeTodosLosCobros";
            this.InformeTodosLosCobros.Size = new System.Drawing.Size(75, 72);
            this.InformeTodosLosCobros.TabIndex = 66;
            this.InformeTodosLosCobros.Text = "Todos los Cobros";
            this.InformeTodosLosCobros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InformeTodosLosCobros.UseVisualStyleBackColor = false;
            this.InformeTodosLosCobros.Click += new System.EventHandler(this.InformeTodosLosCobros_Click);
            // 
            // InformeACobrarPorTrabajo
            // 
            this.InformeACobrarPorTrabajo.BackColor = System.Drawing.Color.White;
            this.InformeACobrarPorTrabajo.Image = global::Corpus.Properties.Resources.INFORMACION;
            this.InformeACobrarPorTrabajo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InformeACobrarPorTrabajo.Location = new System.Drawing.Point(609, 27);
            this.InformeACobrarPorTrabajo.Name = "InformeACobrarPorTrabajo";
            this.InformeACobrarPorTrabajo.Size = new System.Drawing.Size(111, 72);
            this.InformeACobrarPorTrabajo.TabIndex = 65;
            this.InformeACobrarPorTrabajo.Text = "Totales, Cobrados y Saldos";
            this.InformeACobrarPorTrabajo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InformeACobrarPorTrabajo.UseVisualStyleBackColor = false;
            this.InformeACobrarPorTrabajo.Click += new System.EventHandler(this.InformeACobrarPorTrabajo_Click);
            // 
            // aCobrar
            // 
            this.aCobrar.BackColor = System.Drawing.Color.PaleGreen;
            this.aCobrar.Image = global::Corpus.Properties.Resources.Letra_D;
            this.aCobrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aCobrar.Location = new System.Drawing.Point(609, 143);
            this.aCobrar.Name = "aCobrar";
            this.aCobrar.Size = new System.Drawing.Size(192, 69);
            this.aCobrar.TabIndex = 64;
            this.aCobrar.Text = "Detalles de TODOS los Trabajos";
            this.aCobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aCobrar.UseVisualStyleBackColor = false;
            this.aCobrar.Click += new System.EventHandler(this.aCobrar_Click);
            // 
            // detallePagosCobros
            // 
            this.detallePagosCobros.BackColor = System.Drawing.Color.DarkSalmon;
            this.detallePagosCobros.Image = global::Corpus.Properties.Resources.Letra_D;
            this.detallePagosCobros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.detallePagosCobros.Location = new System.Drawing.Point(416, 143);
            this.detallePagosCobros.Name = "detallePagosCobros";
            this.detallePagosCobros.Size = new System.Drawing.Size(136, 70);
            this.detallePagosCobros.TabIndex = 63;
            this.detallePagosCobros.Text = "Detalles por Trabajo";
            this.detallePagosCobros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.detallePagosCobros.UseVisualStyleBackColor = false;
            this.detallePagosCobros.Click += new System.EventHandler(this.detallePagosCobros_Click_1);
            // 
            // mailTextBox
            // 
            this.mailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosExternosBindingSource, "Mail", true));
            this.mailTextBox.Location = new System.Drawing.Point(172, 169);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(201, 20);
            this.mailTextBox.TabIndex = 61;
            this.mailTextBox.Leave += new System.EventHandler(this.mailTextBox_Leave);
            // 
            // empleadosExternosBindingSource
            // 
            this.empleadosExternosBindingSource.DataMember = "EmpleadosExternos";
            this.empleadosExternosBindingSource.DataSource = this.corpusDataSet;
            // 
            // corpusDataSet
            // 
            this.corpusDataSet.DataSetName = "CorpusDataSet";
            this.corpusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telMovilTextBox
            // 
            this.telMovilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosExternosBindingSource, "TelMovil", true));
            this.telMovilTextBox.Location = new System.Drawing.Point(172, 140);
            this.telMovilTextBox.Name = "telMovilTextBox";
            this.telMovilTextBox.Size = new System.Drawing.Size(201, 20);
            this.telMovilTextBox.TabIndex = 60;
            // 
            // telFijoTextBox
            // 
            this.telFijoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosExternosBindingSource, "TelFijo", true));
            this.telFijoTextBox.Location = new System.Drawing.Point(172, 111);
            this.telFijoTextBox.Name = "telFijoTextBox";
            this.telFijoTextBox.Size = new System.Drawing.Size(201, 20);
            this.telFijoTextBox.TabIndex = 59;
            // 
            // id_EmpleadoExternoTextBox
            // 
            this.id_EmpleadoExternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosExternosBindingSource, "Id_EmpleadoExterno", true));
            this.id_EmpleadoExternoTextBox.Enabled = false;
            this.id_EmpleadoExternoTextBox.Location = new System.Drawing.Point(172, 53);
            this.id_EmpleadoExternoTextBox.Name = "id_EmpleadoExternoTextBox";
            this.id_EmpleadoExternoTextBox.Size = new System.Drawing.Size(201, 20);
            this.id_EmpleadoExternoTextBox.TabIndex = 46;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosExternosBindingSource, "Nombre", true));
            this.nombreTextBox.Enabled = false;
            this.nombreTextBox.Location = new System.Drawing.Point(172, 82);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(201, 20);
            this.nombreTextBox.TabIndex = 48;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosExternosBindingSource, "Observaciones", true));
            this.observacionesTextBox.Location = new System.Drawing.Point(172, 198);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacionesTextBox.Size = new System.Drawing.Size(201, 97);
            this.observacionesTextBox.TabIndex = 50;
            // 
            // usuCreTextBox
            // 
            this.usuCreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosExternosBindingSource, "UsuCre", true));
            this.usuCreTextBox.Enabled = false;
            this.usuCreTextBox.Location = new System.Drawing.Point(172, 301);
            this.usuCreTextBox.Name = "usuCreTextBox";
            this.usuCreTextBox.Size = new System.Drawing.Size(201, 20);
            this.usuCreTextBox.TabIndex = 52;
            // 
            // fechaCreDateTimePicker
            // 
            this.fechaCreDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.empleadosExternosBindingSource, "FechaCre", true));
            this.fechaCreDateTimePicker.Enabled = false;
            this.fechaCreDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCreDateTimePicker.Location = new System.Drawing.Point(172, 330);
            this.fechaCreDateTimePicker.Name = "fechaCreDateTimePicker";
            this.fechaCreDateTimePicker.Size = new System.Drawing.Size(201, 20);
            this.fechaCreDateTimePicker.TabIndex = 54;
            // 
            // usuModTextBox
            // 
            this.usuModTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosExternosBindingSource, "UsuMod", true));
            this.usuModTextBox.Enabled = false;
            this.usuModTextBox.Location = new System.Drawing.Point(172, 359);
            this.usuModTextBox.Name = "usuModTextBox";
            this.usuModTextBox.Size = new System.Drawing.Size(201, 20);
            this.usuModTextBox.TabIndex = 56;
            // 
            // fechaModDateTimePicker
            // 
            this.fechaModDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.empleadosExternosBindingSource, "FechaMod", true));
            this.fechaModDateTimePicker.Enabled = false;
            this.fechaModDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaModDateTimePicker.Location = new System.Drawing.Point(172, 388);
            this.fechaModDateTimePicker.Name = "fechaModDateTimePicker";
            this.fechaModDateTimePicker.Size = new System.Drawing.Size(201, 20);
            this.fechaModDateTimePicker.TabIndex = 58;
            // 
            // empleadosExternosDataGridView
            // 
            this.empleadosExternosDataGridView.AllowUserToAddRows = false;
            this.empleadosExternosDataGridView.AllowUserToDeleteRows = false;
            this.empleadosExternosDataGridView.AutoGenerateColumns = false;
            this.empleadosExternosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadosExternosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.empleadosExternosDataGridView.DataSource = this.empleadosExternosBindingSource;
            this.empleadosExternosDataGridView.Location = new System.Drawing.Point(416, 237);
            this.empleadosExternosDataGridView.Name = "empleadosExternosDataGridView";
            this.empleadosExternosDataGridView.ReadOnly = true;
            this.empleadosExternosDataGridView.Size = new System.Drawing.Size(385, 250);
            this.empleadosExternosDataGridView.TabIndex = 45;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_EmpleadoExterno";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_EmpleadoExterno";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(379, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 31);
            this.label5.TabIndex = 45;
            this.label5.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(416, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 100);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por Nombre";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(27, 42);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = global::Corpus.Properties.Resources.Eliminar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(270, 433);
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
            this.button2.Location = new System.Drawing.Point(161, 433);
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
            this.button1.Location = new System.Drawing.Point(67, 433);
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
            this.user.Location = new System.Drawing.Point(109, 27);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(148, 13);
            this.user.TabIndex = 39;
            this.user.Text = "Nombre y Apellido del Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Usuario Activo:";
            // 
            // empleadosExternosTableAdapter
            // 
            this.empleadosExternosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.EmpleadosExternosTableAdapter = this.empleadosExternosTableAdapter;
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
            // presupuestosTableAdapter1
            // 
            this.presupuestosTableAdapter1.ClearBeforeFill = true;
            // 
            // EmpleadosExternos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(911, 590);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmpleadosExternos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesionales Externos";
            this.Load += new System.EventHandler(this.EmpleadosExternos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosExternosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosExternosDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label4;
        private CorpusDataSet corpusDataSet;
        private System.Windows.Forms.BindingSource empleadosExternosBindingSource;
        private CorpusDataSetTableAdapters.EmpleadosExternosTableAdapter empleadosExternosTableAdapter;
        private CorpusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView empleadosExternosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox id_EmpleadoExternoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.TextBox usuCreTextBox;
        private System.Windows.Forms.DateTimePicker fechaCreDateTimePicker;
        private System.Windows.Forms.TextBox usuModTextBox;
        private System.Windows.Forms.DateTimePicker fechaModDateTimePicker;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox telMovilTextBox;
        private System.Windows.Forms.TextBox telFijoTextBox;
        private System.Windows.Forms.Button aCobrar;
        private System.Windows.Forms.Button detallePagosCobros;
        private System.Windows.Forms.Button InformeTodosLosCobros;
        private System.Windows.Forms.Button InformeACobrarPorTrabajo;
        private System.Windows.Forms.TextBox nombreActualizado;
        private CorpusDataSetTableAdapters.PresupuestosTableAdapter presupuestosTableAdapter1;
    }
}