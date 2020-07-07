using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Entidades;

namespace FormJardin
{
    public delegate void Evaluar(object o);
    public partial class FormAlumnos : Form
    {
        Docente docente;
        public List<Docente> listaDocentes;
        public List<Alumno> listaAlumnos;
        public Xml<List<Docente>> xmlDocente;
        public List<Aula> listaAulas;
        public List<Alumno> alumnosEnRecreo;
        public Aula aula;
        private Texto texto;
        public List<Thread> hilos;
        private DataTable dataTableAlumnos;
        private Random evaluarRandom;
        public event Evaluar proximoAEvaluar;
        private Alumno proximoALlamar;
        private Alumno alumnoEvaluando;
        public bool aprobado = false;
        private Evaluaciones evaluaciones = new Evaluaciones();
        Stopwatch stopwatch;
        FormEvaluaciones formEvaluaciones;
        public FormAlumnos()
        {
            InitializeComponent();
            docente = new Docente();
            listaDocentes = new List<Docente>();
            xmlDocente = new Xml<List<Docente>>();
            texto = new Texto();
            hilos = new List<Thread>();
            listaAulas = new List<Aula>();
            dataTableAlumnos = new DataTable();
            evaluarRandom = new Random();
            listaAlumnos = new List<Alumno>();
            alumnosEnRecreo = new List<Alumno>();
            formEvaluaciones = new FormEvaluaciones();
            proximoALlamar = new Alumno();
            alumnoEvaluando = new Alumno();
            stopwatch = new Stopwatch();

            proximoAEvaluar += ProximoAlumno;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerDocentesXml();
            GuardarDocenteSQL();
            LeerAlumnosSql();
            LeerAulaSql();
            CargarDataGridAlumno();
            CantidadAlumnos();
            IniciarHilos();
        }

        /// <summary>
        /// Lee los docentes del archivo xml y lo almacena en una lista de docentes
        /// </summary>
        public void LeerDocentesXml()
        {
            xmlDocente.Leer(ConstantePath.PATHSER + "Docentes\\Docentes.xml", out listaDocentes);
        }

        /// <summary>
        /// Levanta las aulas de la base de datos y las almacena en una lista de aulas
        /// </summary>
        public void LeerAulaSql()
        {
            listaAulas = SQL.LeerAulas();

        }

        /// <summary>
        /// Carga el dataTable que contiene la tabla de la base de datos en el dataGridView alumnos
        /// </summary>
        public void CargarDataGridAlumno()
        {
            dataGridAlumnos.DataSource = dataTableAlumnos;
            #region Comentarios
            //bs.DataSource = SQL.LeerAlumnosALista();
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
            #endregion
        }

        /// <summary>
        /// Inserta la lista de docentes en la base de datos
        /// </summary>
        public void GuardarDocenteSQL()
        {
            if (!(listaDocentes is null))
            {
                foreach (var item in listaDocentes)
                {
                    SQL.InsertarDocente(item);
                }
            }
        }

        /// <summary>
        /// Levanta los alumnos de la base de datos y lo almacena en un objeto DataTable
        /// </summary>
        public void LeerAlumnosSql()
        {
            dataTableAlumnos = SQL.LeerAlumnosDataTable();

        }

        /// <summary>
        /// Metodo que guarda los docentes en un archivo xml
        /// </summary>
        public void GuardarXmlDocentes()
        {
            xmlDocente.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                "\\SegundoParcialUtn\\JardinUtn\\Docentes\\PepitoPruebas\\", "Docentes.xml", listaDocentes);
        }

        /// <summary>
        /// Metodo que cuenta la cantidad de alumnos pendientes de evaluar y los muestra en label
        /// </summary>
        public void CantidadAlumnos()
        {
            Label aux = new Label();
            if (dataGridAlumnos.InvokeRequired)
            {
                dataGridAlumnos.BeginInvoke((MethodInvoker)delegate
                {
                    dataGridAlumnos.DataSource = null;
                    dataGridAlumnos.DataSource = dataTableAlumnos;
                    lblCantidad.Text = dataGridAlumnos.Rows.Count.ToString();
                });
            }
            else
            {
                dataGridAlumnos.DataSource = null;
                dataGridAlumnos.DataSource = dataTableAlumnos;
                lblCantidad.Text = dataGridAlumnos.Rows.Count.ToString();
            }
        }

        /// <summary>
        /// Metodo que elige un alumno del data grid view, lo elimina y lo almacena en un textbox
        /// </summary>
        private void ProximoAlumnoASerLlamado()
        {
            try
            {
                if (dataGridAlumnos.Rows.Count > 0)
                {
                    foreach (DataGridViewRow item in dataGridAlumnos.Rows)
                    {
                        if (!(item is null) && !(item.Cells[item.Index].Value is null))
                        {
                            #region Por si quiero usar datagrid para proximos alumnos a ser llamados
                            //object[] values = {
                            //          item.Cells["idAlumnos"].Value,
                            //          item.Cells["Nombre"].Value,
                            //          item.Cells["Apellido"].Value,
                            //          item.Cells["Edad"].Value,
                            //          item.Cells["Dni"].Value,
                            //          item.Cells["Direccion"].Value,
                            //          item.Cells["Responsable"].Value
                            //};
                            //dataGridProximo.ColumnCount = 7;
                            //dataGridProximo.Columns[0].Name = "idAlumnos";
                            //dataGridProximo.Columns[1].Name = "Nombre";
                            //dataGridProximo.Columns[2].Name = "Apellido";
                            //dataGridProximo.Columns[3].Name = "Edad";
                            //dataGridProximo.Columns[4].Name = "Dni";
                            //dataGridProximo.Columns[5].Name = "Direccion";
                            //dataGridProximo.Columns[6].Name = "Responsable";
                            //DataGridViewRow row = new DataGridViewRow();
                            //row.CreateCells(dataGridProximo, values);
                            //dataGridProximo.Rows.Add(row);
                            #endregion

                            proximoALlamar.Id = (int)(item.Cells[0].Value);
                            proximoALlamar.Nombre = (item.Cells[1].Value.ToString());
                            proximoALlamar.Apellido = (item.Cells[2].Value.ToString());
                            proximoALlamar.Edad = (int)(item.Cells[3].Value);
                            proximoALlamar.Dni = (int)(item.Cells[4].Value);
                            proximoALlamar.Direccion = (item.Cells[5].Value.ToString());
                            proximoALlamar.Responsable = (item.Cells[6].Value.ToString());

                            #region prueba para que no repita alumno en txt proximo y en evaluando...
                            ////prueba

                            //alumnoEvaluando.Id = proximoALlamar.Id;
                            //alumnoEvaluando.Nombre = proximoALlamar.Nombre;
                            //alumnoEvaluando.Apellido = proximoALlamar.Apellido;
                            //alumnoEvaluando.Edad = proximoALlamar.Edad;
                            //alumnoEvaluando.Dni = proximoALlamar.Dni;
                            //alumnoEvaluando.Direccion = proximoALlamar.Direccion;
                            //alumnoEvaluando.Responsable = proximoALlamar.Responsable;
                            #endregion

                            StringBuilder sb = new StringBuilder();
                            sb.Append(proximoALlamar.Nombre + " " + proximoALlamar.Apellido);
                            dataGridAlumnos.Rows.RemoveAt(item.Index);

                            if (txtProximoAlumno.InvokeRequired)
                            {
                                txtProximoAlumno.BeginInvoke((MethodInvoker)delegate
                                {
                                    txtProximoAlumno.Text = sb.ToString();
                                });
                            }
                            else
                                txtProximoAlumno.Text = sb.ToString();
                            //Evaluar();
                            CantidadAlumnos();
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Se evaluaron todos los alumnos");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                texto.Guardar(ConstantePath.PATHLOG, "logs.txt", ex.Message);
            }
        }

        private void FinalizarHilos()
        {
            foreach (var item in hilos)
            {
                if (item.IsAlive)
                {
                    item.Abort();
                }
            }
        }

        /// <summary>
        /// Metodo que llama al proximo alumno y luego ejecuta el metodo Evaluar
        /// </summary>
        /// <param name="o"></param>
        public void ProximoAlumno(object o)
        {

            ProximoAlumnoASerLlamado();

            Evaluar(proximoALlamar, (TextBox)o);
        }

        /// <summary>
        /// Evalua el alumno mostrandolo en textbox, genera docente, aula y nota random y luego lanza evento para llamar al proximo alumno
        /// </summary>
        /// <param name="alumnoSiendoEvaluado"></param>
        /// <param name="txt"></param>
        public void Evaluar(Alumno alumnoSiendoEvaluado, TextBox txt)
        {
            stopwatch.Start();
            MostrarAlumnoSiendoEvaluado(alumnoSiendoEvaluado.ToString(), txt);
            docente = GenerarDocenteRandom();
            evaluaciones.Alumno = alumnoSiendoEvaluado;
            evaluaciones.Docente = docente;
            alumnoSiendoEvaluado.Nota = evaluaciones.GenerarNotaRandom();
            evaluaciones.Aula = GenerarAulaRandom();
            evaluaciones.GenerarObservacionRandom();
            evaluaciones.InsertarASql();
            if (alumnoSiendoEvaluado.Nota >= 6)
            {
                aprobado = true;
            }
            else
            {
                aprobado = false;
            }

            alumnoSiendoEvaluado.AlumnoEvaluado(aprobado);
            Thread.Sleep(8000);
            alumnosEnRecreo.Add(alumnoSiendoEvaluado);


            //lanzo el evento que llame al proximo
            proximoAEvaluar(txt);

        }


        /// <summary>
        /// Muestro tiempo transcurrido desde que se comenzo a evaluar el alumno
        /// </summary>
        /// <param name="segundosObj"></param>
        public void MostrarTiempoTranscurrido(object segundosObj)
        {
            DateTime dt = new DateTime();
            int segundos = (int)segundosObj; //casteo objeto a int
            segundos = 0;


            
                if (formEvaluaciones.lblTiempoTranscurrido.InvokeRequired)
                {
                    formEvaluaciones.lblTiempoTranscurrido.BeginInvoke((MethodInvoker)delegate ()
                    {
                        formEvaluaciones.lblTiempoTranscurrido.Text = dt.AddSeconds(segundos).ToString("ss");
                    });
                }
                else
                {
                    formEvaluaciones.lblTiempoTranscurrido.Text = dt.AddSeconds(segundos).ToString("ss");
                }
                segundos++;
            
            //while (true)
            //{
            //    //verifico si el hilo donde se esta evaluando el alumno se le realizo Thread.Sleep
            //    //verificar ya que sigue contando el tiempo y no se renueva

            //    while (alumnosEnRecreo.Count != 1)
            //    {
            //        
            //    }
            //    alumnosEnRecreo.RemoveAt(0);
            //    segundos = 0;
            //    break;



            //while (hilos[1].ThreadState is ThreadState.WaitSleepJoin)
            //{

            //    if (formEvaluaciones.lblTiempoTranscurrido.InvokeRequired)
            //    {
            //        formEvaluaciones.lblTiempoTranscurrido.BeginInvoke((MethodInvoker)delegate ()
            //        {
            //            formEvaluaciones.lblTiempoTranscurrido.Text = dt.AddSeconds(segundos).ToString("ss");
            //        });
            //    }
            //    else
            //    {
            //        formEvaluaciones.lblTiempoTranscurrido.Text = dt.AddSeconds(segundos).ToString("ss");
            //    }
            //    segundos++;
            //    Thread.Sleep(1000);

            //}
            //segundos = 1;

        }

        /// <summary>
        /// Genera un aula al azar
        /// </summary>
        /// <returns>Aula al azar</returns>
        public Aula GenerarAulaRandom()
        {

            return aula = MetodoExtension.GenerarAulaRandom(listaAulas);

            #region Comentario
            //comento para ver si sale el metodo de extension

            //Aula aulaAux = new Aula();
            //int aulaRandom = evaluarRandom.Next(1, listaAulas.Count);
            //foreach (var item in listaAulas)
            //{
            //    if (item.Id == aulaRandom)
            //    {
            //        aulaAux = item;
            //    }
            //}
            //return aulaAux;
            #endregion
        }

        /// <summary>
        /// Genera un docente al azar
        /// </summary>
        /// <returns>Docente al azar</returns>
        public Docente GenerarDocenteRandom()
        {
            Docente docente = new Docente();
            int evaluoRandom;
            //pongo el random en este rango por que lo carga a la base con este ese rango de id
            evaluoRandom = evaluarRandom.Next(1, listaDocentes.Count);
            foreach (var item in listaDocentes)
            {
                if (item.Id == evaluoRandom)
                {
                    if (formEvaluaciones.txtDocente.InvokeRequired)
                    {
                        formEvaluaciones.txtDocente.BeginInvoke((MethodInvoker)delegate
                        {
                            formEvaluaciones.txtDocente.Text = item.ToString();
                            docente = item;
                            //ProximoAlumnoASerLlamado();
                        });
                    }
                    else
                    {
                        formEvaluaciones.txtDocente.Text = item.ToString();
                        docente = item;
                    }
                }

            }
            return docente;
        }

        /// <summary>
        /// Muestra al alumno siendo evaluado en el FormEvaluaciones
        /// </summary>
        /// <param name="nombreYApellido">Nombre y apellido del alumno a mostrar</param>
        /// <param name="txt">Objeto de tipo textbox para cargar el alumno</param>
        public void MostrarAlumnoSiendoEvaluado(string nombreYApellido, TextBox txt)
        {
            if (txt.InvokeRequired)
            {
                txt.BeginInvoke((MethodInvoker)delegate
                {
                    txt.Text = nombreYApellido;
                    //ProximoAlumnoASerLlamado();
                });
            }
            else
            {
                txt.Text = nombreYApellido;

                #region Comentarios
                //formEvaluaciones.txtAlumno.Text = dataGridProximo.CurrentRow.Cells[0].Value.ToString();
                //dataGridProximo.CurrentRow.Cells.RemoveAt(item.Index);
                //txtProximoAlumno.Text = "";
                //ProximoAlumnoASerLlamado();
                #endregion
            }
        }
        /// <summary>
        /// Espero 0,5 segundos para iniciar el formulario evaluaciones
        /// </summary>
        public void IniciarFormEvaluaciones()
        {
            Application.Run(formEvaluaciones);
        }

        /// <summary>
        /// Inicio los hilos
        /// </summary>
        public void IniciarHilos()
        {
            if (hilos.Count != 5)
            {
                hilos.Add(new Thread(new ThreadStart(IniciarFormEvaluaciones)));
                hilos.Add(new Thread(new ParameterizedThreadStart(ProximoAlumno)));
                hilos.Add(new Thread(MostrarTiempoTranscurrido));

            }
            if (!hilos[0].IsAlive)
            {
                hilos[0].Start();
            }
            if (!hilos[1].IsAlive)
            {
                hilos[1] = new Thread(new ParameterizedThreadStart(ProximoAlumno));
                hilos[1].Start(formEvaluaciones.txtAlumnoSiendoEvaluado);
            }
            //if (!hilos[2].IsAlive)
            //{
            //    hilos[2] = new Thread();
            //    hilos[2].Start(-3);
            //}
        }

        private void FormAlumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalizarHilos();
        }
    }
}
