﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Persona
    {
        protected string email;
        public Docente()
        {

        }
        //string nombre, string apellido,int edad,int dni, string direccion,int id
        public Docente(string nombre, string apellido, int edad, int dni, string direccion,  int id, string sexo, string email) :
            base(nombre, apellido, edad, dni, direccion, id)
        {
            this.Email = email;
            this.Sexo = sexo;
        }


        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }


    }
}
