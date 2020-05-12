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
    public partial class FrmAltaAlumno : Form
    {
        FrmAlta frmAlta;
        public Alumno alumno;
        public FrmAltaAlumno(FrmAlta frmAlta)
        {
            InitializeComponent();
            this.frmAlta = frmAlta;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            //intente dar de alta los alumnos en otro formulario pero no me toma los metodos de validar ya que tendria que pasarle por parametro los textbox y redefinir las funciones en el form FrmAlta

            //float prueba = (float)numPrecioCuota.Value;
            //alumno = new Alumno(txtNombre.Text, txtApellido.Text, this.frmAlta.ValidarDni(), this.frmAlta.ValidarFemenino(), (float)numPrecioCuota.Value, this.frmAlta.responsable, this.frmAlta.ValidarLegajo());
            //MessageBox.Show("Alta realizada con exito. Dar de alta responsable", "Se realizo el alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.DialogResult = DialogResult.OK;
        }
    }
}
