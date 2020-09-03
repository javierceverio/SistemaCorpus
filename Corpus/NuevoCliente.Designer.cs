namespace Corpus
{
    partial class NuevoCliente
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
            System.Windows.Forms.Label cuit1Label;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.Label telFijoLabel;
            System.Windows.Forms.Label telMovilLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label observacionesLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cuit1TextBox = new System.Windows.Forms.TextBox();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.cuit2TextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.domicilioTextBox = new System.Windows.Forms.TextBox();
            this.telFijoTextBox = new System.Windows.Forms.TextBox();
            this.telMovilTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clientesTableAdapter1 = new Corpus.CorpusDataSetTableAdapters.ClientesTableAdapter();
            cuit1Label = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            telFijoLabel = new System.Windows.Forms.Label();
            telMovilLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuit1Label
            // 
            cuit1Label.AutoSize = true;
            cuit1Label.Location = new System.Drawing.Point(26, 86);
            cuit1Label.Name = "cuit1Label";
            cuit1Label.Size = new System.Drawing.Size(70, 17);
            cuit1Label.TabIndex = 36;
            cuit1Label.Text = "CUIT/DNI:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(26, 115);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 40;
            nombreLabel.Text = "Nombre:";
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Location = new System.Drawing.Point(26, 144);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(68, 17);
            domicilioLabel.TabIndex = 42;
            domicilioLabel.Text = "Domicilio:";
            // 
            // telFijoLabel
            // 
            telFijoLabel.AutoSize = true;
            telFijoLabel.Location = new System.Drawing.Point(26, 173);
            telFijoLabel.Name = "telFijoLabel";
            telFijoLabel.Size = new System.Drawing.Size(94, 17);
            telFijoLabel.TabIndex = 44;
            telFijoLabel.Text = "Telefono Fijo:";
            // 
            // telMovilLabel
            // 
            telMovilLabel.AutoSize = true;
            telMovilLabel.Location = new System.Drawing.Point(26, 202);
            telMovilLabel.Name = "telMovilLabel";
            telMovilLabel.Size = new System.Drawing.Size(104, 17);
            telMovilLabel.TabIndex = 46;
            telMovilLabel.Text = "Telefono Movil:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(26, 231);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(37, 17);
            mailLabel.TabIndex = 48;
            mailLabel.Text = "Mail:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(26, 260);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(107, 17);
            observacionesLabel.TabIndex = 50;
            observacionesLabel.Text = "Observaciones:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
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
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 469);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Nuevo Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(342, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 31);
            this.label3.TabIndex = 55;
            this.label3.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(342, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 31);
            this.label5.TabIndex = 54;
            this.label5.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "-";
            // 
            // cuit1TextBox
            // 
            this.cuit1TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cuit1TextBox.Location = new System.Drawing.Point(139, 83);
            this.cuit1TextBox.MaxLength = 2;
            this.cuit1TextBox.Name = "cuit1TextBox";
            this.cuit1TextBox.Size = new System.Drawing.Size(24, 23);
            this.cuit1TextBox.TabIndex = 1;
            // 
            // dNITextBox
            // 
            this.dNITextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dNITextBox.Location = new System.Drawing.Point(188, 83);
            this.dNITextBox.MaxLength = 8;
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(102, 23);
            this.dNITextBox.TabIndex = 2;
            // 
            // cuit2TextBox
            // 
            this.cuit2TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cuit2TextBox.Location = new System.Drawing.Point(310, 81);
            this.cuit2TextBox.MaxLength = 1;
            this.cuit2TextBox.Name = "cuit2TextBox";
            this.cuit2TextBox.Size = new System.Drawing.Size(29, 23);
            this.cuit2TextBox.TabIndex = 3;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.Location = new System.Drawing.Point(139, 112);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 23);
            this.nombreTextBox.TabIndex = 4;
            // 
            // domicilioTextBox
            // 
            this.domicilioTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.domicilioTextBox.Location = new System.Drawing.Point(139, 141);
            this.domicilioTextBox.Name = "domicilioTextBox";
            this.domicilioTextBox.Size = new System.Drawing.Size(200, 23);
            this.domicilioTextBox.TabIndex = 5;
            // 
            // telFijoTextBox
            // 
            this.telFijoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telFijoTextBox.Location = new System.Drawing.Point(139, 170);
            this.telFijoTextBox.Name = "telFijoTextBox";
            this.telFijoTextBox.Size = new System.Drawing.Size(200, 23);
            this.telFijoTextBox.TabIndex = 6;
            // 
            // telMovilTextBox
            // 
            this.telMovilTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telMovilTextBox.Location = new System.Drawing.Point(139, 199);
            this.telMovilTextBox.Name = "telMovilTextBox";
            this.telMovilTextBox.Size = new System.Drawing.Size(200, 23);
            this.telMovilTextBox.TabIndex = 7;
            // 
            // mailTextBox
            // 
            this.mailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.mailTextBox.Location = new System.Drawing.Point(139, 228);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(200, 23);
            this.mailTextBox.TabIndex = 8;
            this.mailTextBox.Leave += new System.EventHandler(this.mailTextBox_Leave);
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observacionesTextBox.Location = new System.Drawing.Point(139, 257);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacionesTextBox.Size = new System.Drawing.Size(200, 81);
            this.observacionesTextBox.TabIndex = 9;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(135, 42);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(199, 17);
            this.user.TabIndex = 35;
            this.user.Text = "Nombre y Apellido del Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Usuario Activo:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::Corpus.Properties.Resources.Borrar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(99, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 56);
            this.button2.TabIndex = 11;
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
            this.button1.Location = new System.Drawing.Point(285, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "Crear";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(522, 540);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cuit1TextBox;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox cuit2TextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox domicilioTextBox;
        private System.Windows.Forms.TextBox telFijoTextBox;
        private System.Windows.Forms.TextBox telMovilTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private CorpusDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter1;
    }
}