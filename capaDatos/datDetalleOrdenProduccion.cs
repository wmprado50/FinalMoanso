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
    public class datDetalleOrdenProduccion
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datDetalleOrdenProduccion _instancia = new datDetalleOrdenProduccion();
        //privado para evitar la instanciación directa
        public static datDetalleOrdenProduccion Instancia
        {
            get
            {
                return datDetalleOrdenProduccion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Color
        public List<entDetalleOrdenProduccion> ListarDetalle()
        {
            SqlCommand cmd = null;
            List<entDetalleOrdenProduccion> lista = new List<entDetalleOrdenProduccion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarDetalleProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetalleOrdenProduccion Lin = new entDetalleOrdenProduccion();
                    Lin.orden_id = Convert.ToInt32(dr["dop_orden_produccion_id"]);
                    Lin.calzado_id = Convert.ToInt32(dr["dop_calzado_id"]);
                    Lin.categoria_calzado_id = Convert.ToInt32(dr["c_categoria_calzado_id"]);
                    Lin.nombre_categoria = dr["nombre_categoria_calzado"].ToString();
                    Lin.linea_calzado_id = Convert.ToInt32(dr["c_linea_calzado_id"]);
                    Lin.nombre_linea = dr["nombre_linea_calzado"].ToString();
                    Lin.modelo_calzado_id = Convert.ToInt32(dr["c_modelo_id"]);
                    Lin.nombre_modelo = dr["nombre_modelo"].ToString();
                    Lin.color_id = Convert.ToInt32(dr["c_color_id"]);
                    Lin.nombre_color = dr["nombre_color"].ToString();
                    Lin.cantidad = Convert.ToInt32(dr["cantidad_orden_produccion"]);
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
        public Boolean InsertarDetalle(entDetalleOrdenProduccion Lin)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertDetalleProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pro", Lin.orden_id);
                cmd.Parameters.AddWithValue("@cal", Lin.calzado_id);
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
        public Boolean EditarDetalle(entDetalleOrdenProduccion lin)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarDetalleProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pro", lin.orden_id);
                cmd.Parameters.AddWithValue("@cal", lin.calzado_id);
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
        public Boolean EliminarDetalle(entDetalleOrdenProduccion Lin)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarDetalleProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pro", Lin.orden_id);
                cmd.Parameters.AddWithValue("@cal", Lin.calzado_id);
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
