using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        protected int legajo;
        protected float precioCuota;

        public Alumno()
        {

        }
        public Alumno(string nombre, string apellido, int edad, int dni, string direccion, int id, string sexo) :
            base(nombre, apellido, edad, dni, direccion, id, sexo)
        {
            this.PrecioCuota = precioCuota;
            this.Legajo = legajo;
        }

        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }
        public float PrecioCuota
        {
            get { return this.precioCuota; }
            set { this.precioCuota = value; }
        }


        public static bool operator ==(Alumno a1, Alumno a2)
        {
            return (a1.Legajo == a2.Legajo);

        }
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return (!(a1 == a2));
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(".Legajo: " + this.Legajo);
            sb.AppendLine(".Precio de la cuota: " + this.PrecioCuota);

            return sb.ToString();
        }
    }
}
