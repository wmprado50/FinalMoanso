using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaLogica
{
    public class logOrdenProduccion
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logOrdenProduccion _instancia = new logOrdenProduccion();
        //privado para evitar la instanciación directa
        public static logOrdenProduccion Instancia
        {
            get
            {
                return logOrdenProduccion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entOrdenProduccion> ListarOrdenProduccion()
        {
            return datOrdenPruduccion.Instancia.ListarOrdenProduccion();
        }

        ///inserta
        public void InsertarOrdenProduccion(entOrdenProduccion cal)
        {
            datOrdenPruduccion.Instancia.InsertarOrdenProduccion(cal);
        }

        //edita
        public void EditarOrdenProduccion(entOrdenProduccion cal)
        {
            datOrdenPruduccion.Instancia.EditarOrdenProduccion(cal);
        }

        //elimina
        public void EliminarOrdenProduccion(entOrdenProduccion cal)
        {
            datOrdenPruduccion.Instancia.EliminarOrdenProduccion(cal);
        }
        #endregion metodos
    }
}
