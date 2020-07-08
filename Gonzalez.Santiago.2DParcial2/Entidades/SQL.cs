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

        /// <summary>
        /// Inserta un docente a la base de datos
        /// </summary>
        /// <param name="docente">Objeto Docente a guardar en la base de datos</param>
        public static void InsertarDocente(Docente docente)
        {
            try
            {
                int retorno = 0;
                if (!(ValidarLecturaDocentes()))
                {
                    comando.Parameters.Clear();
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
                    retorno = comando.ExecuteNonQuery();

                }

                if (retorno != 1)
                {
                    throw new Exception("La base de datos ya se encuentra cargada");
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

        /// <summary>
        /// Lee los alumnos de la base de datos
        /// </summary>
        /// <returns>DataTable con la tabla extraida de la base de datos</returns>
        public static DataTable LeerAlumnosDataTable()
        {
            try
            {
                string conectionString = "select * from Alumnos";
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

        /// <summary>
        /// Valida que la base no se encuentre cargada
        /// </summary>
        /// <returns>True si la base se encuentra cargada, false si la base esta vacia</returns>
        public static bool ValidarLecturaDocentes()
        {
            try
            {
                string conectionString = "select * from Docentes";
                DataTable dt = new DataTable();
                conexion.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();

                comando.Connection = conexion;
                comando.CommandText = conectionString;
                adaptador.SelectCommand = comando;
                adaptador.Fill(dt);
                //realizo esta validacion por que conozco la cantidad de docentes que va a haber en la base de datos
                if (dt.Rows.Count == 10)
                    return true;
                else
                    return false;
            }

            catch (Exception ex)
            {
                Texto texto = new Texto();
                texto.Guardar(ConstantePath.PATHLOG, "logs.txt", ex.ToString());
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
        #region MetodoNoUsado
        public static List<Alumno> LeerAlumnosALista()
        {
            try
            {
                string conectionString = "select * from Alumnos";
                DataTable dt = new DataTable();
                conexion.Open();
                comando.Connection = conexion;

                comando.CommandText = conectionString;
                SqlDataReader read = comando.ExecuteReader();
                while (read.Read())
                {
                    alumnosAux.Add(new Alumno((read["nombre"].ToString()), (read["apellido"].ToString()), (int.Parse(read["edad"].ToString())),
                    (int.Parse(read["dni"].ToString())), (read["direccion"].ToString()), (int.Parse(read["idalumnos"].ToString())), (read["responsable"].ToString())));
                }
                dt.Load(read);
                return alumnosAux;
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
        #endregion

        /// <summary>
        /// Lee las aulas de la base de datos
        /// </summary>
        /// <returns>lista de las aulas</returns>
        public static List<Aula> LeerAulas()
        {
            try
            {
                string conectionString = "select * from aulas";
                conexion.Open();

                comando.Connection = conexion;

                comando.CommandText = conectionString;
                SqlDataReader read = comando.ExecuteReader();

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

        /// <summary>
        /// Inserta la evaluacion en la base de datos
        /// </summary>
        /// <param name="evaluacion">objeto de tipo Evaluaciones para guardar a la base</param>
        public static void InsertarEvaluacion(Evaluaciones evaluacion)
        {
            try
            {
                int retorno = 0;

                comando.Parameters.Clear();
                comando.CommandText = "insert into Evaluaciones (idAlumno, idDocente, idAula, Nota_1, Nota_2, NotaFinal, Observaciones) values (@idAlumno, @idDocente, @idAula, @Nota_1, @Nota_2, @NotaFinal, @Observaciones)";
                comando.Parameters.Add(new SqlParameter("idAlumno", evaluacion.Alumno.Id));
                comando.Parameters.Add(new SqlParameter("idDocente", evaluacion.Docente.Id));
                comando.Parameters.Add(new SqlParameter("idAula", evaluacion.Aula.Id));
                comando.Parameters.Add(new SqlParameter("Nota_1", evaluacion.Nota1));
                comando.Parameters.Add(new SqlParameter("Nota_2", evaluacion.Nota2));
                comando.Parameters.Add(new SqlParameter("NotaFinal", evaluacion.NotaFinal));
                comando.Parameters.Add(new SqlParameter("Observaciones", evaluacion.Observaciones));

                conexion.Open();
                retorno = comando.ExecuteNonQuery();


                if (retorno != 1)
                {
                    throw new Exception("La base de datos ya se encuentra cargada");
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

    }
}
