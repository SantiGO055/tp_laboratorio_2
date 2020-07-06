using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Alumno : Persona
    {

        protected string responsable;
        protected int nota;
        public Alumno()
        {

        }
        //string nombre, string apellido,int edad,int dni, string direccion,int id
        public Alumno(string nombre, string apellido, int edad, int dni, string direccion, int id, string responsable) :
            base(nombre, apellido, edad, dni, direccion, id)
        {
            this.Nota = nota;
            this.Responsable = responsable;
        }


        public int Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public string Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());

            return sb.ToString();
        }

        public void AlumnoEvaluado(bool aprobado)
        {
            Xml<Alumno> xmlAlumno = new Xml<Alumno>();
            //si el 
            //El archivo deberá tener el siguiente formato: Apellido_Nombre_Dia_Mes_Año.xml ,y
            //En caso de aprobar deberá de guardarse en una carpeta llamada APROBADOS, y en caso
            //que no, DESAPROBADOS.
            DateTime fechaHora = new DateTime();
            fechaHora = DateTime.Now;
            string nombreArchivo = this.Apellido + "_" + this.Nombre + "_" + fechaHora.ToString("dd'_'MM'_'yyyy") + ".xml";
            if (aprobado)
            {
                xmlAlumno.Guardar(ConstantePath.PATHXML + "APROBADOS\\",nombreArchivo,this);
            }
            else
            {
                xmlAlumno.Guardar(ConstantePath.PATHXML + "DESAPROBADOS\\", nombreArchivo, this);
            }
        }
}
}
