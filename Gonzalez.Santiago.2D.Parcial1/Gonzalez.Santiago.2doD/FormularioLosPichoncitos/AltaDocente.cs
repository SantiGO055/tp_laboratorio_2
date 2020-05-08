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
    public partial class AltaDocente : Form
    {
        Docente docente;
        List<Docente> docentes;
        public AltaDocente()
        {
            InitializeComponent();
            docentes = new List<Docente>();
            this.MinimizeBox = false;
        }

        private void AltaDocente_Load(object sender, EventArgs e)
        {

        }


        private void btnAltaDocente_Click(object sender, EventArgs e)
        {
            DateTime dtIngreso = new DateTime();
            DateTime dtSalida = new DateTime();
            dtIngreso = dtpHoraIngreso.Value;
            dtSalida = dtpHoraSalida.Value;

            //int.Parse(txtDni.Text)
            if (ValidarCampos())
            {
                docente = new Docente(txtNombre.Text, txtApellido.Text,ValidarDni() , ValidarFemenino(), dtIngreso, dtSalida, (float)numValorHora.Value);
                if (!(docente is null))
                {
                    docentes.Add(docente);
                }
                this.DialogResult = DialogResult.OK;
                //this.Close();
            }
        }

        private bool ValidarCampos()
        {
            if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtDni.Text == string.Empty || (!(ValidarRadioButton())))
            {
                MessageBox.Show("Complete los campos Nombre, Apellido, DNI y Sexo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidarFemenino()
        {
            if (rdbtnFemenino.Checked == true)
            {
                return true;
            }
            else
                return false;
        }

        private bool ValidarRadioButton()
        {
            if (rdbtnFemenino.Checked == true || rdbtnMasculino.Checked == true)
            {
                return true;
            }
            return false;
        }
        private int ValidarDni()
        {
            int dniAux = 0;
            if (ValidarCampos())
            {
                int.TryParse(txtDni.Text, out dniAux);
                if(dniAux > 0)
                return dniAux;
            }
            return dniAux;
        }


    }
}
