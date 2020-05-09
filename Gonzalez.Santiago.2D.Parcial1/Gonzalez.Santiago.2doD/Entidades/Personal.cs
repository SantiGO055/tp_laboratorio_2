using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personal : Persona
    {
        protected DateTime horaEntrada;
        protected DateTime horaSalida;

        public Personal(string nombre, string apellido, int dni, bool femenino) : base(nombre, apellido, dni, femenino)
        {

        }

        public Personal(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {

        }
        public Personal(string nombre, string apellido, int dni, bool femenino, DateTime horaEntrada, DateTime horaSalida) : this(nombre, apellido, dni, femenino)
        {
            this.HoraEntrada = horaEntrada;
            this.HoraSalida = horaSalida;

        }


        #region Propiedades
        public DateTime HoraEntrada
        {
            get { return this.horaEntrada; }
            set { this.horaEntrada = value; }
        }
        public DateTime HoraSalida
        {
            get { return this.horaSalida; }
            set { this.horaSalida = value; }
        }

        public double Salario
        {
            get { return CalcularSalario(); }
        }

        #endregion

        protected abstract double CalcularSalario();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(". Hora Entrada: \n" + this.HoraEntrada);
            sb.AppendLine(". Hora Salida: \n" + this.HoraSalida);
            return sb.ToString();
        }

    }
}
