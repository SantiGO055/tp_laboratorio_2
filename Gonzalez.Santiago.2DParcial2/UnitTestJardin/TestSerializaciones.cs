using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace UnitTestJardin
{
    [TestClass]
    public class TestSerializaciones
    {
        /// <summary>
        /// Prueba para leer archivo binario y esperar que se ejecute
        /// la exepcion ArchivosException ya que no encuentra el archivo
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void TestDeserializacionBinariaSiElArchivoNoExiste()
        {
            Binario<List<Alumno>> binario = new Binario<List<Alumno>>();
            List<Alumno> listaAlumnos = new List<Alumno>();

            binario.Leer(ConstantePath.PATHSER + "Serializaciones\\UnitTest\\Binario\\Alumnoasd.dat", out listaAlumnos);
            
        }
        /// <summary>
        /// Prueba para deserializar un archivo binario si este archivo existe
        /// </summary>
        [TestMethod]
        public void TestDeserializacionBinariaSiElArchivoExiste()
        {
            Binario<List<Alumno>> binario = new Binario<List<Alumno>>();
            List<Alumno> listaAlumnos = new List<Alumno>();

            binario.Leer(ConstantePath.PATHSER + "Serializaciones\\UnitTest\\Binario\\Alumno.dat", out listaAlumnos);

        }
        /// <summary>
        /// Prueba para realizar serializacion binaria
        /// </summary>
        [TestMethod]
        public void TestSerializacionBinaria()
        {
            Binario<List<Alumno>> binario = new Binario<List<Alumno>>();
            //Alumno alumno = new Alumno("Pepe", "Ruiz", 4, 78456123, "1907 Parkside Pass", 1, "4");
            List<Alumno> listaAlumnos = new List<Alumno>();
            listaAlumnos.Add(new Alumno("Pepe", "Ruiz", 4, 78456123, "1907 Parkside Pass", 1, "4"));
            listaAlumnos.Add(new Alumno("Wilie", "Mensler", 5, 3395354, "1907 Parkside Pass", 2, "753"));
            listaAlumnos.Add(new Alumno("Joshua", "Leasor", 6, 9289354, "15 Jay Street", 3, "357"));
            listaAlumnos.Add(new Alumno("Jacintha", "Findlow", 2, 5044354, "67632 Laurel Drive", 4, "789"));
            listaAlumnos.Add(new Alumno("Jervis", "Cusworth", 3, 3972354, "10 Warbler Park", 5, "456"));
            listaAlumnos.Add(new Alumno("Julina", "Mather", 4, 7875354, "7 Warner Parkway", 6, "321"));
            listaAlumnos.Add(new Alumno("Morganica", "Benard", 4, 1847354, "1 Merrick Road", 7, "456"));
            listaAlumnos.Add(new Alumno("Gale", "Antrag", 7, 3956354, "37503 Steensland Trail", 8, "951"));
            listaAlumnos.Add(new Alumno("Perri", "Orrin", 8, 1295354, "59 Magdeline Center", 9, "111"));
            listaAlumnos.Add(new Alumno("Maris", "Skippen", 4, 7832354, "03270 Mockingbird Plaza", 10, "222"));
            listaAlumnos.Add(new Alumno("Olva", "Dearnly", 2, 9894354, "7 Morrow Road", 11, "333"));
            listaAlumnos.Add(new Alumno("Loretta", "Kuhnel", 3, 2048354, "63427 Eggendart Point", 12, "444"));
            listaAlumnos.Add(new Alumno("Debra", "Shouler", 2, 1658354, "4862 Columbus Avenue", 13, "555"));
            listaAlumnos.Add(new Alumno("Vitoria", "Birckmann", 4, 3755354, "36 Rigney Place", 14, "666"));


            binario.Guardar(ConstantePath.PATHSER + "Serializaciones\\UnitTest\\Binario\\", "Alumno.dat", listaAlumnos);

        }
        
        /// <summary>
        /// Prueba para realizar serializacion xml
        /// </summary>
        [TestMethod]
        public void TestSerializacionXml()
        {
            Xml<List<Docente>> xmlDocente = new Xml<List<Docente>>();
            List<Docente> listaDocentes = new List<Docente>();

            //(string nombre, string apellido, int edad, int dni, string direccion,  int id, string sexo, string email)
            listaDocentes.Add(new Docente("Pepe", "Ruiz", 4, 78456123, "1907 Parkside Pass", 1, "masculino", "prueba@gmail.com"));
            listaDocentes.Add(new Docente("Wilie", "Mensler", 5, 3395354, "1907 Parkside Pass", 2, "masculino", "prueba@gmail.com"));
            listaDocentes.Add(new Docente("Joshua", "Leasor", 6, 9289354, "15 Jay Street", 3, "masculino", "prueba@gmail.com"));
            listaDocentes.Add(new Docente("Jacintha", "Findlow", 2, 5044354, "67632 Laurel Drive", 4, "masculino", "prueba@gmail.com"));
            listaDocentes.Add(new Docente("Jervis", "Cusworth", 3, 3972354, "10 Warbler Park", 5, "masculino", "prueba@gmail.com"));
            listaDocentes.Add(new Docente("Julina", "Mather", 4, 7875354, "7 Warner Parkway", 6, "masculino", "prueba@gmail.com"));
            listaDocentes.Add(new Docente("Morganica", "Benard", 4, 1847354, "1 Merrick Road", 7, "masculino", "prueba@gmail.com"));
            listaDocentes.Add(new Docente("Gale", "Antrag", 7, 3956354, "37503 Steensland Trail", 8, "masculino", "prueba@gmail.com"));
            listaDocentes.Add(new Docente("Perri", "Orrin", 8, 1295354, "59 Magdeline Center", 9, "masculino", "prueba@gmail.com"));
            listaDocentes.Add(new Docente("Maris", "Skippen", 4, 7832354, "03270 Mockingbird Plaza", 10, "masculino", "prueba@gmail.com"));
            listaDocentes.Add(new Docente("Olva", "Dearnly", 2, 9894354, "7 Morrow Road", 11, "masculino", "prueba@gmail.com"));
            listaDocentes.Add(new Docente("Loretta", "Kuhnel", 3, 2048354, "63427 Eggendart Point", 12, "masculino", "prueba@gmail.com"));
            listaDocentes.Add(new Docente("Debra", "Shouler", 2, 1658354, "4862 Columbus Avenue", 13, "masculino", "prueba@gmail.com"));
            listaDocentes.Add(new Docente("Vitoria", "Birckmann", 4, 3755354, "36 Rigney Place", 14, "masculino", "prueba@gmail.com"));

            xmlDocente.Guardar(ConstantePath.PATHSER + "Serializaciones\\UnitTest\\Xml\\", "Docentes.xml", listaDocentes);
        }
        /// <summary>
        /// Prueba para deserializar archivo xml
        /// </summary>
        [TestMethod]
        public void TestDeserializacionXml()
        {
            Xml<List<Docente>> xmlDocente = new Xml<List<Docente>>();
            List<Docente> listaDocentes = new List<Docente>();

            xmlDocente.Leer(ConstantePath.PATHSER + "Serializaciones\\UnitTest\\Xml\\Docentes.xml", out listaDocentes);

        }

    }
}
