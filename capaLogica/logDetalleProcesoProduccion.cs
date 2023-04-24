using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaLogica
{
    public class logDetalleProcesoProduccion
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logDetalleProcesoProduccion _instancia = new logDetalleProcesoProduccion();
        //privado para evitar la instanciación directa
        public static logDetalleProcesoProduccion Instancia
        {
            get
            {
                return logDetalleProcesoProduccion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entDetalleProcesoProduccion> ListarDetalle()
        {
            return datDetalleProcesoProduccion.Instancia.ListarDetalle();
        }

        ///inserta
        public void InsertarDetalle(entDetalleProcesoProduccion cal)
        {
            datDetalleProcesoProduccion.Instancia.InsertarDetalle(cal);
        }

        //edita
        public void EditarDetalle(entDetalleProcesoProduccion cal)
        {
            datDetalleProcesoProduccion.Instancia.EditarDetalle(cal);
        }

        //elimina
        public void EliminarDetalle(entDetalleProcesoProduccion cal)
        {
            datDetalleProcesoProduccion.Instancia.EliminarDetalle(cal);
        }
        #endregion metodos
    }
}
