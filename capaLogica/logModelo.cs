using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaLogica
{
    public class logModelo
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logModelo _instancia = new logModelo();
        //privado para evitar la instanciación directa
        public static logModelo Instancia
        {
            get
            {
                return logModelo._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entModelo> ListarModelo()
        {
            return datModelo.Instancia.ListarModelo();
        }

        ///inserta
        public void InsertarModelo(entModelo lin)
        {
            datModelo.Instancia.InsertarModelo(lin);
        }

        //edita
        public void EditarModelo(entModelo lin)
        {
            datModelo.Instancia.EditarModelo(lin);
        }

        //elimina
        public void EliminarModelo(entModelo lin)
        {
            datModelo.Instancia.EliminarModelo(lin);
        }

        #endregion metodos
    }
}
