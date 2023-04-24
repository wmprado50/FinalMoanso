namespace mantenedorLineaCalzado
{
    partial class ordenProduccion
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditarOrden = new System.Windows.Forms.Button();
            this.btnEditarDetalle = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBoxOrden = new System.Windows.Forms.GroupBox();
            this.dtPickerRegOrden = new System.Windows.Forms.DateTimePicker();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbOrdenVenta = new System.Windows.Forms.ComboBox();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRetirarOrden = new System.Windows.Forms.Button();
            this.btnModificarOrden = new System.Windows.Forms.Button();
            this.btnAgregarOrden = new System.Windows.Forms.Button();
            this.groupBoxDetalle = new System.Windows.Forms.GroupBox();
            this.cmbDetalle = new System.Windows.Forms.ComboBox();
            this.btnSiguienteProceso = new System.Windows.Forms.Button();
            this.cmbCalzado = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalirDetalle = new System.Windows.Forms.Button();
            this.btnRetirarDetalle = new System.Windows.Forms.Button();
            this.btnModificarDetalle = new System.Windows.Forms.Button();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.groupBoxProceso = new System.Windows.Forms.GroupBox();
            this.txtProceso = new System.Windows.Forms.TextBox();
            this.btnSiguienteDetalle = new System.Windows.Forms.Button();
            this.cmbProceso = new System.Windows.Forms.ComboBox();
            this.cmbEmpleadoProceso = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalirProceso = new System.Windows.Forms.Button();
            this.btnRetirarProceso = new System.Windows.Forms.Button();
            this.btnModificarProceso = new System.Windows.Forms.Button();
            this.btnAgregarProceso = new System.Windows.Forms.Button();
            this.dgvProceso = new System.Windows.Forms.DataGridView();
            this.groupBoxDetalleProceso = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbProcesoProceso = new System.Windows.Forms.ComboBox();
            this.cmbDetalleProceso = new System.Windows.Forms.ComboBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.txtCantidadMateriales = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSalirDetalleProceso = new System.Windows.Forms.Button();
            this.btnRetirarDetalleProceso = new System.Windows.Forms.Button();
            this.btnModificarDetalleProceso = new System.Windows.Forms.Button();
            this.btnAgregarDetalleProceso = new System.Windows.Forms.Button();
            this.dgvDetalleProceso = new System.Windows.Forms.DataGridView();
            this.btnEditarProceso = new System.Windows.Forms.Button();
            this.btnEditarDetalleProceso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            this.groupBoxOrden.SuspendLayout();
            this.groupBoxDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.groupBoxProceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProceso)).BeginInit();
            this.groupBoxDetalleProceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleProceso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrden
            // 
            this.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrden.Location = new System.Drawing.Point(16, 15);
            this.dgvOrden.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.RowHeadersWidth = 51;
            this.dgvOrden.Size = new System.Drawing.Size(627, 310);
            this.dgvOrden.TabIndex = 0;
            this.dgvOrden.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrden_CellClick);
            this.dgvOrden.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrden_CellDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(689, 32);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(193, 41);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditarOrden
            // 
            this.btnEditarOrden.Location = new System.Drawing.Point(689, 100);
            this.btnEditarOrden.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarOrden.Name = "btnEditarOrden";
            this.btnEditarOrden.Size = new System.Drawing.Size(193, 41);
            this.btnEditarOrden.TabIndex = 2;
            this.btnEditarOrden.Text = "Editar Orden";
            this.btnEditarOrden.UseVisualStyleBackColor = true;
            this.btnEditarOrden.Click += new System.EventHandler(this.btnEditarOrden_Click);
            // 
            // btnEditarDetalle
            // 
            this.btnEditarDetalle.Location = new System.Drawing.Point(909, 32);
            this.btnEditarDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarDetalle.Name = "btnEditarDetalle";
            this.btnEditarDetalle.Size = new System.Drawing.Size(111, 68);
            this.btnEditarDetalle.TabIndex = 3;
            this.btnEditarDetalle.Text = "Editar Detalle de Producciòn";
            this.btnEditarDetalle.UseVisualStyleBackColor = true;
            this.btnEditarDetalle.Click += new System.EventHandler(this.btnEditarDetalle_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(689, 169);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(193, 41);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(689, 257);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(331, 41);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBoxOrden
            // 
            this.groupBoxOrden.Controls.Add(this.dtPickerRegOrden);
            this.groupBoxOrden.Controls.Add(this.cmbEmpleado);
            this.groupBoxOrden.Controls.Add(this.cmbOrdenVenta);
            this.groupBoxOrden.Controls.Add(this.txtOrden);
            this.groupBoxOrden.Controls.Add(this.label4);
            this.groupBoxOrden.Controls.Add(this.label3);
            this.groupBoxOrden.Controls.Add(this.label2);
            this.groupBoxOrden.Controls.Add(this.label1);
            this.groupBoxOrden.Controls.Add(this.btnCancelar);
            this.groupBoxOrden.Controls.Add(this.btnRetirarOrden);
            this.groupBoxOrden.Controls.Add(this.btnModificarOrden);
            this.groupBoxOrden.Controls.Add(this.btnAgregarOrden);
            this.groupBoxOrden.Location = new System.Drawing.Point(16, 358);
            this.groupBoxOrden.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOrden.Name = "groupBoxOrden";
            this.groupBoxOrden.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOrden.Size = new System.Drawing.Size(988, 181);
            this.groupBoxOrden.TabIndex = 6;
            this.groupBoxOrden.TabStop = false;
            this.groupBoxOrden.Text = "Detalle de la Orden";
            // 
            // dtPickerRegOrden
            // 
            this.dtPickerRegOrden.Location = new System.Drawing.Point(319, 62);
            this.dtPickerRegOrden.Margin = new System.Windows.Forms.Padding(4);
            this.dtPickerRegOrden.Name = "dtPickerRegOrden";
            this.dtPickerRegOrden.Size = new System.Drawing.Size(265, 22);
            this.dtPickerRegOrden.TabIndex = 22;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(132, 81);
            this.cmbEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(160, 24);
            this.cmbEmpleado.TabIndex = 21;
            // 
            // cmbOrdenVenta
            // 
            this.cmbOrdenVenta.FormattingEnabled = true;
            this.cmbOrdenVenta.Location = new System.Drawing.Point(132, 122);
            this.cmbOrdenVenta.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOrdenVenta.Name = "cmbOrdenVenta";
            this.cmbOrdenVenta.Size = new System.Drawing.Size(160, 24);
            this.cmbOrdenVenta.TabIndex = 20;
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(132, 27);
            this.txtOrden.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(160, 22);
            this.txtOrden.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Orden de Venta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Empleado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Orden:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(819, 23);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 139);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRetirarOrden
            // 
            this.btnRetirarOrden.Location = new System.Drawing.Point(637, 122);
            this.btnRetirarOrden.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetirarOrden.Name = "btnRetirarOrden";
            this.btnRetirarOrden.Size = new System.Drawing.Size(135, 41);
            this.btnRetirarOrden.TabIndex = 10;
            this.btnRetirarOrden.Text = "Retirar";
            this.btnRetirarOrden.UseVisualStyleBackColor = true;
            this.btnRetirarOrden.Click += new System.EventHandler(this.btnRetirarOrden_Click);
            // 
            // btnModificarOrden
            // 
            this.btnModificarOrden.Location = new System.Drawing.Point(637, 74);
            this.btnModificarOrden.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarOrden.Name = "btnModificarOrden";
            this.btnModificarOrden.Size = new System.Drawing.Size(135, 41);
            this.btnModificarOrden.TabIndex = 9;
            this.btnModificarOrden.Text = "Modificar";
            this.btnModificarOrden.UseVisualStyleBackColor = true;
            this.btnModificarOrden.Click += new System.EventHandler(this.btnModificarOrden_Click);
            // 
            // btnAgregarOrden
            // 
            this.btnAgregarOrden.Location = new System.Drawing.Point(637, 23);
            this.btnAgregarOrden.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarOrden.Name = "btnAgregarOrden";
            this.btnAgregarOrden.Size = new System.Drawing.Size(135, 41);
            this.btnAgregarOrden.TabIndex = 8;
            this.btnAgregarOrden.Text = "Agregar";
            this.btnAgregarOrden.UseVisualStyleBackColor = true;
            this.btnAgregarOrden.Click += new System.EventHandler(this.btnAgregarOrden_Click);
            // 
            // groupBoxDetalle
            // 
            this.groupBoxDetalle.Controls.Add(this.cmbDetalle);
            this.groupBoxDetalle.Controls.Add(this.btnSiguienteProceso);
            this.groupBoxDetalle.Controls.Add(this.cmbCalzado);
            this.groupBoxDetalle.Controls.Add(this.txtCantidad);
            this.groupBoxDetalle.Controls.Add(this.label7);
            this.groupBoxDetalle.Controls.Add(this.label8);
            this.groupBoxDetalle.Controls.Add(this.label9);
            this.groupBoxDetalle.Controls.Add(this.btnSalirDetalle);
            this.groupBoxDetalle.Controls.Add(this.btnRetirarDetalle);
            this.groupBoxDetalle.Controls.Add(this.btnModificarDetalle);
            this.groupBoxDetalle.Controls.Add(this.btnAgregarDetalle);
            this.groupBoxDetalle.Controls.Add(this.dgvDetalle);
            this.groupBoxDetalle.Location = new System.Drawing.Point(16, 560);
            this.groupBoxDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalle.Name = "groupBoxDetalle";
            this.groupBoxDetalle.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalle.Size = new System.Drawing.Size(988, 362);
            this.groupBoxDetalle.TabIndex = 7;
            this.groupBoxDetalle.TabStop = false;
            this.groupBoxDetalle.Text = "Detalle de la Produccion";
            // 
            // cmbDetalle
            // 
            this.cmbDetalle.FormattingEnabled = true;
            this.cmbDetalle.Location = new System.Drawing.Point(132, 262);
            this.cmbDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDetalle.Name = "cmbDetalle";
            this.cmbDetalle.Size = new System.Drawing.Size(160, 24);
            this.cmbDetalle.TabIndex = 24;
            // 
            // btnSiguienteProceso
            // 
            this.btnSiguienteProceso.Location = new System.Drawing.Point(819, 225);
            this.btnSiguienteProceso.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteProceso.Name = "btnSiguienteProceso";
            this.btnSiguienteProceso.Size = new System.Drawing.Size(135, 76);
            this.btnSiguienteProceso.TabIndex = 23;
            this.btnSiguienteProceso.Text = "Siguiente";
            this.btnSiguienteProceso.UseVisualStyleBackColor = true;
            this.btnSiguienteProceso.Click += new System.EventHandler(this.btnSiguienteProceso_Click);
            // 
            // cmbCalzado
            // 
            this.cmbCalzado.FormattingEnabled = true;
            this.cmbCalzado.Location = new System.Drawing.Point(132, 320);
            this.cmbCalzado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCalzado.Name = "cmbCalzado";
            this.cmbCalzado.Size = new System.Drawing.Size(160, 24);
            this.cmbCalzado.TabIndex = 22;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(424, 249);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(160, 22);
            this.txtCantidad.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 268);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Orden:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 330);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Calzado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 252);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cantidad:";
            // 
            // btnSalirDetalle
            // 
            this.btnSalirDetalle.Location = new System.Drawing.Point(819, 65);
            this.btnSalirDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalirDetalle.Name = "btnSalirDetalle";
            this.btnSalirDetalle.Size = new System.Drawing.Size(135, 116);
            this.btnSalirDetalle.TabIndex = 15;
            this.btnSalirDetalle.Text = "Salir";
            this.btnSalirDetalle.UseVisualStyleBackColor = true;
            this.btnSalirDetalle.Click += new System.EventHandler(this.btnSalirDetalle_Click);
            // 
            // btnRetirarDetalle
            // 
            this.btnRetirarDetalle.Location = new System.Drawing.Point(661, 228);
            this.btnRetirarDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetirarDetalle.Name = "btnRetirarDetalle";
            this.btnRetirarDetalle.Size = new System.Drawing.Size(135, 41);
            this.btnRetirarDetalle.TabIndex = 14;
            this.btnRetirarDetalle.Text = "Retirar";
            this.btnRetirarDetalle.UseVisualStyleBackColor = true;
            this.btnRetirarDetalle.Click += new System.EventHandler(this.btnRetirarDetalle_Click);
            // 
            // btnModificarDetalle
            // 
            this.btnModificarDetalle.Location = new System.Drawing.Point(661, 140);
            this.btnModificarDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarDetalle.Name = "btnModificarDetalle";
            this.btnModificarDetalle.Size = new System.Drawing.Size(135, 41);
            this.btnModificarDetalle.TabIndex = 13;
            this.btnModificarDetalle.Text = "Modificar";
            this.btnModificarDetalle.UseVisualStyleBackColor = true;
            this.btnModificarDetalle.Click += new System.EventHandler(this.btnModificarDetalle_Click);
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Location = new System.Drawing.Point(661, 65);
            this.btnAgregarDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(135, 41);
            this.btnAgregarDetalle.TabIndex = 12;
            this.btnAgregarDetalle.Text = "Agregar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(20, 23);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.Size = new System.Drawing.Size(607, 209);
            this.dgvDetalle.TabIndex = 8;
            this.dgvDetalle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellDoubleClick);
            // 
            // groupBoxProceso
            // 
            this.groupBoxProceso.Controls.Add(this.txtProceso);
            this.groupBoxProceso.Controls.Add(this.btnSiguienteDetalle);
            this.groupBoxProceso.Controls.Add(this.cmbProceso);
            this.groupBoxProceso.Controls.Add(this.cmbEmpleadoProceso);
            this.groupBoxProceso.Controls.Add(this.label5);
            this.groupBoxProceso.Controls.Add(this.label6);
            this.groupBoxProceso.Controls.Add(this.label10);
            this.groupBoxProceso.Controls.Add(this.btnSalirProceso);
            this.groupBoxProceso.Controls.Add(this.btnRetirarProceso);
            this.groupBoxProceso.Controls.Add(this.btnModificarProceso);
            this.groupBoxProceso.Controls.Add(this.btnAgregarProceso);
            this.groupBoxProceso.Controls.Add(this.dgvProceso);
            this.groupBoxProceso.Location = new System.Drawing.Point(1044, 82);
            this.groupBoxProceso.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxProceso.Name = "groupBoxProceso";
            this.groupBoxProceso.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxProceso.Size = new System.Drawing.Size(797, 362);
            this.groupBoxProceso.TabIndex = 23;
            this.groupBoxProceso.TabStop = false;
            this.groupBoxProceso.Text = "Lista de Procesos de Produccion:";
            // 
            // txtProceso
            // 
            this.txtProceso.Location = new System.Drawing.Point(100, 260);
            this.txtProceso.Margin = new System.Windows.Forms.Padding(4);
            this.txtProceso.Name = "txtProceso";
            this.txtProceso.Size = new System.Drawing.Size(160, 22);
            this.txtProceso.TabIndex = 25;
            // 
            // btnSiguienteDetalle
            // 
            this.btnSiguienteDetalle.Location = new System.Drawing.Point(687, 263);
            this.btnSiguienteDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteDetalle.Name = "btnSiguienteDetalle";
            this.btnSiguienteDetalle.Size = new System.Drawing.Size(95, 76);
            this.btnSiguienteDetalle.TabIndex = 24;
            this.btnSiguienteDetalle.Text = "Siguiente";
            this.btnSiguienteDetalle.UseVisualStyleBackColor = true;
            this.btnSiguienteDetalle.Click += new System.EventHandler(this.btnSiguienteDetalle_Click);
            // 
            // cmbProceso
            // 
            this.cmbProceso.FormattingEnabled = true;
            this.cmbProceso.Location = new System.Drawing.Point(347, 263);
            this.cmbProceso.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProceso.Name = "cmbProceso";
            this.cmbProceso.Size = new System.Drawing.Size(160, 24);
            this.cmbProceso.TabIndex = 23;
            // 
            // cmbEmpleadoProceso
            // 
            this.cmbEmpleadoProceso.FormattingEnabled = true;
            this.cmbEmpleadoProceso.Location = new System.Drawing.Point(100, 320);
            this.cmbEmpleadoProceso.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmpleadoProceso.Name = "cmbEmpleadoProceso";
            this.cmbEmpleadoProceso.Size = new System.Drawing.Size(160, 24);
            this.cmbEmpleadoProceso.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Orden:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 330);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Empleado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(273, 268);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Proceso:";
            // 
            // btnSalirProceso
            // 
            this.btnSalirProceso.Location = new System.Drawing.Point(687, 94);
            this.btnSalirProceso.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalirProceso.Name = "btnSalirProceso";
            this.btnSalirProceso.Size = new System.Drawing.Size(95, 122);
            this.btnSalirProceso.TabIndex = 15;
            this.btnSalirProceso.Text = "Salir";
            this.btnSalirProceso.UseVisualStyleBackColor = true;
            this.btnSalirProceso.Click += new System.EventHandler(this.btnSalirProceso_Click);
            // 
            // btnRetirarProceso
            // 
            this.btnRetirarProceso.Location = new System.Drawing.Point(531, 256);
            this.btnRetirarProceso.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetirarProceso.Name = "btnRetirarProceso";
            this.btnRetirarProceso.Size = new System.Drawing.Size(135, 41);
            this.btnRetirarProceso.TabIndex = 14;
            this.btnRetirarProceso.Text = "Retirar";
            this.btnRetirarProceso.UseVisualStyleBackColor = true;
            this.btnRetirarProceso.Click += new System.EventHandler(this.btnRetirarProceso_Click);
            // 
            // btnModificarProceso
            // 
            this.btnModificarProceso.Location = new System.Drawing.Point(531, 175);
            this.btnModificarProceso.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarProceso.Name = "btnModificarProceso";
            this.btnModificarProceso.Size = new System.Drawing.Size(135, 41);
            this.btnModificarProceso.TabIndex = 13;
            this.btnModificarProceso.Text = "Modificar";
            this.btnModificarProceso.UseVisualStyleBackColor = true;
            this.btnModificarProceso.Click += new System.EventHandler(this.btnModificarProceso_Click);
            // 
            // btnAgregarProceso
            // 
            this.btnAgregarProceso.Location = new System.Drawing.Point(531, 94);
            this.btnAgregarProceso.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarProceso.Name = "btnAgregarProceso";
            this.btnAgregarProceso.Size = new System.Drawing.Size(135, 41);
            this.btnAgregarProceso.TabIndex = 12;
            this.btnAgregarProceso.Text = "Agregar";
            this.btnAgregarProceso.UseVisualStyleBackColor = true;
            this.btnAgregarProceso.Click += new System.EventHandler(this.btnAgregarProceso_Click);
            // 
            // dgvProceso
            // 
            this.dgvProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProceso.Location = new System.Drawing.Point(20, 23);
            this.dgvProceso.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProceso.Name = "dgvProceso";
            this.dgvProceso.RowHeadersWidth = 51;
            this.dgvProceso.Size = new System.Drawing.Size(425, 209);
            this.dgvProceso.TabIndex = 8;
            this.dgvProceso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProceso_CellClick);
            this.dgvProceso.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProceso_CellDoubleClick);
            // 
            // groupBoxDetalleProceso
            // 
            this.groupBoxDetalleProceso.Controls.Add(this.label14);
            this.groupBoxDetalleProceso.Controls.Add(this.cmbProcesoProceso);
            this.groupBoxDetalleProceso.Controls.Add(this.cmbDetalleProceso);
            this.groupBoxDetalleProceso.Controls.Add(this.cmbMaterial);
            this.groupBoxDetalleProceso.Controls.Add(this.txtCantidadMateriales);
            this.groupBoxDetalleProceso.Controls.Add(this.label11);
            this.groupBoxDetalleProceso.Controls.Add(this.label12);
            this.groupBoxDetalleProceso.Controls.Add(this.label13);
            this.groupBoxDetalleProceso.Controls.Add(this.btnSalirDetalleProceso);
            this.groupBoxDetalleProceso.Controls.Add(this.btnRetirarDetalleProceso);
            this.groupBoxDetalleProceso.Controls.Add(this.btnModificarDetalleProceso);
            this.groupBoxDetalleProceso.Controls.Add(this.btnAgregarDetalleProceso);
            this.groupBoxDetalleProceso.Controls.Add(this.dgvDetalleProceso);
            this.groupBoxDetalleProceso.Location = new System.Drawing.Point(1044, 492);
            this.groupBoxDetalleProceso.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalleProceso.Name = "groupBoxDetalleProceso";
            this.groupBoxDetalleProceso.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDetalleProceso.Size = new System.Drawing.Size(797, 362);
            this.groupBoxDetalleProceso.TabIndex = 24;
            this.groupBoxDetalleProceso.TabStop = false;
            this.groupBoxDetalleProceso.Text = "Detalle del Proceso";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(273, 255);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Proceso de Producción:";
            // 
            // cmbProcesoProceso
            // 
            this.cmbProcesoProceso.FormattingEnabled = true;
            this.cmbProcesoProceso.Location = new System.Drawing.Point(364, 274);
            this.cmbProcesoProceso.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProcesoProceso.Name = "cmbProcesoProceso";
            this.cmbProcesoProceso.Size = new System.Drawing.Size(160, 24);
            this.cmbProcesoProceso.TabIndex = 24;
            // 
            // cmbDetalleProceso
            // 
            this.cmbDetalleProceso.FormattingEnabled = true;
            this.cmbDetalleProceso.Location = new System.Drawing.Point(100, 260);
            this.cmbDetalleProceso.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDetalleProceso.Name = "cmbDetalleProceso";
            this.cmbDetalleProceso.Size = new System.Drawing.Size(160, 24);
            this.cmbDetalleProceso.TabIndex = 23;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(100, 320);
            this.cmbMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(160, 24);
            this.cmbMaterial.TabIndex = 22;
            // 
            // txtCantidadMateriales
            // 
            this.txtCantidadMateriales.Location = new System.Drawing.Point(364, 321);
            this.txtCantidadMateriales.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadMateriales.Name = "txtCantidadMateriales";
            this.txtCantidadMateriales.Size = new System.Drawing.Size(160, 22);
            this.txtCantidadMateriales.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 268);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Orden:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 330);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Material:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(287, 330);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Cantidad:";
            // 
            // btnSalirDetalleProceso
            // 
            this.btnSalirDetalleProceso.Location = new System.Drawing.Point(704, 94);
            this.btnSalirDetalleProceso.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalirDetalleProceso.Name = "btnSalirDetalleProceso";
            this.btnSalirDetalleProceso.Size = new System.Drawing.Size(77, 203);
            this.btnSalirDetalleProceso.TabIndex = 15;
            this.btnSalirDetalleProceso.Text = "Salir";
            this.btnSalirDetalleProceso.UseVisualStyleBackColor = true;
            this.btnSalirDetalleProceso.Click += new System.EventHandler(this.btnSalirDetalleProceso_Click);
            // 
            // btnRetirarDetalleProceso
            // 
            this.btnRetirarDetalleProceso.Location = new System.Drawing.Point(544, 260);
            this.btnRetirarDetalleProceso.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetirarDetalleProceso.Name = "btnRetirarDetalleProceso";
            this.btnRetirarDetalleProceso.Size = new System.Drawing.Size(135, 41);
            this.btnRetirarDetalleProceso.TabIndex = 14;
            this.btnRetirarDetalleProceso.Text = "Retirar";
            this.btnRetirarDetalleProceso.UseVisualStyleBackColor = true;
            this.btnRetirarDetalleProceso.Click += new System.EventHandler(this.btnRetirarDetalleProceso_Click);
            // 
            // btnModificarDetalleProceso
            // 
            this.btnModificarDetalleProceso.Location = new System.Drawing.Point(544, 175);
            this.btnModificarDetalleProceso.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarDetalleProceso.Name = "btnModificarDetalleProceso";
            this.btnModificarDetalleProceso.Size = new System.Drawing.Size(135, 41);
            this.btnModificarDetalleProceso.TabIndex = 13;
            this.btnModificarDetalleProceso.Text = "Modificar";
            this.btnModificarDetalleProceso.UseVisualStyleBackColor = true;
            this.btnModificarDetalleProceso.Click += new System.EventHandler(this.btnModificarDetalleProceso_Click);
            // 
            // btnAgregarDetalleProceso
            // 
            this.btnAgregarDetalleProceso.Location = new System.Drawing.Point(544, 94);
            this.btnAgregarDetalleProceso.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDetalleProceso.Name = "btnAgregarDetalleProceso";
            this.btnAgregarDetalleProceso.Size = new System.Drawing.Size(135, 41);
            this.btnAgregarDetalleProceso.TabIndex = 12;
            this.btnAgregarDetalleProceso.Text = "Agregar";
            this.btnAgregarDetalleProceso.UseVisualStyleBackColor = true;
            this.btnAgregarDetalleProceso.Click += new System.EventHandler(this.btnAgregarDetalleProceso_Click);
            // 
            // dgvDetalleProceso
            // 
            this.dgvDetalleProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleProceso.Location = new System.Drawing.Point(20, 23);
            this.dgvDetalleProceso.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalleProceso.Name = "dgvDetalleProceso";
            this.dgvDetalleProceso.RowHeadersWidth = 51;
            this.dgvDetalleProceso.Size = new System.Drawing.Size(425, 209);
            this.dgvDetalleProceso.TabIndex = 8;
            this.dgvDetalleProceso.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleProceso_CellDoubleClick);
            // 
            // btnEditarProceso
            // 
            this.btnEditarProceso.Location = new System.Drawing.Point(909, 107);
            this.btnEditarProceso.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarProceso.Name = "btnEditarProceso";
            this.btnEditarProceso.Size = new System.Drawing.Size(111, 54);
            this.btnEditarProceso.TabIndex = 25;
            this.btnEditarProceso.Text = "Editar Proceso";
            this.btnEditarProceso.UseVisualStyleBackColor = true;
            this.btnEditarProceso.Click += new System.EventHandler(this.btnEditarProceso_Click);
            // 
            // btnEditarDetalleProceso
            // 
            this.btnEditarDetalleProceso.Location = new System.Drawing.Point(909, 176);
            this.btnEditarDetalleProceso.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarDetalleProceso.Name = "btnEditarDetalleProceso";
            this.btnEditarDetalleProceso.Size = new System.Drawing.Size(111, 53);
            this.btnEditarDetalleProceso.TabIndex = 26;
            this.btnEditarDetalleProceso.Text = "Editar Detalle de Proceso";
            this.btnEditarDetalleProceso.UseVisualStyleBackColor = true;
            this.btnEditarDetalleProceso.Click += new System.EventHandler(this.btnEditarDetalleProceso_Click);
            // 
            // ordenProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1857, 939);
            this.Controls.Add(this.btnEditarDetalleProceso);
            this.Controls.Add(this.btnEditarProceso);
            this.Controls.Add(this.groupBoxDetalleProceso);
            this.Controls.Add(this.groupBoxProceso);
            this.Controls.Add(this.groupBoxDetalle);
            this.Controls.Add(this.groupBoxOrden);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditarDetalle);
            this.Controls.Add(this.btnEditarOrden);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvOrden);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ordenProduccion";
            this.Text = "ordenProduccion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.groupBoxOrden.ResumeLayout(false);
            this.groupBoxOrden.PerformLayout();
            this.groupBoxDetalle.ResumeLayout(false);
            this.groupBoxDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.groupBoxProceso.ResumeLayout(false);
            this.groupBoxProceso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProceso)).EndInit();
            this.groupBoxDetalleProceso.ResumeLayout(false);
            this.groupBoxDetalleProceso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleProceso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrden;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditarOrden;
        private System.Windows.Forms.Button btnEditarDetalle;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBoxOrden;
        private System.Windows.Forms.DateTimePicker dtPickerRegOrden;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbOrdenVenta;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRetirarOrden;
        private System.Windows.Forms.Button btnModificarOrden;
        private System.Windows.Forms.Button btnAgregarOrden;
        private System.Windows.Forms.GroupBox groupBoxDetalle;
        private System.Windows.Forms.ComboBox cmbCalzado;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalirDetalle;
        private System.Windows.Forms.Button btnRetirarDetalle;
        private System.Windows.Forms.Button btnModificarDetalle;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnSiguienteProceso;
        private System.Windows.Forms.GroupBox groupBoxProceso;
        private System.Windows.Forms.Button btnSiguienteDetalle;
        private System.Windows.Forms.ComboBox cmbProceso;
        private System.Windows.Forms.ComboBox cmbEmpleadoProceso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSalirProceso;
        private System.Windows.Forms.Button btnRetirarProceso;
        private System.Windows.Forms.Button btnModificarProceso;
        private System.Windows.Forms.Button btnAgregarProceso;
        private System.Windows.Forms.DataGridView dgvProceso;
        private System.Windows.Forms.GroupBox groupBoxDetalleProceso;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.TextBox txtCantidadMateriales;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSalirDetalleProceso;
        private System.Windows.Forms.Button btnRetirarDetalleProceso;
        private System.Windows.Forms.Button btnModificarDetalleProceso;
        private System.Windows.Forms.Button btnAgregarDetalleProceso;
        private System.Windows.Forms.DataGridView dgvDetalleProceso;
        private System.Windows.Forms.ComboBox cmbDetalle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbProcesoProceso;
        private System.Windows.Forms.ComboBox cmbDetalleProceso;
        private System.Windows.Forms.TextBox txtProceso;
        private System.Windows.Forms.Button btnEditarProceso;
        private System.Windows.Forms.Button btnEditarDetalleProceso;
    }
}