namespace FormJardin
{
    partial class FormAlumnos
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
            this.components = new System.ComponentModel.Container();
            this.dataGridAlumnos = new System.Windows.Forms.DataGridView();
            this.txtProximoAlumno = new System.Windows.Forms.TextBox();
            this.lblProximo = new System.Windows.Forms.Label();
            this.lblCantidadFijo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.timerEvaluacion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAlumnos
            // 
            this.dataGridAlumnos.AllowUserToAddRows = false;
            this.dataGridAlumnos.AllowUserToDeleteRows = false;
            this.dataGridAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAlumnos.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumnos.Location = new System.Drawing.Point(12, 12);
            this.dataGridAlumnos.MultiSelect = false;
            this.dataGridAlumnos.Name = "dataGridAlumnos";
            this.dataGridAlumnos.ReadOnly = true;
            this.dataGridAlumnos.RowHeadersVisible = false;
            this.dataGridAlumnos.Size = new System.Drawing.Size(559, 230);
            this.dataGridAlumnos.TabIndex = 0;
            // 
            // txtProximoAlumno
            // 
            this.txtProximoAlumno.Location = new System.Drawing.Point(26, 362);
            this.txtProximoAlumno.Name = "txtProximoAlumno";
            this.txtProximoAlumno.Size = new System.Drawing.Size(501, 20);
            this.txtProximoAlumno.TabIndex = 5;
            // 
            // lblProximo
            // 
            this.lblProximo.AutoSize = true;
            this.lblProximo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximo.Location = new System.Drawing.Point(23, 334);
            this.lblProximo.Name = "lblProximo";
            this.lblProximo.Size = new System.Drawing.Size(175, 14);
            this.lblProximo.TabIndex = 6;
            this.lblProximo.Text = "Proximo alumno a evaluar:";
            // 
            // lblCantidadFijo
            // 
            this.lblCantidadFijo.AutoSize = true;
            this.lblCantidadFijo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadFijo.Location = new System.Drawing.Point(23, 262);
            this.lblCantidadFijo.Name = "lblCantidadFijo";
            this.lblCantidadFijo.Size = new System.Drawing.Size(214, 14);
            this.lblCantidadFijo.TabIndex = 7;
            this.lblCantidadFijo.Text = "Cantidad de alumnos en espera:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Red;
            this.lblCantidad.Location = new System.Drawing.Point(243, 262);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 14);
            this.lblCantidad.TabIndex = 9;
            // 
            // timerEvaluacion
            // 
            this.timerEvaluacion.Interval = 1000;
            this.timerEvaluacion.Tick += new System.EventHandler(this.timerEvaluacion_Tick);
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(611, 461);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCantidadFijo);
            this.Controls.Add(this.lblProximo);
            this.Controls.Add(this.txtProximoAlumno);
            this.Controls.Add(this.dataGridAlumnos);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "FormAlumnos";
            this.Text = "Alumnos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAlumnos_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAlumnos;
        private System.Windows.Forms.TextBox txtProximoAlumno;
        private System.Windows.Forms.Label lblProximo;
        private System.Windows.Forms.Label lblCantidadFijo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Timer timerEvaluacion;
    }
}

