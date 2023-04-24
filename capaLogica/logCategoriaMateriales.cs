using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaLogica
{
    public class logCategoriaMateriales
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCategoriaMateriales _instancia = new logCategoriaMateriales();
        //privado para evitar la instanciación directa
        public static logCategoriaMateriales Instancia
        {
            get
            {
                return logCategoriaMateriales._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entCategoriaMateriales> ListarCategoriaMateriales()
        {
            return datCategoriaMateriales.Instancia.ListarCategoriaMateriales();
        }

        ///inserta
        public void InsertarCategoriaMateriales(entCategoriaMateriales lin)
        {
            datCategoriaMateriales.Instancia.InsertarCategoriaMateriales(lin);
        }

        //edita
        public void EditarCategoriaMateriales(entCategoriaMateriales lin)
        {
            datCategoriaMateriales.Instancia.EditarCategoriaMateriales(lin);
        }

        //elimina
        public void EliminarCategoriaMateriales(entCategoriaMateriales lin)
        {
            datCategoriaMateriales.Instancia.EliminarCategoriaMateriales(lin);
        }

        #endregion metodos
    }
}
