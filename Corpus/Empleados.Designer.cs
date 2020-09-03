namespace Corpus
{
    partial class Empleados
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
            System.Windows.Forms.Label id_EmpleadoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telFijoLabel;
            System.Windows.Forms.Label telMovilLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label usuCreLabel;
            System.Windows.Forms.Label fechaCreLabel;
            System.Windows.Forms.Label usuModLabel;
            System.Windows.Forms.Label fechaModLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.nombreActualizado = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.InformeTodosLosCobros = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.InformeACobrarPorTrabajo = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.aCobrar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.detallePagosCobros = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.id_EmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corpusDataSet = new Corpus.CorpusDataSet();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telFijoTextBox = new System.Windows.Forms.TextBox();
            this.telMovilTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.usuCreTextBox = new System.Windows.Forms.TextBox();
            this.fechaCreDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.usuModTextBox = new System.Windows.Forms.TextBox();
            this.fechaModDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.empleadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobrosEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new Corpus.CorpusDataSetTableAdapters.EmpleadosTableAdapter();
            this.tableAdapterManager = new Corpus.CorpusDataSetTableAdapters.TableAdapterManager();
            this.presupuestosTableAdapter = new Corpus.CorpusDataSetTableAdapters.PresupuestosTableAdapter();
            this.cobrosEmpleadosTableAdapter = new Corpus.CorpusDataSetTableAdapters.CobrosEmpleadosTableAdapter();
            id_EmpleadoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosEmpleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_EmpleadoLabel
            // 
            id_EmpleadoLabel.AutoSize = true;
            id_EmpleadoLabel.Location = new System.Drawing.Point(28, 62);
            id_EmpleadoLabel.Name = "id_EmpleadoLabel";
            id_EmpleadoLabel.Size = new System.Drawing.Size(110, 13);
            id_EmpleadoLabel.TabIndex = 1;
            id_EmpleadoLabel.Text = "Id Profesional Interno:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(28, 88);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(95, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre y Apellido:";
            // 
            // telFijoLabel
            // 
            telFijoLabel.AutoSize = true;
            telFijoLabel.Location = new System.Drawing.Point(28, 117);
            telFijoLabel.Name = "telFijoLabel";
            telFijoLabel.Size = new System.Drawing.Size(71, 13);
            telFijoLabel.TabIndex = 7;
            telFijoLabel.Text = "Telefono Fijo:";
            // 
            // telMovilLabel
            // 
            telMovilLabel.AutoSize = true;
            telMovilLabel.Location = new System.Drawing.Point(28, 143);
            telMovilLabel.Name = "telMovilLabel";
            telMovilLabel.Size = new System.Drawing.Size(80, 13);
            telMovilLabel.TabIndex = 9;
            telMovilLabel.Text = "Telefono Movil:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(28, 169);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(29, 13);
            mailLabel.TabIndex = 11;
            mailLabel.Text = "Mail:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(28, 195);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 13;
            observacionesLabel.Text = "Observaciones:";
            // 
            // usuCreLabel
            // 
            usuCreLabel.AutoSize = true;
            usuCreLabel.Location = new System.Drawing.Point(28, 307);
            usuCreLabel.Name = "usuCreLabel";
            usuCreLabel.Size = new System.Drawing.Size(62, 13);
            usuCreLabel.TabIndex = 15;
            usuCreLabel.Text = "Creado por:";
            // 
            // fechaCreLabel
            // 
            fechaCreLabel.AutoSize = true;
            fechaCreLabel.Location = new System.Drawing.Point(28, 334);
            fechaCreLabel.Name = "fechaCreLabel";
            fechaCreLabel.Size = new System.Drawing.Size(100, 13);
            fechaCreLabel.TabIndex = 17;
            fechaCreLabel.Text = "Fecha de Creacion:";
            // 
            // usuModLabel
            // 
            usuModLabel.AutoSize = true;
            usuModLabel.Location = new System.Drawing.Point(28, 359);
            usuModLabel.Name = "usuModLabel";
            usuModLabel.Size = new System.Drawing.Size(80, 13);
            usuModLabel.TabIndex = 19;
            usuModLabel.Text = "Modificado por:";
            // 
            // fechaModLabel
            // 
            fechaModLabel.AutoSize = true;
            fechaModLabel.Location = new System.Drawing.Point(28, 386);
            fechaModLabel.Name = "fechaModLabel";
            fechaModLabel.Size = new System.Drawing.Size(118, 13);
            fechaModLabel.TabIndex = 21;
            fechaModLabel.Text = "Fecha de Modificacion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.nombreActualizado);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.InformeTodosLosCobros);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.InformeACobrarPorTrabajo);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.aCobrar);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.detallePagosCobros);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(id_EmpleadoLabel);
            this.groupBox1.Controls.Add(this.id_EmpleadoTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
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
            this.groupBox1.Controls.Add(this.empleadosDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 514);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de los Profesionales Internos";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button8.Image = global::Corpus.Properties.Resources.Dinero1;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.Location = new System.Drawing.Point(677, 142);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(113, 69);
            this.button8.TabIndex = 56;
            this.button8.Text = "Cobrados a Pagar";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // nombreActualizado
            // 
            this.nombreActualizado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreActualizado.Location = new System.Drawing.Point(152, 82);
            this.nombreActualizado.Name = "nombreActualizado";
            this.nombreActualizado.Size = new System.Drawing.Size(197, 20);
            this.nombreActualizado.TabIndex = 55;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Image = global::Corpus.Properties.Resources.INFORMACION;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(715, 33);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 72);
            this.button7.TabIndex = 54;
            this.button7.Text = "Todos los Cobros";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.InformeTodosLosCobros_Click);
            // 
            // InformeTodosLosCobros
            // 
            this.InformeTodosLosCobros.BackColor = System.Drawing.Color.White;
            this.InformeTodosLosCobros.Image = global::Corpus.Properties.Resources.INFORMACION;
            this.InformeTodosLosCobros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InformeTodosLosCobros.Location = new System.Drawing.Point(715, 33);
            this.InformeTodosLosCobros.Name = "InformeTodosLosCobros";
            this.InformeTodosLosCobros.Size = new System.Drawing.Size(75, 72);
            this.InformeTodosLosCobros.TabIndex = 54;
            this.InformeTodosLosCobros.Text = "Todos los Cobros";
            this.InformeTodosLosCobros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InformeTodosLosCobros.UseVisualStyleBackColor = false;
            this.InformeTodosLosCobros.Click += new System.EventHandler(this.InformeTodosLosCobros_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Image = global::Corpus.Properties.Resources.INFORMACION;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(607, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 72);
            this.button6.TabIndex = 53;
            this.button6.Text = "Totales, Cobrados y Saldos";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.InformeACobrarPorTrabajo_Click);
            // 
            // InformeACobrarPorTrabajo
            // 
            this.InformeACobrarPorTrabajo.BackColor = System.Drawing.Color.White;
            this.InformeACobrarPorTrabajo.Image = global::Corpus.Properties.Resources.INFORMACION;
            this.InformeACobrarPorTrabajo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InformeACobrarPorTrabajo.Location = new System.Drawing.Point(607, 33);
            this.InformeACobrarPorTrabajo.Name = "InformeACobrarPorTrabajo";
            this.InformeACobrarPorTrabajo.Size = new System.Drawing.Size(75, 72);
            this.InformeACobrarPorTrabajo.TabIndex = 53;
            this.InformeACobrarPorTrabajo.Text = "A Cobrar";
            this.InformeACobrarPorTrabajo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InformeACobrarPorTrabajo.UseVisualStyleBackColor = false;
            this.InformeACobrarPorTrabajo.Click += new System.EventHandler(this.InformeACobrarPorTrabajo_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleGreen;
            this.button5.Image = global::Corpus.Properties.Resources.Letra_D;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(502, 142);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 69);
            this.button5.TabIndex = 52;
            this.button5.Text = "Detalles de TODOS los Trabajos";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.aCobrar_Click);
            // 
            // aCobrar
            // 
            this.aCobrar.BackColor = System.Drawing.Color.PaleGreen;
            this.aCobrar.Image = global::Corpus.Properties.Resources.Letra_D;
            this.aCobrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aCobrar.Location = new System.Drawing.Point(502, 143);
            this.aCobrar.Name = "aCobrar";
            this.aCobrar.Size = new System.Drawing.Size(169, 69);
            this.aCobrar.TabIndex = 52;
            this.aCobrar.Text = "Detalles de TODOS los Trabajos";
            this.aCobrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aCobrar.UseVisualStyleBackColor = false;
            this.aCobrar.Click += new System.EventHandler(this.aCobrar_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSalmon;
            this.button4.Image = global::Corpus.Properties.Resources.Letra_D;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(386, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 70);
            this.button4.TabIndex = 51;
            this.button4.Text = "Detalles por Trabajo";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.detallePagosCobros_Click);
            // 
            // detallePagosCobros
            // 
            this.detallePagosCobros.BackColor = System.Drawing.Color.DarkSalmon;
            this.detallePagosCobros.Image = global::Corpus.Properties.Resources.Letra_D;
            this.detallePagosCobros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.detallePagosCobros.Location = new System.Drawing.Point(386, 142);
            this.detallePagosCobros.Name = "detallePagosCobros";
            this.detallePagosCobros.Size = new System.Drawing.Size(110, 70);
            this.detallePagosCobros.TabIndex = 51;
            this.detallePagosCobros.Text = "Detalles por Trabajo";
            this.detallePagosCobros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.detallePagosCobros.UseVisualStyleBackColor = false;
            this.detallePagosCobros.Click += new System.EventHandler(this.detallePagosCobros_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::Corpus.Properties.Resources.Nuevo;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(48, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 41;
            this.button1.Text = "Nuevo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::Corpus.Properties.Resources.Actualizar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(142, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 55);
            this.button2.TabIndex = 42;
            this.button2.Text = "Actualizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(113, 33);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(148, 13);
            this.user.TabIndex = 46;
            this.user.Text = "Nombre y Apellido del Usuario";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = global::Corpus.Properties.Resources.Eliminar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(251, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 43;
            this.button3.Text = "Eliminar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Usuario Activo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(355, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 31);
            this.label5.TabIndex = 44;
            this.label5.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(386, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 97);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por Nombre y Apellido";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(15, 39);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // id_EmpleadoTextBox
            // 
            this.id_EmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Id_Empleado", true));
            this.id_EmpleadoTextBox.Enabled = false;
            this.id_EmpleadoTextBox.Location = new System.Drawing.Point(152, 56);
            this.id_EmpleadoTextBox.Name = "id_EmpleadoTextBox";
            this.id_EmpleadoTextBox.Size = new System.Drawing.Size(197, 20);
            this.id_EmpleadoTextBox.TabIndex = 2;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.corpusDataSet;
            // 
            // corpusDataSet
            // 
            this.corpusDataSet.DataSetName = "CorpusDataSet";
            this.corpusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Nombre", true));
            this.nombreTextBox.Enabled = false;
            this.nombreTextBox.Location = new System.Drawing.Point(152, 82);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(197, 20);
            this.nombreTextBox.TabIndex = 4;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // telFijoTextBox
            // 
            this.telFijoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "TelFijo", true));
            this.telFijoTextBox.Location = new System.Drawing.Point(152, 111);
            this.telFijoTextBox.Name = "telFijoTextBox";
            this.telFijoTextBox.Size = new System.Drawing.Size(197, 20);
            this.telFijoTextBox.TabIndex = 8;
            // 
            // telMovilTextBox
            // 
            this.telMovilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "TelMovil", true));
            this.telMovilTextBox.Location = new System.Drawing.Point(152, 137);
            this.telMovilTextBox.Name = "telMovilTextBox";
            this.telMovilTextBox.Size = new System.Drawing.Size(197, 20);
            this.telMovilTextBox.TabIndex = 10;
            // 
            // mailTextBox
            // 
            this.mailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Mail", true));
            this.mailTextBox.Location = new System.Drawing.Point(152, 163);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(197, 20);
            this.mailTextBox.TabIndex = 12;
            this.mailTextBox.Leave += new System.EventHandler(this.mailTextBox_Leave);
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Observaciones", true));
            this.observacionesTextBox.Location = new System.Drawing.Point(152, 189);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacionesTextBox.Size = new System.Drawing.Size(197, 106);
            this.observacionesTextBox.TabIndex = 14;
            // 
            // usuCreTextBox
            // 
            this.usuCreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "UsuCre", true));
            this.usuCreTextBox.Enabled = false;
            this.usuCreTextBox.Location = new System.Drawing.Point(152, 301);
            this.usuCreTextBox.Name = "usuCreTextBox";
            this.usuCreTextBox.Size = new System.Drawing.Size(197, 20);
            this.usuCreTextBox.TabIndex = 16;
            // 
            // fechaCreDateTimePicker
            // 
            this.fechaCreDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.empleadosBindingSource, "FechaCre", true));
            this.fechaCreDateTimePicker.Enabled = false;
            this.fechaCreDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCreDateTimePicker.Location = new System.Drawing.Point(152, 327);
            this.fechaCreDateTimePicker.Name = "fechaCreDateTimePicker";
            this.fechaCreDateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.fechaCreDateTimePicker.TabIndex = 18;
            // 
            // usuModTextBox
            // 
            this.usuModTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "UsuMod", true));
            this.usuModTextBox.Enabled = false;
            this.usuModTextBox.Location = new System.Drawing.Point(152, 353);
            this.usuModTextBox.Name = "usuModTextBox";
            this.usuModTextBox.Size = new System.Drawing.Size(197, 20);
            this.usuModTextBox.TabIndex = 20;
            // 
            // fechaModDateTimePicker
            // 
            this.fechaModDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.empleadosBindingSource, "FechaMod", true));
            this.fechaModDateTimePicker.Enabled = false;
            this.fechaModDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaModDateTimePicker.Location = new System.Drawing.Point(152, 379);
            this.fechaModDateTimePicker.Name = "fechaModDateTimePicker";
            this.fechaModDateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.fechaModDateTimePicker.TabIndex = 22;
            // 
            // empleadosDataGridView
            // 
            this.empleadosDataGridView.AllowUserToAddRows = false;
            this.empleadosDataGridView.AllowUserToDeleteRows = false;
            this.empleadosDataGridView.AutoGenerateColumns = false;
            this.empleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.empleadosDataGridView.DataSource = this.empleadosBindingSource;
            this.empleadosDataGridView.Location = new System.Drawing.Point(386, 236);
            this.empleadosDataGridView.Name = "empleadosDataGridView";
            this.empleadosDataGridView.ReadOnly = true;
            this.empleadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empleadosDataGridView.Size = new System.Drawing.Size(404, 243);
            this.empleadosDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Empleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Empleado";
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TelFijo";
            this.dataGridViewTextBoxColumn4.HeaderText = "TelFijo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TelMovil";
            this.dataGridViewTextBoxColumn5.HeaderText = "TelMovil";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Mail";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Observaciones";
            this.dataGridViewTextBoxColumn7.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UsuCre";
            this.dataGridViewTextBoxColumn8.HeaderText = "UsuCre";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FechaCre";
            this.dataGridViewTextBoxColumn9.HeaderText = "FechaCre";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "UsuMod";
            this.dataGridViewTextBoxColumn10.HeaderText = "UsuMod";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FechaMod";
            this.dataGridViewTextBoxColumn11.HeaderText = "FechaMod";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // presupuestosBindingSource
            // 
            this.presupuestosBindingSource.DataMember = "Presupuestos";
            this.presupuestosBindingSource.DataSource = this.corpusDataSet;
            // 
            // cobrosEmpleadosBindingSource
            // 
            this.cobrosEmpleadosBindingSource.DataMember = "CobrosEmpleados";
            this.cobrosEmpleadosBindingSource.DataSource = this.corpusDataSet;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.EmpleadosTableAdapter = this.empleadosTableAdapter;
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
            // presupuestosTableAdapter
            // 
            this.presupuestosTableAdapter.ClearBeforeFill = true;
            // 
            // cobrosEmpleadosTableAdapter
            // 
            this.cobrosEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(902, 577);
            this.Controls.Add(this.groupBox1);
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesionales Internos";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobrosEmpleadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CorpusDataSet corpusDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private CorpusDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private CorpusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_EmpleadoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telFijoTextBox;
        private System.Windows.Forms.TextBox telMovilTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.TextBox usuCreTextBox;
        private System.Windows.Forms.DateTimePicker fechaCreDateTimePicker;
        private System.Windows.Forms.TextBox usuModTextBox;
        private System.Windows.Forms.DateTimePicker fechaModDateTimePicker;
        private System.Windows.Forms.DataGridView empleadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource presupuestosBindingSource;
        private CorpusDataSetTableAdapters.PresupuestosTableAdapter presupuestosTableAdapter;
        private System.Windows.Forms.BindingSource cobrosEmpleadosBindingSource;
        private CorpusDataSetTableAdapters.CobrosEmpleadosTableAdapter cobrosEmpleadosTableAdapter;
        private System.Windows.Forms.Button detallePagosCobros;
        private System.Windows.Forms.Button aCobrar;
        private System.Windows.Forms.Button InformeACobrarPorTrabajo;
        private System.Windows.Forms.Button InformeTodosLosCobros;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox nombreActualizado;
        private System.Windows.Forms.Button button8;
    }
}