using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase estatica que contiene la ruta de los distintos path a utilizar
    /// </summary>
    public static class ConstantePath
    {
        public static string PATHLOG = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Logs\\";
        public static string PATHXML = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\";
        public static string PATHBINARY = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SegundoParcialUtn\\JardinUtn\\Serializaciones\\BINARIO";
        
    }
}
