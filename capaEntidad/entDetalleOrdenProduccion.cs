using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class entDetalleOrdenProduccion
    {
        public int orden_id { get; set; }
        public int calzado_id { get; set; }
        public int categoria_calzado_id { get; set; }
        public string nombre_categoria { get; set; }
        public int linea_calzado_id { get; set; }
        public string nombre_linea { get; set; }
        public int modelo_calzado_id { get; set; }
        public string nombre_modelo { get; set; }
        public int color_id { get; set; }
        public string nombre_color { get; set; }
        public int cantidad { get; set; }
    }
}
