using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected bool femenino;


        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public bool Femenino
        {
            get { return this.femenino; }
            set { this.femenino = value; }
        }

        public Persona(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }
        public Persona(string nombre, string apellido, int dni, bool femenino) : this(nombre, apellido, dni)
        {
            this.Femenino = femenino;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine(". Apellido: " + this.Apellido);
            sb.AppendLine(". Dni: " + this.Dni);
            if (this.femenino)
            {
                sb.AppendLine(". Genero: Femenino");
            }
            else
            {
                sb.AppendLine(". Genero: Masculino");
            }

            return sb.ToString();
        }

    }
}
