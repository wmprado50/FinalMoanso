using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaLogica
{
    public class logColor
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logColor _instancia = new logColor();
        //privado para evitar la instanciación directa
        public static logColor Instancia
        {
            get
            {
                return logColor._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entColor> ListarColor()
        {
            return datColor.Instancia.ListarColor();
        }

        ///inserta
        public void InsertarColor(entColor lin)
        {
            datColor.Instancia.InsertarColor(lin);
        }

        //edita
        public void EditarColor(entColor lin)
        {
            datColor.Instancia.EditarColor(lin);
        }

        //elimina
        public void EliminarColor(entColor lin)
        {
            datColor.Instancia.EliminarColor(lin);
        }
        #endregion metodos
    }
}
