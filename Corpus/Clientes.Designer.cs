namespace Corpus
{
    partial class Clientes
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
            System.Windows.Forms.Label cuit1Label;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.Label telFijoLabel;
            System.Windows.Forms.Label telMovilLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label usuCreLabel;
            System.Windows.Forms.Label fechaCreLabel;
            System.Windows.Forms.Label usuModLabel;
            System.Windows.Forms.Label fechaModLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.user = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corpusDataSet = new Corpus.CorpusDataSet();
            this.cuit1TextBox = new System.Windows.Forms.TextBox();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.cuit2TextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.domicilioTextBox = new System.Windows.Forms.TextBox();
            this.telFijoTextBox = new System.Windows.Forms.TextBox();
            this.telMovilTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.usuCreTextBox = new System.Windows.Forms.TextBox();
            this.fechaCreDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.usuModTextBox = new System.Windows.Forms.TextBox();
            this.fechaModDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.clientesTableAdapter = new Corpus.CorpusDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new Corpus.CorpusDataSetTableAdapters.TableAdapterManager();
            this.trabajosTableAdapter1 = new Corpus.CorpusDataSetTableAdapters.TrabajosTableAdapter();
            id_ClienteLabel = new System.Windows.Forms.Label();
            cuit1Label = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            telFijoLabel = new System.Windows.Forms.Label();
            telMovilLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            usuCreLabel = new System.Windows.Forms.Label();
            fechaCreLabel = new System.Windows.Forms.Label();
            usuModLabel = new System.Windows.Forms.Label();
            fechaModLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Location = new System.Drawing.Point(31, 81);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(70, 17);
            id_ClienteLabel.TabIndex = 1;
            id_ClienteLabel.Text = "Id Cliente:";
            // 
            // cuit1Label
            // 
            cuit1Label.AutoSize = true;
            cuit1Label.Location = new System.Drawing.Point(31, 110);
            cuit1Label.Name = "cuit1Label";
            cuit1Label.Size = new System.Drawing.Size(70, 17);
            cuit1Label.TabIndex = 3;
            cuit1Label.Text = "CUIT/DNI:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(31, 139);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "Nombre:";
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Location = new System.Drawing.Point(31, 168);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(68, 17);
            domicilioLabel.TabIndex = 11;
            domicilioLabel.Text = "Domicilio:";
            // 
            // telFijoLabel
            // 
            telFijoLabel.AutoSize = true;
            telFijoLabel.Location = new System.Drawing.Point(31, 197);
            telFijoLabel.Name = "telFijoLabel";
            telFijoLabel.Size = new System.Drawing.Size(94, 17);
            telFijoLabel.TabIndex = 13;
            telFijoLabel.Text = "Telefono Fijo:";
            // 
            // telMovilLabel
            // 
            telMovilLabel.AutoSize = true;
            telMovilLabel.Location = new System.Drawing.Point(31, 226);
            telMovilLabel.Name = "telMovilLabel";
            telMovilLabel.Size = new System.Drawing.Size(104, 17);
            telMovilLabel.TabIndex = 15;
            telMovilLabel.Text = "Telefono Movil:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(31, 255);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(37, 17);
            mailLabel.TabIndex = 17;
            mailLabel.Text = "Mail:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(31, 284);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(107, 17);
            observacionesLabel.TabIndex = 19;
            observacionesLabel.Text = "Observaciones:";
            // 
            // usuCreLabel
            // 
            usuCreLabel.AutoSize = true;
            usuCreLabel.Location = new System.Drawing.Point(466, 340);
            usuCreLabel.Name = "usuCreLabel";
            usuCreLabel.Size = new System.Drawing.Size(83, 17);
            usuCreLabel.TabIndex = 21;
            usuCreLabel.Text = "Creado por:";
            // 
            // fechaCreLabel
            // 
            fechaCreLabel.AutoSize = true;
            fechaCreLabel.Location = new System.Drawing.Point(466, 371);
            fechaCreLabel.Name = "fechaCreLabel";
            fechaCreLabel.Size = new System.Drawing.Size(131, 17);
            fechaCreLabel.TabIndex = 23;
            fechaCreLabel.Text = "Fecha de Creacion:";
            // 
            // usuModLabel
            // 
            usuModLabel.AutoSize = true;
            usuModLabel.Location = new System.Drawing.Point(466, 398);
            usuModLabel.Name = "usuModLabel";
            usuModLabel.Size = new System.Drawing.Size(105, 17);
            usuModLabel.TabIndex = 25;
            usuModLabel.Text = "Modificado por:";
            // 
            // fechaModLabel
            // 
            fechaModLabel.AutoSize = true;
            fechaModLabel.Location = new System.Drawing.Point(466, 429);
            fechaModLabel.Name = "fechaModLabel";
            fechaModLabel.Size = new System.Drawing.Size(153, 17);
            fechaModLabel.TabIndex = 27;
            fechaModLabel.Text = "Fecha de Modificacion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(id_ClienteLabel);
            this.groupBox1.Controls.Add(this.id_ClienteTextBox);
            this.groupBox1.Controls.Add(cuit1Label);
            this.groupBox1.Controls.Add(this.cuit1TextBox);
            this.groupBox1.Controls.Add(this.dNITextBox);
            this.groupBox1.Controls.Add(this.cuit2TextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(domicilioLabel);
            this.groupBox1.Controls.Add(this.domicilioTextBox);
            this.groupBox1.Controls.Add(telFijoLabel);
            this.groupBox1.Controls.Add(this.telFijoTextBox);
            this.groupBox1.Controls.Add(telMovilLabel);
            this.groupBox1.Controls.Add(this.telMovilTextBox);
            this.groupBox1.Controls.Add(mailLabel);
            this.groupBox1.Controls.Add(this.mailTextBox);
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
            this.groupBox1.Controls.Add(this.clientesDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 495);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de los Clientes";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(140, 39);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(199, 17);
            this.user.TabIndex = 37;
            this.user.Text = "Nombre y Apellido del Usuario";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = global::Corpus.Properties.Resources.Eliminar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(269, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 40;
            this.button3.Text = "Eliminar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Usuario Activo:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::Corpus.Properties.Resources.Actualizar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(160, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 55);
            this.button2.TabIndex = 10;
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
            this.button1.Location = new System.Drawing.Point(66, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 38;
            this.button1.Text = "Nuevo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(426, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 31);
            this.label3.TabIndex = 35;
            this.label3.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(426, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 31);
            this.label5.TabIndex = 34;
            this.label5.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(469, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 88);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por Nombre o DNI";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(30, 29);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "-";
            // 
            // id_ClienteTextBox
            // 
            this.id_ClienteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.id_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Id_Cliente", true));
            this.id_ClienteTextBox.Enabled = false;
            this.id_ClienteTextBox.Location = new System.Drawing.Point(144, 78);
            this.id_ClienteTextBox.Name = "id_ClienteTextBox";
            this.id_ClienteTextBox.Size = new System.Drawing.Size(276, 23);
            this.id_ClienteTextBox.TabIndex = 16;
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
            // cuit1TextBox
            // 
            this.cuit1TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cuit1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Cuit1", true));
            this.cuit1TextBox.Location = new System.Drawing.Point(144, 107);
            this.cuit1TextBox.MaxLength = 2;
            this.cuit1TextBox.Name = "cuit1TextBox";
            this.cuit1TextBox.Size = new System.Drawing.Size(24, 23);
            this.cuit1TextBox.TabIndex = 1;
            this.cuit1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dNITextBox
            // 
            this.dNITextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "DNI", true));
            this.dNITextBox.Location = new System.Drawing.Point(193, 107);
            this.dNITextBox.MaxLength = 8;
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(178, 23);
            this.dNITextBox.TabIndex = 2;
            this.dNITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cuit2TextBox
            // 
            this.cuit2TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cuit2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Cuit2", true));
            this.cuit2TextBox.Location = new System.Drawing.Point(396, 107);
            this.cuit2TextBox.MaxLength = 1;
            this.cuit2TextBox.Name = "cuit2TextBox";
            this.cuit2TextBox.Size = new System.Drawing.Size(24, 23);
            this.cuit2TextBox.TabIndex = 3;
            this.cuit2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(144, 136);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(276, 23);
            this.nombreTextBox.TabIndex = 4;
            // 
            // domicilioTextBox
            // 
            this.domicilioTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.domicilioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Domicilio", true));
            this.domicilioTextBox.Location = new System.Drawing.Point(144, 165);
            this.domicilioTextBox.Name = "domicilioTextBox";
            this.domicilioTextBox.Size = new System.Drawing.Size(276, 23);
            this.domicilioTextBox.TabIndex = 5;
            // 
            // telFijoTextBox
            // 
            this.telFijoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telFijoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "TelFijo", true));
            this.telFijoTextBox.Location = new System.Drawing.Point(144, 194);
            this.telFijoTextBox.Name = "telFijoTextBox";
            this.telFijoTextBox.Size = new System.Drawing.Size(276, 23);
            this.telFijoTextBox.TabIndex = 6;
            // 
            // telMovilTextBox
            // 
            this.telMovilTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telMovilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "TelMovil", true));
            this.telMovilTextBox.Location = new System.Drawing.Point(144, 223);
            this.telMovilTextBox.Name = "telMovilTextBox";
            this.telMovilTextBox.Size = new System.Drawing.Size(276, 23);
            this.telMovilTextBox.TabIndex = 7;
            // 
            // mailTextBox
            // 
            this.mailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Mail", true));
            this.mailTextBox.Location = new System.Drawing.Point(144, 252);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(276, 23);
            this.mailTextBox.TabIndex = 8;
            this.mailTextBox.Leave += new System.EventHandler(this.mailTextBox_Leave);
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Observaciones", true));
            this.observacionesTextBox.Location = new System.Drawing.Point(144, 281);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacionesTextBox.Size = new System.Drawing.Size(276, 100);
            this.observacionesTextBox.TabIndex = 9;
            // 
            // usuCreTextBox
            // 
            this.usuCreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "UsuCre", true));
            this.usuCreTextBox.Enabled = false;
            this.usuCreTextBox.Location = new System.Drawing.Point(625, 337);
            this.usuCreTextBox.Name = "usuCreTextBox";
            this.usuCreTextBox.Size = new System.Drawing.Size(232, 23);
            this.usuCreTextBox.TabIndex = 22;
            // 
            // fechaCreDateTimePicker
            // 
            this.fechaCreDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "FechaCre", true));
            this.fechaCreDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "FechaCre", true));
            this.fechaCreDateTimePicker.Enabled = false;
            this.fechaCreDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCreDateTimePicker.Location = new System.Drawing.Point(625, 366);
            this.fechaCreDateTimePicker.Name = "fechaCreDateTimePicker";
            this.fechaCreDateTimePicker.Size = new System.Drawing.Size(232, 23);
            this.fechaCreDateTimePicker.TabIndex = 24;
            // 
            // usuModTextBox
            // 
            this.usuModTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "UsuMod", true));
            this.usuModTextBox.Enabled = false;
            this.usuModTextBox.Location = new System.Drawing.Point(625, 395);
            this.usuModTextBox.Name = "usuModTextBox";
            this.usuModTextBox.Size = new System.Drawing.Size(232, 23);
            this.usuModTextBox.TabIndex = 26;
            // 
            // fechaModDateTimePicker
            // 
            this.fechaModDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "FechaMod", true));
            this.fechaModDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "FechaMod", true));
            this.fechaModDateTimePicker.Enabled = false;
            this.fechaModDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaModDateTimePicker.Location = new System.Drawing.Point(625, 424);
            this.fechaModDateTimePicker.Name = "fechaModDateTimePicker";
            this.fechaModDateTimePicker.Size = new System.Drawing.Size(232, 23);
            this.fechaModDateTimePicker.TabIndex = 28;
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
            this.clientesDataGridView.Location = new System.Drawing.Point(469, 139);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.ReadOnly = true;
            this.clientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientesDataGridView.Size = new System.Drawing.Size(388, 183);
            this.clientesDataGridView.TabIndex = 0;
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
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(950, 559);
            this.Controls.Add(this.groupBox1);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CorpusDataSet corpusDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private CorpusDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private CorpusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_ClienteTextBox;
        private System.Windows.Forms.TextBox cuit1TextBox;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox cuit2TextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox domicilioTextBox;
        private System.Windows.Forms.TextBox telFijoTextBox;
        private System.Windows.Forms.TextBox telMovilTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.TextBox usuCreTextBox;
        private System.Windows.Forms.DateTimePicker fechaCreDateTimePicker;
        private System.Windows.Forms.TextBox usuModTextBox;
        private System.Windows.Forms.DateTimePicker fechaModDateTimePicker;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
    }
}