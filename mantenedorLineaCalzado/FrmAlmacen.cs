using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mantenedorLineaCalzado
{
    public partial class FrmAlmacen : Form
    {
        public FrmAlmacen()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            FrmMaterialDatos frmMatDat = new FrmMaterialDatos();
            frmMatDat.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            mantenedorProveedor mPro = new mantenedorProveedor();
            mPro.ShowDialog();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            ordenIngresoMateriales oIMat = new ordenIngresoMateriales();
            oIMat.ShowDialog();
        }
    }
}
