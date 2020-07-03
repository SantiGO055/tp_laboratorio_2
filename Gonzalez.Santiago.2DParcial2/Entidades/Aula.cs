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
        public Aula(int id, string salita)
        {
            this.ID = id;
            this.Salita = salita;
        }


        #region Propiedades

        public int ID
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ID: " + this.ID);
            sb.AppendLine(". Salita: " + this.Salita);
            return sb.ToString();
        }
    }
}
