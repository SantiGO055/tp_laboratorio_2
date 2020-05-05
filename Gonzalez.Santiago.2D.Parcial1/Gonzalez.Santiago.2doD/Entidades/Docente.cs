using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente : Personal
    {
        protected double valorHora;
        public Docente(string nombre, string apellido, int dni, bool femenino,DateTime horaEntrada, DateTime horaSalida, double valorHora) : base(nombre, apellido, dni, femenino,horaEntrada,horaSalida)
        {
            this.ValorHora = valorHora;
        }


        public double ValorHora
        {
            get { return this.valorHora; }
            set { this.valorHora = value; }
        }


        public int HorasMensuales
        {
            get { return Convert.ToInt32(CalcularSalario()); }
        }

        /*multiplicando el valorHora por la cantidad de horas diarias por 20 días hábiles*/
        protected override double CalcularSalario()
        {
            return this.valorHora * (this.HoraSalida.Hour - this.HoraEntrada.Hour) * 480;
        }
    }
}
