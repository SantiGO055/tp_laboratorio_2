using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        protected int id;
        protected string salita;
        public Aula()
        {

        }
        public Aula(int id, string salita)
        {
            this.Id = id;
            this.Salita = salita;
        }


        #region Propiedades

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Salita
        {
            get { return salita; }
            set { salita = value; }
        }


        #endregion

        /// <summary>
        /// Sobrecarga del metodo ToString, publica los datos del aula
        /// </summary>
        /// <returns>Datos del aula</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ID: " + this.Id);
            sb.AppendLine(". Salita: " + this.Salita);
            return sb.ToString();
        }

    }
}
