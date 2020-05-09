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
    public partial class FrmAlta : Form
    {
        public Docente docente;
        public Administrativo administrativo;
        public Alumno alumno;
        public Responsable responsable;
        string tipo;
        public FrmAlta(string tipo)
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.tipo = tipo;
            //this.MdiParent = frmPrincipal;

        }

        private void AltaDocente_Load(object sender, EventArgs e)
        {
            ValidarTipo();

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
            if (rdbtnFemenino.Checked == true || rdbtnMasculino.Checked == true)
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
                if (dniAux > 0)
                    return dniAux;
            }
            return dniAux;
        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                this.RealizarAlta();
                this.DialogResult = DialogResult.OK;

                this.Close();

            }
        }
        public void RealizarAlta()
        {
            string tipoAlta;
            tipoAlta = ValidarTipo();
            switch (tipoAlta)
            {
                case "docente":

                    DateTime dtIngreso = new DateTime();
                    DateTime dtSalida = new DateTime();
                    dtIngreso = dtpHoraIngreso.Value;
                    dtSalida = dtpHoraSalida.Value;

                    docente = new Docente(txtNombre.Text, txtApellido.Text, ValidarDni(), ValidarFemenino(), dtIngreso, dtSalida, (float)numValorHora.Value);

                    MessageBox.Show("Alta realizada con exito.", "Se realizo el alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

                    break;

                case "administrativo":
                    ECargo cargo;
                    cargo = (ECargo)Enum.Parse(typeof(ECargo), cmbCargo.SelectedValue.ToString());
                    administrativo = new Administrativo(txtNombre.Text, txtApellido.Text, ValidarDni(), ValidarFemenino(), cargo);


                    MessageBox.Show("Alta realizada con exito.", "Se realizo el alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    break;
                case "alumno":
                    this.Text = "Alta de Alumno";
                    alumno = new Alumno(txtNombre.Text, txtApellido.Text, ValidarDni(), ValidarFemenino(), (float)numPrecioCuota.Value, responsable, ValidarLegajo());


                    MessageBox.Show("Alta realizada con exito. Dar de alta responsable", "Se realizo el alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmAlta frmAltas = new FrmAlta("responsable");

                    if (frmAltas.ShowDialog() == DialogResult.OK)
                    {
                        this.Hide();
                        this.DialogResult = DialogResult.OK;
                        frmAltas.DialogResult = DialogResult.OK;
                        MessageBox.Show("Alta realizada con exito", "Se realizo el alta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    break;
            }
        }

        private int ValidarLegajo()
        {
            int retorno = 0;
            if (!(txtLegajo.Text == string.Empty))
            {
                retorno = int.Parse(txtLegajo.Text);
                return retorno;
            }
            return retorno;
        }
        private string ValidarTipo()
        {
            string retorno = "";
            if (this.tipo == "docente")
            {
                this.Text = "Alta de Docente";
                grbAdministrativo.Visible = false;
                grbAltaDocente.Visible = true;
                grbResponsable.Visible = false;
                grbPrecioCuota.Visible = false;
                retorno = this.tipo;
            }
            else if (this.tipo == "administrativo")
            {
                this.Text = "Alta de Administrativo";
                grbAltaDocente.Visible = false;
                grbPrecioCuota.Visible = false;
                grbAdministrativo.Visible = true;
                grbResponsable.Visible = false;


                this.cmbCargo.DataSource = Enum.GetValues(typeof(ECargo));
                retorno = this.tipo;
            }
            else if (this.tipo == "alumno")
            {
                this.Text = "Alta de Alumno";
                grbAltaDocente.Visible = false;
                grbPrecioCuota.Visible = true;
                grbAdministrativo.Visible = false;
                grbResponsable.Visible = false;
                retorno = this.tipo;
            }
            else if (this.tipo == "responsable")
            {
                this.Text = "Alta de Responsable";
                grbAltaDocente.Visible = false;
                grbPrecioCuota.Visible = false;
                grbAdministrativo.Visible = false;
                grbResponsable.Visible = true;
                this.cmbParentesco.DataSource = Enum.GetValues(typeof(EParentesco));
                retorno = this.tipo;
            }
            return retorno;
        }

        private void frmAlta_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

    }
}
