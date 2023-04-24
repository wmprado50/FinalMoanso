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
    public partial class mantenedorCalzado : Form
    {
        public mantenedorCalzado()
        {
            InitializeComponent();
            llenarDatosComboBoxModeloCalzado();
            llenarDatosComboBoxColorCalzado();
            llenarDatosComboBoxLineaCalzado();
            llenarDatosComboBoxCategoriaCalzado();
            ListarCalzado();
            groupBoxDatos.Enabled = false;
            dgvCalzado.ReadOnly = true;
        }

        private void llenarDatosComboBoxLineaCalzado()
        {
            cmbLinea.DataSource = logLineaCalzado.Instancia.ListarLineaCalzado();
            cmbLinea.DisplayMember = "nombre";
            cmbLinea.ValueMember = "linea_id";
        }

        private void llenarDatosComboBoxCategoriaCalzado()
        {
            cmbCategoria.DataSource = logCategoriaCalzado.Instancia.ListarCategoriaCalzado();
            cmbCategoria.DisplayMember = "nombre";
            cmbCategoria.ValueMember = "categoria_id";
        }

        private void llenarDatosComboBoxModeloCalzado()
        {
            cmbModelo.DataSource = logModelo.Instancia.ListarModelo();
            cmbModelo.DisplayMember = "nombre";
            cmbModelo.ValueMember = "modelo_id";
        }

        private void llenarDatosComboBoxColorCalzado()
        {
            cmbColor.DataSource = logColor.Instancia.ListarColor();
            cmbColor.DisplayMember = "nombre";
            cmbColor.ValueMember = "color_id";
        }

        public void ListarCalzado()
        {
            dgvCalzado.DataSource = logCalzado.Instancia.ListarCalzado();
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
            txtCalzado.Enabled = false;
            txtStock.Enabled =false;
        }

        private void LimpiarVariables()
        {
            txtCalzado.Text = " ";
            txtStock.Text = " ";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entCalzado cal = new entCalzado();
                cal.linea_calzado = Convert.ToInt32(cmbLinea.SelectedValue);
                cal.categoria_calzado = Convert.ToInt32(cmbCategoria.SelectedValue);
                cal.modelo_calzado = Convert.ToInt32(cmbModelo.SelectedValue);
                cal.color_calzado = Convert.ToInt32(cmbColor.SelectedValue);
                logCalzado.Instancia.InsertarCalzado(cal);
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
            txtCalzado.Enabled = true;
            txtStock.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarCalzado();
            dgvCalzado.ReadOnly = true;
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
                entCalzado cal = new entCalzado();
                cal.calzado_id = int.Parse(txtCalzado.Text.Trim());
                cal.linea_calzado = Convert.ToInt32(cmbLinea.SelectedValue);
                cal.categoria_calzado = Convert.ToInt32(cmbCategoria.SelectedValue);
                cal.modelo_calzado = Convert.ToInt32(cmbModelo.SelectedValue);
                cal.color_calzado = Convert.ToInt32(cmbColor.SelectedValue);
                cal.stock = int.Parse(txtStock.Text.Trim());
                logCalzado.Instancia.EditarCalzado(cal);
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
            ListarCalzado();
            dgvCalzado.ReadOnly = true;            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Visible = true;
            btnRetirar.Visible = true;
            btnModificar.Visible = true;
            txtCalzado.Enabled = true;
            txtStock.Enabled = true;
            cmbLinea.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbColor.Enabled = true;
            cmbModelo.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarCalzado();
            dgvCalzado.ReadOnly = true;
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
            cmbLinea.Enabled = false;
            cmbCategoria.Enabled = false;
            cmbColor.Enabled = false;
            cmbModelo.Enabled = false;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            //Eliminar
            try
            {
                entCalzado cal = new entCalzado();
                cal.calzado_id = int.Parse(txtCalzado.Text.Trim());
                logCalzado.Instancia.EliminarCalzado(cal);
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
            cmbLinea.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbColor.Enabled = true;
            cmbModelo.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarCalzado();
            dgvCalzado.ReadOnly = true;
        }

        private void dgvCalzado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCalzado.Rows[e.RowIndex]; //
            txtCalzado.Text = filaActual.Cells[0].Value.ToString();
            cmbLinea.Text = filaActual.Cells[2].Value.ToString();
            cmbCategoria.Text = filaActual.Cells[4].Value.ToString();
            cmbModelo.Text = filaActual.Cells[6].Value.ToString();
            cmbColor.Text = filaActual.Cells[8].Value.ToString();
            txtStock.Text = filaActual.Cells[9].Value.ToString();
        }
    }
}
