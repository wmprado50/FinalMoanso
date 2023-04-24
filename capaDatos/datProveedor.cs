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
    public class datProveedor
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProveedor _instancia = new datProveedor();
        //privado para evitar la instanciación directa
        public static datProveedor Instancia
        {
            get
            {
                return datProveedor._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Calzado
        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor cat = new entProveedor();
                    cat.proveedor_id = Convert.ToInt32(dr["proveedor_id"]);
                    cat.nombre = dr["nombre_compañia"].ToString();
                    cat.ruc = dr["ruc"].ToString();
                    cat.direccion = dr["direccion"].ToString();
                    cat.telefono = dr["telefono"].ToString();
                    cat.email = dr["email"].ToString();
                    cat.web = dr["pagina_web"].ToString();
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
