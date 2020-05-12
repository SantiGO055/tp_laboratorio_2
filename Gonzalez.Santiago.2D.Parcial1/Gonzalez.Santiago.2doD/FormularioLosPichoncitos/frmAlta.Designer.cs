namespace FormularioLosPichoncitos
{
    partial class FrmAlta
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
            this.btnAlta = new System.Windows.Forms.Button();
            this.numValorHora = new System.Windows.Forms.NumericUpDown();
            this.grbAltaDocente = new System.Windows.Forms.GroupBox();
            this.grbPrecioCuota = new System.Windows.Forms.GroupBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.numPrecioCuota = new System.Windows.Forms.NumericUpDown();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblPrecioCuota = new System.Windows.Forms.Label();
            this.grbAdministrativo = new System.Windows.Forms.GroupBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.grbResponsable = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.cmbParentesco = new System.Windows.Forms.ComboBox();
            this.lblParentesco = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValorHora)).BeginInit();
            this.grbAltaDocente.SuspendLayout();
            this.grbPrecioCuota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCuota)).BeginInit();
            this.grbAdministrativo.SuspendLayout();
            this.grbResponsable.SuspendLayout();
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
            this.txtApellido.Location = new System.Drawing.Point(102, 85);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtDni.Location = new System.Drawing.Point(102, 122);
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
            this.gbxSexo.Location = new System.Drawing.Point(34, 175);
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
            this.lblApellido.Location = new System.Drawing.Point(31, 87);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 14);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblDni.Location = new System.Drawing.Point(39, 124);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 14);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "Dni";
            // 
            // dtpHoraIngreso
            // 
            this.dtpHoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraIngreso.Location = new System.Drawing.Point(167, 24);
            this.dtpHoraIngreso.Name = "dtpHoraIngreso";
            this.dtpHoraIngreso.Size = new System.Drawing.Size(92, 20);
            this.dtpHoraIngreso.TabIndex = 10;
            this.dtpHoraIngreso.Value = new System.DateTime(2020, 5, 7, 19, 56, 0, 0);
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalida.Location = new System.Drawing.Point(167, 62);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(92, 20);
            this.dtpHoraSalida.TabIndex = 11;
            this.dtpHoraSalida.Value = new System.DateTime(2020, 5, 7, 19, 56, 0, 0);
            // 
            // lblHoraIngreso
            // 
            this.lblHoraIngreso.AutoSize = true;
            this.lblHoraIngreso.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraIngreso.Location = new System.Drawing.Point(18, 24);
            this.lblHoraIngreso.Name = "lblHoraIngreso";
            this.lblHoraIngreso.Size = new System.Drawing.Size(130, 14);
            this.lblHoraIngreso.TabIndex = 12;
            this.lblHoraIngreso.Text = "Horario de ingreso";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSalida.Location = new System.Drawing.Point(18, 64);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(120, 14);
            this.lblHoraSalida.TabIndex = 13;
            this.lblHoraSalida.Text = "Horario de salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Valor de la hora";
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAlta.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlta.Location = new System.Drawing.Point(296, 211);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(136, 64);
            this.btnAlta.TabIndex = 16;
            this.btnAlta.Text = "Dar de alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // numValorHora
            // 
            this.numValorHora.BackColor = System.Drawing.Color.PaleGreen;
            this.numValorHora.DecimalPlaces = 2;
            this.numValorHora.Location = new System.Drawing.Point(167, 95);
            this.numValorHora.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numValorHora.Name = "numValorHora";
            this.numValorHora.Size = new System.Drawing.Size(92, 20);
            this.numValorHora.TabIndex = 17;
            // 
            // grbAltaDocente
            // 
            this.grbAltaDocente.Controls.Add(this.numValorHora);
            this.grbAltaDocente.Controls.Add(this.label1);
            this.grbAltaDocente.Controls.Add(this.lblHoraSalida);
            this.grbAltaDocente.Controls.Add(this.lblHoraIngreso);
            this.grbAltaDocente.Controls.Add(this.dtpHoraSalida);
            this.grbAltaDocente.Controls.Add(this.dtpHoraIngreso);
            this.grbAltaDocente.Location = new System.Drawing.Point(284, 28);
            this.grbAltaDocente.Name = "grbAltaDocente";
            this.grbAltaDocente.Size = new System.Drawing.Size(285, 134);
            this.grbAltaDocente.TabIndex = 19;
            this.grbAltaDocente.TabStop = false;
            // 
            // grbPrecioCuota
            // 
            this.grbPrecioCuota.Controls.Add(this.txtLegajo);
            this.grbPrecioCuota.Controls.Add(this.numPrecioCuota);
            this.grbPrecioCuota.Controls.Add(this.lblLegajo);
            this.grbPrecioCuota.Controls.Add(this.lblPrecioCuota);
            this.grbPrecioCuota.Location = new System.Drawing.Point(260, 116);
            this.grbPrecioCuota.Name = "grbPrecioCuota";
            this.grbPrecioCuota.Size = new System.Drawing.Size(267, 82);
            this.grbPrecioCuota.TabIndex = 23;
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
            // grbAdministrativo
            // 
            this.grbAdministrativo.Controls.Add(this.cmbCargo);
            this.grbAdministrativo.Controls.Add(this.lblCargo);
            this.grbAdministrativo.Location = new System.Drawing.Point(305, 26);
            this.grbAdministrativo.Name = "grbAdministrativo";
            this.grbAdministrativo.Size = new System.Drawing.Size(222, 80);
            this.grbAdministrativo.TabIndex = 20;
            this.grbAdministrativo.TabStop = false;
            // 
            // cmbCargo
            // 
            this.cmbCargo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(83, 27);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(121, 21);
            this.cmbCargo.TabIndex = 14;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(21, 29);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(46, 14);
            this.lblCargo.TabIndex = 13;
            this.lblCargo.Text = "Cargo";
            // 
            // grbResponsable
            // 
            this.grbResponsable.Controls.Add(this.txtTelefono);
            this.grbResponsable.Controls.Add(this.lblTelefono);
            this.grbResponsable.Controls.Add(this.cmbParentesco);
            this.grbResponsable.Controls.Add(this.lblParentesco);
            this.grbResponsable.Location = new System.Drawing.Point(260, 16);
            this.grbResponsable.Name = "grbResponsable";
            this.grbResponsable.Size = new System.Drawing.Size(222, 94);
            this.grbResponsable.TabIndex = 21;
            this.grbResponsable.TabStop = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtTelefono.Location = new System.Drawing.Point(106, 56);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(92, 20);
            this.txtTelefono.TabIndex = 22;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(21, 58);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 14);
            this.lblTelefono.TabIndex = 15;
            this.lblTelefono.Text = "Telefono";
            // 
            // cmbParentesco
            // 
            this.cmbParentesco.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbParentesco.FormattingEnabled = true;
            this.cmbParentesco.Items.AddRange(new object[] {
            " "});
            this.cmbParentesco.Location = new System.Drawing.Point(106, 22);
            this.cmbParentesco.Name = "cmbParentesco";
            this.cmbParentesco.Size = new System.Drawing.Size(92, 21);
            this.cmbParentesco.TabIndex = 14;
            // 
            // lblParentesco
            // 
            this.lblParentesco.AutoSize = true;
            this.lblParentesco.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentesco.Location = new System.Drawing.Point(21, 24);
            this.lblParentesco.Name = "lblParentesco";
            this.lblParentesco.Size = new System.Drawing.Size(81, 14);
            this.lblParentesco.TabIndex = 13;
            this.lblParentesco.Text = "Parentesco";
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(629, 297);
            this.Controls.Add(this.grbPrecioCuota);
            this.Controls.Add(this.grbResponsable);
            this.Controls.Add(this.grbAdministrativo);
            this.Controls.Add(this.grbAltaDocente);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.FrmAlta_Load);
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValorHora)).EndInit();
            this.grbAltaDocente.ResumeLayout(false);
            this.grbAltaDocente.PerformLayout();
            this.grbPrecioCuota.ResumeLayout(false);
            this.grbPrecioCuota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioCuota)).EndInit();
            this.grbAdministrativo.ResumeLayout(false);
            this.grbAdministrativo.PerformLayout();
            this.grbResponsable.ResumeLayout(false);
            this.grbResponsable.PerformLayout();
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
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.NumericUpDown numValorHora;
        private System.Windows.Forms.GroupBox grbAltaDocente;
        private System.Windows.Forms.GroupBox grbAdministrativo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.NumericUpDown numPrecioCuota;
        private System.Windows.Forms.Label lblPrecioCuota;
        private System.Windows.Forms.GroupBox grbPrecioCuota;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.GroupBox grbResponsable;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ComboBox cmbParentesco;
        private System.Windows.Forms.Label lblParentesco;
    }
}