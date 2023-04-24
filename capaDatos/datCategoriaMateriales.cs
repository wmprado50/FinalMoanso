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
    public class datCategoriaMateriales
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCategoriaMateriales _instancia = new datCategoriaMateriales();
        //privado para evitar la instanciación directa
        public static datCategoriaMateriales Instancia
        {
            get
            {
                return datCategoriaMateriales._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Categoria de Materiales
        public List<entCategoriaMateriales> ListarCategoriaMateriales()
        {
            SqlCommand cmd = null;
            List<entCategoriaMateriales> lista = new List<entCategoriaMateriales>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCategoriaMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCategoriaMateriales Lin = new entCategoriaMateriales();
                    Lin.categoria_id = Convert.ToInt32(dr["categoria_material_id"]);
                    Lin.nombre = dr["nombre_categoria_material"].ToString();
                    Lin.descripcion = dr["descripcion_categoria_material"].ToString();
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

        /////////////////////////Insertar Categoria del material
        public Boolean InsertarCategoriaMateriales(entCategoriaMateriales Lin)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCategoriaMaterial", cn);
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

        //////////////////////////////////Editar Categoria del MAterial
        public Boolean EditarCategoriaMateriales(entCategoriaMateriales lin)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCategoriaMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCatMaterial", lin.categoria_id);
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

        /////////////////////////Eliminar Categoria del material
        public Boolean EliminarCategoriaMateriales(entCategoriaMateriales Lin)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarCategoriaMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCatMaterial", Lin.categoria_id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception)
            {
                throw new Exception("No se puede eliminar la CATEGORIA porque esta siendo usada por mantenedor MATERIALES");
            }
            finally { cmd.Connection.Close(); }
            return elimina;
        }

        #endregion metodos
    }
}
