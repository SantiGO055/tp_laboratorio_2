using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region "Constructores"
        public Universitario()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, Persona.ENacionalidad nacionalidad) :
            base(nombre, apellido, dni, nacionalidad)
        {
            this.Legajo = legajo;
        }
        #endregion

        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        /// <summary>
        /// Retorna string con los datos del universitario
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("LEGAJO NUMERO: " + this.Legajo);
            return sb.ToString();
        }
        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Verifica que dos objetos universitario no sean nulos, sean del mismo tipo y mismo dni
        /// </summary>
        /// <param name="univ1"></param>
        /// <param name="univ2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario univ1, Universitario univ2)
        {
            bool retorno = false;
            if (!ReferenceEquals(univ1, null) && !ReferenceEquals(univ2, null))
            {
                if (univ1.GetType() == univ2.GetType())
                {
                    if ((univ1.DNI.Equals(univ2.DNI) || univ1.legajo.Equals(univ2.legajo)))
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
            
        }

        /// <summary>
        /// Verifica que el objeto univ1 sea distinto a univ2
        /// </summary>
        /// <param name="univ1"></param>
        /// <param name="univ2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario univ1, Universitario univ2)
        {
            return !(univ1 == univ2);
        }

        /// <summary>
        /// Verifica si la instancia actual de la clase Universitario es igual al objeto pasado como parametro
        /// </summary>
        /// <param name="obj">objeto a comparar con la instancia actual</param>
        /// <returns>true si son iguales, false caso contrario</returns>
        public override bool Equals(object obj)
        {
            return this == (Universitario)obj;
        }

    }
}
