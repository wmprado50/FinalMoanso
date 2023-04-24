using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class entOrdenIngresoMateriales
    {
        public int orden_id { get; set; }
        public int empleado_id { get; set; }
        public string apellido { get; set; }
        public DateTime f_orden { get; set; }
        public int orden_compra_id { get; set; }
        public int comprobante_id { get; set; }
        public string nombre_comprobante { get; set; }
        public string nro_comprobante { get; set; }
    }
}
