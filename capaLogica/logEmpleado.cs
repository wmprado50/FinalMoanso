using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaDatos;

namespace capaLogica
{
    public class logEmpleado
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logEmpleado _instancia = new logEmpleado();
        //privado para evitar la instanciación directa
        public static logEmpleado Instancia
        {
            get
            {
                return logEmpleado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entEmpleado> ListarEmpleado()
        {
            return datEmpleado.Instancia.ListarEmpleado();
        }
        #endregion metodos
    }
}
