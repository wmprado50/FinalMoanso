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
    public class datMateriales
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datMateriales _instancia = new datMateriales();
        //privado para evitar la instanciación directa
        public static datMateriales Instancia
        {
            get
            {
                return datMateriales._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Materiales
        public List<entMateriales> ListarMateriales()
        {
            SqlCommand cmd = null;
            List<entMateriales> lista = new List<entMateriales>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMateriales Lin = new entMateriales();
                    Lin.material_id = Convert.ToInt32(dr["material_id"]);
                    
                    
                    Lin.nombre_material = dr["nombre_material"].ToString();
                    Lin.marca_id = Convert.ToInt32(dr["marca_id"]);
                    Lin.nombre_marca = dr["nombre_marca"].ToString();
                    Lin.proveedor_id = Convert.ToInt32(dr["proveedor_id"]);
                    Lin.nombre_compania = dr["nombre_compañia"].ToString();
                    Lin.categoria_material_id = Convert.ToInt32(dr["categoria_material_id"]);
                    Lin.nombre_categoria_material = dr["nombre_categoria_material"].ToString();
                    Lin.color_id = Convert.ToInt32(dr["color_id"]);
                    Lin.nombre_color = dr["nombre_color"].ToString();
                    Lin.stock = Convert.ToInt32(dr["stock_material"]);
                    Lin.precio = Convert.ToInt32(dr["precio_material"]);
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

        /////////////////////////Insertar Materiales
        public Boolean InsertarMateriales(entMateriales Lin)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nom", Lin.nombre_material);
                cmd.Parameters.AddWithValue("@mar", Lin.marca_id);
                cmd.Parameters.AddWithValue("@pro", Lin.proveedor_id);
                cmd.Parameters.AddWithValue("@cat", Lin.categoria_material_id);
                cmd.Parameters.AddWithValue("@col", Lin.color_id);
                cmd.Parameters.AddWithValue("@pre", Lin.precio);
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

        //////////////////////////////////Edita Material
        public Boolean EditarMateriales(entMateriales lin)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMaterial", lin.material_id);
                cmd.Parameters.AddWithValue("@nom", lin.nombre_material);
                cmd.Parameters.AddWithValue("@mar", lin.marca_id);
                cmd.Parameters.AddWithValue("@pro", lin.proveedor_id);
                cmd.Parameters.AddWithValue("@cat", lin.categoria_material_id);
                cmd.Parameters.AddWithValue("@col", lin.color_id);
                cmd.Parameters.AddWithValue("@pre", lin.precio);
                cmd.Parameters.AddWithValue("@stock", lin.stock);
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

        /////////////////////////Eliminar Material
        public Boolean EliminarMateriales(entMateriales Lin)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMaterial", Lin.material_id);
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
