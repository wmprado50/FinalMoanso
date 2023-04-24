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
    public partial class ordenIngresoMateriales : Form
    {
        public ordenIngresoMateriales()
        {
            InitializeComponent();
            llenarDatosComboBoxEmpleado();
            llenarDatosComboBoxOrdenCompra();
            llenarDatosComboBoxTipoComprobante();
            llenarDatosComboBoxMaterial();
            ListarOrden();
            ListarDetalle();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
        }

        private void llenarDatosComboBoxEmpleado()
        {
            cmbEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleado();
            cmbEmpleado.DisplayMember = "apellido_paterno";
            cmbEmpleado.ValueMember = "empleado_id";
        }

        private void llenarDatosComboBoxOrdenCompra()
        {
            cmbOrdenCompra.DataSource = logOrdenCompraMateriales.Instancia.ListarOrdenCompra();
            cmbOrdenCompra.DisplayMember = "orden_id";
            cmbOrdenCompra.ValueMember = "orden_id";
        }

        private void llenarDatosComboBoxTipoComprobante()
        {
            cmbTipoComprobante.DataSource = logTipoComprobanteCompra.Instancia.ListarComprobante();
            cmbTipoComprobante.DisplayMember = "nombre";
            cmbTipoComprobante.ValueMember = "comprobante_id";
        }

        private void llenarDatosComboBoxMaterial()
        {
            cmbMaterial.DataSource = logMateriales.Instancia.ListarMateriales();
            cmbMaterial.DisplayMember = "nombre_material";
            cmbMaterial.ValueMember = "material_id";
        }

        public void ListarOrden()
        {
            dgvOrden.DataSource = logOrdenIngresoMatariales.Instancia.ListarOrdenIngreso();
        }

        public void ListarDetalle()
        {
            dgvDetalle.DataSource = logDetalleOrdenIngresoMateriales.Instancia.ListarDetalle();
        }

        private void LimpiarVariables()
        {
            txtOrden.Text = " ";
            txtNumero.Text = " ";
            txtDetalle.Text = " ";
            txtCantidad.Text = " ";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            groupBoxOrden.Enabled = true;
            groupBoxDetalle.Enabled = true;
            btnEditarOrden.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregarOrden.Visible = true;
            btnModificarOrden.Visible = false;
            btnRetirarOrden.Visible = false;
            txtOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;    
        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entOrdenIngresoMateriales cal = new entOrdenIngresoMateriales();
                cal.empleado_id = Convert.ToInt32(cmbEmpleado.SelectedValue);
                cal.f_orden = dtPickerRegOrden.Value;
                cal.orden_compra_id = Convert.ToInt32(cmbOrdenCompra.SelectedValue);
                cal.comprobante_id = Convert.ToInt32(cmbTipoComprobante.SelectedValue);
                cal.nro_comprobante = txtNumero.Text.Trim();
                logOrdenIngresoMatariales.Instancia.InsertarOrdenIngreso(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarOrden();
            ListarDetalle();
            LimpiarVariables();
            groupBoxDetalle.Enabled = true;
            groupBoxOrden.Enabled = false;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
        }

        private void dgvOrden_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvOrden.Rows[e.RowIndex]; //
            txtDetalle.Text = filaActual.Cells[0].Value.ToString();
        }

        private void dgvOrden_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvOrden.Rows[e.RowIndex]; //
            txtOrden.Text = filaActual.Cells[0].Value.ToString();
            cmbEmpleado.Text = filaActual.Cells[2].Value.ToString(); ;
            cmbOrdenCompra.Text = filaActual.Cells[4].Value.ToString();
            cmbTipoComprobante.Text = filaActual.Cells[6].Value.ToString();
            txtNumero.Text = filaActual.Cells[7].Value.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditarOrden_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            groupBoxOrden.Enabled = true;
            groupBoxDetalle.Enabled = false;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnModificarOrden.Visible = true;
            btnAgregarOrden.Visible = false;
            btnRetirarOrden.Visible = false;
        }

        private void btnEditarDetalle_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            ListarDetalle();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = true;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnModificarDetalle.Visible = true;
            btnAgregarDetalle.Visible = false;
            btnRetirarDetalle.Visible = false;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
        }

        private void btnModificarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenIngresoMateriales cal = new entOrdenIngresoMateriales();
                cal.orden_id = int.Parse(txtOrden.Text.Trim());
                cal.empleado_id = Convert.ToInt32(cmbEmpleado.SelectedValue);
                cal.f_orden = dtPickerRegOrden.Value;
                cal.orden_compra_id = Convert.ToInt32(cmbOrdenCompra.SelectedValue);
                cal.comprobante_id = Convert.ToInt32(cmbTipoComprobante.SelectedValue);
                cal.nro_comprobante = txtNumero.Text.Trim();
                logOrdenIngresoMatariales.Instancia.EditarOrdenIngreso(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = true;
            btnEditarDetalle.Enabled = true;
            btnAgregarDetalle.Visible = true;
            btnRetirarDetalle.Visible = true;
            ListarOrden();
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            groupBoxOrden.Enabled = true;
            groupBoxDetalle.Enabled = false;
            btnEditarOrden.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnAgregarOrden.Visible = false;
            btnModificarOrden.Visible = false;
            txtOrden.Enabled = true;
            cmbEmpleado.Enabled = false;
            cmbOrdenCompra.Enabled = false;
            cmbTipoComprobante.Enabled = false;
            txtNumero.Enabled = false;
            dtPickerRegOrden.Enabled = false;
            LimpiarVariables();
            ListarDetalle();
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
        }

        private void btnRetirarOrden_Click(object sender, EventArgs e)
        {
            //Eliminar
            try
            {
                entOrdenIngresoMateriales cal = new entOrdenIngresoMateriales();
                cal.orden_id = int.Parse(txtOrden.Text.Trim());
                logOrdenIngresoMatariales.Instancia.EliminarOrdenIngreso(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            btnNuevo.Enabled = true;
            btnEditarOrden.Enabled = true;
            btnEditarDetalle.Enabled=true;
            btnEliminar.Enabled = true;
            btnAgregarOrden.Visible = true;
            btnModificarOrden.Visible = true;
            btnRetirarOrden.Visible = true;
            txtOrden.Enabled = true;
            cmbEmpleado.Enabled = true;
            cmbOrdenCompra.Enabled = true;
            cmbTipoComprobante.Enabled = true;
            txtNumero.Enabled = true;
            dtPickerRegOrden.Enabled = true;
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            ListarOrden();
            ListarDetalle();
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
        }

        private void btnCancelarOrden_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            btnNuevo.Enabled = true;
            btnEditarOrden.Enabled = true;
            btnEditarDetalle.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregarOrden.Visible = true;
            btnModificarOrden.Visible = true;
            btnRetirarOrden.Visible = true;
            txtOrden.Enabled = true;
            cmbEmpleado.Enabled = true;
            cmbOrdenCompra.Enabled = true;
            cmbTipoComprobante.Enabled = true;
            txtNumero.Enabled = true;
            dtPickerRegOrden.Enabled = true;
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            ListarOrden();
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entDetalleOrdenIngresoMateriales cal = new entDetalleOrdenIngresoMateriales();
                cal.orden_id = int.Parse(txtDetalle.Text.Trim());
                cal.material_id = Convert.ToInt32(cmbMaterial.SelectedValue);
                cal.cantidad = int.Parse(txtCantidad.Text.Trim());
                logDetalleOrdenIngresoMateriales.Instancia.InsertarDetalle(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxOrden.Enabled = false;
            ListarDetalle();
            ListarOrden();
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
        }

        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                entDetalleOrdenIngresoMateriales cal = new entDetalleOrdenIngresoMateriales();
                cal.orden_id = int.Parse(txtDetalle.Text.Trim());
                cal.material_id = Convert.ToInt32(cmbMaterial.SelectedValue);
                cal.cantidad = int.Parse(txtCantidad.Text.Trim());
                logDetalleOrdenIngresoMateriales.Instancia.EditarDetalle(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxOrden.Enabled = false;
            ListarDetalle();
            ListarOrden();
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
        }

        private void btnRetirarDetalle_Click(object sender, EventArgs e)
        {
            //Eliminar
            try
            {
                entDetalleOrdenIngresoMateriales cal = new entDetalleOrdenIngresoMateriales();
                cal.orden_id = int.Parse(txtDetalle.Text.Trim());
                cal.material_id = Convert.ToInt32(cmbMaterial.SelectedValue);
                logDetalleOrdenIngresoMateriales.Instancia.EliminarDetalle(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxOrden.Enabled = false;
            ListarDetalle();
            ListarOrden();
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
        }

        private void btnSalirDetalle_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditarOrden.Enabled = true;
            btnEditarDetalle.Enabled = true;  
            btnEliminar.Enabled = true;
            ListarDetalle();
            ListarOrden();
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
        }

        private void dgvDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDetalle.Rows[e.RowIndex]; //
            txtDetalle.Text = filaActual.Cells[0].Value.ToString();
            cmbMaterial.Text = filaActual.Cells[2].Value.ToString(); ;
            txtCantidad.Text = filaActual.Cells[3].Value.ToString();
        }
    }
}
