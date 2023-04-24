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
    public class datCalzado
    {
        #region singleton
        //Patron Singleto
        // Variable estática para la instancia
        private static readonly datCalzado _instancia = new datCalzado();
        //privado para evitar la instanciación directa
        public static datCalzado Instancia
        {
            get
            {
                return datCalzado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Calzado
        public List<entCalzado> ListarCalzado()
        {
            SqlCommand cmd = null;
            List<entCalzado> lista = new List<entCalzado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCalzado cat = new entCalzado();
                    cat.calzado_id = Convert.ToInt32(dr["calzado_id"]);
                    cat.linea_calzado = Convert.ToInt32(dr["c_linea_calzado_id"]);
                    cat.nombre_linea_calzado = dr["nombre_linea_calzado"].ToString();
                    cat.categoria_calzado = Convert.ToInt32(dr["c_categoria_calzado_id"]);
                    cat.nombre_categoria_calzado = dr["nombre_categoria_calzado"].ToString();
                    cat.modelo_calzado = Convert.ToInt32(dr["c_modelo_id"]);
                    cat.nombre_modelo_calzado = dr["nombre_modelo"].ToString();
                    cat.color_calzado = Convert.ToInt32(dr["c_color_id"]);
                    cat.nombre_color_calzado = dr["nombre_color"].ToString();
                    cat.stock = Convert.ToInt32(dr["stock_calzado"]);
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
        public Boolean InsertarCalzado(entCalzado Lin)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@lin", Lin.linea_calzado);
                cmd.Parameters.AddWithValue("@cat", Lin.categoria_calzado);
                cmd.Parameters.AddWithValue("@mo", Lin.modelo_calzado);
                cmd.Parameters.AddWithValue("@co", Lin.color_calzado);
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
        public Boolean EditarCalzado(entCalzado lin)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCalzado", lin.calzado_id);
                cmd.Parameters.AddWithValue("@lin", lin.linea_calzado);
                cmd.Parameters.AddWithValue("@cat", lin.categoria_calzado);
                cmd.Parameters.AddWithValue("@mo", lin.modelo_calzado);
                cmd.Parameters.AddWithValue("@co", lin.color_calzado);
                cmd.Parameters.AddWithValue("@sto", lin.stock);
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
        public Boolean EliminarCalzado(entCalzado Lin)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCalzado", Lin.calzado_id);
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
