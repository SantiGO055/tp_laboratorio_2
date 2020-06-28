using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        #region "Atributos"
        private Queue<Universidad.EClases> claseDelDia;
        private static Random random;
        #endregion

        #region "Constructores"
        static Profesor()
        {
            random = new Random();
        }
        public Profesor()
        {

        }
        public Profesor(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) :
            base(legajo, nombre, apellido, dni, nacionalidad)
        {
            this.claseDelDia = new Queue<Universidad.EClases>();
            _randomClases();
            _randomClases();
        }
        #endregion



        #region "Metodos"

        /// <summary>
        /// Sobreescribe el metodo mostrando las clases del dia
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA: ");
            foreach (Universidad.EClases item in this.claseDelDia)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Muestra todos los datos del profesor
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

        /// <summary>
        /// Sobreescribe metodo ToString para publicar todos los datos del profesor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return MostrarDatos();
        }

        /// <summary>
        /// Genera dos clases random del tipo EClase a la cola de clases
        /// </summary>
        void _randomClases()
        {
            random = new Random();
            claseDelDia.Enqueue((Universidad.EClases)random.Next(0, 4));
        }

        /// <summary>
        /// Un profesor sera igual a EClase solo si el profesor da esa clase
        /// </summary>
        /// <param name="profesor"></param>
        /// <param name="clases"></param>
        /// <returns></returns>
        public static bool operator ==(Profesor profesor, Universidad.EClases clases)
        {
            if (!(profesor is null))
            {
                foreach (Universidad.EClases clase in profesor.claseDelDia)
                {
                    if (clase.Equals(clases))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// El profesor no sera igual a EClase solo si el profesor no da esa clase
        /// </summary>
        /// <param name="profesor"></param>
        /// <param name="clases"></param>
        /// <returns></returns>
        public static bool operator !=(Profesor profesor, Universidad.EClases clases)
        {
            return !(profesor == clases);
        }
        #endregion
    }
}
