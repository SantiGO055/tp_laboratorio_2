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
namespace FormJardin
{
    public partial class Form1 : Form
    {
        Docente docente;
        public List<Docente> listaDocentes;
        public Xml<List<Docente>> xmlDocente;
        //public const string PATHLOG = "\\SegundoParcialUtn\\JardinUtn\\Logs\\";
        public Form1()
        {
            InitializeComponent();
            docente = new Docente();
            listaDocentes = new List<Docente>();
            xmlDocente = new Xml<List<Docente>>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerXml();
        }
        public void LeerXml()
        {
            xmlDocente.Leer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                "\\SegundoParcialUtn\\JardinUtn\\Docentes\\Docentes.xml", out listaDocentes);
        }
        public void GuardarXml()
        {
            xmlDocente.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                "\\SegundoParcialUtn\\JardinUtn\\Docentes\\PepitoPruebas\\", "Docentes.xml", listaDocentes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarXml();
        }

        /// <summary>
        /// Metodo que guarda un archivo log de errores en la ruta especificada
        /// </summary>
        public void GuardarTexto()
        {
            Texto texto = new Texto();
            texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                PATHLOG.pathlog, "logs.txt", "aca va el mensaje exception");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarTexto();
        }
    }
}
