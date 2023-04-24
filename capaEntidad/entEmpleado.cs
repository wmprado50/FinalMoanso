using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class entEmpleado
    {
        public int empleado_id { get; set; }
        public int tipo_documento { get; set; }
        public string numero_documento { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string nombres { get; set; }
        public int cargo_id { get; set; }
        public string sexo { get; set; }
        public DateTime f_nacimiento { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
    }
}
