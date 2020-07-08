using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GuardaString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            try
            {
                FileStream stream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Path.DirectorySeparatorChar +
                        archivo, FileMode.Append);
                byte[] info = new UTF8Encoding(true).GetBytes(texto);
                stream.Write(info, 0, info.Length);
                stream.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
    }
}
