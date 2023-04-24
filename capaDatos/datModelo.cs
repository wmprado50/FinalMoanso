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
    public class datModelo
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datModelo _instancia = new datModelo();
        //privado para evitar la instanciación directa
        public static datModelo Instancia
        {
            get
            {
                return datModelo._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Lineas de Calzado
        public List<entModelo> ListarModelo()
        {
            SqlCommand cmd = null;
            List<entModelo> lista = new List<entModelo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarModelo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entModelo Lin = new entModelo();
                    Lin.modelo_id = Convert.ToInt32(dr["modelo_id"]);
                    Lin.nombre = dr["nombre_modelo"].ToString();
                    Lin.descripcion = dr["descripcion_modelo"].ToString();
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
        public Boolean InsertarModelo(entModelo Lin)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarModelo", cn);
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
        public Boolean EditarModelo(entModelo lin)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarModelo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idModelo", lin.modelo_id);
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
        public Boolean EliminarModelo(entModelo Lin)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarModelo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idModelo", Lin.modelo_id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception)
            {
                throw new Exception("No se puede eliminar MODELO que esta siendo usado por Mantenedor CALZADO");
            }
            finally { cmd.Connection.Close(); }
            return elimina;
        }

        #endregion metodos
    }
}
