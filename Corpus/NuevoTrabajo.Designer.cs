namespace Corpus
{
    partial class NuevoTrabajo
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
            System.Windows.Forms.Label id_ClienteLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fechaFinLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label cantMesesLabel;
            System.Windows.Forms.Label numTrabajoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corpusDataSet = new Corpus.CorpusDataSet();
            this.numTrabajoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.id_ClienteComboBox1 = new System.Windows.Forms.ComboBox();
            this.trabajosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.id_ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fechaFinDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.cantMesesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clientesTableAdapter = new Corpus.CorpusDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new Corpus.CorpusDataSetTableAdapters.TableAdapterManager();
            this.trabajosTableAdapter1 = new Corpus.CorpusDataSetTableAdapters.TrabajosTableAdapter();
            id_ClienteLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            fechaFinLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            cantMesesLabel = new System.Windows.Forms.Label();
            numTrabajoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Location = new System.Drawing.Point(26, 116);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(55, 17);
            id_ClienteLabel.TabIndex = 69;
            id_ClienteLabel.Text = "Cliente:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(26, 144);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 71;
            nombreLabel.Text = "Nombre:";
            // 
            // fechaFinLabel
            // 
            fechaFinLabel.AutoSize = true;
            fechaFinLabel.Location = new System.Drawing.Point(26, 230);
            fechaFinLabel.Name = "fechaFinLabel";
            fechaFinLabel.Size = new System.Drawing.Size(107, 17);
            fechaFinLabel.TabIndex = 77;
            fechaFinLabel.Text = "Fecha de Inicio:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(26, 255);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(107, 17);
            observacionesLabel.TabIndex = 79;
            observacionesLabel.Text = "Observaciones:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(26, 173);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(40, 17);
            tipoLabel.TabIndex = 81;
            tipoLabel.Text = "Tipo:";
            // 
            // cantMesesLabel
            // 
            cantMesesLabel.AutoSize = true;
            cantMesesLabel.Location = new System.Drawing.Point(26, 203);
            cantMesesLabel.Name = "cantMesesLabel";
            cantMesesLabel.Size = new System.Drawing.Size(137, 17);
            cantMesesLabel.TabIndex = 85;
            cantMesesLabel.Text = "Cantidad de  Meses:";
            // 
            // numTrabajoLabel
            // 
            numTrabajoLabel.AutoSize = true;
            numTrabajoLabel.Location = new System.Drawing.Point(26, 87);
            numTrabajoLabel.Name = "numTrabajoLabel";
            numTrabajoLabel.Size = new System.Drawing.Size(135, 17);
            numTrabajoLabel.TabIndex = 90;
            numTrabajoLabel.Text = "Numero de Trabajo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.clientesDataGridView);
            this.groupBox1.Controls.Add(this.numTrabajoTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(numTrabajoLabel);
            this.groupBox1.Controls.Add(this.id_ClienteComboBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(id_ClienteLabel);
            this.groupBox1.Controls.Add(this.id_ClienteComboBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(fechaFinLabel);
            this.groupBox1.Controls.Add(this.fechaFinDateTimePicker);
            this.groupBox1.Controls.Add(observacionesLabel);
            this.groupBox1.Controls.Add(this.observacionesTextBox);
            this.groupBox1.Controls.Add(tipoLabel);
            this.groupBox1.Controls.Add(this.tipoComboBox);
            this.groupBox1.Controls.Add(cantMesesLabel);
            this.groupBox1.Controls.Add(this.cantMesesTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 454);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Nuevo Trabajo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(546, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 26);
            this.label7.TabIndex = 95;
            this.label7.Text = "Clientes:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(551, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 78);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Cliente por Nombre o DNI";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(36, 33);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.AllowUserToAddRows = false;
            this.clientesDataGridView.AllowUserToDeleteRows = false;
            this.clientesDataGridView.AutoGenerateColumns = false;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.clientesDataGridView.DataSource = this.clientesBindingSource;
            this.clientesDataGridView.Location = new System.Drawing.Point(489, 163);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.ReadOnly = true;
            this.clientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientesDataGridView.Size = new System.Drawing.Size(356, 250);
            this.clientesDataGridView.TabIndex = 93;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Cliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cuit1";
            this.dataGridViewTextBoxColumn2.HeaderText = "";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 19;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DNI";
            this.dataGridViewTextBoxColumn3.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 56;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cuit2";
            this.dataGridViewTextBoxColumn4.HeaderText = "";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 19;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 83;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Domicilio";
            this.dataGridViewTextBoxColumn6.HeaderText = "Domicilio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TelFijo";
            this.dataGridViewTextBoxColumn7.HeaderText = "TelFijo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TelMovil";
            this.dataGridViewTextBoxColumn8.HeaderText = "TelMovil";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Mail";
            this.dataGridViewTextBoxColumn9.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Observaciones";
            this.dataGridViewTextBoxColumn10.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "UsuCre";
            this.dataGridViewTextBoxColumn11.HeaderText = "UsuCre";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FechaCre";
            this.dataGridViewTextBoxColumn12.HeaderText = "FechaCre";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "UsuMod";
            this.dataGridViewTextBoxColumn13.HeaderText = "UsuMod";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "FechaMod";
            this.dataGridViewTextBoxColumn14.HeaderText = "FechaMod";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.corpusDataSet;
            // 
            // corpusDataSet
            // 
            this.corpusDataSet.DataSetName = "CorpusDataSet";
            this.corpusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numTrabajoTextBox
            // 
            this.numTrabajoTextBox.Enabled = false;
            this.numTrabajoTextBox.Location = new System.Drawing.Point(181, 84);
            this.numTrabajoTextBox.Name = "numTrabajoTextBox";
            this.numTrabajoTextBox.Size = new System.Drawing.Size(199, 23);
            this.numTrabajoTextBox.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(386, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 31);
            this.label6.TabIndex = 92;
            this.label6.Text = "*";
            // 
            // id_ClienteComboBox1
            // 
            this.id_ClienteComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trabajosBindingSource, "Id_Cliente", true));
            this.id_ClienteComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.trabajosBindingSource, "Id_Cliente", true));
            this.id_ClienteComboBox1.DataSource = this.clientesBindingSource;
            this.id_ClienteComboBox1.DisplayMember = "Id_Cliente";
            this.id_ClienteComboBox1.Enabled = false;
            this.id_ClienteComboBox1.FormattingEnabled = true;
            this.id_ClienteComboBox1.Location = new System.Drawing.Point(181, 113);
            this.id_ClienteComboBox1.Name = "id_ClienteComboBox1";
            this.id_ClienteComboBox1.Size = new System.Drawing.Size(54, 24);
            this.id_ClienteComboBox1.TabIndex = 90;
            this.id_ClienteComboBox1.ValueMember = "Id_Cliente";
            // 
            // trabajosBindingSource
            // 
            this.trabajosBindingSource.DataMember = "Trabajos";
            this.trabajosBindingSource.DataSource = this.corpusDataSet;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(418, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 30);
            this.button3.TabIndex = 89;
            this.button3.Text = "Crear Cliente";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(387, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 31);
            this.label3.TabIndex = 87;
            this.label3.Text = "*";
            // 
            // id_ClienteComboBox
            // 
            this.id_ClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.trabajosBindingSource, "Id_Cliente", true));
            this.id_ClienteComboBox.DataSource = this.clientesBindingSource;
            this.id_ClienteComboBox.DisplayMember = "Nombre";
            this.id_ClienteComboBox.Enabled = false;
            this.id_ClienteComboBox.FormattingEnabled = true;
            this.id_ClienteComboBox.Location = new System.Drawing.Point(241, 113);
            this.id_ClienteComboBox.Name = "id_ClienteComboBox";
            this.id_ClienteComboBox.Size = new System.Drawing.Size(139, 24);
            this.id_ClienteComboBox.TabIndex = 70;
            this.id_ClienteComboBox.ValueMember = "Id_Cliente";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.Location = new System.Drawing.Point(181, 140);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 23);
            this.nombreTextBox.TabIndex = 1;
            // 
            // fechaFinDateTimePicker
            // 
            this.fechaFinDateTimePicker.Checked = false;
            this.fechaFinDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFinDateTimePicker.Location = new System.Drawing.Point(181, 225);
            this.fechaFinDateTimePicker.Name = "fechaFinDateTimePicker";
            this.fechaFinDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.fechaFinDateTimePicker.TabIndex = 4;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observacionesTextBox.Location = new System.Drawing.Point(181, 251);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacionesTextBox.Size = new System.Drawing.Size(200, 81);
            this.observacionesTextBox.TabIndex = 5;
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Items.AddRange(new object[] {
            "BLANCO",
            "NEGRO"});
            this.tipoComboBox.Location = new System.Drawing.Point(181, 169);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(200, 24);
            this.tipoComboBox.TabIndex = 2;
            // 
            // cantMesesTextBox
            // 
            this.cantMesesTextBox.Location = new System.Drawing.Point(181, 199);
            this.cantMesesTextBox.Name = "cantMesesTextBox";
            this.cantMesesTextBox.Size = new System.Drawing.Size(200, 23);
            this.cantMesesTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(387, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 31);
            this.label2.TabIndex = 56;
            this.label2.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(387, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 31);
            this.label5.TabIndex = 55;
            this.label5.Text = "*";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(135, 37);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(199, 17);
            this.user.TabIndex = 37;
            this.user.Text = "Nombre y Apellido del Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Usuario Activo:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::Corpus.Properties.Resources.Borrar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(100, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::Corpus.Properties.Resources.Nuevo;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(255, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Crear";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APagarTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BalanceTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.CobrosEmpleadosExternosTableAdapter = null;
            this.tableAdapterManager.CobrosEmpleadosTableAdapter = null;
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
            // trabajosTableAdapter1
            // 
            this.trabajosTableAdapter1.ClearBeforeFill = true;
            // 
            // NuevoTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1013, 530);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevoTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Trabajo";
            this.Load += new System.EventHandler(this.NuevoTrabajo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox id_ClienteComboBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fechaFinDateTimePicker;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.TextBox cantMesesTextBox;
        private System.Windows.Forms.Label label3;
        private CorpusDataSet corpusDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private CorpusDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource trabajosBindingSource;
        private System.Windows.Forms.Button button3;
        private CorpusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox id_ClienteComboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numTrabajoTextBox;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private CorpusDataSetTableAdapters.TrabajosTableAdapter trabajosTableAdapter1;
        private System.Windows.Forms.Label label7;
    }
}