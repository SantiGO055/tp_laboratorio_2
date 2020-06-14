using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    

    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        private Universidad.EClases clasesQueToma;
        private EEstadoCuenta estadoCuenta;

        #region "Constructores"
        public Alumno()
        {

        }
        public Alumno(int legajo, string nombre, string apellido, string dni, Persona.ENacionalidad nacionalidad, Universidad.EClases clasesQueToma) :
            base(legajo,nombre,apellido, dni,nacionalidad)
        {
            this.ClasesQueToma = clasesQueToma;
        }
        
        public Alumno(int legajo, string nombre, string apellido, string dni, Persona.ENacionalidad nacionalidad, Universidad.EClases clasesQueToma,EEstadoCuenta estadoCuenta) :
            this(legajo,nombre,apellido, dni, nacionalidad,clasesQueToma)
        {
            this.EstadoCuenta = estadoCuenta;
        }
        #endregion

        public EEstadoCuenta EstadoCuenta
        {
            get { return this.estadoCuenta; }
            set { this.estadoCuenta = value; }
        }


        public Universidad.EClases ClasesQueToma
        {
            get { return this.clasesQueToma; }
            set { this.clasesQueToma = value; }
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("TOMA CLASE DE: " + this.ClasesQueToma);
            return sb.ToString();
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("ESTADO DE LA CUENTA: " + this.estadoCuenta);
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

        public override string ToString()
        {
            
            return this.MostrarDatos();
        }

        public static bool operator ==(Alumno alumno, Universidad.EClases clase)
        {
            return alumno.clasesQueToma.Equals(clase) && !(alumno.estadoCuenta.Equals(EEstadoCuenta.Deudor));
        }
        public static bool operator !=(Alumno alumno, Universidad.EClases clase)
        {
            return !(alumno == clase);
        }

    }
}
