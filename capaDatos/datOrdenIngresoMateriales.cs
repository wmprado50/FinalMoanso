using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

namespace capaDatos
{
    public class datOrdenIngresoMateriales
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datOrdenIngresoMateriales _instancia = new datOrdenIngresoMateriales();
        //privado para evitar la instanciación directa
        public static datOrdenIngresoMateriales Instancia
        {
            get
            {
                return datOrdenIngresoMateriales._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Calzado
        public List<entOrdenIngresoMateriales> ListarOrdenIngreso()
        {
            SqlCommand cmd = null;
            List<entOrdenIngresoMateriales> lista = new List<entOrdenIngresoMateriales >();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarIngresoMateriales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenIngresoMateriales cat = new entOrdenIngresoMateriales();
                    cat.orden_id = Convert.ToInt32(dr["orden_ingreso_id"]);
                    cat.empleado_id = Convert.ToInt32(dr["oi_empleado_id"]);
                    cat.apellido = dr["ape_paterno"].ToString();
                    cat.f_orden = Convert.ToDateTime(dr["f_orden_ingreso"]);
                    cat.orden_compra_id = Convert.ToInt32(dr["oi_orden_compra_id"]);
                    cat.comprobante_id = Convert.ToInt32(dr["oi_comprobante_id"]);
                    cat.nombre_comprobante = dr["nombre_comprobante"].ToString();
                    cat.nro_comprobante = dr["nro_comprobante"].ToString();
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
        public Boolean InsertarOrdenIngreso(entOrdenIngresoMateriales Lin)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertIngresoMateriales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@emp", Lin.empleado_id);
                cmd.Parameters.AddWithValue("@fec", Lin.f_orden);
                cmd.Parameters.AddWithValue("@com", Lin.orden_compra_id);
                cmd.Parameters.AddWithValue("@comp", Lin.comprobante_id);
                cmd.Parameters.AddWithValue("@num", Lin.nro_comprobante);
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
        public Boolean EditarOrdenIngreso(entOrdenIngresoMateriales lin)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarIngresoMateriales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idIngreso", lin.orden_id);
                cmd.Parameters.AddWithValue("@emp", lin.empleado_id);
                cmd.Parameters.AddWithValue("@fec", lin.f_orden);
                cmd.Parameters.AddWithValue("@com", lin.orden_compra_id);
                cmd.Parameters.AddWithValue("@comp", lin.comprobante_id);
                cmd.Parameters.AddWithValue("@num", lin.nro_comprobante);
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
        public Boolean EliminarOrdenIngreso(entOrdenIngresoMateriales Lin)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarOrdenIngresoMateriales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idIngreso", Lin.orden_id);
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
