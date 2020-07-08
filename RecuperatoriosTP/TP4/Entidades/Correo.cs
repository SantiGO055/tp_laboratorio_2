using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }
        public List<Paquete> Paquetes
        {
            get { return paquetes; }
            set { paquetes = value; }
        }

        public static Correo operator +(Correo correo, Paquete p)
        {
            foreach (Paquete paquete in correo.paquetes)
            {
                if (p == paquete)
                {
                    throw new TrackingIDRepetidoException($"El Tracking ID {p.TrackingID} ya figura en la lista de envios.");
                }
            }

            correo.paquetes.Add(p);
            Thread item = new Thread(p.MockCicloDeVida);
            item.Start();
            correo.mockPaquetes.Add(item);
            return correo;
        }

        public string MostrarDatos(IMostrar<List<Paquete>> listaPaquetes)
        {
            List<Paquete> paquetes = ((Correo)listaPaquetes).paquetes;
            StringBuilder sb = new StringBuilder();
            foreach (Paquete paquete in paquetes)
            {
                sb.AppendLine($"{paquete.TrackingID} para {paquete.DireccionEntrega} ({paquete.Estado.ToString()})");
            }
            return sb.ToString();
        }

        public void FinEntregas()
        {
            foreach (Thread thread in this.mockPaquetes)
            {
                if (thread.IsAlive)
                {
                    thread.Abort();
                }
            }
        }
    }
}
