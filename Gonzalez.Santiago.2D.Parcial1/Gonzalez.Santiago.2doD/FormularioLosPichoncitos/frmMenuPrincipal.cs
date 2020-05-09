using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Media;
using System.Security.Cryptography;
using System.Reflection;

namespace FormularioLosPichoncitos
{
    public partial class FrmMenuPrincipal : Form
    {
        public List<Docente> listaDocentes;
        private List<Administrativo> listaAdministrativos;
        private List<Alumno> listaAlumnos;
        private List<Responsable> listaResponsables;
        private Docente docente;
        private Administrativo administrativo;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            //this.BackColor = Color.FromArgb(255, 232, 232);
            listaDocentes = new List<Docente>();
            listaAdministrativos = new List<Administrativo>();
            listaAlumnos = new List<Alumno>();
            listaResponsables = new List<Responsable>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que deea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void altaDeDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;
            FrmAlta altaDocente = new FrmAlta("docente");
            
            //altaDocente.Show();
            SoundPlayer simpleSound = new SoundPlayer(@"Sonido\welcometothejungle.wav");
            simpleSound.Play();


            
            if (altaDocente.ShowDialog() == DialogResult.OK)
            {
                this.listaDocentes.Add(altaDocente.docente);
                //MostrarListaDeDocentes();
            }
            
            

            
        }
        
        private void crearAutomaticamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            
            docente = new Docente("Pepe", "Gonzalez", 123654872, false, dt, dt, 200);
            this.listaDocentes.Add(docente);
            docente = new Docente("Maria", "Rodriguez", 123652134, true, dt, dt, 250);
            this.listaDocentes.Add(docente);
            docente = new Docente("Juan", "Perez", 23658749, false, dt, dt, 320);
            this.listaDocentes.Add(docente);
            docente = new Docente("Rodrigo", "De la Serna", 46875123, false, dt, dt, 300);
            this.listaDocentes.Add(docente);
            docente = new Docente("Juan", "Gomez", 24879321, false, dt, dt, 200);
            this.listaDocentes.Add(docente);

        }

        private void altaDeNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlta frmAltas = new FrmAlta("administrativo");
            if(frmAltas.ShowDialog() == DialogResult.OK)
            {
                this.listaAdministrativos.Add(frmAltas.administrativo);
            }

        }

        private void crearAutomaticamenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            administrativo = new Administrativo("Pepe", "Gonzalez", 123654872, false, ECargo.Cocina);
            this.listaDocentes.Add(docente);
            administrativo = new Administrativo("Luke", "Skywalker", 23658749, false, ECargo.Dirección);
            this.listaDocentes.Add(docente);
            administrativo = new Administrativo("Maria", "Rivera", 123652134, true, ECargo.Secretaría);
            this.listaDocentes.Add(docente);
            administrativo = new Administrativo("Rodrigo", "De la Serna", 46875123, false, ECargo.Tesorería);
            this.listaDocentes.Add(docente);
            administrativo = new Administrativo("Maria", "Petrona", 24879321, true, ECargo.Portería);
            this.listaDocentes.Add(docente);
            administrativo = new Administrativo("Juana", "Gomez", 24879321, true, ECargo.Portería);
            this.listaDocentes.Add(docente);
            administrativo = new Administrativo("Martina", "Perez", 24879321, true, ECargo.Portería);
            this.listaDocentes.Add(docente);
            administrativo = new Administrativo("Francisca", "Gimenez", 24879321, true, ECargo.Portería);
            this.listaDocentes.Add(docente);
            administrativo = new Administrativo("Margarita", "Diaz", 24879321, true, ECargo.Portería);
            this.listaDocentes.Add(docente);
            administrativo = new Administrativo("Rufina", "Sosa", 24879321, true, ECargo.Portería);
            this.listaDocentes.Add(docente);

        }
        //private void MostrarListaDeDocentes()
        //{

        //    lstAulas.Items.Clear();
        //    foreach (var item in this.listaDocentes)
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        if (!(listaDocentes is null) && !(item is null))
        //        {
        //            sb.Append(item.ToString());
        //            sb.AppendLine("");
        //            lstAulas.Items.Add(sb.ToString());

        //        }
        //        this.Controls.Add(lstAulas);

        //    }
        //}

        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string nombre, string apellido, int dni, bool femenino, float precioCuota, Responsable responsable,int legajo
            FrmAlta frmAltas = new FrmAlta("alumno");
            if (frmAltas.ShowDialog() == DialogResult.OK)
            {
                this.listaAlumnos.Add(frmAltas.alumno);
                this.listaResponsables.Add(frmAltas.responsable);
            }
        }

        private void altaDeAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAula altaAula = new FrmAula(this);
            altaAula.MdiParent = this;
            altaAula.Show();
        }
    }
}
