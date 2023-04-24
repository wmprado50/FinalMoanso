using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaDatos;

namespace capaLogica
{
    public class logDetalleOrdenProduccion
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logDetalleOrdenProduccion _instancia = new logDetalleOrdenProduccion();
        //privado para evitar la instanciación directa
        public static logDetalleOrdenProduccion Instancia
        {
            get
            {
                return logDetalleOrdenProduccion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entDetalleOrdenProduccion> ListarDetalle()
        {
            return datDetalleOrdenProduccion.Instancia.ListarDetalle();
        }

        ///inserta
        public void InsertarDetalle(entDetalleOrdenProduccion cal)
        {
            datDetalleOrdenProduccion.Instancia.InsertarDetalle(cal);
        }

        //edita
        public void EditarDetalle(entDetalleOrdenProduccion cal)
        {
            datDetalleOrdenProduccion.Instancia.EditarDetalle(cal);
        }

        //elimina
        public void EliminarDetalle(entDetalleOrdenProduccion cal)
        {
            datDetalleOrdenProduccion.Instancia.EliminarDetalle(cal);
        }
        #endregion metodos
    }
}
