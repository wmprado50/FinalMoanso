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
    public partial class ordenProduccion : Form
    {
        public ordenProduccion()
        {
            InitializeComponent();
            llenarDatosComboBoxEmpleado();
            llenarDatosComboBoxOrdenVenta();
            llenarDatosComboBoxCalzado();
            llenarDatosComboBoxEmpleadoProceso();
            llenarDatosComboBoxProceso();
            llenarDatosComboBoxMaterial();
            llenarDatosComboBoxDetalle();
            llenarDatosComboBoxDetalleProceso();
            llenarDatosComboBoxDetalleProcesoProduccion();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            groupBoxProceso.Enabled = false;
            groupBoxDetalleProceso.Enabled = false;
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void llenarDatosComboBoxEmpleado()
        {
            cmbEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleado();
            cmbEmpleado.DisplayMember = "apellido_paterno";
            cmbEmpleado.ValueMember = "empleado_id";
        }

        private void llenarDatosComboBoxOrdenVenta()
        {
            cmbOrdenVenta.DataSource = logOrdenPedidoVenta.Instancia.ListarOrden();
            cmbOrdenVenta.DisplayMember = "orden_id";
            cmbOrdenVenta.ValueMember = "orden_id";
        }

        private void llenarDatosComboBoxCalzado()
        {
            cmbCalzado.DataSource = logCalzado.Instancia.ListarCalzado();
            cmbCalzado.DisplayMember = "nombre_modelo_calzado";
            cmbCalzado.ValueMember = "calzado_id";
        }

        private void llenarDatosComboBoxEmpleadoProceso()
        {
            cmbEmpleadoProceso.DataSource = logEmpleado.Instancia.ListarEmpleado();
            cmbEmpleadoProceso.DisplayMember = "apellido_paterno";
            cmbEmpleadoProceso.ValueMember = "empleado_id";
        }

        private void llenarDatosComboBoxProceso()
        {
            cmbProceso.DataSource = logProceso.Instancia.ListarProceso();
            cmbProceso.DisplayMember = "nombre";
            cmbProceso.ValueMember = "proceso_id";
        }

        private void llenarDatosComboBoxMaterial()
        {
            cmbMaterial.DataSource = logMateriales.Instancia.ListarMateriales();
            cmbMaterial.DisplayMember = "nombre_material";
            cmbMaterial.ValueMember = "material_id";
        }

        private void llenarDatosComboBoxDetalle()
        {
            cmbDetalle.DataSource = logOrdenProduccion.Instancia.ListarOrdenProduccion();
            cmbDetalle.DisplayMember = "orden_id";
            cmbDetalle.ValueMember = "orden_id";
        }

        private void llenarDatosComboBoxDetalleProceso()
        {
            cmbDetalleProceso.DataSource = logOrdenProduccion.Instancia.ListarOrdenProduccion();
            cmbDetalleProceso.DisplayMember = "orden_id";
            cmbDetalleProceso.ValueMember = "orden_id";
        }

        private void llenarDatosComboBoxDetalleProcesoProduccion()
        {
            cmbProcesoProceso.DataSource = logProcesoProduccion.Instancia.ListarProcesoProduccion();
            cmbProcesoProceso.DisplayMember = "proceso_produccion_id";
            cmbProcesoProceso.ValueMember = "proceso_produccion_id";
        }

        public void ListarOrden()
        {
            dgvOrden.DataSource = logOrdenProduccion.Instancia.ListarOrdenProduccion();
        }

        public void ListarDetalle()
        {
            dgvDetalle.DataSource = logDetalleOrdenProduccion.Instancia.ListarDetalle();
        }

        public void ListarProceso()
        {
            dgvProceso.DataSource = logProcesoProduccion.Instancia.ListarProcesoProduccion();
        }

        public void ListarDetalleProceso()
        {
            dgvDetalleProceso.DataSource = logDetalleProcesoProduccion.Instancia.ListarDetalle();
        }

        private void LimpiarVariables()
        {
            txtOrden.Text = " ";
            txtProceso.Text = " ";
            txtCantidad.Text = " ";
            txtCantidadMateriales.Text = " ";  
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            groupBoxOrden.Enabled = true;
            groupBoxDetalle.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditarOrden.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnEditarProceso.Enabled = false;
            btnEditarDetalleProceso.Enabled = false;
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
                entOrdenProduccion cal = new entOrdenProduccion();
                cal.empleado_id = Convert.ToInt32(cmbEmpleado.SelectedValue);
                cal.f_orden = dtPickerRegOrden.Value;
                cal.orden_venta_id = Convert.ToInt32(cmbOrdenVenta.SelectedValue);
                logOrdenProduccion.Instancia.InsertarOrdenProduccion(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            LimpiarVariables();
            llenarDatosComboBoxDetalle();
            llenarDatosComboBoxDetalleProceso();
            groupBoxDetalle.Enabled = true;
            groupBoxOrden.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditarOrden.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnEditarProceso.Enabled = false;
            btnEditarDetalleProceso.Enabled = false;
            btnAgregarOrden.Visible = true;
            btnModificarOrden.Visible = true;
            btnRetirarOrden.Visible = true;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void dgvOrden_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvOrden.Rows[e.RowIndex]; //
            cmbDetalle.Text = filaActual.Cells[0].Value.ToString();
        }

        private void dgvOrden_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvOrden.Rows[e.RowIndex]; //
            txtOrden.Text = filaActual.Cells[0].Value.ToString();
            cmbEmpleado.Text = filaActual.Cells[2].Value.ToString(); ;
            cmbOrdenVenta.Text = filaActual.Cells[3].Value.ToString();
        }

        private void dgvDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDetalle.Rows[e.RowIndex]; //
            cmbDetalle.Text = filaActual.Cells[0].Value.ToString();
            cmbCalzado.Text = filaActual.Cells[7].Value.ToString(); ;
            txtCantidad.Text = filaActual.Cells[10].Value.ToString();
        }

        private void dgvProceso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProceso.Rows[e.RowIndex]; //
            cmbDetalleProceso.Text = filaActual.Cells[0].Value.ToString();
        }

        private void dgvProceso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProceso.Rows[e.RowIndex]; //
            txtProceso.Text = filaActual.Cells[0].Value.ToString();
            cmbEmpleadoProceso.Text = filaActual.Cells[2].Value.ToString(); ;
            cmbProceso.Text = filaActual.Cells[4].Value.ToString();
        }

        private void dgvDetalleProceso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvDetalleProceso.Rows[e.RowIndex]; //
            cmbDetalleProceso.Text = filaActual.Cells[0].Value.ToString();
            cmbMaterial.Text = filaActual.Cells[4].Value.ToString();
            cmbProcesoProceso.Text = filaActual.Cells[1].Value.ToString();
            txtCantidadMateriales.Text = filaActual.Cells[5].Value.ToString();
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
            btnEditarOrden.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnEditarProceso.Enabled = false;
            btnEditarDetalleProceso.Enabled = false;
            btnModificarOrden.Visible = true;
            btnAgregarOrden.Visible = false;
            btnRetirarOrden.Visible = false;
        }

        private void btnEditarDetalle_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditarOrden.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnEditarProceso.Enabled = false;
            btnEditarDetalleProceso.Enabled = false;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnModificarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenProduccion cal = new entOrdenProduccion();
                cal.orden_id = int.Parse(txtOrden.Text.Trim());
                cal.empleado_id = Convert.ToInt32(cmbEmpleado.SelectedValue);
                cal.f_orden = dtPickerRegOrden.Value;
                cal.orden_venta_id = Convert.ToInt32(cmbOrdenVenta.SelectedValue);
                logOrdenProduccion.Instancia.EditarOrdenProduccion(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditarOrden.Enabled = true;
            btnEliminar.Enabled = true;
            btnEditarDetalle.Enabled = true;
            btnEditarProceso.Enabled = true;
            btnEditarDetalleProceso.Enabled = true;
            btnAgregarDetalle.Visible = true;
            btnRetirarDetalle.Visible = true;
            ListarOrden();
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            groupBoxOrden.Enabled = true;
            groupBoxDetalle.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditarOrden.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnEditarProceso.Enabled = false;
            btnEditarDetalleProceso.Enabled = false;
            btnModificarOrden.Visible = false;
            btnAgregarOrden.Visible = false;
            btnRetirarOrden.Visible = true;
            txtOrden.Enabled = true;
            cmbEmpleado.Enabled = false;
            cmbOrdenVenta.Enabled = false;
            dtPickerRegOrden.Enabled = false;
            LimpiarVariables();
            ListarDetalle();
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnRetirarOrden_Click(object sender, EventArgs e)
        {
            //Eliminar
            try
            {
                entOrdenProduccion cal = new entOrdenProduccion();
                cal.orden_id = int.Parse(txtOrden.Text.Trim());
                logOrdenProduccion.Instancia.EliminarOrdenProduccion(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            btnNuevo.Enabled = true;
            btnEditarOrden.Enabled = true;
            btnEliminar.Enabled = true;
            btnEditarDetalle.Enabled = true;
            btnEditarProceso.Enabled = true;
            btnEditarDetalleProceso.Enabled = true;
            btnModificarOrden.Visible = true;
            btnAgregarOrden.Visible = true;
            btnRetirarOrden.Visible = true;
            txtOrden.Enabled = true;
            cmbEmpleado.Enabled = true;
            cmbOrdenVenta.Enabled = true;
            dtPickerRegOrden.Enabled = true;
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            btnNuevo.Enabled = true;
            btnEditarOrden.Enabled = true;
            btnEliminar.Enabled = true;
            btnEditarDetalle.Enabled = true;
            btnEditarProceso.Enabled = true;
            btnEditarDetalleProceso.Enabled = true;
            btnAgregarOrden.Visible = true;
            btnModificarOrden.Visible = true;
            btnRetirarOrden.Visible = true;
            txtOrden.Enabled = true;
            cmbEmpleado.Enabled = true;
            cmbOrdenVenta.Enabled = true;
            dtPickerRegOrden.Enabled = true;
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            ListarOrden();
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnAgregarProceso_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entProcesoProduccion cal = new entProcesoProduccion();
                cal.empleado_id = Convert.ToInt32(cmbEmpleadoProceso.SelectedValue);
                cal.proceso_id = Convert.ToInt32(cmbProceso.SelectedValue);
                logProcesoProduccion.Instancia.InsertarProcesoProduccion(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            llenarDatosComboBoxDetalleProcesoProduccion();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            groupBoxProceso.Enabled = true;
            groupBoxDetalleProceso.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditarOrden.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnEliminar.Enabled = false;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entDetalleOrdenProduccion cal = new entDetalleOrdenProduccion();
                cal.orden_id = Convert.ToInt32(cmbDetalle.SelectedValue);
                cal.calzado_id = Convert.ToInt32(cmbCalzado.SelectedValue);
                cal.cantidad = int.Parse(txtCantidad.Text.Trim());
                logDetalleOrdenProduccion.Instancia.InsertarDetalle(cal);
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
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnModificarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                entDetalleOrdenProduccion cal = new entDetalleOrdenProduccion();
                cal.orden_id = Convert.ToInt32(cmbDetalle.SelectedValue);
                cal.calzado_id = Convert.ToInt32(cmbCalzado.SelectedValue);
                cal.cantidad = int.Parse(txtCantidad.Text.Trim());
                logDetalleOrdenProduccion.Instancia.EditarDetalle(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxOrden.Enabled = false;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
            LimpiarVariables();
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
        }

        private void btnRetirarDetalle_Click(object sender, EventArgs e)
        {
            //Eliminar
            try
            {
                entDetalleOrdenProduccion cal = new entDetalleOrdenProduccion();
                cal.orden_id = Convert.ToInt32(cmbDetalle.SelectedValue);
                cal.calzado_id = Convert.ToInt32(cmbCalzado.SelectedValue);
                logDetalleOrdenProduccion.Instancia.EliminarDetalle(cal);
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
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnSalirDetalle_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditarOrden.Enabled = true;
            btnEliminar.Enabled = true;
            btnEditarDetalle.Enabled = true;
            btnEditarProceso.Enabled = true;
            btnEditarDetalleProceso.Enabled = true;
            btnAgregarDetalle.Visible = true;
            btnRetirarDetalle.Visible=true;
            btnModificarDetalle.Visible = true;
            ListarDetalle();
            ListarOrden();
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnSiguienteProceso_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            ListarProceso();
            ListarDetalleProceso();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            groupBoxProceso.Enabled = true;
            groupBoxDetalleProceso.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditarOrden.Enabled = false;
            btnEditarDetalle.Enabled=false;
            btnEliminar.Enabled = false;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnModificarProceso_Click(object sender, EventArgs e)
        {
            try
            {
                entProcesoProduccion cal = new entProcesoProduccion();
                cal.proceso_produccion_id = int.Parse(txtProceso.Text.Trim());
                cal.empleado_id = Convert.ToInt32(cmbEmpleadoProceso.SelectedValue);  
                cal.proceso_id = Convert.ToInt32(cmbProceso.SelectedValue);
                logProcesoProduccion.Instancia.EditarProcesoProduccion(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            groupBoxProceso.Enabled = true;
            groupBoxDetalleProceso.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditarOrden.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnEliminar.Enabled = false;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnRetirarProceso_Click(object sender, EventArgs e)
        {
            //Eliminar
            try
            {
                entProcesoProduccion cal = new entProcesoProduccion();
                cal.proceso_produccion_id = int.Parse(txtProceso.Text.Trim());
                logProcesoProduccion.Instancia.EliminarProcesoProduccion(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            groupBoxProceso.Enabled = true;
            groupBoxDetalleProceso.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditarOrden.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnEliminar.Enabled = false;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnSalirProceso_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            groupBoxProceso.Enabled = false;
            groupBoxDetalleProceso.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditarOrden.Enabled = true;
            btnEliminar.Enabled = true;
            btnEditarDetalle.Enabled = true;
            btnEditarProceso.Enabled = true;
            btnEditarDetalleProceso.Enabled = true;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnSiguienteDetalle_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            groupBoxProceso.Enabled = false;
            groupBoxDetalleProceso.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditarOrden.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnEliminar.Enabled = false;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnAgregarDetalleProceso_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entDetalleProcesoProduccion cal = new entDetalleProcesoProduccion();
                cal.orden_id = Convert.ToInt32(cmbDetalleProceso.SelectedValue);
                cal.proceso_produccion_id = Convert.ToInt32(cmbProcesoProceso.SelectedValue);
                cal.material_id = Convert.ToInt32(cmbMaterial.SelectedValue);
                cal.cantidad = int.Parse(txtCantidadMateriales.Text.Trim());
                logDetalleProcesoProduccion.Instancia.InsertarDetalle(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            groupBoxProceso.Enabled = false;
            groupBoxDetalleProceso.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditarOrden.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnEliminar.Enabled = false;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnModificarDetalleProceso_Click(object sender, EventArgs e)
        {
            try
            {
                entDetalleProcesoProduccion cal = new entDetalleProcesoProduccion();
                cal.orden_id = Convert.ToInt32(cmbDetalleProceso.SelectedValue);
                cal.proceso_produccion_id = Convert.ToInt32(cmbProcesoProceso.SelectedValue);
                cal.material_id = Convert.ToInt32(cmbMaterial.SelectedValue);
                cal.cantidad = int.Parse(txtCantidadMateriales.Text.Trim());
                logDetalleProcesoProduccion.Instancia.EditarDetalle(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            groupBoxProceso.Enabled = false;
            groupBoxDetalleProceso.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditarOrden.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnEliminar.Enabled = false;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnRetirarDetalleProceso_Click(object sender, EventArgs e)
        {
            //Eliminar
            try
            {
                entDetalleProcesoProduccion cal = new entDetalleProcesoProduccion();
                cal.orden_id = Convert.ToInt32(cmbDetalleProceso.SelectedValue);
                cal.proceso_produccion_id = Convert.ToInt32(cmbProcesoProceso.SelectedValue);
                cal.material_id = Convert.ToInt32(cmbMaterial.SelectedValue);
                logDetalleProcesoProduccion.Instancia.EliminarDetalle(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            groupBoxProceso.Enabled = false;
            groupBoxDetalleProceso.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditarOrden.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnEliminar.Enabled = false;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnSalirDetalleProceso_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            groupBoxProceso.Enabled = false;
            groupBoxDetalleProceso.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditarOrden.Enabled = true;
            btnEliminar.Enabled = true;
            btnEditarDetalle.Enabled = true;
            btnEditarProceso.Enabled = true;
            btnEditarDetalleProceso.Enabled = true;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnEditarProceso_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            groupBoxProceso.Enabled = true;
            groupBoxDetalleProceso.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditarOrden.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnEditarProceso.Enabled = false;
            btnEditarDetalleProceso.Enabled = false;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }

        private void btnEditarDetalleProceso_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            ListarOrden();
            ListarDetalle();
            ListarProceso();
            ListarDetalleProceso();
            groupBoxOrden.Enabled = false;
            groupBoxDetalle.Enabled = false;
            groupBoxProceso.Enabled = false;
            groupBoxDetalleProceso.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditarOrden.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditarDetalle.Enabled = false;
            btnEditarProceso.Enabled = false;
            btnEditarDetalleProceso.Enabled = false;
            dgvOrden.ReadOnly = true;
            dgvDetalle.ReadOnly = true;
            dgvProceso.ReadOnly = true;
            dgvDetalleProceso.ReadOnly = true;
        }
    }
}
