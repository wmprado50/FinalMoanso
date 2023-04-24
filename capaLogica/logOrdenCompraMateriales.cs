using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaDatos;

namespace capaLogica
{
    public class logOrdenCompraMateriales
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logOrdenCompraMateriales _instancia = new logOrdenCompraMateriales();
        //privado para evitar la instanciación directa
        public static logOrdenCompraMateriales Instancia
        {
            get
            {
                return logOrdenCompraMateriales._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entOrdenCompraMateriales> ListarOrdenCompra()
        {
            return datOrdenCompraMateriales.Instancia.ListarOrdenCompra();
        }
        #endregion metodos
    }
}
