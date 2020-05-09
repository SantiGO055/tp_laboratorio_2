using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        protected EColores colorSala;
        protected int legajo;
        protected float precioCuota;
        protected Responsable responsable;

        public Alumno(string nombre, string apellido, int dni, bool femenino, float precioCuota, Responsable responsable,int legajo) : base(nombre, apellido, dni, femenino)
        {
            this.PrecioCuota = precioCuota;
            this.Responsable = responsable;
            this.Legajo = legajo;
        }


        public EColores ColorSala
        {
            get { return this.colorSala; }
            set { this.colorSala = value; }
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
        public Responsable Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }

        public static implicit operator Responsable(Alumno al)
        {
            return al.Responsable;
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
            sb.AppendLine(".Color de la sala: " + this.ColorSala);
            sb.AppendLine(".Responsable: " + this.Responsable);
            sb.AppendLine(".Precio de la cuota: " + this.PrecioCuota);

            return sb.ToString();
        }


    }
}
