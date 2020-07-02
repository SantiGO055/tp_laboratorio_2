using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Aula
    {
        protected List<Alumno> alumnos;
        protected Docente docente;

        public Aula(Docente docente)
        {
            this.Docente = docente;
            this.alumnos = new List<Alumno>();
        }


        #region Propiedades
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            //verificar si rompe o no
            set
            {

                this.alumnos = value;


            }
        }

        public Docente Docente
        {
            get { return this.docente; }
            set { this.docente = value; }
        }
        #endregion

        public static bool operator +(Aula aula, Alumno alumno)
        {
            if ((!(aula is null)) && (!(alumno is null)) && (aula.alumnos.Count < 30))
            {
                if (!(aula.alumnos.Contains(alumno)))
                {
                    aula.Alumnos.Add(alumno);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Docente: " + this.Docente);
            foreach (var item in this.alumnos)
            {
                sb.AppendLine("Alumnos: ");
                sb.AppendLine("Nombre: " + item.Nombre);
                sb.AppendLine("Apellido: " + item.Apellido);
                sb.AppendLine("Legajo: " + item.Legajo);
            }


            return sb.ToString();
        }
    }
}
