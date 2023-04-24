using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class entDetalleProcesoProduccion
    {
        public int orden_id { get; set; }
        public int proceso_produccion_id { get; set; }
        public string nombre_proceso { get; set; }
        public int material_id { get; set; }
        public string nombre_material { get; set; }
        public int cantidad { get; set; }
    }
}
