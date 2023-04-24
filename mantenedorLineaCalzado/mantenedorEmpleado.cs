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
    public partial class mantenedorEmpleado : Form
    {
        public mantenedorEmpleado()
        {
            InitializeComponent();
            ListarEmpleado();


        }
        public void ListarEmpleado()
        {
            dgvEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleado();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
