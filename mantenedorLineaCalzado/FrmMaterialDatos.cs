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
    public partial class FrmMaterialDatos : Form
    {
        public FrmMaterialDatos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mantenedorMateriales mMat = new mantenedorMateriales();
            mMat.ShowDialog();
        }

        private void btnCategoriaMateriales_Click(object sender, EventArgs e)
        {
            mantenedorCategoriaMateriales mCMat = new mantenedorCategoriaMateriales();
            mCMat.ShowDialog();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            mantenedorColor mCo = new mantenedorColor();
            mCo.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {

        }

        private void btnMarcaMaterial_Click(object sender, EventArgs e)
        {
            mantenedorMarca mMaMa = new mantenedorMarca();
            mMaMa.ShowDialog();
        }
    }
}
