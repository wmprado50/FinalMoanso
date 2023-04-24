using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaLogica
{
    public class logOrdenPedidoVenta
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logOrdenPedidoVenta _instancia = new logOrdenPedidoVenta();
        //privado para evitar la instanciación directa
        public static logOrdenPedidoVenta Instancia
        {
            get
            {
                return logOrdenPedidoVenta._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entOrdenPedidoVenta> ListarOrden()
        {
            return datOrdenPedidoVenta.Instancia.ListarOrden();
        }
        #endregion metodos
    }
}
