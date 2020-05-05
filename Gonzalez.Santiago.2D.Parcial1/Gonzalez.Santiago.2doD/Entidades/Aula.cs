using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        protected List<Alumno> alumnos;
        protected EColores colorSala;
        protected Docente docente;
        protected ETurno turno;

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos.Add(value); }
        }

    }
}
