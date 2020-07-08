using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListaDePaquetesDeCorreoInstanciada()
        {
            Correo correo = new Correo();

            Assert.AreEqual(correo.Paquetes.Count, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(TrackingIDRepetidoException))]
        public void IDRepetido()
        {
            Correo correo = new Correo();
            correo += new Paquete("Av. Chiclana 4321", "12332");
            correo += new Paquete("Av. Chiclana 4321", "12332");
            Assert.AreEqual(correo.Paquetes.Count, 1);
        }
    }
}
