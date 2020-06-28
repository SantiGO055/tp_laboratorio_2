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

        #region "Atributos"
        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;
        #endregion

        #region "Constructores"
        public Persona()
        {

        }
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

        #region "Propiedades"
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
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }
        public string StringDNI
        {
            set { DNI = ValidarDni(this.nacionalidad, value); }
        }
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set
            {
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
        #endregion

        #region "Metodos"
        /// <summary>
        /// Valida que el dni ingresado sea correcto para la nacionalidad
        /// Caso contrario ejecuta la excepcion de nacionalidad incorrecta
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dni"></param>
        /// <returns>DNI entero</returns>
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

        /// <summary>
        /// Valida que el dni que llega por parametro sea string
        /// Caso contrario lo retorna
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dni"></param>
        /// <returns>DNI Entero</returns>
        public int ValidarDni(ENacionalidad nacionalidad, string dni)
        {
            if (int.TryParse(dni,out int dniEntero))
            {
                ValidarDni(nacionalidad, dniEntero);
            }
            else
            {
                throw new DniInvalidoException();
            }
            return dniEntero;
                
        }

        /// <summary>
        /// Valida que el nombre o apellido sea string
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Publica los datos de la persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE COMPLETO: " + this.Apellido + ", "+ this.Nombre);
            sb.AppendLine("NACIONALIDAD: " + this.Nacionalidad + "\n");
            return sb.ToString();
        }
        #endregion
    }
}
