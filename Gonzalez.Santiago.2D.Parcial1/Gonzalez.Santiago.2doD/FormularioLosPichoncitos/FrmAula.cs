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
        public List<Alumno> listaDeAlumnos;

        public List<Aula> listaDeAulas;
        public Aula aula;
        EColores colorAula;
        ETurno turnoAula;
        List<Docente> listaDeDocentes;
        public Docente docenteMañana;
        public Docente docenteTarde;
        BindingSource bsDocenteMañana = new BindingSource();
        BindingSource bsDocenteTarde = new BindingSource();
        DateTime horaMañana = new DateTime(2020, 5, 11, 12, 00, 00);
        DateTime horaTarde = new DateTime(2020, 5, 11, 13, 00, 00);
        BindingSource bsSinAula = new BindingSource();
        BindingSource bsConAula = new BindingSource();
        bool primeraVez;
        public FrmAula(FrmMenuPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.cmbColor.DataSource = Enum.GetValues(typeof(EColores));
            this.cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));

            //listaAlumnosSinAula = listaAlumnos;
            listaDeAlumnos = frmPrincipal.listaAlumnos;
            listaDeAulas = frmPrincipal.listaDeAulas;

            listaDeDocentes = frmPrincipal.listaDocentes;

            //listaDeAulasMañana = frmPrincipal.listaDeAulas;
            //listaDeAulasTarde = frmPrincipal.listaDeAulas;



            MostrarListaAlumnosSinAula();


            //listaDeDocentesMañana = listaDocentes;
            //new List<Docente>();




        }

        private void MostrarListaAlumnosSinAula()
        {
            foreach (var item in listaDeAlumnos)
            {
                lstAlumnosSinAula.Items.Add(item);
            }
            //bsSinAula.DataSource = listaDeAlumnos;
            //lstAlumnosSinAula.DataSource = bsSinAula;


        }
        private void MostrarListaDocentesSinAulaMañana()
        {
            bsDocenteMañana.DataSource = null;
            bsDocenteMañana.DataSource = listaDeDocentes;
            lstAlumnosSinAula.DataSource = bsDocenteMañana;
        }


        public bool VerificarAlumnoEnListaAula(List<Aula> listaDeAulas)
        {
            foreach (var aula in listaDeAulas)
            {
                foreach (var alumno in listaDeAlumnos)
                {
                    if (!(aula is null) && aula.Alumnos.Contains(alumno))
                    {
                        return true;
                    }
                    else
                        return false;
                }

            }
            return false;
        }

        private void FrmAula_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }


        private void cmbColor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CambiarColorFondo();

        }

        private void CambiarColorFondo()
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
            //corroborar que se seleccione color, turno, profesor, y que la lista de alumnos con sala no sea vacia

            if (ValidarCampos())
            {
                //public static bool operator +(Aula aula, Alumno alumno)
                //public Aula(EColores colorSala, ETurno turno, Docente docente)

                List<Alumno> listaAux = new List<Alumno>(); ;
                colorAula = (EColores)Enum.Parse(typeof(EColores), cmbColor.SelectedValue.ToString());
                turnoAula = (ETurno)Enum.Parse(typeof(ETurno), cmbTurno.SelectedValue.ToString());
                //Alumno alumno = listaDeAlumnos[this.lstAlumnosConAula.SelectedIndex];


                if (this.lstDocenteSinAula.SelectedIndex != -1)
                {
                    if (ValidarTurnoSeleccionado().Equals(ETurno.Mañana))
                    {
                        Docente docenteMañana = listaDeDocentes[this.lstDocenteSinAula.SelectedIndex];
                        aula = new Aula(colorAula, turnoAula, docenteMañana);
                    }
                    else
                    {
                        Docente docenteTarde = listaDeDocentes[this.lstDocenteSinAula.SelectedIndex];
                        aula = new Aula(colorAula, turnoAula, docenteTarde);
                    }
                    foreach (var item in lstAlumnosConAula.Items)
                    {

                        if (aula + (Alumno)item) ;
                    }
                    this.listaDeAulas.Add(aula);

                }


                //listaAlumnosSinAula.Remove(alumno);



                this.DialogResult = DialogResult.OK;
            }


        }


        private bool ValidarCampos()
        {

            if (cmbColor.Text == string.Empty || cmbTurno.Text == string.Empty || listaDeAlumnos.Count <= 0)
            {
                MessageBox.Show("Seleccione un color de sala, un turno, un profesor y un alumno de la lista", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        public ETurno ValidarTurnoSeleccionado()
        {
            if (ETurno.Mañana.Equals(cmbTurno.SelectedItem))
            {

                //MostrarListaDocentesMañana(listaDeDocentesMañana);

                return ETurno.Mañana;

            }
            else
            {
                //MostrarListaDocentesTarde(listaDeDocentesTarde);

                return ETurno.Tarde;
            }
        }

        private void cmbTurno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //ETurno.Mañana.Equals(cmbTurno.SelectedItem);
            ValidarTurnoSeleccionado();

        }
        private bool MostrarListaDocentesMañana(Docente docentes)
        {

            if (docentes.HoraEntrada.Hour <= horaMañana.Hour)
            {
                //bsDocenteMañana.Add(docentes);
                lstDocenteSinAula.Items.Add(docentes);
                //lstDocenteSinAula.DataSource = bsDocenteMañana;
                return true;

                //lstDocenteSinAula.Items.Add(docentes.ToString());
            }
            return false;
        }
        private bool MostrarListaDocentesTarde(Docente docentes)
        {
            if (docentes.HoraEntrada.Hour >= horaTarde.Hour)
            {
                lstDocenteSinAula.Items.Add(docentes);
                //bsDocenteTarde.Add(docentes);
                //lstDocenteSinAula.DataSource = bsDocenteTarde;
                //lstDocenteSinAula.Items.Add(docentes.ToString());
                return true;
            }
            return false;
        }
        /// <summary>
        /// Valido y muestro si el docente no esta en la lista
        /// </summary>
        /// <param name="docente"></param>
        private void ValidarDocenteMañanaEnAula(Docente docente)
        {
            foreach (var itemAulas in listaDeAulas)
            {
                if (!(itemAulas.Docente.Equals(docente)))
                {
                    MostrarListaDocentesMañana(docente);
                }
            }
        }
        private void ValidarDocenteTardeEnAula(Docente docente)
        {
            foreach (var itemAulas in listaDeAulas)
            {
                if (!(itemAulas.Docente.Equals(docente)))
                {
                    MostrarListaDocentesTarde(docente);
                    break;
                }

            }

        }
        private void cmbTurno_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            //lstDocenteSinAula.Items.Clear();
            //bsDocenteMañana.DataSource = null;
            //lstDocenteSinAula.DataSource = null;
            lstDocenteSinAula.Items.Clear();
            if (ValidarTurnoSeleccionado() == ETurno.Mañana)
            {

                //lstDocenteSinAula.Items.Clear();
                //bsDocenteMañana.ResetBindings(false);
                
                    foreach (var itemDocentes in listaDeDocentes)
                    {
                        if (listaDeAulas.Count <= 0)
                        {
                            MostrarListaDocentesMañana(itemDocentes);
                        }
                        
                        else
                        {
                            ValidarDocenteMañanaEnAula(itemDocentes);
                        }
                    }
                

            }
            else
            {
                foreach (var itemDocentes in listaDeDocentes)
                {
                    if (listaDeAulas.Count <= 0)
                    {
                        MostrarListaDocentesTarde(itemDocentes);
                    }
                    else
                    {
                        ValidarDocenteTardeEnAula(itemDocentes);
                    }
                }
            }

        }

        private void btnPasarAAula_Click(object sender, EventArgs e)
        {

            Alumno alumno = (Alumno)lstAlumnosSinAula.SelectedItem;


            if (this.lstAlumnosSinAula.SelectedIndex != -1)
            {

                //MostrarListaAlumnosSinAula(listaDeAlumnos);
                //lstAlumnosConAula.Items.Add(alumno.ToString());
                foreach (var item in lstAlumnosSinAula.Items)
                {
                    if (item == lstAlumnosSinAula.SelectedItem)
                    {
                        lstAlumnosSinAula.Items.Remove(item);
                        //bsSinAula.Remove(item);
                        //lstAlumnosSinAula.DataSource = bsSinAula;
                        lstAlumnosConAula.Items.Add(item);
                        break;
                    }
                }
                //bsConAula.Add(alumno);

                //lstAlumnosConAula.DataSource = bsConAula;
            }


        }

        private void btnDevolverASinAula_Click(object sender, EventArgs e)
        {

            Alumno alumno = (Alumno)lstAlumnosConAula.SelectedItem;


            if (this.lstAlumnosConAula.SelectedIndex != -1)
            {

                //MostrarListaAlumnosSinAula(listaDeAlumnos);
                //lstAlumnosConAula.Items.Add(alumno.ToString());
                foreach (var item in lstAlumnosConAula.Items)
                {
                    if (item == lstAlumnosConAula.SelectedItem)
                    {
                        lstAlumnosSinAula.Items.Add(item);
                        lstAlumnosConAula.Items.Remove(item);
                        //bsConAula.Remove(item);
                        //lstAlumnosConAula.DataSource = bsConAula;
                        break;
                    }
                }
                //bsSinAula.Add(alumno);


                //lstAlumnosSinAula.DataSource = bsSinAula;
                //lstAlumnosSinAula.DataSource = bsSinAula;

                //bsConAula.DataSource = null;
                //bsConAula.DataSource = alumno;
                //lstAlumnosConAula.DataSource = bsConAula;
            }
        }
    }
}
