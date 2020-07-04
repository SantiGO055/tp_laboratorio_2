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
            this.dataGridAlumnos = new System.Windows.Forms.DataGridView();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.dataGridProximo = new System.Windows.Forms.DataGridView();
            this.lblEspera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProximo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAlumnos
            // 
            this.dataGridAlumnos.AllowUserToAddRows = false;
            this.dataGridAlumnos.AllowUserToDeleteRows = false;
            this.dataGridAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumnos.Location = new System.Drawing.Point(12, 12);
            this.dataGridAlumnos.MultiSelect = false;
            this.dataGridAlumnos.Name = "dataGridAlumnos";
            this.dataGridAlumnos.ReadOnly = true;
            this.dataGridAlumnos.RowHeadersVisible = false;
            this.dataGridAlumnos.Size = new System.Drawing.Size(559, 230);
            this.dataGridAlumnos.TabIndex = 0;
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(359, 258);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(75, 23);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "button1";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // dataGridProximo
            // 
            this.dataGridProximo.AllowUserToAddRows = false;
            this.dataGridProximo.AllowUserToDeleteRows = false;
            this.dataGridProximo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProximo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridProximo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProximo.Location = new System.Drawing.Point(12, 306);
            this.dataGridProximo.MultiSelect = false;
            this.dataGridProximo.Name = "dataGridProximo";
            this.dataGridProximo.ReadOnly = true;
            this.dataGridProximo.RowHeadersVisible = false;
            this.dataGridProximo.Size = new System.Drawing.Size(560, 110);
            this.dataGridProximo.TabIndex = 3;
            // 
            // lblEspera
            // 
            this.lblEspera.AutoSize = true;
            this.lblEspera.Location = new System.Drawing.Point(23, 258);
            this.lblEspera.Name = "lblEspera";
            this.lblEspera.Size = new System.Drawing.Size(162, 13);
            this.lblEspera.TabIndex = 4;
            this.lblEspera.Text = "Cantidad de alumnos en espera: ";
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.lblEspera);
            this.Controls.Add(this.dataGridProximo);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.dataGridAlumnos);
            this.Name = "FormAlumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProximo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAlumnos;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.DataGridView dataGridProximo;
        private System.Windows.Forms.Label lblEspera;
    }
}

