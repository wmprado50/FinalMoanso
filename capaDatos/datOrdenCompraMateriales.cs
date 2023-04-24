using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;

namespace capaDatos
{
    public class datOrdenCompraMateriales
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datOrdenCompraMateriales _instancia = new datOrdenCompraMateriales();
        //privado para evitar la instanciación directa
        public static datOrdenCompraMateriales Instancia
        {
            get
            {
                return datOrdenCompraMateriales._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Calzado
        public List<entOrdenCompraMateriales> ListarOrdenCompra()
        {
            SqlCommand cmd = null;
            List<entOrdenCompraMateriales> lista = new List<entOrdenCompraMateriales>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarOrdenCompraMateriales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenCompraMateriales cat = new entOrdenCompraMateriales();
                    cat.orden_id = Convert.ToInt32(dr["orden_compra_id"]);
                    cat.empleado_id = Convert.ToInt32(dr["ocm_empleado_id"]);
                    cat.f_orden = Convert.ToDateTime(dr["f_orden"]);
                    lista.Add(cat);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        #endregion metodos
    }
}
