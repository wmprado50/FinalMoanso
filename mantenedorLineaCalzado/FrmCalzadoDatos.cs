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
    public partial class FrmCalzadoDatos : Form
    {
        public FrmCalzadoDatos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalzado_Click(object sender, EventArgs e)
        {
            mantenedorCalzado mCal = new mantenedorCalzado();
            mCal.ShowDialog();
        }

        private void btnLineaCalzado_Click(object sender, EventArgs e)
        {
            mantenedorLineaCalzado mLiCa = new mantenedorLineaCalzado();
            mLiCa.ShowDialog();
        }

        private void btnCategoriaCalzado_Click(object sender, EventArgs e)
        {
            mantenedorCategoriaCalzado mCaCa = new mantenedorCategoriaCalzado();
            mCaCa.ShowDialog();
        }

        private void btnModeloCalzado_Click(object sender, EventArgs e)
        {
            mantenedorModelo mMoCa = new mantenedorModelo();
            mMoCa.ShowDialog();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            mantenedorColor mCoCa = new mantenedorColor();
            mCoCa.ShowDialog();
        }
    }
}
