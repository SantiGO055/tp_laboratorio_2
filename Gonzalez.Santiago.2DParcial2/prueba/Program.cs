using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoSQL.ConectarALaBase(@"Data Source = LCCTECNMJ669C42\SQLEXPRESS; Initial Catalog = Argentina; Integrated Security = True;");

        }
    }
}
