using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static PaqueteDAO()
        {
            conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=correo-sp-2017;Integrated Security=True");
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }
        public static bool Insertar(Paquete paquete)
        {
            string alumno = "Gonzalez Santiago";
            string sql =
                $"INSERT INTO [correo-sp-2017].[dbo].[Paquetes] VALUES ('{paquete.DireccionEntrega}','{paquete.TrackingID}','{alumno}')";

            
            

            try
            {
                Paquete paqueteRepeated = ObtenerTrackingId(paquete.TrackingID);
                if (!ReferenceEquals(paqueteRepeated, null))
                {
                    throw new Exception($"TrackingId {paquete.TrackingID} ya está en la base de datos");
                }
                comando.CommandText = sql;
                conexion.Open();
                int rowsAffected = comando.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} were affected.");
                return true;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        private static Paquete ObtenerTrackingId(string paqueteTrackingId)
        {
            Paquete paqueteRetorno = null;
            try
            {
                conexion.Close();
                comando.CommandText = $"Select direccionEntrega,trackingID from [correo-sp-2017].[dbo].[Paquetes] where trackingID='{paqueteTrackingId}'";

                conexion.Open();

                using (SqlDataReader oDr = comando.ExecuteReader())
                {
                    while (oDr.Read())
                    {
                        paqueteRetorno = new Paquete(oDr["direccionEntrega"].ToString(), oDr["trackingID"].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return paqueteRetorno;
        }
    }
}
