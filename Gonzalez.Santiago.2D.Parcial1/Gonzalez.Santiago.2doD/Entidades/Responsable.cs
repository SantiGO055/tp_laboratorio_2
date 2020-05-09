using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Responsable : Persona
    {
        protected EParentesco parentesco;
        protected string telefono;


        public EParentesco Parentesco
        {
            get { return this.parentesco; }
            set { this.parentesco = value; }
        }
        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }
        public Responsable(string nombre, string apellido, int dni, bool femenino, EParentesco parentesco, string telefono) : base(nombre, apellido, dni, femenino)
        {
            this.Parentesco = parentesco;
            this.Telefono = telefono;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(". Parentesco: " + this.Parentesco);
            sb.AppendLine(". Telefono: " + this.Telefono);
            return sb.ToString();
        }


    }
}
