using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaDatos;

namespace capaLogica
{
    public class logMarca
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMarca _instancia = new logMarca();
        //privado para evitar la instanciación directa
        public static logMarca Instancia
        {
            get
            {
                return logMarca._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entMarca> ListarMarca()
        {
            return datMarca.Instancia.ListarMarca();
        }

        ///inserta
        public void InsertarMarca(entMarca lin)
        {
            datMarca.Instancia.InsertarMarca(lin);
        }

        //edita
        public void EditarMarca(entMarca lin)
        {
            datMarca.Instancia.EditarMarca(lin);
        }

        //elimina
        public void EliminarMarca(entMarca lin)
        {
            datMarca.Instancia.EliminarMarca(lin);
        }
        #endregion metodos
    }
}
