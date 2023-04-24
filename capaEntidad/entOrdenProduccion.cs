using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class entOrdenProduccion
    {
        public int orden_id { get; set; }
        public int empleado_id { get; set; }
        public string apellido { get; set; }
        public int orden_venta_id { get; set; }
        public DateTime f_orden { get; set; }
    }
}
