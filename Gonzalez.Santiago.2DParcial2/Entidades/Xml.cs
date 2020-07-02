using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Xml<T> : IArchivo<T>
    {
        Texto texto;
        public Xml()
        {
            texto = new Texto();
        }
        /// <summary>
        /// Guarda en un archivo xml los datos del objeto que recibe como parametro
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string path, string archivo, T datos)
        {
            try
            {
                XmlSerializer s = new XmlSerializer(typeof(T));
                if (Directory.Exists(path))
                {
                    using (TextWriter writer = new StreamWriter(path+archivo))
                    {
                        s.Serialize(writer, datos);
                    }
                }
                else
                {
                    Directory.CreateDirectory(path);
                    using (TextWriter writer = new StreamWriter(path+archivo))
                    {
                        s.Serialize(writer, datos);
                    }
                    //llamar a guardar de txt
                    
                    throw new ArchivosException();
                }
                return true;
            }
            catch (ArchivosException ex)
            {
                texto.Guardar(PATHLOG.pathlog, archivo, ex.Message);
                return false;
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
                XmlSerializer deserializar = new XmlSerializer(typeof(T));
                using (TextReader reader = new StreamReader(archivo))
                {
                    datos = (T)deserializar.Deserialize(reader);
                }
                return true;
            }
            catch (ArchivosException ex)
            {
                throw new ArchivosException(ex.Message, ex);
            }
            
        }
    }
}
