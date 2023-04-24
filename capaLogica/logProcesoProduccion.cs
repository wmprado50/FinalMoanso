using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaLogica
{
    public class logProcesoProduccion
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProcesoProduccion _instancia = new logProcesoProduccion();
        //privado para evitar la instanciación directa
        public static logProcesoProduccion Instancia
        {
            get
            {
                return logProcesoProduccion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entProcesoProduccion> ListarProcesoProduccion()
        {
            return datProcesoProduccion.Instancia.ListarProcesoProduccion();
        }

        ///inserta
        public void InsertarProcesoProduccion(entProcesoProduccion cal)
        {
            datProcesoProduccion.Instancia.InsertarProcesoProduccion(cal);
        }

        //edita
        public void EditarProcesoProduccion(entProcesoProduccion cal)
        {
            datProcesoProduccion.Instancia.EditarProcesoProduccion(cal);
        }

        //elimina
        public void EliminarProcesoProduccion(entProcesoProduccion cal)
        {
            datProcesoProduccion.Instancia.EliminarProcesoProduccion(cal);
        }
        #endregion metodos
    }
}
