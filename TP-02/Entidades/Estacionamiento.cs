using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public class Estacionamiento
    {
        List<Vehiculo> vehiculos;
        int espacioDisponible;
        public enum ETipo
        {
            Moto, Automovil, Camioneta, Todos
        }

        #region "Constructores"
        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            
                return Mostrar(this,ETipo.Todos);
                //return item.Mostrar(this, ETipo.Todos);
            
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="c">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        /// 


        public static string Mostrar(Estacionamiento estacionamiento, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", estacionamiento.vehiculos.Count, estacionamiento.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo vehiculoEstacionado in estacionamiento.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Camioneta:
                        sb.AppendLine(vehiculoEstacionado.Mostrar());
                        break;
                    case ETipo.Moto:
                        sb.AppendLine(vehiculoEstacionado.Mostrar());
                        break;
                    case ETipo.Automovil:
                        sb.AppendLine(vehiculoEstacionado.Mostrar());
                        break;
                    default:
                        sb.AppendLine(vehiculoEstacionado.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns></returns>
        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento.vehiculos.Count < estacionamiento.espacioDisponible)
            {
                if (!(estacionamiento is null))
                {
                    foreach (var vehiculoEstacionado in estacionamiento.vehiculos)
                    {
                        if (vehiculoEstacionado == vehiculo)
                            return estacionamiento;
                    }
                    if (estacionamiento.espacioDisponible > 0)
                    {
                        estacionamiento.vehiculos.Add(vehiculo);
                    }

                }
            }
            
            

            
            return estacionamiento;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns></returns>
        public static Estacionamiento operator -(Estacionamiento cEstacionamiento, Vehiculo pVehiculo)
        {
            foreach (Vehiculo v in cEstacionamiento.vehiculos)
            {
                if (v == pVehiculo)
                {
                    if (cEstacionamiento.espacioDisponible <= 6)
                    {
                        cEstacionamiento.vehiculos.Remove(v);
                        break;
                    }
                    
                }
            }

            return cEstacionamiento;
        }
        #endregion
    }
}
