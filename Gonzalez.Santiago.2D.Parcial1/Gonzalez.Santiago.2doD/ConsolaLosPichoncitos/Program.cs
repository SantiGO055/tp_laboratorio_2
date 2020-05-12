using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace ConsolaLosPichoncitos
{
    public class Program
    {
        static void Main(string[] args)
        {

            Docente docente1 = new Docente("Juan", "Gonzalez", 39789456, false, HoraEntrada(8), HoraSalida(17), 200);

            Administrativo portera1 = new Administrativo("Ramona", "Perez", 123456789, true, ECargo.Portería);
            Administrativo cocinera1 = new Administrativo("Pepita", "Juarez", 123654987, true, ECargo.Cocina);



            //Creo responsable
            Responsable responsableDeAlumno1 = new Responsable("Gabriel", "Luli", 99999999, false, EParentesco.Padre, "0800111222");
            //Creo alumno
            Alumno alumno1 = new Alumno("Jaimito", "Luli", 11111111, false, 4500, responsableDeAlumno1,45671);
            Alumno alumno2 = new Alumno("PEPE", "Luigi", 11111111, false, 5000, responsableDeAlumno1,45671);
            //devuelve el responsable de alumno1
            responsableDeAlumno1 = alumno1;
            //creo el aula
            Aula salitaRoja = new Aula(EColores.Rojo, ETurno.Mañana, docente1);

            if (salitaRoja + alumno1) ;
            if (salitaRoja + alumno1) ; //chequeo si el alumno esta o no en la salita

            Console.WriteLine( salitaRoja.ToString());


            

            //imprimo docente con sueldo calculado
            //Console.WriteLine("Docente: ");
            //Console.WriteLine(docente1.ToString());

            //imprimo administrativo con sueldo calculado
            Console.WriteLine("Portera: " + portera1.ToString());
            Console.WriteLine("Cocinera: " + cocinera1.ToString());
            Console.WriteLine("Salario total de todo el personal por mes: " + SalarioMensualPersonal());
            Console.WriteLine("Cuota mensual recaudada de alumnos: " + CuotaDeAlumnoMensual());


            Console.ReadKey();


            //Utilizo este metodo para recibir la hora de entrada y retornar un objeto datetime con la hora de entrada
            DateTime HoraEntrada(int horaEntrada)
            {
                //DateTime.Now.ToString("H:mm");
                DateTime miHorarioEntrada = new DateTime(1, 1, 1, horaEntrada, 0, 0);

                return miHorarioEntrada;
            }
            //Utilizo este metodo para recibir la hora de salida y retornar un objeto datetime con la hora de salida
            DateTime HoraSalida(int horaSalida)
            {
                //DateTime.Now.ToString("H:mm");
                DateTime miHorarioSalida = new DateTime(1, 1, 1, horaSalida, 0, 0);

                return miHorarioSalida;
            }

            double SalarioMensualPersonal()
            {
                return docente1.HorasMensuales + portera1.Salario + cocinera1.Salario;
            }
            double CuotaDeAlumnoMensual()
            {
                return alumno1.PrecioCuota + alumno2.PrecioCuota;
            }
        }

    }
}
