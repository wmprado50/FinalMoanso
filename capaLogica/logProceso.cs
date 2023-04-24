using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaDatos;

namespace capaLogica
{
    public class logProceso
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProceso _instancia = new logProceso();
        //privado para evitar la instanciación directa
        public static logProceso Instancia
        {
            get
            {
                return logProceso._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entProceso> ListarProceso()
        {
            return datProceso.Instancia.ListarProceso();
        }

        ///inserta
        public void InsertarProceso(entProceso lin)
        {
            datProceso.Instancia.InsertarProceso(lin);
        }

        //edita
        public void EditarProceso(entProceso lin)
        {
            datProceso.Instancia.EditarProceso(lin);
        }

        //elimina
        public void EliminarProceso(entProceso lin)
        {
            datProceso.Instancia.EliminarProceso(lin);
        }
        #endregion metodos
    }
}
