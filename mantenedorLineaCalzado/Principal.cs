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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            FrmProduccion frmPro = new FrmProduccion();
            frmPro.ShowDialog();
           
            
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            FrmAlmacen frmAlm = new FrmAlmacen();
            frmAlm.ShowDialog();
           
            
        }
    }
}
