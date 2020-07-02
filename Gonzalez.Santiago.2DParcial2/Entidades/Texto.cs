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
        //crear hora actual para ir guardando en el archivo log la hora que se produjo la excepcion
        public bool Guardar(string path, string archivo, string datos)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    using (StreamWriter file = new StreamWriter(path + archivo, true))
                    {
                        file.WriteLine(datos);
                    }
                    return true;
                }
                else
                {
                    Directory.CreateDirectory(path);
                    
                    using (StreamWriter file = new StreamWriter(path + archivo, true))
                    {
                        file.WriteLine(datos);
                    }
                    throw new ArchivosException("Ruta del archivo inexistente, se crearon las carpetas: " + path+archivo);
                }
            }
            catch (ArchivosException ex)
            {
                Guardar(PATHLOG.pathlog, archivo,ex.Message);
                return false;
            }
        }

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
