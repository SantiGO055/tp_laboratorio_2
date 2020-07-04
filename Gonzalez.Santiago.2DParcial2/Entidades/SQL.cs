using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class SQL
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static List<Alumno> alumnosAux;
        private static List<Aula> aulasAux;
        static SQL()
        {
            conexion = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = JardinUtn; Integrated Security = True;");
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
            alumnosAux = new List<Alumno>();
            aulasAux = new List<Aula>();
        }
        public static void InsertarDocente(Docente docente)
        {
            try
            {
                comando.Parameters.Clear();
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
        public static DataTable LeerAlumnosDataTable(string conectionString)
        {
            try
            {
                DataTable dt = new DataTable();
                conexion.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();

                comando.Connection = conexion;
                comando.CommandText = conectionString;
                adaptador.SelectCommand = comando;
                adaptador.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                Texto texto = new Texto();
                texto.Guardar(ConstantePath.PATHLOG, "logs.txt", ex.Message);
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static List<Alumno> LeerAlumnosALista(string conectionString)
        {
            try
            {
                DataTable dt = new DataTable();
                conexion.Open();
                //SqlDataAdapter adaptador = new SqlDataAdapter();
                comando.Connection = conexion;

                comando.CommandText = conectionString;
                SqlDataReader read = comando.ExecuteReader();
                while (read.Read())
                {
                    alumnosAux.Add(new Alumno((read["nombre"].ToString()), (read["apellido"].ToString()), (int.Parse(read["edad"].ToString())),
                    (int.Parse(read["dni"].ToString())), (read["direccion"].ToString()), (int.Parse(read["idalumnos"].ToString())), (read["responsable"].ToString())));
                }
                //adaptador.SelectCommand = comando;
                //adaptador.Fill(dt);
                dt.Load(read);

                return alumnosAux;
                //DataTable dt = new DataTable();
                //dt.Load(dr);
                //(string nombre, string apellido, int edad, int dni, string direccion, int id, string sexo)
                //return new Alumno((dr["Nombre"].ToString()), (dr["Apellido"].ToString()), (int.Parse(dr["Edad"].ToString())),
                //    (int.Parse(dr["Dni"].ToString())), (dr["Direccion"].ToString()), (int.Parse(dr["idAlumnos"].ToString())), (dr["Responsable"].ToString()));

            }
            catch (Exception ex)
            {
                Texto texto = new Texto();
                texto.Guardar(ConstantePath.PATHLOG, "logs.txt", ex.Message);
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<Aula> LeerAulas(string conectionString)
        {
            try
            {
                conexion.Open();

                comando.Connection = conexion;

                comando.CommandText = conectionString;
                SqlDataReader read = comando.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Load(dr);
                //(string nombre, string apellido, int edad, int dni, string direccion, int id, string sexo)
                //return new Alumno((dr["Nombre"].ToString()), (dr["Apellido"].ToString()), (int.Parse(dr["Edad"].ToString())),
                //    (int.Parse(dr["Dni"].ToString())), (dr["Direccion"].ToString()), (int.Parse(dr["idAlumnos"].ToString())), (dr["Responsable"].ToString()));
                while (read.Read())
                {
                    aulasAux.Add(new Aula((int.Parse(read["idAula"].ToString())), (read["Salita"].ToString())));
                }
                return aulasAux;

            }
            catch (Exception ex)
            {
                Texto texto = new Texto();
                texto.Guardar(ConstantePath.PATHLOG, "logs.txt", ex.Message);
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
