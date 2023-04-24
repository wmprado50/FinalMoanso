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
    
    public class datDetalleOrdenIngresoMateriales
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datDetalleOrdenIngresoMateriales _instancia = new datDetalleOrdenIngresoMateriales();
        //privado para evitar la instanciación directa
        public static datDetalleOrdenIngresoMateriales Instancia
        {
            get
            {
                return datDetalleOrdenIngresoMateriales._instancia;
            }
        }
        #endregion singleton

        #region metodos
       //listado de Colo
        public List<entDetalleOrdenIngresoMateriales> ListarDetalle()
        {
            SqlCommand cmd = null;
            List<entDetalleOrdenIngresoMateriales> lista = new List<entDetalleOrdenIngresoMateriales>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarDetalleIngresoMateriales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetalleOrdenIngresoMateriales Lin = new entDetalleOrdenIngresoMateriales();
                    Lin.orden_id = Convert.ToInt32(dr["doi_ingreso_id"]);
                    Lin.material_id = Convert.ToInt32(dr["doi_material_id"]);
                    Lin.nombre_material = dr["nombre_material"].ToString();
                    Lin.cantidad = Convert.ToInt32(dr["cantidad_orden_ingreso"]);
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
        public Boolean InsertarDetalle(entDetalleOrdenIngresoMateriales Lin)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertDetalleIngresoMateriales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ing", Lin.orden_id);
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
        public Boolean EditarDetalle(entDetalleOrdenIngresoMateriales lin)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarDetalleIngresoMateriales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ing", lin.orden_id);
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
        public Boolean EliminarDetalle(entDetalleOrdenIngresoMateriales Lin)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarDetalleOrdenIngresoMateriales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ing", Lin.orden_id);
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
