using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {

        public Xml()
        {

        }
        /// <summary>
        /// Guarda en un archivo xml los datos del objeto que recibe como parametro
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                using (TextWriter writer = new StreamWriter(archivo))
                {
                    s.Serialize(writer, datos);
                }
                return true;
            }
            catch (Exception ex)
            {

                throw new ArchivosException(ex);
            }
        }

        /// <summary>
        /// Lee el archivo xml con los datos del objeto que recibe por parametro
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            try
            {
                XmlSerializer serializar = new XmlSerializer(typeof(T));
                using (TextReader reader = new StreamReader(archivo))
                {
                    datos = (T)serializar.Deserialize(reader);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException(ex);
            }
        }
    }
}
