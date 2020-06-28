using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using ClasesInstanciables;
using EntidadesAbstractas;
using Archivos;
namespace UnitTests
{
    [TestClass]
    public class TesteoUnitario
    {
        /// <summary>
        /// Test que valida que se ejecute la excepcion de alumno repetido
        /// al agregar mismo alumno a la universidad
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void AgregarAlumnoRepetido()
        {
            Universidad utn = new Universidad();
            Alumno a1 = new Alumno(1, "Juan", "Lopez", "12234456",
                Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
                Alumno.EEstadoCuenta.AlDia);
            Alumno a2 = new Alumno(2, "Juana", "Martinez", "99899999",
                Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
                Alumno.EEstadoCuenta.Becado);
            Alumno a3 = new Alumno(2, "Juana", "Martinez", "99999999",
                Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
                Alumno.EEstadoCuenta.Deudor);
            utn += a1;
            utn += a2;
            utn += a3;
        }

        /// <summary>
        /// Test que valida que se ejecute la excepcion nacionalidad invalida
        /// para el dni ingresado
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void AgregarAlumnoConDniInvalidoParaLaNacionalidadQuePosee()
        {
            Universidad utn = new Universidad();
            Alumno a1 = new Alumno(1, "Juan", "Lopez", "12234456",
                Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
                Alumno.EEstadoCuenta.AlDia);
            Alumno a2 = new Alumno(2, "Juana", "Martinez", "11234654",
                Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
                Alumno.EEstadoCuenta.Becado);
            Alumno a3 = new Alumno(2, "Juana", "Martinez", "17894234",
                Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
                Alumno.EEstadoCuenta.Deudor);
            utn += a1;
            utn += a2;
            utn += a3;
        }

        /// <summary>
        /// Test que valida que se ejecute la excepcion de dni invalido
        /// al ingresar un string que no son numeros al dni
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void DniInvalido()
        {
            Alumno alumno1 = new Alumno(1, "Pepito", "Peposo", "DNI",
                Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.AlDia);
        }

        [TestMethod]
        public void AgregarTresAlumnosALaLista()
        {
            Universidad utn = new Universidad();
            Alumno a1 = new Alumno(1, "Juan", "Lopez", "12234456",
                Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
                Alumno.EEstadoCuenta.AlDia);
            Alumno a2 = new Alumno(2, "Juana", "Martinez", "99123456",
                Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
                Alumno.EEstadoCuenta.Becado);
            Alumno a3 = new Alumno(3, "Pepito", "Peposo", "99456789",
                Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
                Alumno.EEstadoCuenta.Deudor);
            utn += a1;
            utn += a2;
            utn += a3;

            Assert.IsNotNull(utn.Alumnos.Count);
            Assert.AreEqual(3, utn.Alumnos.Count);
        }
    }
}
