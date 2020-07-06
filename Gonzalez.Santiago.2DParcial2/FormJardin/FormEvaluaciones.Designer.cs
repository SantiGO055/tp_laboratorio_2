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
            this.components = new System.ComponentModel.Container();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.txtAlumnoSiendoEvaluado = new System.Windows.Forms.TextBox();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.lblDocente = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTiempoTranscurrido = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
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
            // txtAlumnoSiendoEvaluado
            // 
            this.txtAlumnoSiendoEvaluado.Location = new System.Drawing.Point(38, 47);
            this.txtAlumnoSiendoEvaluado.Name = "txtAlumnoSiendoEvaluado";
            this.txtAlumnoSiendoEvaluado.ReadOnly = true;
            this.txtAlumnoSiendoEvaluado.Size = new System.Drawing.Size(500, 20);
            this.txtAlumnoSiendoEvaluado.TabIndex = 1;
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 252);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(569, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // lblTiempoTranscurrido
            // 
            this.lblTiempoTranscurrido.AutoSize = true;
            this.lblTiempoTranscurrido.Location = new System.Drawing.Point(35, 135);
            this.lblTiempoTranscurrido.Name = "lblTiempoTranscurrido";
            this.lblTiempoTranscurrido.Size = new System.Drawing.Size(106, 13);
            this.lblTiempoTranscurrido.TabIndex = 5;
            this.lblTiempoTranscurrido.Text = "Tiempo transcurrido: ";
            // 
            // FormEvaluaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(569, 274);
            this.Controls.Add(this.lblTiempoTranscurrido);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblDocente);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.txtAlumnoSiendoEvaluado);
            this.Controls.Add(this.lblAlumno);
            this.Name = "FormEvaluaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Evaluacion del alumno";
            this.Load += new System.EventHandler(this.FormEvaluaciones_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblDocente;
        public System.Windows.Forms.TextBox txtAlumnoSiendoEvaluado;
        public System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblTiempoTranscurrido;
    }
}