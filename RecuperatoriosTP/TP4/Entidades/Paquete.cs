using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EEstado
    {
        Ingresado,
        EnViaje,
        Entregado
    }
    
    public class Paquete : IMostrar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;
        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformarEstado;

        public Paquete(string direccionEntrega, string trackingID)
        {
            DireccionEntrega = direccionEntrega;
            TrackingID = trackingID;
        }

        public string DireccionEntrega
        {
            get { return direccionEntrega; }
            set { direccionEntrega = value; }
        }


        public EEstado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string TrackingID
        {
            get { return trackingID; }
            set { trackingID = value; }
        }

        public void MockCicloDeVida()
        {
            do
            {
                Thread.Sleep(4000);
                this.estado += 1;
                this.InformarEstado(this, new EventArgs());
            } while (this.estado != EEstado.Entregado);

            PaqueteDAO.Insertar(this);
        }

        public string MostrarDatos(IMostrar<Paquete> lista)
        {

            Paquete p = (Paquete)lista;
            return $"{p.TrackingID} para direccion: {p.DireccionEntrega}";
        }

        public static bool operator ==(Paquete paquete1, Paquete paquete2)
        {
            return paquete1.TrackingID == paquete2.TrackingID;
        }

        public static bool operator !=(Paquete paquete1, Paquete paquete2)
        {
            return !(paquete1 == paquete2);
        }


        public override string ToString()
        {
            return MostrarDatos(this);
        }
    }
}
