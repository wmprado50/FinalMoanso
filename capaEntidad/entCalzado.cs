using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class entCalzado
    {
        public int calzado_id { get; set; }
        public int linea_calzado { get; set; }
        public string nombre_linea_calzado { get; set; }
        public int categoria_calzado { get; set; }
        public string nombre_categoria_calzado { get; set; }
        public int modelo_calzado { get; set; }
        public string nombre_modelo_calzado { get; set; }
        public int color_calzado { get; set; }
        public string nombre_color_calzado { get; set; }
        public int stock { get; set; }
    }
}
