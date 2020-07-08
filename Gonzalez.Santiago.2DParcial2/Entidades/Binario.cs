using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Binario<T> : IArchivo<T> 
        //where T: new()
    {
        protected Texto texto = new Texto();

        /// <summary>
        /// Guarda los datos pasados por parametro en archivo binario
        /// </summary>
        /// <param name="path">Ruta del archivo a guardar</param>
        /// <param name="archivo">Nombre del archivo a guardar</param>
        /// <param name="datos">Dato que sera pasado por parametro segun el tipo de dato que fue declarada la clase</param>
        /// <returns></returns>
        public bool Guardar(string path, string archivo, T datos)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                if (Directory.Exists(path))
                {
                    using (Stream fs = new FileStream(path + archivo, FileMode.Create, FileAccess.Write))
                    {
                        formatter.Serialize(fs, datos);
                        return true;
                    }
                }
                else
                {
                    Directory.CreateDirectory(path);
                    using (Stream fs = new FileStream(path + archivo, FileMode.Create, FileAccess.Write))
                    {
                        formatter.Serialize(fs, datos);
                        return true;
                    }

                    throw new ArchivosException("Ruta del archivo inexistente, se creo la ruta: " + path + archivo);
                }
            }
            catch (ArchivosException e)
            {
                texto.Guardar(path, archivo, e.ToString());
                throw;
            }
        }

        /// <summary>
        /// Lee el archivo binario
        /// </summary>
        /// <param name="archivo">Ruta del archivo a leer</param>
        /// <param name="datos">Variable donde almacena los datos segun el tipo de dato que fue declarada la instancia de la clase</param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                if (File.Exists(archivo))
                {
                    using (FileStream fs = new FileStream(archivo, FileMode.Open))
                    {
                        datos = ((T)formatter.Deserialize(fs));
                        return true;
                    }
                }
                else
                    throw new ArchivosException("No se encontro el archivo: " + archivo);
            }
            catch (ArchivosException ex)
            {
                texto.Guardar(ConstantePath.PATHLOG, "logs.txt", ex.ToString());
                datos = default(T);
                throw;
            }
        }
    }
}
