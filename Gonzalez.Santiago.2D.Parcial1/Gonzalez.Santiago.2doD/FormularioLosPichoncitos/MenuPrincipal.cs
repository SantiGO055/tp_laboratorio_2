using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Media;
using System.Security.Cryptography;

namespace FormularioLosPichoncitos
{
    public partial class MenuPrincipal : Form
    {
        public List<Docente> docentes;

        public MenuPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.BackColor = Color.FromArgb(255, 232, 232);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que deea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void altaDeDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AltaDocente altaDocente = new AltaDocente();
            altaDocente.MdiParent = this;
            altaDocente.Show();
            SoundPlayer simpleSound = new SoundPlayer(@"Sonido\welcometothejungle.wav");
            simpleSound.Play();
            
            if (altaDocente.DialogResult == DialogResult.OK)
            {
                altaDocente.Visible = false;
                altaDocente.Dispose();
                this.IsMdiContainer = false;
            }
        }
    }
}
