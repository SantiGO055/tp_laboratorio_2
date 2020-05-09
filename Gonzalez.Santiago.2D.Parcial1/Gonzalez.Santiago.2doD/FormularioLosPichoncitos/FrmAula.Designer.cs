namespace FormularioLosPichoncitos
{
    partial class FrmAula
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.grpSinSala = new System.Windows.Forms.GroupBox();
            this.grbEnSala = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstSinSala = new System.Windows.Forms.ListBox();
            this.lstConSala = new System.Windows.Forms.ListBox();
            this.grpSinSala.SuspendLayout();
            this.grbEnSala.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(45, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(42, 14);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Color";
            // 
            // cmbColor
            // 
            this.cmbColor.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(105, 22);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(92, 21);
            this.cmbColor.TabIndex = 15;
            this.cmbColor.SelectionChangeCommitted += new System.EventHandler(this.cmbColor_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Turno";
            // 
            // cmbTurno
            // 
            this.cmbTurno.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(339, 22);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(92, 21);
            this.cmbTurno.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Profesor";
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(539, 22);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(92, 21);
            this.cmbProfesor.TabIndex = 19;
            // 
            // grpSinSala
            // 
            this.grpSinSala.Controls.Add(this.lstSinSala);
            this.grpSinSala.Location = new System.Drawing.Point(22, 68);
            this.grpSinSala.Name = "grpSinSala";
            this.grpSinSala.Size = new System.Drawing.Size(317, 345);
            this.grpSinSala.TabIndex = 20;
            this.grpSinSala.TabStop = false;
            this.grpSinSala.Text = "Alumnos sin sala";
            // 
            // grbEnSala
            // 
            this.grbEnSala.Controls.Add(this.lstConSala);
            this.grbEnSala.Location = new System.Drawing.Point(417, 68);
            this.grbEnSala.Name = "grbEnSala";
            this.grbEnSala.Size = new System.Drawing.Size(319, 344);
            this.grbEnSala.TabIndex = 21;
            this.grbEnSala.TabStop = false;
            this.grbEnSala.Text = "Alumnos en sala";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(618, 430);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 27);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lstSinSala
            // 
            this.lstSinSala.AllowDrop = true;
            this.lstSinSala.FormattingEnabled = true;
            this.lstSinSala.Location = new System.Drawing.Point(15, 34);
            this.lstSinSala.Name = "lstSinSala";
            this.lstSinSala.ScrollAlwaysVisible = true;
            this.lstSinSala.Size = new System.Drawing.Size(285, 290);
            this.lstSinSala.TabIndex = 2;
            // 
            // lstConSala
            // 
            this.lstConSala.AllowDrop = true;
            this.lstConSala.FormattingEnabled = true;
            this.lstConSala.Location = new System.Drawing.Point(17, 34);
            this.lstConSala.Name = "lstConSala";
            this.lstConSala.ScrollAlwaysVisible = true;
            this.lstConSala.Size = new System.Drawing.Size(285, 290);
            this.lstConSala.TabIndex = 3;
            // 
            // FrmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 479);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbEnSala);
            this.Controls.Add(this.grpSinSala);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmAula";
            this.Text = "FrmAula";
            this.Load += new System.EventHandler(this.FrmAula_Load);
            this.grpSinSala.ResumeLayout(false);
            this.grbEnSala.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.GroupBox grpSinSala;
        private System.Windows.Forms.GroupBox grbEnSala;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lstSinSala;
        private System.Windows.Forms.ListBox lstConSala;
    }
}