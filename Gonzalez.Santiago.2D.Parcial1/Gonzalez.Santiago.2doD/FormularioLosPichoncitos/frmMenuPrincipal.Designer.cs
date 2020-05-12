namespace FormularioLosPichoncitos
{
    partial class FrmMenuPrincipal
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
            this.crearAutomaticamenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDePadresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionPorAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionTotalDelJardinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.video1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstAulas = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
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
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
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
            // crearAutomaticamenteToolStripMenuItem1
            // 
            this.crearAutomaticamenteToolStripMenuItem1.Name = "crearAutomaticamenteToolStripMenuItem1";
            this.crearAutomaticamenteToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.crearAutomaticamenteToolStripMenuItem1.Text = "Crear automaticamente";
            this.crearAutomaticamenteToolStripMenuItem1.Click += new System.EventHandler(this.crearAutomaticamenteToolStripMenuItem1_Click);
            // 
            // altaAlumnoToolStripMenuItem
            // 
            this.altaAlumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem});
            this.altaAlumnoToolStripMenuItem.Name = "altaAlumnoToolStripMenuItem";
            this.altaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaAlumnoToolStripMenuItem.Text = "Alta alumno";
            this.altaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnoToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.crearToolStripMenuItem.Text = "Crear automaticamente";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // altaDeAulaToolStripMenuItem
            // 
            this.altaDeAulaToolStripMenuItem.Name = "altaDeAulaToolStripMenuItem";
            this.altaDeAulaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeAulaToolStripMenuItem.Text = "Alta de aula";
            this.altaDeAulaToolStripMenuItem.Click += new System.EventHandler(this.altaDeAulaToolStripMenuItem_Click);
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
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionDePadresToolStripMenuItem,
            this.sueldoDocenteToolStripMenuItem,
            this.sueldoNoDocenteToolStripMenuItem,
            this.recaudacionPorAulaToolStripMenuItem,
            this.recaudacionTotalDelJardinToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // informacionDePadresToolStripMenuItem
            // 
            this.informacionDePadresToolStripMenuItem.Name = "informacionDePadresToolStripMenuItem";
            this.informacionDePadresToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.informacionDePadresToolStripMenuItem.Text = "Informacion de padres";
            this.informacionDePadresToolStripMenuItem.Click += new System.EventHandler(this.informacionDePadresToolStripMenuItem_Click);
            // 
            // sueldoDocenteToolStripMenuItem
            // 
            this.sueldoDocenteToolStripMenuItem.Name = "sueldoDocenteToolStripMenuItem";
            this.sueldoDocenteToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.sueldoDocenteToolStripMenuItem.Text = "Sueldo Docente";
            this.sueldoDocenteToolStripMenuItem.Click += new System.EventHandler(this.sueldoDocenteToolStripMenuItem_Click);
            // 
            // sueldoNoDocenteToolStripMenuItem
            // 
            this.sueldoNoDocenteToolStripMenuItem.Name = "sueldoNoDocenteToolStripMenuItem";
            this.sueldoNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.sueldoNoDocenteToolStripMenuItem.Text = "Sueldo No Docente";
            this.sueldoNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.sueldoNoDocenteToolStripMenuItem_Click);
            // 
            // recaudacionPorAulaToolStripMenuItem
            // 
            this.recaudacionPorAulaToolStripMenuItem.Name = "recaudacionPorAulaToolStripMenuItem";
            this.recaudacionPorAulaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.recaudacionPorAulaToolStripMenuItem.Text = "Recaudacion por aula";
            this.recaudacionPorAulaToolStripMenuItem.Click += new System.EventHandler(this.recaudacionPorAulaToolStripMenuItem_Click);
            // 
            // recaudacionTotalDelJardinToolStripMenuItem
            // 
            this.recaudacionTotalDelJardinToolStripMenuItem.Name = "recaudacionTotalDelJardinToolStripMenuItem";
            this.recaudacionTotalDelJardinToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.recaudacionTotalDelJardinToolStripMenuItem.Text = "Recaudacion total del jardin";
            this.recaudacionTotalDelJardinToolStripMenuItem.Click += new System.EventHandler(this.recaudacionTotalDelJardinToolStripMenuItem_Click);
            // 
            // másToolStripMenuItem
            // 
            this.másToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.video1ToolStripMenuItem});
            this.másToolStripMenuItem.Name = "másToolStripMenuItem";
            this.másToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.másToolStripMenuItem.Text = "Más";
            // 
            // video1ToolStripMenuItem
            // 
            this.video1ToolStripMenuItem.Name = "video1ToolStripMenuItem";
            this.video1ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.video1ToolStripMenuItem.Text = "Video";
            this.video1ToolStripMenuItem.Click += new System.EventHandler(this.video1ToolStripMenuItem_Click);
            // 
            // lstAulas
            // 
            this.lstAulas.BackColor = System.Drawing.Color.LightBlue;
            this.lstAulas.FormattingEnabled = true;
            this.lstAulas.Location = new System.Drawing.Point(12, 52);
            this.lstAulas.Name = "lstAulas";
            this.lstAulas.ScrollAlwaysVisible = true;
            this.lstAulas.Size = new System.Drawing.Size(765, 368);
            this.lstAulas.TabIndex = 1;
            this.lstAulas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstAulas_MouseClick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(42, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 14);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Lista de aulas";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lstAulas);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menu Principal";
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
        private System.Windows.Forms.ToolStripMenuItem crearAutomaticamenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ListBox lstAulas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolStripMenuItem informacionDePadresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionPorAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionTotalDelJardinToolStripMenuItem;
    }
}

