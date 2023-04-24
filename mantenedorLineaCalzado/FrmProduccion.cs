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
    public partial class FrmProduccion : Form
    {
        public FrmProduccion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultarEmpleados_Click(object sender, EventArgs e)
        {
            mantenedorEmpleado mEmp = new mantenedorEmpleado();
            mEmp.ShowDialog();
        }

        private void btnCalzado_Click(object sender, EventArgs e)
        {
            FrmCalzadoDatos frmCalDat = new FrmCalzadoDatos();
            frmCalDat.ShowDialog();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ordenProduccion oPro = new ordenProduccion();
            oPro.ShowDialog();
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            mantenedorProceso mProc = new mantenedorProceso();
            mProc.ShowDialog();
        }
    }
}
