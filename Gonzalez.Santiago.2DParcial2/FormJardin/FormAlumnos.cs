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
    public delegate void Evaluar(object o);
    public partial class FormAlumnos : Form
    {
        Docente docente;
        public List<Docente> listaDocentes;
        public List<Alumno> listaAlumnos;
        public Xml<List<Docente>> xmlDocente;
        public List<Aula> listaAulas;
        Texto texto;
        List<Thread> hilos;
        Thread hilosForm;
        DataTable dataTable;
        Random evaluarRandom;
        BindingSource bs;
        event Evaluar proximoAEvaluar;
        Alumno proximoALlamar;

        FormEvaluaciones formEvaluaciones;
        public FormAlumnos()
        {
            InitializeComponent();
            docente = new Docente();
            listaDocentes = new List<Docente>();
            xmlDocente = new Xml<List<Docente>>();
            texto = new Texto();
            hilos = new List<Thread>();
            hilosForm = new Thread(new ThreadStart(startForm2));
            listaAulas = new List<Aula>();
            dataTable = new DataTable();
            evaluarRandom = new Random();
            listaAlumnos = new List<Alumno>();
            bs = new BindingSource();
            formEvaluaciones = new FormEvaluaciones();
            proximoALlamar = new Alumno();

            proximoAEvaluar += Proximo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LeerXmlDocentes();
            GuardarDocenteEnSQL();
            LeerAlumnosSql();
            LeerAulaSql();
            CargarDataGridAlumno();
            CantidadAlumnos();
            IniciarHilos();
        }
        public void LeerXmlDocentes()
        {
            xmlDocente.Leer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                "\\SegundoParcialUtn\\JardinUtn\\Docentes\\Docentes.xml", out listaDocentes);
        }

        public void LeerAulaSql()
        {
            listaAulas = SQL.LeerAulas();

        }

        public void CargarDataGridAlumno()
        {

            dataGridAlumnos.DataSource = dataTable;

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
            dataTable = SQL.LeerAlumnosDataTable();

        }

        public void GuardarXmlDocentes()
        {
            xmlDocente.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                "\\SegundoParcialUtn\\JardinUtn\\Docentes\\PepitoPruebas\\", "Docentes.xml", listaDocentes);
        }

        public void CantidadAlumnos()
        {
            if (dataGridAlumnos.InvokeRequired)
            {
                dataGridAlumnos.BeginInvoke((MethodInvoker)delegate
                {
                    dataGridAlumnos.DataSource = null;
                    dataGridAlumnos.DataSource = dataTable;
                    lblEspera.Text = "Cantidad de alumnos en espera:  " + dataGridAlumnos.Rows.Count.ToString();
                });
            }
            else
            {
                dataGridAlumnos.DataSource = null;
                dataGridAlumnos.DataSource = dataTable;
                lblEspera.Text = "Cantidad de alumnos en espera:  " + dataGridAlumnos.Rows.Count.ToString();
            }
        }
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


                            #region ParaUsarDataGridDelProximo
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

                            proximoALlamar.ID = (int)(item.Cells[0].Value);
                            proximoALlamar.Nombre = (item.Cells[1].Value.ToString());
                            proximoALlamar.Apellido = (item.Cells[2].Value.ToString());
                            proximoALlamar.Edad = (int)(item.Cells[3].Value);
                            proximoALlamar.Dni = (int)(item.Cells[4].Value);
                            proximoALlamar.Direccion = (item.Cells[5].Value.ToString());
                            proximoALlamar.Responsable = (item.Cells[6].Value.ToString());

                            StringBuilder sb = new StringBuilder();
                            sb.Append(proximoALlamar.Nombre + " " + proximoALlamar.Apellido);
                            //sb.Append(item.Cells[1].Value.ToString() + " " +  item.Cells[2].Value.ToString());

                            dataGridAlumnos.Rows.RemoveAt(item.Index);

                            if (txtProximoAlumno.InvokeRequired)
                            {
                                txtProximoAlumno.BeginInvoke((MethodInvoker)delegate
                                {
                                    txtProximoAlumno.Text = sb.ToString();
                                        //ProximoAlumnoASerLlamado();
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
            }
            catch (Exception ex)
            {
                texto.Guardar(ConstantePath.PATHLOG, "logs.txt", ex.Message);
            }

        }

        public void Proximo(object o)
        {
            ProximoAlumnoASerLlamado();

            Evaluar(proximoALlamar, (TextBox)o);
        }
        public void Evaluar(Alumno alumnoSiendoEvaluado, TextBox txt)
        {
            MostrarAlumnoSiendoEvaluado(alumnoSiendoEvaluado.ToString(), txt);
            Thread.Sleep(4000);

            //lanzo el evento que llame al proximo
            proximoAEvaluar(txt);
        }
        public void MostrarAlumnoSiendoEvaluado(string nombreYApellido, TextBox txt)
        {

            if (formEvaluaciones.txtAlumnoSiendoEvaluado.InvokeRequired)
            {
                formEvaluaciones.txtAlumnoSiendoEvaluado.BeginInvoke((MethodInvoker)delegate
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
        public void QuitarAlumnoDeEspera()
        {
            if (txtProximoAlumno.InvokeRequired)
            {
                txtProximoAlumno.BeginInvoke((MethodInvoker)delegate
                {
                    txtProximoAlumno.Text = "";
                    //ProximoAlumnoASerLlamado();
                });
            }
            else
            {
                txtProximoAlumno.Text = "";

            }
        }
        


        private void btnLlamar_Click(object sender, EventArgs e)
        {

        }

        public void startForm2()
        {
            Thread.Sleep(1500);
            Application.Run(formEvaluaciones);
        }

        public void IniciarHilos()
        {
            if (hilos.Count != 5)
            {
                hilos.Add(new Thread(new ThreadStart(startForm2)));
                hilos.Add(new Thread(new ParameterizedThreadStart(Proximo)));
            }
            if (!hilos[0].IsAlive)
            {

                hilos[0].Start();
            }
            if (!hilos[1].IsAlive)
            {
                hilos[1] = new Thread(new ParameterizedThreadStart(Proximo));
                hilos[1].Start(formEvaluaciones.txtAlumnoSiendoEvaluado);
            }
            //if (!hilos[1].IsAlive)
            //{
            //    hilos[1].Start(txtProximoAlumno);
            //}
            //if (!hilos[1].IsAlive)
            //{
            //    hilos[1] = new Thread(new ParameterizedThreadStart(ProximoAlumnoASerLlamado));
            //    hilos[1].Start(lstProximo);
            //}
            //if (!hilos[2].IsAlive)
            //{
            //    hilos[2] = new Thread(new ParameterizedThreadStart(ProximoAlumnoASerLlamado));
            //    hilos[2].Start(lstProximo);
            //}
            //if (!hilos[3].IsAlive)
            //{
            //    hilos[3] = new Thread(new ParameterizedThreadStart(ProximoAlumnoASerLlamado));
            //    hilos[3].Start(lstProximo);
            //}
            //if (!hilos[4].IsAlive)
            //{
            //    hilos[4] = new Thread(new ParameterizedThreadStart(ProximoAlumnoASerLlamado));
            //    hilos[4].Start(lstProximo);
            //}
        }

    }
}
