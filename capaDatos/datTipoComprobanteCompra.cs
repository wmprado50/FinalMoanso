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
    public class datTipoComprobanteCompra
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datTipoComprobanteCompra _instancia = new datTipoComprobanteCompra();
        //privado para evitar la instanciación directa
        public static datTipoComprobanteCompra Instancia
        {
            get
            {
                return datTipoComprobanteCompra._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Calzado
        public List<entTipoComprobanteCompra> ListarComprobante()
        {
            SqlCommand cmd = null;
            List<entTipoComprobanteCompra> lista = new List<entTipoComprobanteCompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTipoComprobanteCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoComprobanteCompra cat = new entTipoComprobanteCompra();
                    cat.comprobante_id = Convert.ToInt32(dr["comprobante_id"]);
                    cat.nombre = dr["nombre_comprobante"].ToString();
                    cat.descripcion = dr["descripcion_comprobante"].ToString();
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
