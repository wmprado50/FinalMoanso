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
    public class datEmpleado
    {
        #region singleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datEmpleado _instancia = new datEmpleado();
        //privado para evitar la instanciación directa
        public static datEmpleado Instancia
        {
            get
            {
                return datEmpleado._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Calzado
        public List<entEmpleado> ListarEmpleado()
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleado cat = new entEmpleado();
                    cat.empleado_id = Convert.ToInt32(dr["empleado_id"]);
                    cat.tipo_documento = Convert.ToInt32(dr["e_tipo_documento_id"]);
                    cat.numero_documento = dr["numero_documento"].ToString();
                    cat.apellido_paterno = dr["ape_paterno"].ToString();
                    cat.apellido_materno = dr["ape_materno"].ToString();
                    cat.nombres = dr["nombres"].ToString();
                    cat.cargo_id = Convert.ToInt32(dr["e_cargo_id"]);
                    cat.sexo = dr["sexo"].ToString();
                    cat.f_nacimiento = Convert.ToDateTime(dr["f_nacimiento"]);
                    cat.direccion = dr["direccion"].ToString();
                    cat.email = dr["enail"].ToString();
                    cat.telefono = dr["telefono"].ToString();
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
