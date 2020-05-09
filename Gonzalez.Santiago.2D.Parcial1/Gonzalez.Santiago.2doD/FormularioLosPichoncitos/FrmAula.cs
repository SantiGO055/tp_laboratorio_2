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
using System.Media;

namespace FormularioLosPichoncitos
{
    public partial class FrmAula : Form
    {
        public FrmAula(FrmMenuPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.cmbColor.DataSource = Enum.GetValues(typeof(EColores));
            this.cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));
            this.lstSinSala.DataSource = frmPrincipal.listaAlumnos;
            //LlenarListaAlumnos(frmPrincipal);
            this.LlenarCmbDocentes(frmPrincipal);
            

            //this.cmbProfesor.DataSource = LlenarCmbDocentes(frmPrincipal);

        }

        private void LlenarListaAlumnos(FrmMenuPrincipal frmPrincipal)
        {
            foreach (var item in frmPrincipal.listaAlumnos)
            {
                if (!(item is null))
                {
                }

            }
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
            this.BackColor = Color.Orange;
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
                    btnGuardar.BackColor = Color.LightYellow;
                    break;
                case EColores.Rojo:
                    this.BackColor = Color.Red;
                    btnGuardar.BackColor = Color.LightPink;
                    break;
                case EColores.Amarillo:
                    this.BackColor = Color.Yellow;
                    btnGuardar.BackColor = Color.LightSalmon;
                    break;
                case EColores.Verde:
                    this.BackColor = Color.Green;
                    btnGuardar.BackColor = Color.LightSkyBlue;
                    break;
                default:
                    
                    break;
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"Sonido\upSound.wav");
            simpleSound.Play();
        }
    }
}
