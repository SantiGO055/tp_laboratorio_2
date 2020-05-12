namespace FormularioLosPichoncitos
{
    partial class FrmAltaAlumno
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
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rdbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rdbtnMasculino = new System.Windows.Forms.RadioButton();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grbPrecioCuota = new System.Windows.Forms.GroupBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.numPrecioCuota = new System.Windows.Forms.NumericUpDown();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblPrecioCuota = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.gbxSexo.SuspendLayout();
            this.grbPrecioCuota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCuota)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblDni.Location = new System.Drawing.Point(61, 112);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 14);
            this.lblDni.TabIndex = 15;
            this.lblDni.Text = "Dni";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(53, 75);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 14);
            this.lblApellido.TabIndex = 14;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(53, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 14);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rdbtnFemenino);
            this.gbxSexo.Controls.Add(this.rdbtnMasculino);
            this.gbxSexo.Location = new System.Drawing.Point(56, 163);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(169, 100);
            this.gbxSexo.TabIndex = 12;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
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
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtDni.Location = new System.Drawing.Point(124, 110);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtApellido.Location = new System.Drawing.Point(124, 73);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtNombre.Location = new System.Drawing.Point(124, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // grbPrecioCuota
            // 
            this.grbPrecioCuota.Controls.Add(this.txtLegajo);
            this.grbPrecioCuota.Controls.Add(this.numPrecioCuota);
            this.grbPrecioCuota.Controls.Add(this.lblLegajo);
            this.grbPrecioCuota.Controls.Add(this.lblPrecioCuota);
            this.grbPrecioCuota.Location = new System.Drawing.Point(281, 32);
            this.grbPrecioCuota.Name = "grbPrecioCuota";
            this.grbPrecioCuota.Size = new System.Drawing.Size(267, 82);
            this.grbPrecioCuota.TabIndex = 24;
            this.grbPrecioCuota.TabStop = false;
            // 
            // txtLegajo
            // 
            this.txtLegajo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtLegajo.Location = new System.Drawing.Point(161, 50);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(92, 20);
            this.txtLegajo.TabIndex = 21;
            // 
            // numPrecioCuota
            // 
            this.numPrecioCuota.BackColor = System.Drawing.Color.PaleGreen;
            this.numPrecioCuota.DecimalPlaces = 2;
            this.numPrecioCuota.Location = new System.Drawing.Point(161, 15);
            this.numPrecioCuota.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrecioCuota.Name = "numPrecioCuota";
            this.numPrecioCuota.Size = new System.Drawing.Size(92, 20);
            this.numPrecioCuota.TabIndex = 22;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.Location = new System.Drawing.Point(12, 53);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(52, 14);
            this.lblLegajo.TabIndex = 22;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblPrecioCuota
            // 
            this.lblPrecioCuota.AutoSize = true;
            this.lblPrecioCuota.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCuota.Location = new System.Drawing.Point(12, 16);
            this.lblPrecioCuota.Name = "lblPrecioCuota";
            this.lblPrecioCuota.Size = new System.Drawing.Size(125, 14);
            this.lblPrecioCuota.TabIndex = 21;
            this.lblPrecioCuota.Text = "Precio de la cuota";
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAlta.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlta.Location = new System.Drawing.Point(339, 180);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(136, 64);
            this.btnAlta.TabIndex = 23;
            this.btnAlta.Text = "Dar de alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // FrmAltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 283);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.grbPrecioCuota);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmAltaAlumno";
            this.Text = "FrmAltaAlumno";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.grbPrecioCuota.ResumeLayout(false);
            this.grbPrecioCuota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCuota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rdbtnFemenino;
        private System.Windows.Forms.RadioButton rdbtnMasculino;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grbPrecioCuota;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.NumericUpDown numPrecioCuota;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblPrecioCuota;
        private System.Windows.Forms.Button btnAlta;
    }
}