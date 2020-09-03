namespace Corpus
{
    partial class InicioParaUsuarios
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreActualizado = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corpusDataSet = new Corpus.CorpusDataSet();
            this.id_EmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.telFijoTextBox = new System.Windows.Forms.TextBox();
            this.telMovilTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.empleadosTableAdapter = new Corpus.CorpusDataSetTableAdapters.EmpleadosTableAdapter();
            this.tableAdapterManager = new Corpus.CorpusDataSetTableAdapters.TableAdapterManager();
            this.empleadoNombre = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.idEmpleado = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            id_EmpleadoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telFijoLabel = new System.Windows.Forms.Label();
            telMovilLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // id_EmpleadoLabel
            // 
            id_EmpleadoLabel.AutoSize = true;
            id_EmpleadoLabel.Location = new System.Drawing.Point(26, 43);
            id_EmpleadoLabel.Name = "id_EmpleadoLabel";
            id_EmpleadoLabel.Size = new System.Drawing.Size(69, 13);
            id_EmpleadoLabel.TabIndex = 0;
            id_EmpleadoLabel.Text = "Id Empleado:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(26, 69);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(95, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre y Apellido:";
            // 
            // telFijoLabel
            // 
            telFijoLabel.AutoSize = true;
            telFijoLabel.Location = new System.Drawing.Point(26, 95);
            telFijoLabel.Name = "telFijoLabel";
            telFijoLabel.Size = new System.Drawing.Size(71, 13);
            telFijoLabel.TabIndex = 4;
            telFijoLabel.Text = "Telefono Fijo:";
            // 
            // telMovilLabel
            // 
            telMovilLabel.AutoSize = true;
            telMovilLabel.Location = new System.Drawing.Point(26, 121);
            telMovilLabel.Name = "telMovilLabel";
            telMovilLabel.Size = new System.Drawing.Size(80, 13);
            telMovilLabel.TabIndex = 6;
            telMovilLabel.Text = "Telefono Movil:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(26, 147);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(29, 13);
            mailLabel.TabIndex = 8;
            mailLabel.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sistema Informatico Corpus Ingenieria";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nombreActualizado);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(id_EmpleadoLabel);
            this.groupBox1.Controls.Add(this.id_EmpleadoTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(telFijoLabel);
            this.groupBox1.Controls.Add(this.telFijoTextBox);
            this.groupBox1.Controls.Add(telMovilLabel);
            this.groupBox1.Controls.Add(this.telMovilTextBox);
            this.groupBox1.Controls.Add(mailLabel);
            this.groupBox1.Controls.Add(this.mailTextBox);
            this.groupBox1.Location = new System.Drawing.Point(26, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 283);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Image = global::Corpus.Properties.Resources.Dinero1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(492, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 72);
            this.button3.TabIndex = 61;
            this.button3.Text = "Cobrados a Pagar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Corpus.Properties.Resources.Pass;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(29, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 55);
            this.button1.TabIndex = 60;
            this.button1.Text = "Cambiar Contraseña";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // nombreActualizado
            // 
            this.nombreActualizado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreActualizado.Location = new System.Drawing.Point(127, 66);
            this.nombreActualizado.Name = "nombreActualizado";
            this.nombreActualizado.Size = new System.Drawing.Size(200, 20);
            this.nombreActualizado.TabIndex = 59;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Image = global::Corpus.Properties.Resources.INFORMACION;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(632, 40);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 72);
            this.button7.TabIndex = 58;
            this.button7.Text = "Todos los Cobros";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Image = global::Corpus.Properties.Resources.INFORMACION;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(356, 40);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 72);
            this.button6.TabIndex = 57;
            this.button6.Text = "Totales, Cobrados y Saldos";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleGreen;
            this.button5.Image = global::Corpus.Properties.Resources.Letra_D;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(515, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 69);
            this.button5.TabIndex = 56;
            this.button5.Text = "Detalles de TODOS los Trabajos";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSalmon;
            this.button4.Image = global::Corpus.Properties.Resources.Letra_D;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(356, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 70);
            this.button4.TabIndex = 55;
            this.button4.Text = "Detalles por Trabajo";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::Corpus.Properties.Resources.Actualizar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(215, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 55);
            this.button2.TabIndex = 43;
            this.button2.Text = "Actualizar Datos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Nombre", true));
            this.nombreTextBox.Enabled = false;
            this.nombreTextBox.Location = new System.Drawing.Point(127, 66);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 10;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
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
            // id_EmpleadoTextBox
            // 
            this.id_EmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Id_Empleado", true));
            this.id_EmpleadoTextBox.Enabled = false;
            this.id_EmpleadoTextBox.Location = new System.Drawing.Point(127, 40);
            this.id_EmpleadoTextBox.Name = "id_EmpleadoTextBox";
            this.id_EmpleadoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_EmpleadoTextBox.TabIndex = 1;
            // 
            // telFijoTextBox
            // 
            this.telFijoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "TelFijo", true));
            this.telFijoTextBox.Location = new System.Drawing.Point(127, 92);
            this.telFijoTextBox.Name = "telFijoTextBox";
            this.telFijoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telFijoTextBox.TabIndex = 5;
            // 
            // telMovilTextBox
            // 
            this.telMovilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "TelMovil", true));
            this.telMovilTextBox.Location = new System.Drawing.Point(127, 118);
            this.telMovilTextBox.Name = "telMovilTextBox";
            this.telMovilTextBox.Size = new System.Drawing.Size(200, 20);
            this.telMovilTextBox.TabIndex = 7;
            // 
            // mailTextBox
            // 
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Mail", true));
            this.mailTextBox.Location = new System.Drawing.Point(127, 144);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(200, 20);
            this.mailTextBox.TabIndex = 9;
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
            // empleadoNombre
            // 
            this.empleadoNombre.AutoSize = true;
            this.empleadoNombre.Location = new System.Drawing.Point(219, 21);
            this.empleadoNombre.Name = "empleadoNombre";
            this.empleadoNombre.Size = new System.Drawing.Size(90, 13);
            this.empleadoNombre.TabIndex = 60;
            this.empleadoNombre.Text = "empleadoNombre";
            this.empleadoNombre.Visible = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Image = global::Corpus.Properties.Resources.Backup;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.Location = new System.Drawing.Point(594, 26);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 84);
            this.button8.TabIndex = 59;
            this.button8.Text = "Backup";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Image = global::Corpus.Properties.Resources.Corpus_Logo_Mas_Chico;
            this.button10.Location = new System.Drawing.Point(26, 21);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(77, 65);
            this.button10.TabIndex = 4;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // idEmpleado
            // 
            this.idEmpleado.AutoSize = true;
            this.idEmpleado.Location = new System.Drawing.Point(338, 21);
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.Size = new System.Drawing.Size(62, 13);
            this.idEmpleado.TabIndex = 61;
            this.idEmpleado.Text = "idEmpleado";
            this.idEmpleado.Visible = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Image = global::Corpus.Properties.Resources.Ayuda;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(709, 26);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 84);
            this.button9.TabIndex = 62;
            this.button9.Text = "Ayuda";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // InicioParaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(797, 422);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.idEmpleado);
            this.Controls.Add(this.empleadoNombre);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button10);
            this.Name = "InicioParaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a Sistema Informatico Corpus Ingenieria";
            this.Load += new System.EventHandler(this.InicioParaUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox1;
        private CorpusDataSet corpusDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private CorpusDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private CorpusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_EmpleadoTextBox;
        private System.Windows.Forms.TextBox telFijoTextBox;
        private System.Windows.Forms.TextBox telMovilTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label empleadoNombre;
        private System.Windows.Forms.TextBox nombreActualizado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label idEmpleado;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button9;
    }
}