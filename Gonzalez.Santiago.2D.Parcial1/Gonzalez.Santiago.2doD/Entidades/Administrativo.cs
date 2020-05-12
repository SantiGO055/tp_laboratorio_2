using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrativo : Personal
    {
        protected ECargo cargo;
        public static double SalarioBase;

        //el constructor estatico de Administrativo setea el atributo estatico salarioBase a 30000

        /*agregamos 2 cosas, que el constructor estatico de Administrativo setea el atributo estatico salarioBase a 30000
        y que el ctor de Responsable tambien pide el telefono*/
        static Administrativo()
        {
            SalarioBase = 30000;
        }
        public Administrativo(string nombre, string apellido, int dni, bool femenino, ECargo cargo) : base(nombre, apellido, dni, femenino)
        {
            this.Cargo = cargo;
        }

        public ECargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        /// <summary>
        /// Calcula el salario por mes del administrativo
        /// </summary>
        /// <returns>retorna valor double del sueldo calculado</returns>
        protected override double CalcularSalario()
        {
            return ((SalarioBase * (int)this.cargo) / 100); //chequear que realice bien la cuenta
        }
        /// <summary>
        /// Sobrecarga del metodo ToString que publica datos del administrativo
        /// </summary>
        /// <returns>Retorna string con los </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(". Horas Mensuales: " + this.CalcularSalario());
            return sb.ToString();
        }
    }
}
