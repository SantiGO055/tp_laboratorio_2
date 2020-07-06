using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Observaciones
    {

    }
    public class Evaluaciones
    {
        protected int nota1;
        protected int nota2;
        protected float notaFinal;
        protected string observaciones;
        protected Alumno alumno;
        protected Docente docente;
        protected Aula aula;
        private Random notaRandom = new Random();

        public Evaluaciones()
        {

        }
        public Evaluaciones(int nota1, int nota2, int notaFinal, string observaciones, Alumno alumno, Docente docente, Aula aula)
        {
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.notaFinal = notaFinal;
            this.Observaciones = observaciones;
            this.Alumno = alumno;
            this.Docente = docente;
            this.Aula = aula;
        }


        public int Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }
        public int Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }
        public float NotaFinal
        {
            get { return notaFinal; }
            set { notaFinal = value; }
        }
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        public Alumno Alumno
        {
            get { return alumno; }
            set { alumno = value; }
        }
        public Docente Docente
        {
            get { return docente; }
            set { docente = value; }
        }
        public Aula Aula
        {
            get { return aula; }
            set { aula = value; }
        }
        public int GenerarNotaRandom()
        {
            int nota1 = notaRandom.Next(1, 10);
            int nota2 = notaRandom.Next(1, 10);
            int notaFinal;
            notaFinal = (nota1 + nota2) / 2;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.NotaFinal = notaFinal;

            return notaFinal;
        }

        public void InsertarASql()
        {
            SQL.InsertarEvaluacion(this);
        }
        public void GenerarObservacionRandom()
        {
            string observacionRandom = "";
            switch (notaRandom.Next(1, 5))
            {
                case 1:
                    observacionRandom = "Algunos errores son debido a descuidos o falta de atencion";
                    break;
                case 2:
                    observacionRandom = "Necesita practicar la expresion oral a diario";
                    break;
                case 3:
                    observacionRandom = "Necesita practicar la expresion oral a diario";
                    break;
                case 4:
                    observacionRandom = "Buen rendimiento";
                    break;
                case 5:
                    observacionRandom = "Trabajo limpio y ordenadamente";
                    break;
            }
            this.Observaciones = observacionRandom;
        }

    }
}
