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
    public partial class mantenedorCategoriaMateriales : Form
    {
        public mantenedorCategoriaMateriales()
        {
            InitializeComponent();
            groupBoxDatos.Enabled = false;
            ListarCategoriaMateriales();
            dgvCategoria.ReadOnly = true;
        }

        public void ListarCategoriaMateriales()
        {
            dgvCategoria.DataSource = logCategoriaMateriales.Instancia.ListarCategoriaMateriales();
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
            txtCategoria.Enabled = false;
        }

        private void LimpiarVariables()
        {
            txtCategoria.Text = " ";
            txtNombre.Text = " ";
            txtDescripcion.Text = " ";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entCategoriaMateriales cat = new entCategoriaMateriales();
                cat.nombre = txtNombre.Text.Trim();
                cat.descripcion = txtDescripcion.Text.Trim();

                logCategoriaMateriales.Instancia.InsertarCategoriaMateriales(cat);
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
            txtCategoria.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarCategoriaMateriales();
            dgvCategoria.ReadOnly = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCategoria.Rows[e.RowIndex]; //
            txtCategoria.Text = filaActual.Cells[0].Value.ToString();
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
                entCategoriaMateriales cat = new entCategoriaMateriales();
                cat.categoria_id = int.Parse(txtCategoria.Text.Trim());
                cat.nombre = txtNombre.Text.Trim();
                cat.descripcion = txtDescripcion.Text.Trim();
                logCategoriaMateriales.Instancia.EditarCategoriaMateriales(cat);
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
            ListarCategoriaMateriales();
            dgvCategoria.ReadOnly = true;
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
            txtCategoria.Enabled = true;
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarCategoriaMateriales();
            dgvCategoria.ReadOnly = true;
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
            txtCategoria.Enabled = true;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            //Eliminar
            try
            {
                entCategoriaMateriales cat = new entCategoriaMateriales();
                cat.categoria_id = int.Parse(txtCategoria.Text.Trim());
                logCategoriaMateriales.Instancia.EliminarCategoriaMateriales(cat);
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
            txtCategoria.Enabled = true;
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarCategoriaMateriales();
            dgvCategoria.ReadOnly = true;
        }
    }
}
