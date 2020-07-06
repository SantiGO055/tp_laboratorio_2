using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Texto : IArchivo<string>
    {
        public DateTime fechaHora = new DateTime();
        
        /// <summary>
        /// Metodo que guarda en un archivo de texto el contenido pasado por parametro.
        /// Si el directorio no existe lo crea y guarda el mensaje de la excepcion indicando la ruta creada
        /// </summary>
        /// <param name="path">Ruta del archivo a guardar</param>
        /// <param name="archivo">Nombre del archivo a guardar</param>
        /// <param name="datos">Datos que contendra el archivo</param>
        /// <returns>True si fue guardado correctamente. False si hubo error</returns>
        public bool Guardar(string path, string archivo, string datos)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    using (StreamWriter file = new StreamWriter(path + archivo, true, Encoding.UTF8))
                    {
                        file.WriteLine("-----------------------------------------------------");
                        fechaHora = DateTime.Now;
                        file.WriteLine(fechaHora.ToString("dd'/'MM'/'yyyy HH:mm:ss"));
                        file.WriteLine(datos);
                        
                    }
                    return true;
                }
                else
                {
                    Directory.CreateDirectory(path);
                    
                    using (StreamWriter fileNotDirectory = new StreamWriter(path + archivo, true,Encoding.UTF8))
                    {
                        fileNotDirectory.WriteLine("-----------------------------------------------------");
                        fechaHora = DateTime.Now;
                        fileNotDirectory.WriteLine(fechaHora.ToString("dd'/'MM'/'yyyy HH:mm:ss"));
                        fileNotDirectory.WriteLine(datos);
                    }
                    throw new ArchivosException("Ruta del archivo inexistente, se creo la ruta: " + path);
                }
            }
            catch (ArchivosException ex)
            {
                Guardar(ConstantePath.PATHLOG, archivo,ex.ToString());
                throw new ArchivosException(ex);
                return false;
            }
        }

        /// <summary>
        /// Lee un archivo de texto
        /// </summary>
        /// <param name="archivo">Ruta y nombre del archivo a leer</param>
        /// <param name="datos">datos que leyo del archivo de texto que sera retornado</param>
        /// <returns>True si fue leido correctamente. False si hubo erro</returns>
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader file = new StreamReader(archivo))
                {
                    datos = file.ReadToEnd();
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
