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
            this.grpSinAula = new System.Windows.Forms.GroupBox();
            this.lstAlumnosSinAula = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grbConAula = new System.Windows.Forms.GroupBox();
            this.lstAlumnosConAula = new System.Windows.Forms.ListBox();
            this.btnPasarAAula = new System.Windows.Forms.Button();
            this.btnDevolverASinAula = new System.Windows.Forms.Button();
            this.cmbDocente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSinAula.SuspendLayout();
            this.grbConAula.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(236, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Turno";
            // 
            // cmbTurno
            // 
            this.cmbTurno.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(310, 22);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(92, 21);
            this.cmbTurno.TabIndex = 17;
            this.cmbTurno.SelectionChangeCommitted += new System.EventHandler(this.cmbTurno_SelectionChangeCommitted_1);
            // 
            // grpSinAula
            // 
            this.grpSinAula.Controls.Add(this.lstAlumnosSinAula);
            this.grpSinAula.Location = new System.Drawing.Point(22, 68);
            this.grpSinAula.Name = "grpSinAula";
            this.grpSinAula.Size = new System.Drawing.Size(317, 345);
            this.grpSinAula.TabIndex = 20;
            this.grpSinAula.TabStop = false;
            this.grpSinAula.Text = "Total de alumnos";
            // 
            // lstAlumnosSinAula
            // 
            this.lstAlumnosSinAula.AllowDrop = true;
            this.lstAlumnosSinAula.FormattingEnabled = true;
            this.lstAlumnosSinAula.HorizontalScrollbar = true;
            this.lstAlumnosSinAula.Location = new System.Drawing.Point(15, 34);
            this.lstAlumnosSinAula.Name = "lstAlumnosSinAula";
            this.lstAlumnosSinAula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstAlumnosSinAula.ScrollAlwaysVisible = true;
            this.lstAlumnosSinAula.Size = new System.Drawing.Size(285, 290);
            this.lstAlumnosSinAula.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(414, 440);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(317, 27);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grbConAula
            // 
            this.grbConAula.Controls.Add(this.lstAlumnosConAula);
            this.grbConAula.Location = new System.Drawing.Point(414, 68);
            this.grbConAula.Name = "grbConAula";
            this.grbConAula.Size = new System.Drawing.Size(317, 345);
            this.grbConAula.TabIndex = 23;
            this.grbConAula.TabStop = false;
            this.grbConAula.Text = "Alumnos a cargar";
            // 
            // lstAlumnosConAula
            // 
            this.lstAlumnosConAula.AllowDrop = true;
            this.lstAlumnosConAula.FormattingEnabled = true;
            this.lstAlumnosConAula.HorizontalScrollbar = true;
            this.lstAlumnosConAula.Location = new System.Drawing.Point(16, 35);
            this.lstAlumnosConAula.Name = "lstAlumnosConAula";
            this.lstAlumnosConAula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstAlumnosConAula.ScrollAlwaysVisible = true;
            this.lstAlumnosConAula.Size = new System.Drawing.Size(285, 290);
            this.lstAlumnosConAula.TabIndex = 2;
            // 
            // btnPasarAAula
            // 
            this.btnPasarAAula.Location = new System.Drawing.Point(349, 110);
            this.btnPasarAAula.Name = "btnPasarAAula";
            this.btnPasarAAula.Size = new System.Drawing.Size(53, 30);
            this.btnPasarAAula.TabIndex = 24;
            this.btnPasarAAula.Text = "----->";
            this.btnPasarAAula.UseVisualStyleBackColor = true;
            this.btnPasarAAula.Click += new System.EventHandler(this.btnPasarAAula_Click);
            // 
            // btnDevolverASinAula
            // 
            this.btnDevolverASinAula.Location = new System.Drawing.Point(349, 156);
            this.btnDevolverASinAula.Name = "btnDevolverASinAula";
            this.btnDevolverASinAula.Size = new System.Drawing.Size(53, 30);
            this.btnDevolverASinAula.TabIndex = 25;
            this.btnDevolverASinAula.Text = "<-----";
            this.btnDevolverASinAula.UseVisualStyleBackColor = true;
            this.btnDevolverASinAula.Click += new System.EventHandler(this.btnDevolverASinAula_Click);
            // 
            // cmbDocente
            // 
            this.cmbDocente.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbDocente.FormattingEnabled = true;
            this.cmbDocente.Location = new System.Drawing.Point(568, 22);
            this.cmbDocente.Name = "cmbDocente";
            this.cmbDocente.Size = new System.Drawing.Size(147, 21);
            this.cmbDocente.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 27;
            this.label2.Text = "Docente";
            // 
            // FrmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDocente);
            this.Controls.Add(this.btnDevolverASinAula);
            this.Controls.Add(this.btnPasarAAula);
            this.Controls.Add(this.grbConAula);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpSinAula);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmAula";
            this.Text = "FrmAula";
            this.Load += new System.EventHandler(this.FrmAula_Load);
            this.grpSinAula.ResumeLayout(false);
            this.grbConAula.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.GroupBox grpSinAula;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lstAlumnosSinAula;
        private System.Windows.Forms.GroupBox grbConAula;
        private System.Windows.Forms.ListBox lstAlumnosConAula;
        private System.Windows.Forms.Button btnPasarAAula;
        private System.Windows.Forms.Button btnDevolverASinAula;
        private System.Windows.Forms.ComboBox cmbDocente;
        private System.Windows.Forms.Label label2;
    }
}