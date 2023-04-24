using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaLogica;

namespace mantenedorLineaCalzado
{
    public partial class mantenedorMateriales : Form
    {
        public mantenedorMateriales()
        {
            InitializeComponent();
            ListarMateriales();
            llenarDatosComboBoxCategoriaMateriales();
            llenarDatosComboBoxMarcaMateriales();
            llenarDatosComboBoxProveedor();
            llenarDatosComboBoxColor();
            groupBoxDatos.Enabled = false;
            dgvMaterial.ReadOnly = true;
        }

        private void llenarDatosComboBoxCategoriaMateriales()
        {
            cmbCategoria.DataSource = logCategoriaMateriales.Instancia.ListarCategoriaMateriales();
            cmbCategoria.DisplayMember = "nombre";
            cmbCategoria.ValueMember = "categoria_id";
        }

        private void llenarDatosComboBoxMarcaMateriales()
        {
            cmbMarca.DataSource = logMarca.Instancia.ListarMarca();
            cmbMarca.DisplayMember = "nombre";
            cmbMarca.ValueMember = "marca_id";
        }

        private void llenarDatosComboBoxProveedor()
        {
            cmbProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
            cmbProveedor.DisplayMember = "nombre";
            cmbProveedor.ValueMember = "proveedor_id";
        }

        private void llenarDatosComboBoxColor()
        {
            cmbColor.DataSource = logColor.Instancia.ListarColor();
            cmbColor.DisplayMember = "nombre";
            cmbColor.ValueMember = "color_id"; 
        }

        public void ListarMateriales()
        {
            dgvMaterial.DataSource = logMateriales.Instancia.ListarMateriales();
        }

        private void LimpiarVariables()
        {

            txtMaterial.Text = " ";
            txtNombre.Text = " ";
            txtPrecio.Text = " ";
            txtStock.Text = " ";
            //txtDescripcion.Text = " ";
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
            txtMaterial.Enabled = false;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entMateriales cal = new entMateriales();
                cal.nombre_material = txtNombre.Text.Trim();
                cal.marca_id = Convert.ToInt32(cmbMarca.SelectedValue);
                cal.proveedor_id = Convert.ToInt32(cmbProveedor.SelectedValue);
                cal.categoria_material_id = Convert.ToInt32(cmbCategoria.SelectedValue);
                cal.color_id = Convert.ToInt32(cmbColor.SelectedValue);
                cal.precio = float.Parse(txtPrecio.Text.Trim());
                logMateriales.Instancia.InsertarMateriales(cal);
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
            txtMaterial.Enabled = true;
            txtStock.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarMateriales();
            dgvMaterial.ReadOnly = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
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
                entMateriales cal = new entMateriales();
                cal.material_id = int.Parse(txtMaterial.Text.Trim());
                cal.nombre_material = txtNombre.Text.Trim();
                cal.marca_id = Convert.ToInt32(cmbMarca.SelectedValue);
                cal.proveedor_id = Convert.ToInt32(cmbProveedor.SelectedValue);
                cal.categoria_material_id = Convert.ToInt32(cmbCategoria.SelectedValue);
                cal.color_id = Convert.ToInt32(cmbColor.SelectedValue);
                cal.precio = float.Parse(txtPrecio.Text.Trim());
                cal.stock = int.Parse(txtStock.Text.Trim());
                logMateriales.Instancia.EditarMateriales(cal);
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
            ListarMateriales();
            dgvMaterial.ReadOnly = true;
        }

        private void dgvMaterial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMaterial.Rows[e.RowIndex]; //
            txtMaterial.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            cmbMarca.Text = filaActual.Cells[3].Value.ToString();
            cmbProveedor.Text = filaActual.Cells[5].Value.ToString();
            cmbCategoria.Text = filaActual.Cells[7].Value.ToString();
            cmbColor.Text = filaActual.Cells[9].Value.ToString();
            txtPrecio.Text = filaActual.Cells[10].Value.ToString();
            txtStock.Text = filaActual.Cells[11].Value.ToString();
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
            txtMaterial.Enabled = true;
            txtStock.Enabled = true;
            cmbProveedor.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbColor.Enabled = true;
            cmbMarca.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarMateriales();
            dgvMaterial.ReadOnly = true;
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
            txtStock.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            cmbProveedor.Enabled = false;
            cmbCategoria.Enabled = false;
            cmbColor.Enabled = false;
            cmbMarca.Enabled = false;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            //Eliminar
            try
            {
                entMateriales cal = new entMateriales();
                cal.material_id = int.Parse(txtMaterial.Text.Trim());
                logMateriales.Instancia.EliminarMateriales(cal);
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
            txtStock.Enabled = true;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            cmbProveedor.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbColor.Enabled = true;
            cmbMarca.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarMateriales();
            dgvMaterial.ReadOnly = true;
        }
    }
}
