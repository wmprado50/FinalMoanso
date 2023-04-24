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
    public class datDetalleProcesoProduccion
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datDetalleProcesoProduccion _instancia = new datDetalleProcesoProduccion();
        //privado para evitar la instanciación directa
        public static datDetalleProcesoProduccion Instancia
        {
            get
            {
                return datDetalleProcesoProduccion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Color
        public List<entDetalleProcesoProduccion> ListarDetalle()
        {
            SqlCommand cmd = null;
            List<entDetalleProcesoProduccion> lista = new List<entDetalleProcesoProduccion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarDetalleProcesoProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetalleProcesoProduccion Lin = new entDetalleProcesoProduccion();
                    Lin.orden_id = Convert.ToInt32(dr["dpp_orden_produccion_id"]);
                    Lin.proceso_produccion_id = Convert.ToInt32(dr["dpp_proceso_produccion_id"]);
                    Lin.nombre_proceso = dr["nombre_proceso"].ToString();
                    Lin.material_id = Convert.ToInt32(dr["dpp_material_id"]);
                    Lin.nombre_material = dr["nombre_material"].ToString();
                    Lin.cantidad = Convert.ToInt32(dr["cantidad_proceso_produccion"]);
                    lista.Add(Lin);
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

        /////////////////////////Insertar Color
        public Boolean InsertarDetalle(entDetalleProcesoProduccion Lin)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertDetalleProcesoProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pro", Lin.orden_id);
                cmd.Parameters.AddWithValue("@proc", Lin.proceso_produccion_id);
                cmd.Parameters.AddWithValue("@mat", Lin.material_id);
                cmd.Parameters.AddWithValue("@can", Lin.cantidad);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        //////////////////////////////////Edita Color
        public Boolean EditarDetalle(entDetalleProcesoProduccion lin)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarDetalleProcesoProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pro", lin.orden_id);
                cmd.Parameters.AddWithValue("@proc", lin.proceso_produccion_id);
                cmd.Parameters.AddWithValue("@mat", lin.material_id);
                cmd.Parameters.AddWithValue("@can", lin.cantidad);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        /////////////////////////Eliminar Color
        public Boolean EliminarDetalle(entDetalleProcesoProduccion Lin)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarDetalleProcesoProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pro", Lin.orden_id);
                cmd.Parameters.AddWithValue("@proc", Lin.proceso_produccion_id);
                cmd.Parameters.AddWithValue("@mat", Lin.material_id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return elimina;
        }
        #endregion metodos
    }
}
