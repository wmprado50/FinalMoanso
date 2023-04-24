using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaDatos;

namespace capaLogica
{
    public class logTipoComprobanteCompra
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTipoComprobanteCompra _instancia = new logTipoComprobanteCompra();
        //privado para evitar la instanciación directa
        public static logTipoComprobanteCompra Instancia
        {
            get
            {
                return logTipoComprobanteCompra._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entTipoComprobanteCompra> ListarComprobante()
        {
            return datTipoComprobanteCompra.Instancia.ListarComprobante();
        }
        #endregion metodos
    }
}
