using Entidades;
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
    public partial class FrmAula : Form
    {
        public FrmAula(FrmMenuPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.cmbColor.DataSource = Enum.GetValues(typeof(EColores));
            this.cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));

            this.LlenarCmbDocentes(frmPrincipal);
            //this.cmbProfesor.DataSource = LlenarCmbDocentes(frmPrincipal);

        }

        private void LlenarCmbDocentes(FrmMenuPrincipal frmPrincipal)
        {
            foreach (var item in frmPrincipal.listaDocentes)
            {
                if (!(item is null))
                {
                    cmbProfesor.Items.Add(item.Nombre + " " + item.Apellido);
                }
                
            }
        }

        private void FrmAula_Load(object sender, EventArgs e)
        {
            
        }

        private void rtbSinSala_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbColor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EColores colorFondo = (EColores)cmbColor.SelectedItem;
            switch (colorFondo)
            {
                case EColores.Naranja:
                    this.BackColor = Color.Orange;
                    break;
                case EColores.Rojo:
                    this.BackColor = Color.Red;
                    break;
                case EColores.Amarillo:
                    this.BackColor = Color.Yellow;
                    break;
                case EColores.Verde:
                    this.BackColor = Color.Green;
                    break;
                default:
                    break;
            }
            
        }
    }
}
