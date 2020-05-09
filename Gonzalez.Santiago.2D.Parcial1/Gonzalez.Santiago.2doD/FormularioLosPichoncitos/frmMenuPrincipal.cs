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
        private Alumno alumno;
        private Responsable responsable;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;
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
            if (frmAltas.ShowDialog() == DialogResult.OK)
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
            altaAula.ShowDialog();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            responsable = new Responsable("Pepe", "Gonzalez", 123654872, false, EParentesco.Padre, "11234568");

            this.listaAlumnos.Add(new Alumno("Wilie", "Mensler", 569142265, false, 3395054562, responsable, 753));
            this.listaAlumnos.Add(new Alumno("Joshua", "Leasor", 873887298, true, 9289085439, responsable, 357));
            this.listaAlumnos.Add(new Alumno("Jacintha", "Findlow", 907386156, true, 5044361512, responsable, 789));
            this.listaAlumnos.Add(new Alumno("Jervis", "Cusworth", 711690091, false, 3972881979, responsable, 456));
            this.listaAlumnos.Add(new Alumno("Julina", "Mather", 771491982, false, 7875748006, responsable, 321));
            this.listaAlumnos.Add(new Alumno("Morganica", "Benard", 289460490, false, 1847106230, responsable, 456));
            this.listaAlumnos.Add(new Alumno("Gale", "Antrag", 089238675, false, 3956910768, responsable, 951));
            this.listaAlumnos.Add(new Alumno("Perri", "Orrin", 402162271, false, 1295133167, responsable, 111));
            this.listaAlumnos.Add(new Alumno("Maris", "Skippen", 063170256, false, 7832941574, responsable, 222));
            this.listaAlumnos.Add(new Alumno("Olva", "Dearnly", 737722609, true, 9894495550, responsable, 333));
            this.listaAlumnos.Add(new Alumno("Loretta", "Kuhnel", 503594956, false, 2048795199, responsable, 444));
            this.listaAlumnos.Add(new Alumno("Debra", "Shouler", 714512074, true, 1658249453, responsable, 555));
            this.listaAlumnos.Add(new Alumno("Vitoria", "Birckmann", 646524971, true, 3755647931, responsable, 666));
            this.listaAlumnos.Add(new Alumno("Betsy", "Kinnen", 380626302, false, 1274763592, responsable, 777));
            this.listaAlumnos.Add(new Alumno("Ephrem", "Luthwood", 094210334, false, 6659002190, responsable, 888));
            this.listaAlumnos.Add(new Alumno("Dasya", "Hugli", 587962541, true, 7964110756, responsable, 999));
            this.listaAlumnos.Add(new Alumno("Elli", "Eyden", 564319386, true, 2468526048, responsable, 101010));
            this.listaAlumnos.Add(new Alumno("Pierre", "Kobel", 908785210, false, 5562113839, responsable, 1212));
            this.listaAlumnos.Add(new Alumno("Koren", "Brugemann", 037299695, true, 7659882640, responsable, 1313));
            this.listaAlumnos.Add(new Alumno("Rhiamon", "Kennifick", 515890592, true, 2251077506, responsable, 1414));
            this.listaAlumnos.Add(new Alumno("Maxie", "Laugharne", 917394619, false, 4749154708, responsable, 1515));
            this.listaAlumnos.Add(new Alumno("Fanechka", "Gittings", 728506891, false, 5842550156, responsable, 1616));
            this.listaAlumnos.Add(new Alumno("Ricardo", "Weatherley", 658458349, true, 6852726334, responsable, 1717));
            this.listaAlumnos.Add(new Alumno("Alexandro", "Knoller", 075508493, true, 3942672674, responsable, 1818));
            this.listaAlumnos.Add(new Alumno("Harper", "Gilstin", 501060006, true, 3605380134, responsable, 1919));
            this.listaAlumnos.Add(new Alumno("Reuven", "Broady", 462912522, false, 2461177332, responsable, 2020));
            this.listaAlumnos.Add(new Alumno("Lorry", "Leedal", 788024461, true, 1245318575, responsable, 2121));
            this.listaAlumnos.Add(new Alumno("Jeannie", "Burtonshaw", 241137555, false, 8307185377, responsable, 2323));
            this.listaAlumnos.Add(new Alumno("Lauri", "Corps", 114188843, false, 1335715365, responsable, 2222));
            this.listaAlumnos.Add(new Alumno("Cy", "Benninger", 542928768, false, 3358207227, responsable, 2424));
            this.listaAlumnos.Add(new Alumno("Marcello", "MacAllen", 839829656, true, 2132033346, responsable, 2525));
            this.listaAlumnos.Add(new Alumno("Miguelita", "Jugging", 218670575, true, 7126625199, responsable, 2626));
            this.listaAlumnos.Add(new Alumno("Wren", "Pach", 036111977, false, 7526815815, responsable, 2727));
            this.listaAlumnos.Add(new Alumno("Staford", "Rumgay", 947540456, false, 4237115582, responsable, 2828));
            this.listaAlumnos.Add(new Alumno("Nanon", "Jewiss", 139524527, false, 6706615748, responsable, 2929));
            this.listaAlumnos.Add(new Alumno("Matilda", "Capstack", 774453470, true, 1221910207, responsable, 3030));
            this.listaAlumnos.Add(new Alumno("Meier", "Siely", 423157861, false, 4154483599, responsable, 3131));
            this.listaAlumnos.Add(new Alumno("Lee", "Fripp", 431924406, true, 8367460547, responsable, 3232));
            this.listaAlumnos.Add(new Alumno("Trenna", "Charnock", 233779239, true, 3769140391, responsable, 34334));
            this.listaAlumnos.Add(new Alumno("Dottie", "Putnam", 254144845, true, 9758653501, responsable, 3333));
            this.listaAlumnos.Add(new Alumno("Jobey", "Whorlow", 240393006, false, 2679499997, responsable, 3838));
            this.listaAlumnos.Add(new Alumno("Ferdinand", "Bousler", 731748931, false, 2483154992, responsable, 3737));
            this.listaAlumnos.Add(new Alumno("Ianthe", "Kirsche", 013266978, false, 8532528621, responsable, 3636));
            this.listaAlumnos.Add(new Alumno("Gordie", "Cockin", 471742112, false, 3952339843, responsable, 3939));
            this.listaAlumnos.Add(new Alumno("Jard", "Mendes", 604764082, false, 2961728847, responsable, 4040));
            this.listaAlumnos.Add(new Alumno("Elsworth", "Durn", 118965899, true, 8778824218, responsable, 44141));
            this.listaAlumnos.Add(new Alumno("Catherine", "Paragreen", 099078200, true, 3547720472, responsable, 4242));
            this.listaAlumnos.Add(new Alumno("Gertrud", "Lardier", 965787272, true, 9001224010, responsable, 4343));
            this.listaAlumnos.Add(new Alumno("Kassi", "Kenealy", 046136466, true, 2484671378, responsable, 4444));
            this.listaAlumnos.Add(new Alumno("Langston", "Skerman", 746234537, true, 3007503106, responsable, 4545));


        }
    }
}
