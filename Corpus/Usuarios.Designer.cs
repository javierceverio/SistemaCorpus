namespace Corpus
{
    partial class Usuarios
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
            System.Windows.Forms.Label id_UsuarioLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label passLabel;
            System.Windows.Forms.Label usuCreLabel;
            System.Windows.Forms.Label fechaCreLabel;
            System.Windows.Forms.Label usuModLabel;
            System.Windows.Forms.Label fechaModLabel;
            System.Windows.Forms.Label nivelLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nivelComboBox = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corpusDataSet = new Corpus.CorpusDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.usuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.usuCreTextBox = new System.Windows.Forms.TextBox();
            this.fechaCreDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.usuModTextBox = new System.Windows.Forms.TextBox();
            this.fechaModDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.usuariosTableAdapter = new Corpus.CorpusDataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new Corpus.CorpusDataSetTableAdapters.TableAdapterManager();
            this.nomusuario = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            id_UsuarioLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            passLabel = new System.Windows.Forms.Label();
            usuCreLabel = new System.Windows.Forms.Label();
            fechaCreLabel = new System.Windows.Forms.Label();
            usuModLabel = new System.Windows.Forms.Label();
            fechaModLabel = new System.Windows.Forms.Label();
            nivelLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_UsuarioLabel
            // 
            id_UsuarioLabel.AutoSize = true;
            id_UsuarioLabel.Location = new System.Drawing.Point(37, 104);
            id_UsuarioLabel.Name = "id_UsuarioLabel";
            id_UsuarioLabel.Size = new System.Drawing.Size(76, 17);
            id_UsuarioLabel.TabIndex = 0;
            id_UsuarioLabel.Text = "Id Usuario:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(37, 133);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(127, 17);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre y Apellido:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(37, 162);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(61, 17);
            usuarioLabel.TabIndex = 6;
            usuarioLabel.Text = "Usuario:";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(37, 191);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(85, 17);
            passLabel.TabIndex = 8;
            passLabel.Text = "Contraseña:";
            // 
            // usuCreLabel
            // 
            usuCreLabel.AutoSize = true;
            usuCreLabel.Location = new System.Drawing.Point(37, 250);
            usuCreLabel.Name = "usuCreLabel";
            usuCreLabel.Size = new System.Drawing.Size(83, 17);
            usuCreLabel.TabIndex = 10;
            usuCreLabel.Text = "Creado por:";
            // 
            // fechaCreLabel
            // 
            fechaCreLabel.AutoSize = true;
            fechaCreLabel.Location = new System.Drawing.Point(37, 280);
            fechaCreLabel.Name = "fechaCreLabel";
            fechaCreLabel.Size = new System.Drawing.Size(131, 17);
            fechaCreLabel.TabIndex = 12;
            fechaCreLabel.Text = "Fecha de Creacion:";
            // 
            // usuModLabel
            // 
            usuModLabel.AutoSize = true;
            usuModLabel.Location = new System.Drawing.Point(37, 308);
            usuModLabel.Name = "usuModLabel";
            usuModLabel.Size = new System.Drawing.Size(105, 17);
            usuModLabel.TabIndex = 14;
            usuModLabel.Text = "Modificado por:";
            // 
            // fechaModLabel
            // 
            fechaModLabel.AutoSize = true;
            fechaModLabel.Location = new System.Drawing.Point(37, 338);
            fechaModLabel.Name = "fechaModLabel";
            fechaModLabel.Size = new System.Drawing.Size(153, 17);
            fechaModLabel.TabIndex = 16;
            fechaModLabel.Text = "Fecha de Modificacion:";
            // 
            // nivelLabel
            // 
            nivelLabel.AutoSize = true;
            nivelLabel.Location = new System.Drawing.Point(37, 220);
            nivelLabel.Name = "nivelLabel";
            nivelLabel.Size = new System.Drawing.Size(43, 17);
            nivelLabel.TabIndex = 25;
            nivelLabel.Text = "Nivel:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(nivelLabel);
            this.groupBox1.Controls.Add(this.nivelComboBox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.usuariosDataGridView);
            this.groupBox1.Controls.Add(id_UsuarioLabel);
            this.groupBox1.Controls.Add(this.id_UsuarioTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(usuarioLabel);
            this.groupBox1.Controls.Add(this.usuarioTextBox);
            this.groupBox1.Controls.Add(passLabel);
            this.groupBox1.Controls.Add(this.passTextBox);
            this.groupBox1.Controls.Add(usuCreLabel);
            this.groupBox1.Controls.Add(this.usuCreTextBox);
            this.groupBox1.Controls.Add(fechaCreLabel);
            this.groupBox1.Controls.Add(this.fechaCreDateTimePicker);
            this.groupBox1.Controls.Add(usuModLabel);
            this.groupBox1.Controls.Add(this.usuModTextBox);
            this.groupBox1.Controls.Add(fechaModLabel);
            this.groupBox1.Controls.Add(this.fechaModDateTimePicker);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de los Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(505, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 31);
            this.label2.TabIndex = 31;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(505, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 31);
            this.label3.TabIndex = 30;
            this.label3.Text = "*";
            // 
            // nivelComboBox
            // 
            this.nivelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Nivel", true));
            this.nivelComboBox.FormattingEnabled = true;
            this.nivelComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.nivelComboBox.Location = new System.Drawing.Point(196, 216);
            this.nivelComboBox.Name = "nivelComboBox";
            this.nivelComboBox.Size = new System.Drawing.Size(303, 24);
            this.nivelComboBox.TabIndex = 26;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.corpusDataSet;
            // 
            // corpusDataSet
            // 
            this.corpusDataSet.DataSetName = "CorpusDataSet";
            this.corpusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(552, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 102);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por Nombre y Apellido";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(31, 43);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(146, 35);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(199, 17);
            this.user.TabIndex = 12;
            this.user.Text = "Nombre y Apellido del Usuario";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = global::Corpus.Properties.Resources.Eliminar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(352, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 21;
            this.button3.Text = "Eliminar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario Activo:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::Corpus.Properties.Resources.Actualizar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(243, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 55);
            this.button2.TabIndex = 20;
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
            this.button1.Location = new System.Drawing.Point(149, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 19;
            this.button1.Text = "Nuevo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usuariosDataGridView
            // 
            this.usuariosDataGridView.AllowUserToAddRows = false;
            this.usuariosDataGridView.AllowUserToDeleteRows = false;
            this.usuariosDataGridView.AutoGenerateColumns = false;
            this.usuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.usuariosDataGridView.DataSource = this.usuariosBindingSource;
            this.usuariosDataGridView.Location = new System.Drawing.Point(552, 245);
            this.usuariosDataGridView.Name = "usuariosDataGridView";
            this.usuariosDataGridView.ReadOnly = true;
            this.usuariosDataGridView.Size = new System.Drawing.Size(380, 195);
            this.usuariosDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Usuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Usuario";
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pass";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pass";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UsuCre";
            this.dataGridViewTextBoxColumn6.HeaderText = "UsuCre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FechaCre";
            this.dataGridViewTextBoxColumn7.HeaderText = "FechaCre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UsuMod";
            this.dataGridViewTextBoxColumn8.HeaderText = "UsuMod";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FechaMod";
            this.dataGridViewTextBoxColumn9.HeaderText = "FechaMod";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // id_UsuarioTextBox
            // 
            this.id_UsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Id_Usuario", true));
            this.id_UsuarioTextBox.Enabled = false;
            this.id_UsuarioTextBox.Location = new System.Drawing.Point(196, 100);
            this.id_UsuarioTextBox.Name = "id_UsuarioTextBox";
            this.id_UsuarioTextBox.Size = new System.Drawing.Size(303, 23);
            this.id_UsuarioTextBox.TabIndex = 1;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Nombre", true));
            this.nombreTextBox.Enabled = false;
            this.nombreTextBox.Location = new System.Drawing.Point(196, 129);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(303, 23);
            this.nombreTextBox.TabIndex = 3;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(196, 158);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(303, 23);
            this.usuarioTextBox.TabIndex = 7;
            // 
            // passTextBox
            // 
            this.passTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Pass", true));
            this.passTextBox.Enabled = false;
            this.passTextBox.Location = new System.Drawing.Point(196, 187);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(303, 23);
            this.passTextBox.TabIndex = 9;
            // 
            // usuCreTextBox
            // 
            this.usuCreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "UsuCre", true));
            this.usuCreTextBox.Enabled = false;
            this.usuCreTextBox.Location = new System.Drawing.Point(196, 246);
            this.usuCreTextBox.Name = "usuCreTextBox";
            this.usuCreTextBox.Size = new System.Drawing.Size(303, 23);
            this.usuCreTextBox.TabIndex = 11;
            // 
            // fechaCreDateTimePicker
            // 
            this.fechaCreDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuariosBindingSource, "FechaCre", true));
            this.fechaCreDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "FechaCre", true));
            this.fechaCreDateTimePicker.Enabled = false;
            this.fechaCreDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCreDateTimePicker.Location = new System.Drawing.Point(196, 275);
            this.fechaCreDateTimePicker.Name = "fechaCreDateTimePicker";
            this.fechaCreDateTimePicker.Size = new System.Drawing.Size(303, 23);
            this.fechaCreDateTimePicker.TabIndex = 13;
            this.fechaCreDateTimePicker.Value = new System.DateTime(2019, 5, 8, 11, 20, 3, 0);
            // 
            // usuModTextBox
            // 
            this.usuModTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "UsuMod", true));
            this.usuModTextBox.Enabled = false;
            this.usuModTextBox.Location = new System.Drawing.Point(196, 304);
            this.usuModTextBox.Name = "usuModTextBox";
            this.usuModTextBox.Size = new System.Drawing.Size(303, 23);
            this.usuModTextBox.TabIndex = 15;
            // 
            // fechaModDateTimePicker
            // 
            this.fechaModDateTimePicker.Checked = false;
            this.fechaModDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuariosBindingSource, "FechaMod", true));
            this.fechaModDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "FechaMod", true));
            this.fechaModDateTimePicker.Enabled = false;
            this.fechaModDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaModDateTimePicker.Location = new System.Drawing.Point(196, 333);
            this.fechaModDateTimePicker.Name = "fechaModDateTimePicker";
            this.fechaModDateTimePicker.Size = new System.Drawing.Size(303, 23);
            this.fechaModDateTimePicker.TabIndex = 17;
            this.fechaModDateTimePicker.Value = new System.DateTime(2019, 5, 8, 11, 20, 37, 0);
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ImpuestosTableAdapter = null;
            this.tableAdapterManager.InformeCorpusTableAdapter = null;
            this.tableAdapterManager.OtrosTableAdapter = null;
            this.tableAdapterManager.PagosTableAdapter = null;
            this.tableAdapterManager.PresupuestosTableAdapter = null;
            this.tableAdapterManager.TrabajosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Corpus.CorpusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // nomusuario
            // 
            this.nomusuario.AutoSize = true;
            this.nomusuario.Location = new System.Drawing.Point(778, 13);
            this.nomusuario.Name = "nomusuario";
            this.nomusuario.Size = new System.Drawing.Size(64, 13);
            this.nomusuario.TabIndex = 1;
            this.nomusuario.Text = "usuariosave";
            this.nomusuario.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Corpus.Properties.Resources.Pass;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(552, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 55);
            this.button4.TabIndex = 61;
            this.button4.Text = "Cambiar Contraseña";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1056, 554);
            this.Controls.Add(this.nomusuario);
            this.Controls.Add(this.groupBox1);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CorpusDataSet corpusDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private CorpusDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private CorpusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView usuariosDataGridView;
        private System.Windows.Forms.TextBox id_UsuarioTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox usuCreTextBox;
        private System.Windows.Forms.DateTimePicker fechaCreDateTimePicker;
        private System.Windows.Forms.TextBox usuModTextBox;
        private System.Windows.Forms.DateTimePicker fechaModDateTimePicker;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ComboBox nivelComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nomusuario;
        private System.Windows.Forms.Button button4;
    }
}