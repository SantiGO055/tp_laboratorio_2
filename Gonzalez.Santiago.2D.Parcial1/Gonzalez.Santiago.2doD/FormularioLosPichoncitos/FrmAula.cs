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
        List<Alumno> listaAlumnosSinAula;
        List<Alumno> listaConAula;
        public List<Aula> listaDeAulas;
        public Aula aula;
        EColores colorAula;
        ETurno turnoAula;
        List<Docente> listaDeDocentesMañana;
        List<Docente> listaDeDocentesTarde;
        List<Docente> listaDeDocentes;
        BindingSource bsSinAula = new BindingSource();
        BindingSource bsDocentesMañana = new BindingSource();
        BindingSource bsDocentesTarde = new BindingSource();
        Docente docenteMañana;
        Docente docenteTarde;
        public FrmAula(List<Aula> listaDeAulas, List<Alumno> listaAlumnos, List<Docente> listaDocentes)
        {
            InitializeComponent();
            this.cmbColor.DataSource = Enum.GetValues(typeof(EColores));
            this.cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));

            //listaAlumnosSinAula = listaAlumnos;
            listaAlumnosSinAula = listaAlumnos;

            listaDeDocentes = listaDocentes;
            listaDeDocentesMañana = listaDocentes;
                //new List<Docente>();
            listaDeDocentesTarde = new List<Docente>();
            MostrarListaAlumnosSinAula(listaAlumnosSinAula);


        }

        public void PruebaDocente(List<Aula> listaDeAulas)
        {
            foreach (var item in listaDeAulas)
            {
                if (item.Docente == docenteMañana && item.Turno == ETurno.Mañana)
                {
                    
                }
            }
            
        }
        private void MostrarListaAlumnosSinAula(List<Alumno> listaAlumnos)
        {
            bsSinAula.DataSource = listaAlumnos;
            lstSinAula.DataSource = bsSinAula;
            
        }
        private void MostrarListaDocentesSinAula(List<Docente> listaDeDocentes)
        {
            
            bsDocentesMañana.DataSource = listaDeDocentes;
            lstDocenteSinAula.DataSource = bsDocentesMañana;
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

                
                colorAula = (EColores)Enum.Parse(typeof(EColores), cmbColor.SelectedValue.ToString());
                turnoAula = (ETurno)Enum.Parse(typeof(ETurno), cmbTurno.SelectedValue.ToString());

                if (this.lstDocenteSinAula.SelectedIndex != -1)
                {
                    if (ValidarTurnoSeleccionado().Equals(ETurno.Mañana))
                    {
                        Docente docenteMañana = listaDeDocentesMañana[this.lstDocenteSinAula.SelectedIndex];
                        listaDeDocentesMañana.Remove(docenteMañana);
                        bsDocentesMañana.ResetBindings(true);
                        //listaDocentesConAula.Add()
                        //listaDeDocentesTarde.Add(docenteTarde);
                        aula = new Aula(colorAula, turnoAula, docenteMañana);
                    }
                    else
                    {
                        Docente docenteTarde = listaDeDocentesTarde[this.lstDocenteSinAula.SelectedIndex];
                        //listaDeDocentesTarde.Remove(docenteTarde);
                        aula = new Aula(colorAula, turnoAula, docenteTarde);
                    }
                    
                }
                Alumno alumno = listaAlumnosSinAula[this.lstSinAula.SelectedIndex];
                listaAlumnosSinAula.Remove(alumno);
                if(aula + alumno);
                
                this.DialogResult = DialogResult.OK;
            }


        }


        private bool ValidarCampos()
        {

            if (cmbColor.Text == string.Empty || cmbTurno.Text == string.Empty || listaAlumnosSinAula.Count <= 0)
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

        private void cmbTurno_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (ValidarTurnoSeleccionado() == ETurno.Mañana)
            {
                listaDeDocentesMañana = listaDeDocentes;
                MostrarListaDocentesSinAula(listaDeDocentesMañana);
            }
            else
            {
                listaDeDocentesTarde = listaDeDocentes;
                MostrarListaDocentesSinAula(listaDeDocentesTarde);
            }
        }
    }
}
