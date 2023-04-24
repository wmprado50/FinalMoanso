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
    public class datColor
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datColor _instancia = new datColor();
        //privado para evitar la instanciación directa
        public static datColor Instancia
        {
            get
            {
                return datColor._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Color
        public List<entColor> ListarColor()
        {
            SqlCommand cmd = null;
            List<entColor> lista = new List<entColor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarColor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entColor Lin = new entColor();
                    Lin.color_id = Convert.ToInt32(dr["color_id"]);
                    Lin.nombre = dr["nombre_color"].ToString();
                    Lin.descripcion = dr["descripcion_color"].ToString();
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

        /////////////////////////Insertar Color
        public Boolean InsertarColor(entColor Lin)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarColor", cn);
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

        //////////////////////////////////Edita Color
        public Boolean EditarColor(entColor lin)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarColor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idColor", lin.color_id);
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

        /////////////////////////Eliminar Color
        public Boolean EliminarColor(entColor Lin)
        {
            SqlCommand cmd = null;
            Boolean elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarColor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idColor", Lin.color_id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    elimina = true;
                }
            }
            catch (Exception )
            {
                throw new Exception("No se puede eliminar COLOR que esta siendo usado por otro MANTENEDOR");
            }
            finally { cmd.Connection.Close(); }
            return elimina;
        }
        #endregion metodos
    }
}
