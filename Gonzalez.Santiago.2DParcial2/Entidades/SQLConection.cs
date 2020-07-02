using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class SQLConection
    {
        static SqlConnection serverConection;
        static SqlCommand commandConection;

        public static void ConectarALaBase(string conectionString)
        {
            try
            {
                serverConection = new SqlConnection(conectionString);
                commandConection = new SqlCommand();
                serverConection.Open();

                commandConection.Connection = serverConection;
            }
            catch (ArchivosException ex)
            {
                throw new ArchivosException(ex);
            }
        }
    }
}
