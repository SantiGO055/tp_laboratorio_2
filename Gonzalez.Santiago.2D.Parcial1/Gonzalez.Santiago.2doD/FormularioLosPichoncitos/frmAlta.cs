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
        public List<Alumno> listaAlumnos;
        public List<Responsable> listaResponsable;
        string tipo;
        public FrmAlta(string tipo) : this()
        {

            this.MinimizeBox = false;
            this.tipo = tipo;
            listaResponsable = new List<Responsable>();

            //this.MdiParent = frmPrincipal;

        }
        public FrmAlta()
        {
            InitializeComponent();
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
            switch (this.tipo)
            {
                case "docente":

                    DateTime dtIngreso = new DateTime();
                    DateTime dtSalida = new DateTime();
                    dtIngreso = dtpHoraIngreso.Value;
                    dtSalida = dtpHoraSalida.Value;
                    dtpHoraIngreso.TabIndex = 6;
                    dtpHoraSalida.TabIndex = 7;
                    numValorHora.TabIndex = 8;
                    btnAlta.TabIndex = 9;

                    docente = new Docente(txtNombre.Text, txtApellido.Text, ValidarDni(), ValidarFemenino(), dtIngreso, dtSalida, (float)numValorHora.Value);

                    MessageBox.Show("Alta realizada con exito.", "Se realizo el alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

                    break;

                case "administrativo":
                    ECargo cargo;
                    cmbCargo.TabIndex = 6;
                    btnAlta.TabIndex = 7;
                    cargo = (ECargo)Enum.Parse(typeof(ECargo), cmbCargo.SelectedValue.ToString());
                    administrativo = new Administrativo(txtNombre.Text, txtApellido.Text, ValidarDni(), ValidarFemenino(), cargo);


                    MessageBox.Show("Alta realizada con exito.", "Se realizo el alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    break;

                //case "alumno":
                    //si meto aca el alumno dado de alta: alumno = new alumno(etc...) no me toma el responsable para el alumno

                //    break;
                case "responsable":
                    //doy de alta el responsable y a la vez el alumno
                    EParentesco parentesco;
                    this.Hide();
                    parentesco = (EParentesco)Enum.Parse(typeof(EParentesco), cmbParentesco.SelectedItem.ToString());
                    responsable = new Responsable(txtNombre.Text, txtApellido.Text, ValidarDni(), ValidarFemenino(), parentesco, ValidarTelefono());
                    MessageBox.Show("Alta realizada con exito. Dar de alta alumno", "Se realizo el alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //listaResponsable.Add(responsable);
                    FrmAlta frmAltaAlumno = new FrmAlta("alumno");
                    if (frmAltaAlumno.ShowDialog() == DialogResult.OK)
                    {
                        
                        float prueba = (float)numPrecioCuota.Value;
                        //si meto aca el alumno dado de alta: alumno = new alumno(etc...) no me toma el numPrecioCuota.Vlue
                        alumno = new Alumno(txtNombre.Text, txtApellido.Text, ValidarDni(), ValidarFemenino(), (float)numPrecioCuota.Value, responsable, ValidarLegajo());
                        MessageBox.Show("Alta realizada con exito. Dar de alta responsable", "Se realizo el alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;
            }
        }

        /// <summary>
        /// Valida el telefono ingresado
        /// </summary>
        /// <returns></returns>
        private string ValidarTelefono()
        {
            string retorno = "";
            if (!(txtTelefono.Text == string.Empty))
            {
                retorno = (txtTelefono.Text.ToString());
                return retorno;
            }
            return retorno;
        }
        /// <summary>
        /// Valida el legajo ingresado
        /// </summary>
        /// <returns></returns>
        private int ValidarLegajo()
        {
            int retorno = 0;
            if (!(txtLegajo.Text == string.Empty) && (!(txtLegajo.Text is string)))
            {
                retorno = int.Parse(txtLegajo.Text);
                return retorno;
            }
            return retorno;
        }
        private string AltaDeCampos()
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
                cmbParentesco.TabIndex = 6;
                txtTelefono.TabIndex = 7;
                btnAlta.TabIndex = 9;
                grbAltaDocente.Visible = false;
                grbPrecioCuota.Visible = false;
                grbAdministrativo.Visible = false;
                grbResponsable.Visible = true;
                foreach (var item in Enum.GetValues(typeof(EParentesco)))
                {
                    cmbParentesco.Items.Add(item);
                }
                //this.cmbParentesco.DataSource = Enum.GetValues(typeof(EParentesco));
                retorno = this.tipo;
            }
            return retorno;
        }


        private void frmAlta_FormClosing(object sender, FormClosingEventArgs e)
        {


        }


        private void Alta_Load(object sender, EventArgs e)
        {

        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            AltaDeCampos();
        }
    }
}
