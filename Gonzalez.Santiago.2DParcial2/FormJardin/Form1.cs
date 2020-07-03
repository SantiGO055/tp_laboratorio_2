using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace FormJardin
{
    public partial class Form1 : Form
    {
        Docente docente;
        public List<Docente> listaDocentes;
        public List<Alumno> listaAlumnos;
        public Xml<List<Docente>> xmlDocente;
        Texto texto;
        //public const string PATHLOG = "\\SegundoParcialUtn\\JardinUtn\\Logs\\";
        public Form1()
        {
            InitializeComponent();
            docente = new Docente();
            listaDocentes = new List<Docente>();
            xmlDocente = new Xml<List<Docente>>();
            texto = new Texto();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerXmlDocentes();
            GuardarDocenteEnSQL();
            LeerAlumnosSql();
        }
        public void LeerXmlDocentes()
        {
            xmlDocente.Leer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                "\\SegundoParcialUtn\\JardinUtn\\Docentes\\Docentes.xml", out listaDocentes);
        }

        public void GuardarDocenteEnSQL()
        {

            foreach (var item in listaDocentes)
            {
                SQL.InsertarDocente(item);
            }
            //SqlManejo.GuardarSql(@"Data Source = .\SQLEXPRESS; Initial Catalog = JardinUtn; Integrated Security = True;");
        }

        public void LeerAlumnosSql()
        {
            SQL.LeerAlumnos("select * from Alumnos");
        }
        public void GuardarXmlDocentes()
        {
            xmlDocente.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                "\\SegundoParcialUtn\\JardinUtn\\Docentes\\PepitoPruebas\\", "Docentes.xml", listaDocentes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarXmlDocentes();
        }

        /// <summary>
        /// Metodo que guarda un archivo log de errores en la ruta especificada
        /// </summary>
        public void GuardarTexto()
        {
            texto.Guardar(ConstantePath.PATHLOG, "logs.txt", "aca va lo que deseo guardar como txt, esto es una prueba");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarTexto();
        }
    }
}
