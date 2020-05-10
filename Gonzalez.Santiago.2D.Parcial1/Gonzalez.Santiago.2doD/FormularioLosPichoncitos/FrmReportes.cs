﻿using System;
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
        public FrmReportes(List<Aula> listaDeAulas, List<Alumno> listaDeAlumnos) : this()
        {
            this.listaDeAulas = listaDeAulas;
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
                        foreach (var alumno in listaDeAlumnos)
                        {
                            if (aulas.Alumnos.Contains(alumno))
                            {
                                precioCuota += alumno.PrecioCuota;
                            }
                            
                        }
                    }
                    lstReporte.Items.Add("Precio total de las cuotas recaudadas: " + precioCuota.ToString());
                    break;
                default:

                    break;
            }
            
        }
    }
}
