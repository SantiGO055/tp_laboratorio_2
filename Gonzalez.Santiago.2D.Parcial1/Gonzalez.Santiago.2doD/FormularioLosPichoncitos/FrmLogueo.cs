using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioLosPichoncitos
{
    public partial class FrmLogueo : Form
    {
        public FrmLogueo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogueo_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin")
            {
                FrmMenuPrincipal frmPrincipal = new FrmMenuPrincipal();
                frmPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Ingrese usuario: admin. contraseña: admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
