using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Extiende la clase Aula para generar un aula random
    /// </summary>
    public static class MetodoExtension
    {
        public static Aula GenerarAulaRandom(this List<Aula> listaAulas)
        {
            
            Random evaluarRandom = new Random();
            Aula aulaAux = new Aula();
            int aulaRandom = evaluarRandom.Next(1, listaAulas.Count);
            foreach (var item in listaAulas)
            {
                if (!(item is null) && item.Id == aulaRandom)
                {
                    aulaAux = item;
                }
            }
            return aulaAux;
        }
    }
}
