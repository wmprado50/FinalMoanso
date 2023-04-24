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
    public class datCategoriaCalzado
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCategoriaCalzado _instancia = new datCategoriaCalzado();
        //privado para evitar la instanciación directa
        public static datCategoriaCalzado Instancia
        {
            get
            {
                return datCategoriaCalzado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Categoria de Calzado
        public List<entCategoriaCalzado> ListarCategoriaCalzado()
        {
            SqlCommand cmd = null;
            List<entCategoriaCalzado> lista = new List<entCategoriaCalzado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCategoriaCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCategoriaCalzado cat = new entCategoriaCalzado();
                    cat.categoria_id = Convert.ToInt32(dr["categoria_calzado_id"]);
                    cat.nombre = dr["nombre_categoria_calzado"].ToString();
                    cat.descripcion = dr["descripcion_categoria_calzado"].ToString();
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

        /////////////////////////Insertar Categoria de calzado
        public Boolean InsertarCategoriaCalzado(entCategoriaCalzado cat)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCategoriaCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nom", cat.nombre);
                cmd.Parameters.AddWithValue("@des", cat.descripcion);
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

        //////////////////////////////////Edita Categoria de calzado
        public Boolean EditarCategoriaCalzado(entCategoriaCalzado cat)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCategoriaCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCategoria", cat.categoria_id);
                cmd.Parameters.AddWithValue("@nom", cat.nombre);
                cmd.Parameters.AddWithValue("@des", cat.descripcion);
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

        /////////////////////////Eliminar Categoria de calzado
        public Boolean EliminarCategoriaCalzado(entCategoriaCalzado cat)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarCategoriaCalzado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCategoria", cat.categoria_id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception)
            {
                throw new Exception("No se puede eliminar CATEGORIA que esta siendo usada por mantenedor CALZADO");
            }
            finally { cmd.Connection.Close(); }
            return elimina;
        }
        #endregion metodos
    }
}
