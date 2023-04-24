using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaDatos;

namespace capaLogica
{
    public class logLineaCalzado
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logLineaCalzado _instancia = new logLineaCalzado();
        //privado para evitar la instanciación directa
        public static logLineaCalzado Instancia
        {
            get
            {
                return logLineaCalzado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entLineaCalzado> ListarLineaCalzado()
        {
            return datLineaCalzado.Instancia.ListarLineaCalzado();
        }

        ///inserta
        public void InsertarLineaCalzado(entLineaCalzado lin)
        {
            datLineaCalzado.Instancia.InsertarLineaCalzado(lin);
        }

        //edita
        public void EditarLineaCalzado(entLineaCalzado lin)
        {
            datLineaCalzado.Instancia.EditarLineaCalzado(lin);
        }

        //elimina
        public void EliminarLineaCalzado(entLineaCalzado lin)
        {
            datLineaCalzado.Instancia.EliminarLineaCalzado(lin);
        }

        #endregion metodos

    }

}
