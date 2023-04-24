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
    public partial class mantenedorMarca : Form
    {
        public mantenedorMarca()
        {
            InitializeComponent();
            ListarMarca();
            groupBoxDatos.Enabled = false;
            dgvMarca.ReadOnly = true;
        }

        public void ListarMarca()
        {
            dgvMarca.DataSource = logMarca.Instancia.ListarMarca();
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
            txtMarca.Enabled = false;
        }

        private void LimpiarVariables()
        {
            txtMarca.Text = " ";
            txtNombre.Text = " ";
            txtDescripcion.Text = " ";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entMarca cat = new entMarca();
                cat.nombre = txtNombre.Text.Trim();
                cat.descripcion = txtDescripcion.Text.Trim();

                logMarca.Instancia.InsertarMarca(cat);
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
            txtMarca.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarMarca();
            dgvMarca.ReadOnly = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvMarca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMarca.Rows[e.RowIndex]; //
            txtMarca.Text = filaActual.Cells[0].Value.ToString();
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
                entMarca cat = new entMarca();
                cat.marca_id = int.Parse(txtMarca.Text.Trim());
                cat.nombre = txtNombre.Text.Trim();
                cat.descripcion = txtDescripcion.Text.Trim();
                logMarca.Instancia.EditarMarca(cat);
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
            ListarMarca();
            dgvMarca.ReadOnly = true;
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
            txtMarca.Enabled = true;
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarMarca();
            dgvMarca.ReadOnly = true;
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
            txtMarca.Enabled = true;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            //Eliminar
            try
            {
                entMarca cat = new entMarca();
                cat.marca_id = int.Parse(txtMarca.Text.Trim());
                logMarca.Instancia.EliminarMarca(cat);
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
            txtMarca.Enabled = true;
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarMarca();
            dgvMarca.ReadOnly = true;
        }
    }
}
