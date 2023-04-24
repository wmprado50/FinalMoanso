using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaLogica;

namespace mantenedorLineaCalzado
{
    public partial class mantenedorProveedor : Form
    {
        public mantenedorProveedor()
        {
            InitializeComponent();
            ListarProveedor();

        }
        public void ListarProveedor()
        {
            dgvProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
