using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Persona
    {
        protected string mail;
        public Docente()
        {

        }
        public Docente(string nombre, string apellido, int edad, int dni, string direccion,  int id, string sexo, string mail) :
            base(nombre, apellido, edad, dni, direccion, id, sexo)
        {
            this.Mail = mail;
        }

        public string Mail
        {
            get { return this.mail; }
            set { this.mail = value; }
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }
    }
}
