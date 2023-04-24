using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class entProcesoProduccion
    {
        public int proceso_produccion_id { get; set; }
        public int empleado_id { get; set; }
        public string apellido { get; set; }
        public int proceso_id { get; set; }
        public string nombre_proceso { get; set; }
    }
}
