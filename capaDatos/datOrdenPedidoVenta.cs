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
    public class datOrdenPedidoVenta
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datOrdenPedidoVenta _instancia = new datOrdenPedidoVenta();
        //privado para evitar la instanciación directa
        public static datOrdenPedidoVenta Instancia
        {
            get
            {
                return datOrdenPedidoVenta._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Calzado
        public List<entOrdenPedidoVenta> ListarOrden()
        {
            SqlCommand cmd = null;
            List<entOrdenPedidoVenta> lista = new List<entOrdenPedidoVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarOrdenPedidoVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenPedidoVenta cat = new entOrdenPedidoVenta();
                    cat.orden_id = Convert.ToInt32(dr["orden_pedido_venta_id"]);
                    cat.empleado_id = Convert.ToInt32(dr["opv_empleado_id"]);
                    cat.f_orden = Convert.ToDateTime(dr["f_orden_pedido_venta"]);
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
