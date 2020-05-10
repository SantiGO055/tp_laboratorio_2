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
        List<Docente> listaDeDocentesMañana;
        List<Docente> listaDeDocentesTarde;
        List<Docente> listaDeDocentes;

        public Docente docenteMañana;
        public Docente docenteTarde;
        public FrmAula(FrmMenuPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.cmbColor.DataSource = Enum.GetValues(typeof(EColores));
            this.cmbTurno.DataSource = Enum.GetValues(typeof(ETurno));

            //listaAlumnosSinAula = listaAlumnos;
            listaDeAlumnos = new List<Alumno>(frmPrincipal.listaAlumnos);
            listaDeAulas = new List<Aula>();

            listaDeDocentes = frmPrincipal.listaDocentes;
            listaDeDocentesMañana = new List<Docente>(frmPrincipal.listaDocentes);
            listaDeDocentesTarde = new List<Docente>(frmPrincipal.listaDocentes);


            listaDeAulas = frmPrincipal.listaDeAulas;

            foreach (var item in listaDeAlumnos)
            {

                MostrarListaAlumnos(item);
            }

            //listaDeDocentesMañana = listaDocentes;
            //new List<Docente>();




        }

        private void MostrarListaAlumnos(Alumno alumno)
        {
            //bsSinAula.DataSource = listaAlumnos;
            //lstSinAula.DataSource = bsSinAula;
            
                lstSinAula.Items.Add(alumno.ToString());
            
        }
        private void EliminarListaAlumnos(Alumno alumno)
        {
            
            lstSinAula.Items.Remove(alumno.ToString());
            
        }
        private void MostrarListaDocentesSinAula(Docente docentes)
        {
             lstDocenteSinAula.Items.Add(docentes.ToString());
            
        }

        public bool VerificarDocenteEnListaAula(Docente docente)
        {
            bool retorno = false;
            foreach (var item in listaDeAulas)
            {
                
                if (item.Docente.Equals(docente))
                {
                    retorno = true;
                }
                else
                    retorno = false;
            }
            return retorno;
            //List<Aula> listaDeAulas
            //foreach (var aula in listaDeAulas)
            //{
            //    foreach (var docente in listaDeDocentes)
            //    {
            //        if (!(aula is null) && aula.Docente.Equals(docente))
            //        {
            //            return true;
            //        }
            //        else
            //            return false;
            //    }

            //}
            //return false;

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

                
                colorAula = (EColores)Enum.Parse(typeof(EColores), cmbColor.SelectedValue.ToString());
                turnoAula = (ETurno)Enum.Parse(typeof(ETurno), cmbTurno.SelectedValue.ToString());

                if (this.lstDocenteSinAula.SelectedIndex != -1)
                {
                    if (ValidarTurnoSeleccionado().Equals(ETurno.Mañana))
                    {
                        Docente docenteMañana = listaDeDocentes[this.lstDocenteSinAula.SelectedIndex];
                        
                        //listaDeDocentesMañana.Remove(docenteMañana);
                        

                        aula = new Aula(colorAula, turnoAula, docenteMañana);
                    }
                    else
                    {
                        Docente docenteTarde = listaDeDocentes[this.lstDocenteSinAula.SelectedIndex];
                        listaDeDocentesTarde.Remove(docenteTarde);
                        
                        aula = new Aula(colorAula, turnoAula, docenteTarde);
                    }
                    
                }
                Alumno alumno = listaDeAlumnos[this.lstSinAula.SelectedIndex];
                EliminarListaAlumnos(alumno);
                //listaAlumnosSinAula.Remove(alumno);
                
                if(aula + alumno);
                this.listaDeAulas.Add(aula);
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

        private void cmbTurno_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            lstDocenteSinAula.Items.Clear();
            if (ValidarTurnoSeleccionado() == ETurno.Mañana)
            {

                foreach (var item in listaDeDocentes)
                {
                    if (!(VerificarDocenteEnListaAula(item)))
                    {
                        MostrarListaDocentesSinAula(item);
                    }
                    
                }
                
            }
            else
            {
                foreach (var item in listaDeDocentes)
                {
                    if (!(VerificarDocenteEnListaAula(item)))
                    {
                        MostrarListaDocentesSinAula(item);
                    }
                }
            }
        }
    }
}
