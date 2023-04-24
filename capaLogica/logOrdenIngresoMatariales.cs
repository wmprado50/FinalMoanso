using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaLogica
{
    public class logOrdenIngresoMatariales
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logOrdenIngresoMatariales _instancia = new logOrdenIngresoMatariales();
        //privado para evitar la instanciación directa
        public static logOrdenIngresoMatariales Instancia
        {
            get
            {
                return logOrdenIngresoMatariales._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entOrdenIngresoMateriales> ListarOrdenIngreso()
        {
            return datOrdenIngresoMateriales.Instancia.ListarOrdenIngreso();
        }

        ///inserta
        public void InsertarOrdenIngreso(entOrdenIngresoMateriales cal)
        {
            datOrdenIngresoMateriales.Instancia.InsertarOrdenIngreso(cal);
        }

        //edita
        public void EditarOrdenIngreso(entOrdenIngresoMateriales cal)
        {
            datOrdenIngresoMateriales.Instancia.EditarOrdenIngreso(cal);
        }

        //elimina
        public void EliminarOrdenIngreso(entOrdenIngresoMateriales cal)
        {
            datOrdenIngresoMateriales.Instancia.EliminarOrdenIngreso(cal);
        }
        #endregion metodos
    }
}
