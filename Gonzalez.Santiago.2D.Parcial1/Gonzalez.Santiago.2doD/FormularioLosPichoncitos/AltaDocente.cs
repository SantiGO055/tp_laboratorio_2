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
        public AltaDocente()
        {
            InitializeComponent();

        }

        private void AltaDocente_Load(object sender, EventArgs e)
        {

        }

        private void ntfAltaCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnAltaDocente_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                docente = new Docente(txtNombre.Text,txtApellido.Text,ValidarFemenino(), (DateTime)dtpHoraIngreso.Value, (DateTime)dtpHoraSalida.Value,)
            }
        }

        private bool ValidarCampos()
        {
            if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtDni.Text == string.Empty)
            {
                MessageBox.Show("Complete los campos nombre, apellido y DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private float ValidarValorPorHora()
        {
            float valorHora;
            if (float.Parse(txtValorHora.Text) > 0)
            {
                return valorHora;
            }
            
            return valorHora;
        }
    }
}
