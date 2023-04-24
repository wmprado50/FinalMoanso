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
    public partial class mantenedorModelo : Form
    {
        public mantenedorModelo()
        {
            InitializeComponent();
            ListarModelo();
            groupBoxDatos.Enabled = false;
            dgvModelo.ReadOnly = true;
        }

        public void ListarModelo()
        {
            dgvModelo.DataSource = logModelo.Instancia.ListarModelo();
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
            txtModelo.Enabled = false;
        }

        private void LimpiarVariables()
        {
            txtModelo.Text = " ";
            txtNombre.Text = " ";
            txtDescripcion.Text = " ";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entModelo cat = new entModelo();
                cat.nombre = txtNombre.Text.Trim();
                cat.descripcion = txtDescripcion.Text.Trim();

                logModelo.Instancia.InsertarModelo(cat);
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
            txtModelo.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarModelo();
            dgvModelo.ReadOnly = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvModelo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvModelo.Rows[e.RowIndex]; //
            txtModelo.Text = filaActual.Cells[0].Value.ToString();
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
                entModelo cat = new entModelo();
                cat.modelo_id = int.Parse(txtModelo.Text.Trim());
                cat.nombre = txtNombre.Text.Trim();
                cat.descripcion = txtDescripcion.Text.Trim();
                logModelo.Instancia.EditarModelo(cat);
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
            ListarModelo();
            dgvModelo.ReadOnly = true;
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
            txtModelo.Enabled = true;
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarModelo();
            dgvModelo.ReadOnly = true;
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
            txtModelo.Enabled = true;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            //Eliminar
            try
            {
                entModelo cat = new entModelo();
                cat.modelo_id = int.Parse(txtModelo.Text.Trim());
                logModelo.Instancia.EliminarModelo(cat);
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
            txtModelo.Enabled = true;
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            groupBoxDatos.Enabled = false;
            ListarModelo();
            dgvModelo.ReadOnly = true;
        }
    }
}
