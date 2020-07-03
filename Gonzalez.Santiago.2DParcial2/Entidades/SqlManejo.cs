using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class SqlManejo
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static SqlManejo()
        {
            conexion = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = JardinUtn; Integrated Security = True;");
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;

        }
        public static void InsertarDocente(Docente docente)
        {
            try
            {

                //string nombre, string apellido, int edad, int dni, string direccion,  int id, string sexo, string mail
                comando.CommandText = "insert into Docentes (nombre, apellido, edad, dni, direccion, sexo, email) values (@nombre,@apellido,@edad,@dni,@direccion,@sexo,@email)";
                comando.Parameters.Add(new SqlParameter("nombre", docente.Nombre));
                comando.Parameters.Add(new SqlParameter("apellido", docente.Apellido));
                comando.Parameters.Add(new SqlParameter("edad", docente.Edad));
                comando.Parameters.Add(new SqlParameter("dni", docente.Dni));
                comando.Parameters.Add(new SqlParameter("direccion", docente.Direccion));
                //comando.Parameters.Add(new SqlParameter("id", docente.ID)); prueba de si hace falta o no ya que es autoincremental con identity en la db
                comando.Parameters.Add(new SqlParameter("sexo", docente.Sexo));
                comando.Parameters.Add(new SqlParameter("email", docente.Email));

                conexion.Open();
                int retorno = comando.ExecuteNonQuery();

                if (retorno != 1)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Texto texto = new Texto();
                texto.Guardar(ConstantePath.PATHLOG, "logs.txt", ex.ToString());
            }
            finally
            {
                conexion.Close();
            }
            
        }
        public static void LeerSql()
        {
            //try
            //{
            //    conexion = new SqlConnection();
            //    comando = new SqlCommand();
            //    conexion.Open();

            //    comando.Connection = conexion;

            //    comando.CommandText = conectionString;
            //    SqlDataReader dr = comando.ExecuteReader();
            //    DataTable dt = new DataTable();
            //    dt.Load(dr);

            //}
            //catch (ArchivosException ex)
            //{
            //    throw new ArchivosException(ex);
            //}
        }
    }
}
