using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class entMateriales
    {
        public int material_id { get; set; }
        public string nombre_material { get; set; }
        public int marca_id { get; set; }
        public string nombre_marca { get; set; }
        public int proveedor_id { get; set; }
        public string nombre_compania { get; set; }
        public int categoria_material_id { get; set; }
        public string nombre_categoria_material { get; set; }
        public int color_id { get; set; }
        public string nombre_color { get; set; }
        public int stock { get; set; }
        public float precio { get; set; }
     

    }
}
