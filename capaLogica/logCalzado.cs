using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaDatos;

namespace capaLogica
{
    public class logCalzado
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCalzado _instancia = new logCalzado();
        //privado para evitar la instanciación directa
        public static logCalzado Instancia
        {
            get
            {
                return logCalzado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entCalzado> ListarCalzado()
        {
            return datCalzado.Instancia.ListarCalzado();
        }

        ///inserta
        public void InsertarCalzado(entCalzado cal)
        {
            datCalzado.Instancia.InsertarCalzado(cal);
        }

        //edita
        public void EditarCalzado(entCalzado cal)
        {
            datCalzado.Instancia.EditarCalzado(cal);
        }

        //elimina
        public void EliminarCalzado(entCalzado cal)
        {
            datCalzado.Instancia.EliminarCalzado(cal);
        }
        #endregion metodos
    }
}
