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
        
        
        //crear hora actual para ir guardando en el archivo log la hora que se produjo la excepcion
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
                    //verificar si no existe la ruta, no esta guardando el texo en las excepciones
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
