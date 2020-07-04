namespace FormJardin
{
    partial class FormEvaluaciones
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
            this.lblAlumno = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.lblDocente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(256, 31);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(42, 13);
            this.lblAlumno.TabIndex = 0;
            this.lblAlumno.Text = "Alumno";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(38, 47);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.ReadOnly = true;
            this.txtAlumno.Size = new System.Drawing.Size(500, 20);
            this.txtAlumno.TabIndex = 1;
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(38, 95);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.ReadOnly = true;
            this.txtDocente.Size = new System.Drawing.Size(500, 20);
            this.txtDocente.TabIndex = 2;
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(224, 79);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(118, 13);
            this.lblDocente.TabIndex = 3;
            this.lblDocente.Text = "Evaluado por docente: ";
            // 
            // FormEvaluaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.lblAlumno);
            this.Name = "FormEvaluaciones";
            this.Text = "FormEvaluaciones";
            this.Load += new System.EventHandler(this.FormEvaluaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblDocente;
        public System.Windows.Forms.TextBox txtAlumno;
        public System.Windows.Forms.TextBox txtDocente;
    }
}