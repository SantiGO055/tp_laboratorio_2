namespace FormularioLosPichoncitos
{
    partial class AltaDocente
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.rdbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rdbtnFemenino = new System.Windows.Forms.RadioButton();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.dtpHoraIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.lblHoraIngreso = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAltaDocente = new System.Windows.Forms.Button();
            this.numValorHora = new System.Windows.Forms.NumericUpDown();
            this.gbxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValorHora)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNombre.Location = new System.Drawing.Point(102, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtApellido.Location = new System.Drawing.Point(102, 103);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtDni.Location = new System.Drawing.Point(102, 170);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 2;
            // 
            // rdbtnMasculino
            // 
            this.rdbtnMasculino.AutoSize = true;
            this.rdbtnMasculino.Location = new System.Drawing.Point(40, 19);
            this.rdbtnMasculino.Name = "rdbtnMasculino";
            this.rdbtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbtnMasculino.TabIndex = 3;
            this.rdbtnMasculino.TabStop = true;
            this.rdbtnMasculino.Text = "Masculino";
            this.rdbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbtnFemenino
            // 
            this.rdbtnFemenino.AutoSize = true;
            this.rdbtnFemenino.Location = new System.Drawing.Point(40, 64);
            this.rdbtnFemenino.Name = "rdbtnFemenino";
            this.rdbtnFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbtnFemenino.TabIndex = 4;
            this.rdbtnFemenino.TabStop = true;
            this.rdbtnFemenino.Text = "Femenino";
            this.rdbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rdbtnFemenino);
            this.gbxSexo.Controls.Add(this.rdbtnMasculino);
            this.gbxSexo.Location = new System.Drawing.Point(34, 240);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(169, 100);
            this.gbxSexo.TabIndex = 5;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 14);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(30, 105);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 14);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblDni.Location = new System.Drawing.Point(39, 172);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 14);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "Dni";
            // 
            // dtpHoraIngreso
            // 
            this.dtpHoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraIngreso.Location = new System.Drawing.Point(411, 42);
            this.dtpHoraIngreso.Name = "dtpHoraIngreso";
            this.dtpHoraIngreso.Size = new System.Drawing.Size(92, 20);
            this.dtpHoraIngreso.TabIndex = 10;
            this.dtpHoraIngreso.Value = new System.DateTime(2020, 5, 7, 19, 56, 0, 0);
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalida.Location = new System.Drawing.Point(411, 103);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(92, 20);
            this.dtpHoraSalida.TabIndex = 11;
            this.dtpHoraSalida.Value = new System.DateTime(2020, 5, 7, 19, 56, 0, 0);
            // 
            // lblHoraIngreso
            // 
            this.lblHoraIngreso.AutoSize = true;
            this.lblHoraIngreso.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraIngreso.Location = new System.Drawing.Point(262, 44);
            this.lblHoraIngreso.Name = "lblHoraIngreso";
            this.lblHoraIngreso.Size = new System.Drawing.Size(130, 14);
            this.lblHoraIngreso.TabIndex = 12;
            this.lblHoraIngreso.Text = "Horario de ingreso";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSalida.Location = new System.Drawing.Point(262, 105);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(120, 14);
            this.lblHoraSalida.TabIndex = 13;
            this.lblHoraSalida.Text = "Horario de salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Valor de la hora";
            // 
            // btnAltaDocente
            // 
            this.btnAltaDocente.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAltaDocente.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaDocente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAltaDocente.Location = new System.Drawing.Point(367, 276);
            this.btnAltaDocente.Name = "btnAltaDocente";
            this.btnAltaDocente.Size = new System.Drawing.Size(136, 64);
            this.btnAltaDocente.TabIndex = 16;
            this.btnAltaDocente.Text = "Dar de alta";
            this.btnAltaDocente.UseVisualStyleBackColor = false;
            this.btnAltaDocente.Click += new System.EventHandler(this.btnAltaDocente_Click);
            // 
            // numValorHora
            // 
            this.numValorHora.BackColor = System.Drawing.Color.PaleGreen;
            this.numValorHora.DecimalPlaces = 2;
            this.numValorHora.Location = new System.Drawing.Point(411, 172);
            this.numValorHora.Name = "numValorHora";
            this.numValorHora.Size = new System.Drawing.Size(92, 20);
            this.numValorHora.TabIndex = 17;
            // 
            // AltaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(542, 368);
            this.Controls.Add(this.numValorHora);
            this.Controls.Add(this.btnAltaDocente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHoraSalida);
            this.Controls.Add(this.lblHoraIngreso);
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.dtpHoraIngreso);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AltaDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta de docente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AltaDocente_Load);
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValorHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.RadioButton rdbtnMasculino;
        private System.Windows.Forms.RadioButton rdbtnFemenino;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.DateTimePicker dtpHoraIngreso;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.Label lblHoraIngreso;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAltaDocente;
        private System.Windows.Forms.NumericUpDown numValorHora;
    }
}