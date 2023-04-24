using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaLogica
{
    public class logMateriales
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMateriales _instancia = new logMateriales();
        //privado para evitar la instanciación directa
        public static logMateriales Instancia
        {
            get
            {
                return logMateriales._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entMateriales> ListarMateriales()
        {
            return datMateriales.Instancia.ListarMateriales();
        }

        ///inserta
        public void InsertarMateriales(entMateriales lin)
        {
            datMateriales.Instancia.InsertarMateriales(lin);
        }

        //edita
        public void EditarMateriales(entMateriales lin)
        {
            datMateriales.Instancia.EditarMateriales(lin);
        }

        //elimina
        public void EliminarMateriales(entMateriales lin)
        {
            datMateriales.Instancia.EliminarMateriales(lin);
        }

        #endregion metodos
    }
}
