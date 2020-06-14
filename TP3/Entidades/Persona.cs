using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace EntidadesAbstractas
{
    
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;

        public Persona()
        {

        }

        #region "Constructores"
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni,ENacionalidad nacionalidad ) : this(nombre, apellido, nacionalidad)
        {
            DNI = dni;
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            StringDNI = dni;
        }
        #endregion

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = ValidarNombreApellido(value); }
        }

        
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = ValidarNombreApellido(value); }
        }
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set {
                switch (value)
                {
                    case ENacionalidad.Argentino:
                    case ENacionalidad.Extranjero:
                        this.nacionalidad = value;
                        break;
                    default:
                        throw new NacionalidadInvalidaException("Nacionalidad" + value + "invalida.");
                }
            }
        }
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = ValidarDni(this.nacionalidad,value); }
        }
        public string StringDNI
        {
            set { DNI = ValidarDni(this.nacionalidad,value); }
        }




        public int ValidarDni(ENacionalidad nacionalidad, int dni)
        {
            if (ENacionalidad.Argentino.Equals(nacionalidad) && dni >= 1 && dni <= 89999999)
            {
                return dni;
            }
            if (ENacionalidad.Extranjero.Equals(nacionalidad) && dni >= 90000000 && dni <= 99999999)
            {
                return dni;
            }
            else
                throw new NacionalidadInvalidaException("Nacionalidad incorrecta");
        }

        public int ValidarDni(ENacionalidad nacionalidad, string dni)
        {
            if (int.TryParse(dni,out int dniEntero))
            {
                switch (nacionalidad)
                {
                    case ENacionalidad.Argentino:
                        if (dniEntero >= 1 && dniEntero <= 89999999)
                        {
                            return dniEntero;
                        }
                        break;
                    case ENacionalidad.Extranjero:
                        if (dniEntero >= 90000000 && dniEntero <= 99999999)
                        {
                            return dniEntero;
                        }
                        break;
                    default:
                        throw new DniInvalidoException("DNI: " + dni + " no es valido");
                }
            }
            return dniEntero;
                
        }

        private string ValidarNombreApellido(string dato)
        {
            bool validaLetra = false; ;

            foreach (var letra in dato)
            {
                if (!Char.IsLetter(letra))
                {
                    validaLetra = true;
                }
            }
            return validaLetra ? string.Empty : dato;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE COMPLETO: " + this.Apellido + ", "+ this.Nombre);
            sb.AppendLine("NACIONALIDAD: " + this.Nacionalidad + "\n");
            return sb.ToString();
        }

    }
}
