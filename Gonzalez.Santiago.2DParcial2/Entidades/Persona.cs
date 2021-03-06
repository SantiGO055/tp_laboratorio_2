﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public abstract class Persona
    {
        #region "Atributos"
        protected int id;
        protected string nombre;
        protected string apellido;
        protected string sexo;
        protected int dni;
        protected int edad;
        protected string direccion;
        #endregion

        #region "Propiedades"
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

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }


        #endregion

        #region "Constructores"
        public Persona()
        {

        }
        public Persona(string nombre, string apellido,int edad,int dni, string direccion,int id)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Id = id;
            this.Edad = edad;
            this.Direccion = direccion;
        }

        #endregion

        #region "Metodos"
        /// <summary>
        /// Publica los datos de la persona
        /// </summary>
        /// <returns>Retorna StringBuilder con todos los datos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine(". Apellido: " + this.Apellido);

            return sb.ToString();
        }
        #endregion
    }
}
