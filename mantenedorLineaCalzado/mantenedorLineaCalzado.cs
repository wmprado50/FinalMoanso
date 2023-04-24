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
using capaEntidad;


namespace mantenedorLineaCalzado
{
    public partial class mantenedorLineaCalzado : Form
    {
        public mantenedorLineaCalzado()
        {
            InitializeComponent();
            ListarLineaCalzado();
            groupBoxDatos.Enabled = false;
            dvgLinea.ReadOnly = true;
        }

        public void ListarLineaCalzado()
        {
            dvgLinea.DataSource = logLineaCalzado.Instancia.ListarLineaCalzado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            groupBoxDatos.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            btnRetirar.Visible = false;
            txtLinea.Enabled = false;
        }

        private void LimpiarVariables()
        {
            txtLinea.Text = " ";
            txtNombre.Text = " ";
            txtDescripcion.Text = " ";
            //cbkEstadoCliente.Checked = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entLineaCalzado lin = new entLineaCalzado();
                lin.nombre = txtNombre.Text.Trim();
                lin.descripcion = txtDescripcion.Text.Trim();
                
                logLineaCalzado.Instancia.InsertarLineaCalzado(lin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            btnRetirar.Visible = true;
            txtLinea.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarLineaCalzado();
            dvgLinea.ReadOnly = true;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dvgLinea_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dvgLinea.Rows[e.RowIndex]; //
            txtLinea.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            groupBoxDatos.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            btnRetirar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entLineaCalzado lin = new entLineaCalzado();
                lin.linea_id = int.Parse(txtLinea.Text.Trim());
                lin.nombre = txtNombre.Text.Trim();
                lin.descripcion = txtDescripcion.Text.Trim();
                logLineaCalzado.Instancia.EditarLineaCalzado(lin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = true;
            btnRetirar.Visible = true;
            groupBoxDatos.Enabled = false;
            ListarLineaCalzado();
            dvgLinea.ReadOnly = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Visible = true;
            btnRetirar.Visible = true;
            btnModificar.Visible = true;
            txtLinea.Enabled = true;
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarLineaCalzado();
            dvgLinea.ReadOnly = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            groupBoxDatos.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = true;
            btnAgregar.Visible = false;
            btnRetirar.Visible = true;
            btnModificar.Visible = false;
            txtLinea.Enabled = true;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            //Eliminar
            try
            {
                entLineaCalzado lin = new entLineaCalzado();
                lin.linea_id = int.Parse(txtLinea.Text.Trim());
                logLineaCalzado.Instancia.EliminarLineaCalzado(lin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Visible = true;
            btnRetirar.Visible = true;
            btnModificar.Visible = true;
            txtLinea.Enabled = true;
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarLineaCalzado();
            dvgLinea.ReadOnly = true;
        }
    }
}
