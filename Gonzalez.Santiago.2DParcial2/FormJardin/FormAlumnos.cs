using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace FormJardin
{
    public delegate void Evaluar();
    public partial class FormAlumnos : Form
    {
        Docente docente;
        public List<Docente> listaDocentes;
        public List<Alumno> listaAlumnos;
        public Xml<List<Docente>> xmlDocente;
        public List<Aula> listaAulas;
        Texto texto;
        List<Thread> hilos;
        DataTable dataTable;
        Random evaluarRandom;
        BindingSource bs;
        public event Evaluar proximoAEvaluar;

        public FormAlumnos()
        {
            InitializeComponent();
            docente = new Docente();
            listaDocentes = new List<Docente>();
            xmlDocente = new Xml<List<Docente>>();
            texto = new Texto();
            hilos = new List<Thread>();
            listaAulas = new List<Aula>();
            dataTable = new DataTable();
            evaluarRandom = new Random();
            listaAlumnos = new List<Alumno>();
            bs = new BindingSource();
            //proximoAEvaluar += ProximoAlumnoASerLlamado();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerXmlDocentes();
            GuardarDocenteEnSQL();
            LeerAlumnosSql();
            LeerAulaSql();
            CargarDataGridAlumno();
        }
        public void LeerXmlDocentes()
        {
            xmlDocente.Leer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                "\\SegundoParcialUtn\\JardinUtn\\Docentes\\Docentes.xml", out listaDocentes);
        }

        public void LeerAulaSql()
        {
            listaAulas = SQL.LeerAulas("select * from aulas");
            
        }

        public void CargarDataGridAlumno()
        {

            dataGridAlumnos.DataSource = dataTable;
            //bs.DataSource = SQL.LeerAlumnosALista("select * from Alumnos");
            //dataGridAlumnos.DataSource = bs.DataSource;
            //for (int i = 1; i < dataTable.Rows.Count; i++)
            //{
            //    Alumno alumnoAux = new Alumno();
            //    alumnoAux.ID = Convert.ToInt32(dataTable.Rows[i]);
            //    alumnoAux.Nombre = dataTable.Rows[i]["Nombre"].ToString();
            //    alumnoAux.Apellido = dataTable.Rows[i]["Apellido"].ToString();
            //    alumnoAux.Edad = Convert.ToInt32(dataTable.Rows[i]["Edad"]);
            //    alumnoAux.Dni = Convert.ToInt32(dataTable.Rows[i]["Dni"]);
            //    alumnoAux.Direccion = dataTable.Rows[i]["Direccion"].ToString();
            //    alumnoAux.Responsable = dataTable.Rows[i]["Responsable"].ToString();
            //    listaAlumnos.Add(alumnoAux);
            //}


        }

        public void GuardarDocenteEnSQL()
        {
            if (!(listaDocentes is null))
            {
                foreach (var item in listaDocentes)
                {
                    SQL.InsertarDocente(item);
                }
            }

        }

        public void LeerAlumnosSql()
        {
            dataTable = SQL.LeerAlumnosDataTable("select * from Alumnos");

        }

        public void GuardarListaAlumnos()
        {

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

        public void CantidadAlumnos()
        {
            foreach (var item in collection)
            {

            }
        }
        public void ProximoAlumnoASerLlamado()
        {
            int alumnoAEvaluar;
            alumnoAEvaluar = evaluarRandom.Next(1, 30);
            try
            {
                if (dataGridAlumnos.Rows.Count > 0)
                {
                    foreach (DataGridViewRow item in dataGridAlumnos.Rows)
                    {
                        if (!(item is null))
                        {
                            if (item.Cells["idAlumnos"].Value.ToString() == alumnoAEvaluar.ToString())
                            {
                                //bs.RemoveAt(item.Index);
                                //dataGridAlumnos.Rows.RemoveAt(item.Index);
                                //bs.Clear();
                                dataGridAlumnos.Rows.RemoveAt(item.Index);
                                dataGridProximo.Rows.Add(item);
                                break;
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                texto.Guardar(ConstantePath.PATHLOG, "logs.txt", ex.Message);
                
            }
            

        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            ProximoAlumnoASerLlamado();
        }

        //public void IniciarHilos()
        //{
        //    if (!hilos[0].IsAlive)
        //    {
        //        hilos[0] = new Thread(new ParameterizedThreadStart(ProximoAlumnoASerLlamado));
        //        hilos[0].Start(lstProximo);
        //    }
        //    if (!hilos[1].IsAlive)
        //    {
        //        hilos[1] = new Thread(new ParameterizedThreadStart(ProximoAlumnoASerLlamado));
        //        hilos[1].Start(lstProximo);
        //    }
        //    if (!hilos[2].IsAlive)
        //    {
        //        hilos[2] = new Thread(new ParameterizedThreadStart(ProximoAlumnoASerLlamado));
        //        hilos[2].Start(lstProximo);
        //    }
        //    if (!hilos[3].IsAlive)
        //    {
        //        hilos[3] = new Thread(new ParameterizedThreadStart(ProximoAlumnoASerLlamado));
        //        hilos[3].Start(lstProximo);
        //    }
        //    if (!hilos[4].IsAlive)
        //    {
        //        hilos[4] = new Thread(new ParameterizedThreadStart(ProximoAlumnoASerLlamado));
        //        hilos[4].Start(lstProximo);
        //    }
        //}

    }
}
