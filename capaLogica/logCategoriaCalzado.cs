using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaDatos;

namespace capaLogica
{
    public class logCategoriaCalzado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCategoriaCalzado _instancia = new logCategoriaCalzado();
        //privado para evitar la instanciación directa
        public static logCategoriaCalzado Instancia
        {
            get
            {
                return logCategoriaCalzado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entCategoriaCalzado> ListarCategoriaCalzado()
        {
            return datCategoriaCalzado.Instancia.ListarCategoriaCalzado();
        }

        ///inserta
        public void InsertarCategoriaCalzado(entCategoriaCalzado cat)
        {
            datCategoriaCalzado.Instancia.InsertarCategoriaCalzado(cat);
        }

        //edita
        public void EditarCategoriaCalzado(entCategoriaCalzado cat)
        {
            datCategoriaCalzado.Instancia.EditarCategoriaCalzado(cat);
        }

        //elimina
        public void EliminarCategoriaCalzado(entCategoriaCalzado cat)
        {
            datCategoriaCalzado.Instancia.EliminarCategoriaCalzado(cat);
        }
        #endregion metodos
    }
}
