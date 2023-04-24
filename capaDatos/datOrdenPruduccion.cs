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
    public class datOrdenPruduccion
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datOrdenPruduccion _instancia = new datOrdenPruduccion();
        //privado para evitar la instanciación directa
        public static datOrdenPruduccion Instancia
        {
            get
            {
                return datOrdenPruduccion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Calzado
        public List<entOrdenProduccion> ListarOrdenProduccion()
        {
            SqlCommand cmd = null;
            List<entOrdenProduccion> lista = new List<entOrdenProduccion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenProduccion cat = new entOrdenProduccion();
                    cat.orden_id = Convert.ToInt32(dr["orden_produccion_id"]);
                    cat.empleado_id = Convert.ToInt32(dr["op_empleado_id"]);
                    cat.apellido = dr["ape_paterno"].ToString();
                    cat.orden_venta_id = Convert.ToInt32(dr["op_orden_pedido_venta_id"]);
                    cat.f_orden = Convert.ToDateTime(dr["f_orden_produccion"]);
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

        /////////////////////////Insertar Linea de calzado
        public Boolean InsertarOrdenProduccion(entOrdenProduccion Lin)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@emp", Lin.empleado_id);
                cmd.Parameters.AddWithValue("@fec", Lin.f_orden);
                cmd.Parameters.AddWithValue("@ven", Lin.orden_venta_id);
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

        //////////////////////////////////Edita Linea de calzado
        public Boolean EditarOrdenProduccion(entOrdenProduccion lin)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProduccion", lin.orden_id);
                cmd.Parameters.AddWithValue("@emp", lin.empleado_id);
                cmd.Parameters.AddWithValue("@fec", lin.f_orden);
                cmd.Parameters.AddWithValue("@ven", lin.orden_venta_id);
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

        /////////////////////////Eliminar Linea de calzado
        public Boolean EliminarOrdenProduccion(entOrdenProduccion Lin)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProduccion", Lin.orden_id);
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
