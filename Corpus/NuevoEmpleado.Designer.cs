namespace Corpus
{
    partial class NuevoEmpleado
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telFijoLabel;
            System.Windows.Forms.Label telMovilLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label observacionesLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telFijoTextBox = new System.Windows.Forms.TextBox();
            this.telMovilTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.empleadosTableAdapter1 = new Corpus.CorpusDataSetTableAdapters.EmpleadosTableAdapter();
            this.aPagarTableAdapter1 = new Corpus.CorpusDataSetTableAdapters.APagarTableAdapter();
            nombreLabel = new System.Windows.Forms.Label();
            telFijoLabel = new System.Windows.Forms.Label();
            telMovilLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(26, 86);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(127, 17);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre y Apellido:";
            // 
            // telFijoLabel
            // 
            telFijoLabel.AutoSize = true;
            telFijoLabel.Location = new System.Drawing.Point(26, 115);
            telFijoLabel.Name = "telFijoLabel";
            telFijoLabel.Size = new System.Drawing.Size(94, 17);
            telFijoLabel.TabIndex = 6;
            telFijoLabel.Text = "Telefono Fijo:";
            // 
            // telMovilLabel
            // 
            telMovilLabel.AutoSize = true;
            telMovilLabel.Location = new System.Drawing.Point(26, 144);
            telMovilLabel.Name = "telMovilLabel";
            telMovilLabel.Size = new System.Drawing.Size(104, 17);
            telMovilLabel.TabIndex = 8;
            telMovilLabel.Text = "Telefono Movil:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(26, 173);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(37, 17);
            mailLabel.TabIndex = 10;
            mailLabel.Text = "Mail:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(26, 202);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(107, 17);
            observacionesLabel.TabIndex = 12;
            observacionesLabel.Text = "Observaciones:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 428);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Profesional Interno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(400, 83);
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
            this.button2.Location = new System.Drawing.Point(93, 328);
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
            this.button1.Location = new System.Drawing.Point(248, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Crear";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.Location = new System.Drawing.Point(159, 83);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(235, 23);
            this.nombreTextBox.TabIndex = 1;
            // 
            // telFijoTextBox
            // 
            this.telFijoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telFijoTextBox.Location = new System.Drawing.Point(159, 112);
            this.telFijoTextBox.Name = "telFijoTextBox";
            this.telFijoTextBox.Size = new System.Drawing.Size(235, 23);
            this.telFijoTextBox.TabIndex = 2;
            // 
            // telMovilTextBox
            // 
            this.telMovilTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telMovilTextBox.Location = new System.Drawing.Point(159, 141);
            this.telMovilTextBox.Name = "telMovilTextBox";
            this.telMovilTextBox.Size = new System.Drawing.Size(235, 23);
            this.telMovilTextBox.TabIndex = 3;
            // 
            // mailTextBox
            // 
            this.mailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.mailTextBox.Location = new System.Drawing.Point(159, 170);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(235, 23);
            this.mailTextBox.TabIndex = 4;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observacionesTextBox.Location = new System.Drawing.Point(159, 199);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacionesTextBox.Size = new System.Drawing.Size(235, 97);
            this.observacionesTextBox.TabIndex = 5;
            // 
            // empleadosTableAdapter1
            // 
            this.empleadosTableAdapter1.ClearBeforeFill = true;
            // 
            // aPagarTableAdapter1
            // 
            this.aPagarTableAdapter1.ClearBeforeFill = true;
            // 
            // NuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(527, 493);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Profesional Interno";
            this.Load += new System.EventHandler(this.NuevoEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telFijoTextBox;
        private System.Windows.Forms.TextBox telMovilTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private CorpusDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter1;
        private CorpusDataSetTableAdapters.APagarTableAdapter aPagarTableAdapter1;
    }
}