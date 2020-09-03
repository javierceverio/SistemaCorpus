namespace Corpus
{
    partial class NuevoCobro
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
            System.Windows.Forms.Label numTrabajoLabel;
            System.Windows.Forms.Label montoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label observacionesLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numTrabajoTextBox = new System.Windows.Forms.TextBox();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cobrosTableAdapter1 = new Corpus.CorpusDataSetTableAdapters.CobrosTableAdapter();
            this.precioTrabajo = new System.Windows.Forms.Label();
            this.ultimoCobro = new System.Windows.Forms.Label();
            this.lblSaldoTrabajo = new System.Windows.Forms.Label();
            numTrabajoLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numTrabajoLabel
            // 
            numTrabajoLabel.AutoSize = true;
            numTrabajoLabel.Location = new System.Drawing.Point(23, 81);
            numTrabajoLabel.Name = "numTrabajoLabel";
            numTrabajoLabel.Size = new System.Drawing.Size(135, 17);
            numTrabajoLabel.TabIndex = 55;
            numTrabajoLabel.Text = "Numero de Trabajo:";
            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Location = new System.Drawing.Point(23, 110);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(51, 17);
            montoLabel.TabIndex = 57;
            montoLabel.Text = "Monto:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(23, 140);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(51, 17);
            fechaLabel.TabIndex = 59;
            fechaLabel.Text = "Fecha:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(23, 168);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(107, 17);
            observacionesLabel.TabIndex = 61;
            observacionesLabel.Text = "Observaciones:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(numTrabajoLabel);
            this.groupBox1.Controls.Add(this.numTrabajoTextBox);
            this.groupBox1.Controls.Add(montoLabel);
            this.groupBox1.Controls.Add(this.montoTextBox);
            this.groupBox1.Controls.Add(fechaLabel);
            this.groupBox1.Controls.Add(this.fechaDateTimePicker);
            this.groupBox1.Controls.Add(observacionesLabel);
            this.groupBox1.Controls.Add(this.observacionesTextBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cobro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(388, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 31);
            this.label3.TabIndex = 65;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(388, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 31);
            this.label2.TabIndex = 64;
            this.label2.Text = "*";
            // 
            // numTrabajoTextBox
            // 
            this.numTrabajoTextBox.Enabled = false;
            this.numTrabajoTextBox.Location = new System.Drawing.Point(182, 78);
            this.numTrabajoTextBox.Name = "numTrabajoTextBox";
            this.numTrabajoTextBox.Size = new System.Drawing.Size(200, 23);
            this.numTrabajoTextBox.TabIndex = 0;
            // 
            // montoTextBox
            // 
            this.montoTextBox.Location = new System.Drawing.Point(182, 107);
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(200, 23);
            this.montoTextBox.TabIndex = 1;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(182, 136);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.fechaDateTimePicker.TabIndex = 2;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.Location = new System.Drawing.Point(182, 165);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacionesTextBox.Size = new System.Drawing.Size(200, 107);
            this.observacionesTextBox.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::Corpus.Properties.Resources.Borrar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(102, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 56);
            this.button2.TabIndex = 5;
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
            this.button1.Location = new System.Drawing.Point(233, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crear";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(132, 35);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(199, 17);
            this.user.TabIndex = 12;
            this.user.Text = "Nombre y Apellido del Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario Activo:";
            // 
            // cobrosTableAdapter1
            // 
            this.cobrosTableAdapter1.ClearBeforeFill = true;
            // 
            // precioTrabajo
            // 
            this.precioTrabajo.AutoSize = true;
            this.precioTrabajo.Location = new System.Drawing.Point(300, 13);
            this.precioTrabajo.Name = "precioTrabajo";
            this.precioTrabajo.Size = new System.Drawing.Size(88, 13);
            this.precioTrabajo.TabIndex = 1;
            this.precioTrabajo.Text = "precio del trabajo";
            this.precioTrabajo.Visible = false;
            // 
            // ultimoCobro
            // 
            this.ultimoCobro.AutoSize = true;
            this.ultimoCobro.Location = new System.Drawing.Point(207, 11);
            this.ultimoCobro.Name = "ultimoCobro";
            this.ultimoCobro.Size = new System.Drawing.Size(62, 13);
            this.ultimoCobro.TabIndex = 66;
            this.ultimoCobro.Text = "ultimoCobro";
            this.ultimoCobro.Visible = false;
            // 
            // lblSaldoTrabajo
            // 
            this.lblSaldoTrabajo.AutoSize = true;
            this.lblSaldoTrabajo.Location = new System.Drawing.Point(119, 11);
            this.lblSaldoTrabajo.Name = "lblSaldoTrabajo";
            this.lblSaldoTrabajo.Size = new System.Drawing.Size(80, 13);
            this.lblSaldoTrabajo.TabIndex = 67;
            this.lblSaldoTrabajo.Text = "lblSaldoTrabajo";
            this.lblSaldoTrabajo.Visible = false;
            // 
            // NuevoCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(497, 462);
            this.Controls.Add(this.lblSaldoTrabajo);
            this.Controls.Add(this.ultimoCobro);
            this.Controls.Add(this.precioTrabajo);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevoCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cobro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numTrabajoTextBox;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CorpusDataSetTableAdapters.CobrosTableAdapter cobrosTableAdapter1;
        private System.Windows.Forms.Label precioTrabajo;
        private System.Windows.Forms.Label ultimoCobro;
        private System.Windows.Forms.Label lblSaldoTrabajo;
    }
}