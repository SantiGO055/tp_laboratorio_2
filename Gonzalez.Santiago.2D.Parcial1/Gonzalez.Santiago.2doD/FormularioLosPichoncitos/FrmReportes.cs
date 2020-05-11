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
namespace FormularioLosPichoncitos
{
    public partial class FrmReportes : Form
    {
        List<Responsable> listaResponsables;
        List<Docente> listaDocentes;
        List<Administrativo> listaAdministrativos;
        List<Aula> listaDeAulas;
        List<Alumno> listaDeAlumnos;
        float precioCuota;
        float precioTotal;
        public FrmReportes()
        {
            InitializeComponent();

        }
        public FrmReportes(List<Responsable> listaResponsables) : this()
        {
            this.listaResponsables = listaResponsables;

        }
        public FrmReportes(List<Docente> listaDocentes) : this()
        {
            this.listaDocentes = listaDocentes;
        }
        public FrmReportes(List<Administrativo> listaAdministrativos) : this()
        {
            this.listaAdministrativos = listaAdministrativos;
        }
        public FrmReportes(List<Aula> listaDeAulasMañana, List<Alumno> listaDeAlumnos) : this()
        {
            this.listaDeAulas = listaDeAulasMañana;
            this.listaDeAlumnos = listaDeAlumnos;
        }
        private void FrmReportes_Load(object sender, EventArgs e)
        {


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RealizarReporte(string tipoReporte)
        {
            switch (tipoReporte)
            {
                case "responsables":
                    foreach (var item in listaResponsables)
                    {
                        lstReporte.Items.Add(item.ToString());
                    }
                    break;
                case "docentes":
                    foreach (var item in listaDocentes)
                    {
                        lstReporte.Items.Add(item.Nombre + " " + item.Apellido + ". Sueldo: " + item.HorasMensuales.ToString());
                    }
                    break;
                case "administrativos":
                    foreach (var item in listaAdministrativos)
                    {
                        lstReporte.Items.Add(item.Nombre + " " + item.Apellido + ". Sueldo: " + item.Salario.ToString());
                    }
                    break;
                case "aulas":

                    foreach (var aulas in listaDeAulas)
                    {
                        foreach (var alumno in aulas.Alumnos)
                        {
                            if (aulas.Alumnos.Contains(alumno))
                            {
                                lstReporte.Items.Add("Sala color: " + aulas.ColorSala.ToString() + " recaudo: " + alumno.PrecioCuota.ToString());
                                precioCuota += alumno.PrecioCuota;
                            }
                        }
                    }
                    break;
                case "aulasTotal":
                    foreach (var aulas in listaDeAulas)
                    {
                        foreach (var alumno in aulas.Alumnos)
                        {
                            
                            precioTotal += alumno.PrecioCuota;
                        }


                    }
                    lstReporte.Items.Add("Total recaudado: " + precioTotal);
                    break;

                default:

                    break;
            }

        }
    }
}
