using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaDatos;

namespace capaLogica
{
    public class logDetalleOrdenIngresoMateriales
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logDetalleOrdenIngresoMateriales _instancia = new logDetalleOrdenIngresoMateriales();
        //privado para evitar la instanciación directa
        public static logDetalleOrdenIngresoMateriales Instancia
        {
            get
            {
                return logDetalleOrdenIngresoMateriales._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entDetalleOrdenIngresoMateriales> ListarDetalle()
        {
            return datDetalleOrdenIngresoMateriales.Instancia.ListarDetalle();
        }

        ///inserta
        public void InsertarDetalle(entDetalleOrdenIngresoMateriales cal)
        {
            datDetalleOrdenIngresoMateriales.Instancia.InsertarDetalle(cal);
        }

        //edita
        public void EditarDetalle(entDetalleOrdenIngresoMateriales cal)
        {
            datDetalleOrdenIngresoMateriales.Instancia.EditarDetalle(cal);
        }

        //elimina
        public void EliminarDetalle(entDetalleOrdenIngresoMateriales cal)
        {
            datDetalleOrdenIngresoMateriales.Instancia.EliminarDetalle(cal);
        }
        #endregion metodos
    }
}
