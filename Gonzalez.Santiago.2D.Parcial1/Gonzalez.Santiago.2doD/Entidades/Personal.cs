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

        public Personal(string nombre, string apellido, int dni, bool femenino) : base(nombre,apellido,dni,femenino)
        {

        }

        public Personal(string nombre, string apellido, int dni) :base(nombre,apellido,dni)
        {

        }
        public Personal(string nombre, string apellido, int dni, bool femenino,DateTime horaEntrada, DateTime horaSalida) :this(nombre,apellido,dni,femenino)
        {
            this.HoraEntrada = horaEntrada;
            this.HoraSalida = horaSalida;
            //DateTime d = new DateTime(01, 01, 01, horaEntrada, 00, 00);
            //DateTime a = new DateTime(01, 01, 01, horaSalida, 00, 00);
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


    }
}
