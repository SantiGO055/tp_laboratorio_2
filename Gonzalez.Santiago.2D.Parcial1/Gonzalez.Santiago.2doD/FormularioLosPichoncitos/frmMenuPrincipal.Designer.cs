namespace FormularioLosPichoncitos
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAutomaticamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.video1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.video2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.video3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAutomaticamenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lstAulas = new System.Windows.Forms.ListBox();
            this.lstAdministrativos = new System.Windows.Forms.ListBox();
            this.lblAulas = new System.Windows.Forms.Label();
            this.lblAdministrativos = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.másToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeDocenteToolStripMenuItem,
            this.altaDeNoDocenteToolStripMenuItem,
            this.altaAlumnoToolStripMenuItem,
            this.altaDeAulaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // altaDeDocenteToolStripMenuItem
            // 
            this.altaDeDocenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAutomaticamenteToolStripMenuItem});
            this.altaDeDocenteToolStripMenuItem.Name = "altaDeDocenteToolStripMenuItem";
            this.altaDeDocenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeDocenteToolStripMenuItem.Text = "Alta de docente";
            this.altaDeDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaDeDocenteToolStripMenuItem_Click);
            // 
            // crearAutomaticamenteToolStripMenuItem
            // 
            this.crearAutomaticamenteToolStripMenuItem.Name = "crearAutomaticamenteToolStripMenuItem";
            this.crearAutomaticamenteToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.crearAutomaticamenteToolStripMenuItem.Text = "Crear automaticamente";
            this.crearAutomaticamenteToolStripMenuItem.Click += new System.EventHandler(this.crearAutomaticamenteToolStripMenuItem_Click);
            // 
            // altaDeNoDocenteToolStripMenuItem
            // 
            this.altaDeNoDocenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAutomaticamenteToolStripMenuItem1});
            this.altaDeNoDocenteToolStripMenuItem.Name = "altaDeNoDocenteToolStripMenuItem";
            this.altaDeNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeNoDocenteToolStripMenuItem.Text = "Alta de no docente";
            this.altaDeNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaDeNoDocenteToolStripMenuItem_Click);
            // 
            // altaAlumnoToolStripMenuItem
            // 
            this.altaAlumnoToolStripMenuItem.Name = "altaAlumnoToolStripMenuItem";
            this.altaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaAlumnoToolStripMenuItem.Text = "Alta alumno";
            this.altaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnoToolStripMenuItem_Click);
            // 
            // altaDeAulaToolStripMenuItem
            // 
            this.altaDeAulaToolStripMenuItem.Name = "altaDeAulaToolStripMenuItem";
            this.altaDeAulaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeAulaToolStripMenuItem.Text = "Alta de aula";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // másToolStripMenuItem
            // 
            this.másToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.video1ToolStripMenuItem,
            this.video2ToolStripMenuItem,
            this.video3ToolStripMenuItem});
            this.másToolStripMenuItem.Name = "másToolStripMenuItem";
            this.másToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.másToolStripMenuItem.Text = "Más";
            // 
            // video1ToolStripMenuItem
            // 
            this.video1ToolStripMenuItem.Name = "video1ToolStripMenuItem";
            this.video1ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.video1ToolStripMenuItem.Text = "Video1";
            // 
            // video2ToolStripMenuItem
            // 
            this.video2ToolStripMenuItem.Name = "video2ToolStripMenuItem";
            this.video2ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.video2ToolStripMenuItem.Text = "Video2";
            // 
            // video3ToolStripMenuItem
            // 
            this.video3ToolStripMenuItem.Name = "video3ToolStripMenuItem";
            this.video3ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.video3ToolStripMenuItem.Text = "Video3";
            // 
            // crearAutomaticamenteToolStripMenuItem1
            // 
            this.crearAutomaticamenteToolStripMenuItem1.Name = "crearAutomaticamenteToolStripMenuItem1";
            this.crearAutomaticamenteToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.crearAutomaticamenteToolStripMenuItem1.Text = "Crear automaticamente";
            this.crearAutomaticamenteToolStripMenuItem1.Click += new System.EventHandler(this.crearAutomaticamenteToolStripMenuItem1_Click);
            // 
            // lstAulas
            // 
            this.lstAulas.BackColor = System.Drawing.Color.Wheat;
            this.lstAulas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lstAulas.FormattingEnabled = true;
            this.lstAulas.Location = new System.Drawing.Point(29, 77);
            this.lstAulas.Name = "lstAulas";
            this.lstAulas.Size = new System.Drawing.Size(296, 173);
            this.lstAulas.TabIndex = 1;
            // 
            // lstAdministrativos
            // 
            this.lstAdministrativos.BackColor = System.Drawing.Color.Wheat;
            this.lstAdministrativos.FormattingEnabled = true;
            this.lstAdministrativos.Location = new System.Drawing.Point(421, 77);
            this.lstAdministrativos.Name = "lstAdministrativos";
            this.lstAdministrativos.Size = new System.Drawing.Size(296, 173);
            this.lstAdministrativos.TabIndex = 2;
            // 
            // lblAulas
            // 
            this.lblAulas.AutoSize = true;
            this.lblAulas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAulas.Location = new System.Drawing.Point(63, 50);
            this.lblAulas.Name = "lblAulas";
            this.lblAulas.Size = new System.Drawing.Size(68, 14);
            this.lblAulas.TabIndex = 7;
            this.lblAulas.Text = "Docentes";
            // 
            // lblAdministrativos
            // 
            this.lblAdministrativos.AutoSize = true;
            this.lblAdministrativos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrativos.Location = new System.Drawing.Point(465, 50);
            this.lblAdministrativos.Name = "lblAdministrativos";
            this.lblAdministrativos.Size = new System.Drawing.Size(110, 14);
            this.lblAdministrativos.TabIndex = 8;
            this.lblAdministrativos.Text = "Administrativos";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAdministrativos);
            this.Controls.Add(this.lblAulas);
            this.Controls.Add(this.lstAdministrativos);
            this.Controls.Add(this.lstAulas);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem másToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearAutomaticamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem video1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem video2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem video3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearAutomaticamenteToolStripMenuItem1;
        private System.Windows.Forms.ListBox lstAulas;
        private System.Windows.Forms.ListBox lstAdministrativos;
        private System.Windows.Forms.Label lblAulas;
        private System.Windows.Forms.Label lblAdministrativos;
    }
}

