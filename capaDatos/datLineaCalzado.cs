using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using System.Net.Http;

namespace capaDatos
{
    public class datLineaCalzado
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datLineaCalzado _instancia = new datLineaCalzado();
        //privado para evitar la instanciación directa
        public static datLineaCalzado Instancia
        {
            get
            {
                return datLineaCalzado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Lineas de Calzado
        public List<entLineaCalzado> ListarLineaCalzado()
        {
            SqlCommand cmd = null;
            List<entLineaCalzado> lista = new List<entLineaCalzado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarLineaCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entLineaCalzado Lin = new entLineaCalzado();
                    Lin.linea_id = Convert.ToInt32(dr["linea_calzado_id"]);
                    Lin.nombre = dr["nombre_linea_calzado"].ToString();
                    Lin.descripcion = dr["descripcion_linea_calzado"].ToString();
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

        /////////////////////////Insertar Linea de calzado
        public Boolean InsertarLineaCalzado(entLineaCalzado Lin)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarLineaCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nom", Lin.nombre);
                cmd.Parameters.AddWithValue("@des", Lin.descripcion);
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
        public Boolean EditarLineaCalzado(entLineaCalzado lin)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarLineaCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idLinea", lin.linea_id);
                cmd.Parameters.AddWithValue("@nom", lin.nombre);
                cmd.Parameters.AddWithValue("@des", lin.descripcion);
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
        public Boolean EliminarLineaCalzado(entLineaCalzado Lin)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarLineaCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idLinea", Lin.linea_id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception )
            {
                throw new Exception ("No puede eliminar LINEA que esta siendo usada por mantenedor CALZADO");
               
            }
            finally { cmd.Connection.Close(); }
            return elimina;
        }

        #endregion metodos

    }
}
