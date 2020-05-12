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

using System.Security.Cryptography;
using System.Reflection;

namespace FormularioLosPichoncitos
{
    public partial class FrmMenuPrincipal : Form
    {
        public List<Docente> listaDocentes;
        private List<Administrativo> listaAdministrativos;
        public List<Alumno> listaAlumnos;


        private List<Responsable> listaResponsables;
        private Docente docente;
        private Administrativo administrativo;
        private Responsable responsable;
        public List<Aula> listaDeAulas;

        //ListView listView = new ListView();
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            listaDocentes = new List<Docente>();
            listaAdministrativos = new List<Administrativo>();
            listaAlumnos = new List<Alumno>();

            listaResponsables = new List<Responsable>();
            listaDeAulas = new List<Aula>();
        }


        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que deea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void altaDeDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlta altaDocente = new FrmAlta("docente");
            if (altaDocente.ShowDialog() == DialogResult.OK)
            {
                this.listaDocentes.Add(altaDocente.docente);
            }
        }



        private void altaDeNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlta frmAltas = new FrmAlta("administrativo");
            if (frmAltas.ShowDialog() == DialogResult.OK)
            {
                this.listaAdministrativos.Add(frmAltas.administrativo);
            }

        }
        private void crearAutomaticamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dtIngresoMañana = new DateTime(2020, 5, 11, 8, 00, 00);
            DateTime dtSalidaMañana = new DateTime(2020, 5, 11, 12, 00, 00);
            DateTime dtIngresoTarde = new DateTime(2020, 5, 11, 13, 00, 00);
            DateTime dtSalidaTarde = new DateTime(2020, 5, 11, 17, 00, 00);

            docente = new Docente("Pepe", "Gonzalez", 123654872, false, dtIngresoMañana, dtSalidaMañana, 200);
            this.listaDocentes.Add(docente);
            docente = new Docente("Maria", "Rodriguez", 123652134, true, dtIngresoMañana, dtSalidaMañana, 250);
            this.listaDocentes.Add(docente);
            docente = new Docente("Juan", "Perez", 23658749, false, dtIngresoTarde, dtSalidaTarde, 320);
            this.listaDocentes.Add(docente);
            docente = new Docente("Rodrigo", "De la Serna", 46875123, false, dtIngresoTarde, dtSalidaTarde, 300);
            this.listaDocentes.Add(docente);
            docente = new Docente("Juan", "Gomez", 24879321, false, dtIngresoTarde, dtSalidaTarde, 200);
            this.listaDocentes.Add(docente);

        }
        private void crearAutomaticamenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            administrativo = new Administrativo("Pepe", "Gonzalez", 123654872, false, ECargo.Cocina);
            this.listaAdministrativos.Add(administrativo);
            administrativo = new Administrativo("Luke", "Skywalker", 23658749, false, ECargo.Dirección);
            this.listaAdministrativos.Add(administrativo);
            administrativo = new Administrativo("Maria", "Rivera", 123652134, true, ECargo.Secretaría);
            this.listaAdministrativos.Add(administrativo);
            administrativo = new Administrativo("Rodrigo", "De la Serna", 46875123, false, ECargo.Tesorería);
            this.listaAdministrativos.Add(administrativo);
            administrativo = new Administrativo("Maria", "Petrona", 24879321, true, ECargo.Portería);
            this.listaAdministrativos.Add(administrativo);
            administrativo = new Administrativo("Juana", "Gomez", 24879321, true, ECargo.Portería);
            this.listaAdministrativos.Add(administrativo);
            administrativo = new Administrativo("Martina", "Perez", 24879321, true, ECargo.Portería);
            this.listaAdministrativos.Add(administrativo);
            administrativo = new Administrativo("Francisca", "Gimenez", 24879321, true, ECargo.Portería);
            this.listaAdministrativos.Add(administrativo);
            administrativo = new Administrativo("Margarita", "Diaz", 24879321, true, ECargo.Portería);
            this.listaAdministrativos.Add(administrativo);
            administrativo = new Administrativo("Rufina", "Sosa", 24879321, true, ECargo.Portería);
            this.listaAdministrativos.Add(administrativo);

        }
        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listaResponsables.Add(new Responsable("Pepe", "Gonzalez", 123654872, false, EParentesco.Padre, "11234568"));
            this.listaAlumnos.Add(new Alumno("Wilie", "Mensler", 569142265, false, 3395, responsable, 753));
            this.listaAlumnos.Add(new Alumno("Joshua", "Leasor", 873887298, true, 9289, responsable, 357));
            this.listaAlumnos.Add(new Alumno("Jacintha", "Findlow", 907386156, true, 5044, responsable, 789));
            this.listaAlumnos.Add(new Alumno("Jervis", "Cusworth", 711690091, false, 3972, responsable, 456));
            this.listaAlumnos.Add(new Alumno("Julina", "Mather", 771491982, false, 7875, responsable, 321));
            this.listaAlumnos.Add(new Alumno("Morganica", "Benard", 289460490, false, 1847, responsable, 456));
            this.listaAlumnos.Add(new Alumno("Gale", "Antrag", 089238675, false, 3956, responsable, 951));
            this.listaAlumnos.Add(new Alumno("Perri", "Orrin", 402162271, false, 1295, responsable, 111));
            this.listaAlumnos.Add(new Alumno("Maris", "Skippen", 063170256, false, 7832, responsable, 222));
            this.listaAlumnos.Add(new Alumno("Olva", "Dearnly", 737722609, true, 9894, responsable, 333));
            this.listaAlumnos.Add(new Alumno("Loretta", "Kuhnel", 503594956, false, 2048, responsable, 444));
            this.listaAlumnos.Add(new Alumno("Debra", "Shouler", 714512074, true, 1658, responsable, 555));
            this.listaAlumnos.Add(new Alumno("Vitoria", "Birckmann", 646524971, true, 3755, responsable, 666));
            this.listaAlumnos.Add(new Alumno("Betsy", "Kinnen", 380626302, false, 1274, responsable, 777));
            this.listaAlumnos.Add(new Alumno("Ephrem", "Luthwood", 094210334, false, 6659, responsable, 888));
            this.listaAlumnos.Add(new Alumno("Dasya", "Hugli", 587962541, true, 7964, responsable, 999));
            this.listaAlumnos.Add(new Alumno("Elli", "Eyden", 564319386, true, 2468, responsable, 101010));
            this.listaAlumnos.Add(new Alumno("Pierre", "Kobel", 908785210, false, 5568, responsable, 1212));
            this.listaAlumnos.Add(new Alumno("Koren", "Brugemann", 037299695, true, 7659, responsable, 1313));
            this.listaAlumnos.Add(new Alumno("Rhiamon", "Kennifick", 515890592, true, 22510, responsable, 1414));
            this.listaAlumnos.Add(new Alumno("Maxie", "Laugharne", 917394619, false, 4749, responsable, 1515));
            this.listaAlumnos.Add(new Alumno("Fanechka", "Gittings", 728506891, false, 5842, responsable, 1616));
            this.listaAlumnos.Add(new Alumno("Ricardo", "Weatherley", 658458349, true, 6852, responsable, 1717));
            this.listaAlumnos.Add(new Alumno("Alexandro", "Knoller", 075508493, true, 3942, responsable, 1818));
            this.listaAlumnos.Add(new Alumno("Harper", "Gilstin", 501060006, true, 3605, responsable, 1919));
            this.listaAlumnos.Add(new Alumno("Reuven", "Broady", 462912522, false, 24611, responsable, 2020));
            this.listaAlumnos.Add(new Alumno("Lorry", "Leedal", 788024461, true, 1245, responsable, 2121));
            this.listaAlumnos.Add(new Alumno("Jeannie", "Burtonshaw", 241137555, false, 830, responsable, 2323));
            this.listaAlumnos.Add(new Alumno("Lauri", "Corps", 114188843, false, 1335, responsable, 2222));
            this.listaAlumnos.Add(new Alumno("Cy", "Benninger", 542928768, false, 3358, responsable, 2424));
            this.listaAlumnos.Add(new Alumno("Marcello", "MacAllen", 839829656, true, 2132, responsable, 2525));
            this.listaAlumnos.Add(new Alumno("Miguelita", "Jugging", 218670575, true, 7126, responsable, 2626));
            this.listaAlumnos.Add(new Alumno("Wren", "Pach", 036111977, false, 7526, responsable, 2727));
            this.listaAlumnos.Add(new Alumno("Staford", "Rumgay", 947540456, false, 4237, responsable, 2828));
            this.listaAlumnos.Add(new Alumno("Nanon", "Jewiss", 139524527, false, 6706, responsable, 2929));
            this.listaAlumnos.Add(new Alumno("Matilda", "Capstack", 774453470, true, 1221, responsable, 3030));
            this.listaAlumnos.Add(new Alumno("Meier", "Siely", 423157861, false, 4154, responsable, 3131));
            this.listaAlumnos.Add(new Alumno("Lee", "Fripp", 431924406, true, 8367, responsable, 3232));
            this.listaAlumnos.Add(new Alumno("Trenna", "Charnock", 233779239, true, 3760, responsable, 34334));
            this.listaAlumnos.Add(new Alumno("Dottie", "Putnam", 254144845, true, 9758, responsable, 3333));
            this.listaAlumnos.Add(new Alumno("Jobey", "Whorlow", 240393006, false, 2679, responsable, 3838));
            this.listaAlumnos.Add(new Alumno("Ferdinand", "Bousler", 731748931, false, 2483, responsable, 3737));
            this.listaAlumnos.Add(new Alumno("Ianthe", "Kirsche", 013266978, false, 8532, responsable, 3636));
            this.listaAlumnos.Add(new Alumno("Gordie", "Cockin", 471742112, false, 3953, responsable, 3939));
            this.listaAlumnos.Add(new Alumno("Jard", "Mendes", 604764082, false, 2961, responsable, 4040));
            this.listaAlumnos.Add(new Alumno("Elsworth", "Durn", 118965899, true, 8778, responsable, 44141));
            this.listaAlumnos.Add(new Alumno("Catherine", "Paragreen", 099078200, true, 3547, responsable, 4242));
            this.listaAlumnos.Add(new Alumno("Gertrud", "Lardier", 965787272, true, 9001, responsable, 4343));
            this.listaAlumnos.Add(new Alumno("Kassi", "Kenealy", 046136466, true, 2484, responsable, 4444));
            this.listaAlumnos.Add(new Alumno("Langston", "Skerman", 746234537, true, 3007, responsable, 4545));
        }

        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlta frmAltas = new FrmAlta("responsable");
            if (frmAltas.ShowDialog() == DialogResult.OK)
            {
                this.listaAlumnos.Add(frmAltas.alumno);
                this.listaResponsables.Add(frmAltas.responsable);
            }
        }

        private void altaDeAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmAula altaAula = new FrmAula(this);

            if (altaAula.ShowDialog() == DialogResult.OK)
            {
                altaAula.listaDeAulas = listaDeAulas;
                MostrarListaAulas();

            }
        }

        private void MostrarListaAulas()
        {
            
            lstAulas.Items.Clear();
            foreach (var item in listaDeAulas)
            {
                lstAulas.Items.Add(item);
            }
        }



        private void lstAulas_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstAulas.SelectedIndex != -1)
            {
                Aula am = listaDeAulas[lstAulas.SelectedIndex];
                MessageBox.Show(am.ToString());
            }
        }

        private void informacionDePadresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportes frmReporte = new FrmReportes(listaResponsables);
            frmReporte.Text = "Informacion de padres";
            frmReporte.RealizarReporte("responsables");
            frmReporte.ShowDialog();
        }

        private void sueldoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportes frmReporte = new FrmReportes(listaDocentes);
            frmReporte.Text = "Sueldo de docentes";
            frmReporte.RealizarReporte("docentes");
            frmReporte.ShowDialog();
        }

        private void sueldoNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportes frmReporte = new FrmReportes(listaAdministrativos);
            frmReporte.Text = "Sueldo de administrativos";
            frmReporte.RealizarReporte("administrativos");
            frmReporte.ShowDialog();
        }

        private void recaudacionPorAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportes frmReporte = new FrmReportes(listaDeAulas, listaAlumnos);
            frmReporte.Text = "Recaudacion por aula";
            frmReporte.RealizarReporte("aulas");
            frmReporte.ShowDialog();
        }

        private void recaudacionTotalDelJardinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportes frmReporte = new FrmReportes(listaDeAulas, listaAlumnos);
            frmReporte.Text = "Recaudacion total";
            frmReporte.RealizarReporte("aulasTotal");
            frmReporte.ShowDialog();
        }

        private void video1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVideos frmVideos = new FrmVideos();
            frmVideos.ShowDialog();
        }
    }
}
