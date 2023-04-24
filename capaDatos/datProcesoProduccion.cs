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
    public class datProcesoProduccion
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProcesoProduccion _instancia = new datProcesoProduccion();
        //privado para evitar la instanciación directa
        public static datProcesoProduccion Instancia
        {
            get
            {
                return datProcesoProduccion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Calzado
        public List<entProcesoProduccion> ListarProcesoProduccion()
        {
            SqlCommand cmd = null;
            List<entProcesoProduccion> lista = new List<entProcesoProduccion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarProcesoProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProcesoProduccion cat = new entProcesoProduccion();
                    cat.proceso_produccion_id = Convert.ToInt32(dr["proceso_produccion_id"]);
                    cat.empleado_id = Convert.ToInt32(dr["pp_empleado_id"]);
                    cat.apellido = dr["ape_paterno"].ToString();
                    cat.proceso_id = Convert.ToInt32(dr["pp_proceso_id"]);
                    cat.nombre_proceso = dr["nombre_proceso"].ToString();
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
        public Boolean InsertarProcesoProduccion(entProcesoProduccion Lin)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProcesoProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@emp", Lin.empleado_id);
                cmd.Parameters.AddWithValue("@proc", Lin.proceso_id);
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
        public Boolean EditarProcesoProduccion(entProcesoProduccion lin)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProcesoProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProceso", lin.proceso_produccion_id);
                cmd.Parameters.AddWithValue("@emp", lin.empleado_id);
                cmd.Parameters.AddWithValue("@proc", lin.proceso_id);
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
        public Boolean EliminarProcesoProduccion(entProcesoProduccion Lin)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarProcesoProduccion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProceso", Lin.proceso_produccion_id);
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
