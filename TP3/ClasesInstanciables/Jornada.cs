using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace ClasesInstanciables
{
    public class Jornada
    {
        #region "Atributos"
        private Profesor instructor;
        private Universidad.EClases clase;
        private List<Alumno> alumnos;
        #endregion

        #region "Constructores"
        public Jornada()
        {
            alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clases, Profesor instructor) : this()
        {
            this.clase = clases;
            this.instructor = instructor;
        }

        #endregion

        #region "Propiedades"
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        public Profesor Instructor
        {
            get { return this.instructor; }
            set { this.instructor = value; }
        }
        public Universidad.EClases Clases
        {
            get { return this.clase; }
            set { this.clase = value; }
        }
        #endregion


        #region "Metodos"
        public static bool operator ==(Jornada jornada, Alumno alumno)
        {
            if (!(jornada is null))
            {
                foreach (var alumnoJornada in jornada.alumnos)
                {
                    if (alumno == alumnoJornada)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Jornada jornada, Alumno alumno)
        {
            return !(jornada == alumno);
        }

        public static Jornada operator +(Jornada jornada, Alumno alumno)
        {
            if (jornada != alumno)
            {
                jornada.alumnos.Add(alumno);
            }
            return jornada;
        }

        /// <summary>
        /// Sobreescribe el metodo ToString para publicar los datos de la clase junto con profesor y alumnos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASE DE: " + clase.ToString() + " TOMADA POR: " + instructor.ToString());

            sb.AppendLine("Alumnos: ");
            foreach (var alumno in alumnos)
            {
                sb.AppendLine(alumno.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Guarda en un archivo de texto todos los datos de la jornada
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            try
            {
                Texto texto = new Texto();
                string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Jornada.txt";
                texto.Guardar(path, jornada.ToString());
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
        }

        /// <summary>
        /// Lee los datos de la jornada en modo texto
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            try
            {
                Texto texto = new Texto();
                string datos;
                texto.Leer("Jornada.txt", out datos);
                return datos;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
        }
        #endregion
    }
}
