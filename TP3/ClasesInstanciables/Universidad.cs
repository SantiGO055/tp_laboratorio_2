using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Excepciones;
using Archivos;

namespace ClasesInstanciables
{

    public class Universidad
    {

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

        private List<Alumno> alumnos;
        private List<Profesor> profesores;
        private List<Jornada> jornadas;

        public Universidad()
        {
            alumnos = new List<Alumno>();
            profesores = new List<Profesor>();
            jornadas = new List<Jornada>();
        }

        #region "Propiedades"
        public Jornada this[int index]
        {
            get { return this.jornadas[index]; }
            set { this.jornadas[index] = value; }
        }
        public List<Jornada> Jornada
        {
            get { return this.jornadas; }
            set { this.jornadas = value; }
        }

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        public List<Profesor> Instructores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }

        #endregion

        /// <summary>
        /// Guarda objeto universidad en archivo Universidad.xml ubicado en bin\debug
        /// </summary>
        /// <param name="universidad"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad universidad)
        {
            Xml<Universidad> xmlUniversidad = new Xml<Universidad>();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Universidad.Xml";
            return xmlUniversidad.Guardar(path, universidad);
        }

        /// <summary>
        /// Lee el objeto universidad del archivo Universidad.xml ubicado en bin\debug
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer()
        {
            Universidad universidad = new Universidad();
            Xml<Universidad> xmlUniversidad = new Xml<Universidad>();
            if (xmlUniversidad.Leer(AppDomain.CurrentDomain.BaseDirectory + "Universidad.Xml", out universidad))
            {
                return universidad;
            }
            return universidad;
        }


        private static string MostrarDatos(Universidad universidad)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("JORNADA: ");

            foreach (Jornada jornada in universidad.Jornada)
            {
                sb.AppendLine(jornada.ToString());
                sb.AppendLine("<---------------------------------------------->\n");
            }
            return sb.ToString();
        }



        #region "Metodos sobreescritos"
        #region "(Universidad y alumno)"
        /// <summary>
        /// Sobreescribe el metodo == donde la lista de alumnos de la universidad
        /// es igual al alumno pasado por parametro
        /// </summary>
        /// <param name="universidad"></param>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad universidad, Alumno alumno)
        {
            if (!(universidad is null))
            {
                foreach (var alumnosUniversidad in universidad.alumnos)
                {
                    if (alumnosUniversidad == alumno)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Universidad distinto a alumno cuando la lista de alumnos no posee al alumno cargado
        /// </summary>
        /// <param name="universidad"></param>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad universidad, Alumno alumno)
        {
            return !(universidad == alumno);
        }

        /// <summary>
        /// Agrega un alumno a la lista de alumnos de la universidad
        /// </summary>
        /// <param name="universidad"></param>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad universidad, Alumno alumno)
        {
            if (universidad == alumno)
            {
                throw new AlumnoRepetidoException("Alumno repetido");
            }
            else
            {
                universidad.alumnos.Add(alumno);
            }

            return universidad;
        }

        #endregion

        #region "(universidad y profesor)"
        /// <summary>
        /// Sobreescribe el metodo == donde la lista de profesores contiene al profesor pasado por parametro
        /// </summary>
        /// <param name="universidad"></param>
        /// <param name="profesor"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad universidad, Profesor profesor)
        {
            if (!(universidad is null))
            {
                foreach (var profesorUniversidad in universidad.profesores)
                {
                    if (profesorUniversidad == profesor)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Sobreescribe el metodo distinto (!=) donde la lista de profesores de la universidad 
        /// no posee al profesor pasado como parametro
        /// </summary>
        /// <param name="universidad"></param>
        /// <param name="profesor"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad universidad, Profesor profesor)
        {
            return !(universidad == profesor);
        }

        /// <summary>
        /// Agrego un profesor a la lista de profesores de la universidad
        /// </summary>
        /// <param name="universidad"></param>
        /// <param name="profesor"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad universidad, Profesor profesor)
        {
            if (universidad != profesor)
            {
                universidad.profesores.Add(profesor);
            }
            return universidad;
        }
        #endregion

        #region "(Universidad y clases)"



        /// <summary>
        /// Sobreescribe el metodo == donde la lista de profesores contiene a la clase
        /// Para saber si el profesor esta ocupado en esa clase
        /// </summary>
        /// <param name="universidad"></param>
        /// <param name="clases"></param>
        /// <returns></returns>
        public static Profesor operator ==(Universidad universidad, Universidad.EClases clases)
        {
            foreach (Profesor profesor in universidad.profesores)
            {
                if (profesor == clases)
                {
                    return profesor;
                }
            }
            throw new SinProfesorException("No hay profesor para la clase.");
        }

        /// <summary>
        /// Sobreescribe el metodo distinto (!=) donde verifica si el profesor
        /// no posee la clase asignada pasada como parametro
        /// </summary>
        /// <param name="universidad"></param>
        /// <param name="clases"></param>
        /// <returns></returns>
        public static Profesor operator !=(Universidad universidad, Universidad.EClases clases)
        {
            foreach (Profesor profesor in universidad.profesores)
            {
                if (profesor != clases)
                {
                    return profesor;
                }
            }
            throw new SinProfesorException("No hay profesor para la clase.");
        }
        /// <summary>
        /// Agrego una jornada a la lista de jornadas de la universidad 
        /// con los alumnos y profesores disponibles para tomarla
        /// </summary>
        /// <param name="universidad"></param>
        /// <param name="clases"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad universidad, Universidad.EClases clases)
        {
            Profesor profesorDisponible = universidad == clases;
            Jornada jornada = new Jornada(clases, profesorDisponible);

            foreach (Alumno alumno in universidad.alumnos)
            {
                if (alumno == clases)
                {
                    jornada.Alumnos.Add(alumno);
                }
            }
            universidad.jornadas.Add(jornada);

            return universidad;
        }

        #endregion


        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
        #endregion


    }
}
