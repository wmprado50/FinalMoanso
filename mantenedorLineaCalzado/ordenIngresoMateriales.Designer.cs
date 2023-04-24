namespace mantenedorLineaCalzado
{
    partial class ordenIngresoMateriales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvOrden = new System.Windows.Forms.DataGridView();
            this.groupBoxOrden = new System.Windows.Forms.GroupBox();
            this.dtPickerRegOrden = new System.Windows.Forms.DateTimePicker();
            this.cmbOrdenCompra = new System.Windows.Forms.ComboBox();
            this.cmbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.txtOrden = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCancelarOrden = new System.Windows.Forms.Button();
            this.btnRetirarOrden = new System.Windows.Forms.Button();
            this.btnModificarOrden = new System.Windows.Forms.Button();
            this.btnAgregarOrden = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDetalle = new System.Windows.Forms.GroupBox();
            this.btnSalirDetalle = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRetirarDetalle = new System.Windows.Forms.Button();
            this.btnModificarDetalle = new System.Windows.Forms.Button();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditarOrden = new System.Windows.Forms.Button();
            this.btnEditarDetalle = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            this.groupBoxOrden.SuspendLayout();
            this.groupBoxDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrden
            // 
            this.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrden.Location = new System.Drawing.Point(12, 21);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.Size = new System.Drawing.Size(488, 215);
            this.dgvOrden.TabIndex = 0;
            this.dgvOrden.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrden_CellClick);
            this.dgvOrden.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrden_CellDoubleClick);
            // 
            // groupBoxOrden
            // 
            this.groupBoxOrden.Controls.Add(this.dtPickerRegOrden);
            this.groupBoxOrden.Controls.Add(this.cmbOrdenCompra);
            this.groupBoxOrden.Controls.Add(this.cmbTipoComprobante);
            this.groupBoxOrden.Controls.Add(this.cmbEmpleado);
            this.groupBoxOrden.Controls.Add(this.txtOrden);
            this.groupBoxOrden.Controls.Add(this.txtNumero);
            this.groupBoxOrden.Controls.Add(this.btnCancelarOrden);
            this.groupBoxOrden.Controls.Add(this.btnRetirarOrden);
            this.groupBoxOrden.Controls.Add(this.btnModificarOrden);
            this.groupBoxOrden.Controls.Add(this.btnAgregarOrden);
            this.groupBoxOrden.Controls.Add(this.label6);
            this.groupBoxOrden.Controls.Add(this.label5);
            this.groupBoxOrden.Controls.Add(this.label4);
            this.groupBoxOrden.Controls.Add(this.label3);
            this.groupBoxOrden.Controls.Add(this.label2);
            this.groupBoxOrden.Controls.Add(this.label1);
            this.groupBoxOrden.Location = new System.Drawing.Point(12, 259);
            this.groupBoxOrden.Name = "groupBoxOrden";
            this.groupBoxOrden.Size = new System.Drawing.Size(759, 159);
            this.groupBoxOrden.TabIndex = 1;
            this.groupBoxOrden.TabStop = false;
            this.groupBoxOrden.Text = "Datos de la Orden:";
            // 
            // dtPickerRegOrden
            // 
            this.dtPickerRegOrden.Location = new System.Drawing.Point(316, 111);
            this.dtPickerRegOrden.Name = "dtPickerRegOrden";
            this.dtPickerRegOrden.Size = new System.Drawing.Size(200, 20);
            this.dtPickerRegOrden.TabIndex = 16;
            // 
            // cmbOrdenCompra
            // 
            this.cmbOrdenCompra.FormattingEnabled = true;
            this.cmbOrdenCompra.Location = new System.Drawing.Point(113, 108);
            this.cmbOrdenCompra.Name = "cmbOrdenCompra";
            this.cmbOrdenCompra.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenCompra.TabIndex = 15;
            // 
            // cmbTipoComprobante
            // 
            this.cmbTipoComprobante.FormattingEnabled = true;
            this.cmbTipoComprobante.Location = new System.Drawing.Point(395, 29);
            this.cmbTipoComprobante.Name = "cmbTipoComprobante";
            this.cmbTipoComprobante.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoComprobante.TabIndex = 14;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(113, 67);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleado.TabIndex = 13;
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(113, 30);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(121, 20);
            this.txtOrden.TabIndex = 12;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(395, 63);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 20);
            this.txtNumero.TabIndex = 11;
            // 
            // btnCancelarOrden
            // 
            this.btnCancelarOrden.Location = new System.Drawing.Point(684, 20);
            this.btnCancelarOrden.Name = "btnCancelarOrden";
            this.btnCancelarOrden.Size = new System.Drawing.Size(60, 118);
            this.btnCancelarOrden.TabIndex = 10;
            this.btnCancelarOrden.Text = "Cancelar";
            this.btnCancelarOrden.UseVisualStyleBackColor = true;
            this.btnCancelarOrden.Click += new System.EventHandler(this.btnCancelarOrden_Click);
            // 
            // btnRetirarOrden
            // 
            this.btnRetirarOrden.Location = new System.Drawing.Point(532, 108);
            this.btnRetirarOrden.Name = "btnRetirarOrden";
            this.btnRetirarOrden.Size = new System.Drawing.Size(132, 30);
            this.btnRetirarOrden.TabIndex = 9;
            this.btnRetirarOrden.Text = "Retirar";
            this.btnRetirarOrden.UseVisualStyleBackColor = true;
            this.btnRetirarOrden.Click += new System.EventHandler(this.btnRetirarOrden_Click);
            // 
            // btnModificarOrden
            // 
            this.btnModificarOrden.Location = new System.Drawing.Point(532, 62);
            this.btnModificarOrden.Name = "btnModificarOrden";
            this.btnModificarOrden.Size = new System.Drawing.Size(132, 30);
            this.btnModificarOrden.TabIndex = 8;
            this.btnModificarOrden.Text = "Modificar";
            this.btnModificarOrden.UseVisualStyleBackColor = true;
            this.btnModificarOrden.Click += new System.EventHandler(this.btnModificarOrden_Click);
            // 
            // btnAgregarOrden
            // 
            this.btnAgregarOrden.Location = new System.Drawing.Point(532, 20);
            this.btnAgregarOrden.Name = "btnAgregarOrden";
            this.btnAgregarOrden.Size = new System.Drawing.Size(132, 30);
            this.btnAgregarOrden.TabIndex = 7;
            this.btnAgregarOrden.Text = "Agregar";
            this.btnAgregarOrden.UseVisualStyleBackColor = true;
            this.btnAgregarOrden.Click += new System.EventHandler(this.btnAgregarOrden_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número de Comprobante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Comprobante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Orden de Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orden:";
            // 
            // groupBoxDetalle
            // 
            this.groupBoxDetalle.Controls.Add(this.btnSalirDetalle);
            this.groupBoxDetalle.Controls.Add(this.txtCantidad);
            this.groupBoxDetalle.Controls.Add(this.cmbMaterial);
            this.groupBoxDetalle.Controls.Add(this.txtDetalle);
            this.groupBoxDetalle.Controls.Add(this.label9);
            this.groupBoxDetalle.Controls.Add(this.label8);
            this.groupBoxDetalle.Controls.Add(this.label7);
            this.groupBoxDetalle.Controls.Add(this.btnRetirarDetalle);
            this.groupBoxDetalle.Controls.Add(this.btnModificarDetalle);
            this.groupBoxDetalle.Controls.Add(this.btnAgregarDetalle);
            this.groupBoxDetalle.Controls.Add(this.dgvDetalle);
            this.groupBoxDetalle.Location = new System.Drawing.Point(12, 433);
            this.groupBoxDetalle.Name = "groupBoxDetalle";
            this.groupBoxDetalle.Size = new System.Drawing.Size(759, 302);
            this.groupBoxDetalle.TabIndex = 2;
            this.groupBoxDetalle.TabStop = false;
            this.groupBoxDetalle.Text = "Detalle de la Orden:";
            // 
            // btnSalirDetalle
            // 
            this.btnSalirDetalle.Location = new System.Drawing.Point(684, 38);
            this.btnSalirDetalle.Name = "btnSalirDetalle";
            this.btnSalirDetalle.Size = new System.Drawing.Size(60, 190);
            this.btnSalirDetalle.TabIndex = 18;
            this.btnSalirDetalle.Text = "Salir";
            this.btnSalirDetalle.UseVisualStyleBackColor = true;
            this.btnSalirDetalle.Click += new System.EventHandler(this.btnSalirDetalle_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(337, 199);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 17;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(89, 243);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterial.TabIndex = 16;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(89, 203);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(121, 20);
            this.txtDetalle.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Material:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Orden:";
            // 
            // btnRetirarDetalle
            // 
            this.btnRetirarDetalle.Location = new System.Drawing.Point(532, 177);
            this.btnRetirarDetalle.Name = "btnRetirarDetalle";
            this.btnRetirarDetalle.Size = new System.Drawing.Size(132, 51);
            this.btnRetirarDetalle.TabIndex = 8;
            this.btnRetirarDetalle.Text = "Retirar";
            this.btnRetirarDetalle.UseVisualStyleBackColor = true;
            this.btnRetirarDetalle.Click += new System.EventHandler(this.btnRetirarDetalle_Click);
            // 
            // btnModificarDetalle
            // 
            this.btnModificarDetalle.Location = new System.Drawing.Point(532, 104);
            this.btnModificarDetalle.Name = "btnModificarDetalle";
            this.btnModificarDetalle.Size = new System.Drawing.Size(132, 51);
            this.btnModificarDetalle.TabIndex = 7;
            this.btnModificarDetalle.Text = "Modificar";
            this.btnModificarDetalle.UseVisualStyleBackColor = true;
            this.btnModificarDetalle.Click += new System.EventHandler(this.btnModificarDetalle_Click);
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Location = new System.Drawing.Point(532, 38);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(132, 51);
            this.btnAgregarDetalle.TabIndex = 6;
            this.btnAgregarDetalle.Text = "Agregar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(17, 28);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(471, 153);
            this.dgvDetalle.TabIndex = 1;
            this.dgvDetalle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(544, 21);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(171, 37);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(544, 163);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 33);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(544, 202);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(171, 34);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditarOrden
            // 
            this.btnEditarOrden.Location = new System.Drawing.Point(544, 76);
            this.btnEditarOrden.Name = "btnEditarOrden";
            this.btnEditarOrden.Size = new System.Drawing.Size(171, 33);
            this.btnEditarOrden.TabIndex = 7;
            this.btnEditarOrden.Text = "Editar Orden";
            this.btnEditarOrden.UseVisualStyleBackColor = true;
            this.btnEditarOrden.Click += new System.EventHandler(this.btnEditarOrden_Click);
            // 
            // btnEditarDetalle
            // 
            this.btnEditarDetalle.Location = new System.Drawing.Point(544, 124);
            this.btnEditarDetalle.Name = "btnEditarDetalle";
            this.btnEditarDetalle.Size = new System.Drawing.Size(171, 33);
            this.btnEditarDetalle.TabIndex = 8;
            this.btnEditarDetalle.Text = "Editar Detalle";
            this.btnEditarDetalle.UseVisualStyleBackColor = true;
            this.btnEditarDetalle.Click += new System.EventHandler(this.btnEditarDetalle_Click);
            // 
            // ordenIngresoMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 747);
            this.Controls.Add(this.btnEditarDetalle);
            this.Controls.Add(this.btnEditarOrden);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBoxDetalle);
            this.Controls.Add(this.groupBoxOrden);
            this.Controls.Add(this.dgvOrden);
            this.Name = "ordenIngresoMateriales";
            this.Text = "ordenIngresoMateriales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.groupBoxOrden.ResumeLayout(false);
            this.groupBoxOrden.PerformLayout();
            this.groupBoxDetalle.ResumeLayout(false);
            this.groupBoxDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrden;
        private System.Windows.Forms.GroupBox groupBoxOrden;
        private System.Windows.Forms.Button btnCancelarOrden;
        private System.Windows.Forms.Button btnRetirarOrden;
        private System.Windows.Forms.Button btnModificarOrden;
        private System.Windows.Forms.Button btnAgregarOrden;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDetalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRetirarDetalle;
        private System.Windows.Forms.Button btnModificarDetalle;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dtPickerRegOrden;
        private System.Windows.Forms.ComboBox cmbOrdenCompra;
        private System.Windows.Forms.ComboBox cmbTipoComprobante;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.MaskedTextBox txtOrden;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button btnEditarOrden;
        private System.Windows.Forms.Button btnEditarDetalle;
        private System.Windows.Forms.Button btnSalirDetalle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}