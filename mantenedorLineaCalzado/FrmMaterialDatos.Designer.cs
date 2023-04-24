namespace mantenedorLineaCalzado
{
    partial class FrmMaterialDatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMateriales = new System.Windows.Forms.Button();
            this.btnCategoriaMateriales = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnMarcaMaterial = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos de Materiales";
            // 
            // btnMateriales
            // 
            this.btnMateriales.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateriales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMateriales.Location = new System.Drawing.Point(57, 136);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Size = new System.Drawing.Size(171, 102);
            this.btnMateriales.TabIndex = 1;
            this.btnMateriales.Text = "Materiales";
            this.btnMateriales.UseVisualStyleBackColor = false;
            this.btnMateriales.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCategoriaMateriales
            // 
            this.btnCategoriaMateriales.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCategoriaMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriaMateriales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCategoriaMateriales.Location = new System.Drawing.Point(296, 136);
            this.btnCategoriaMateriales.Name = "btnCategoriaMateriales";
            this.btnCategoriaMateriales.Size = new System.Drawing.Size(171, 102);
            this.btnCategoriaMateriales.TabIndex = 2;
            this.btnCategoriaMateriales.Text = "Categoria Materiales";
            this.btnCategoriaMateriales.UseVisualStyleBackColor = false;
            this.btnCategoriaMateriales.Click += new System.EventHandler(this.btnCategoriaMateriales_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnColor.Location = new System.Drawing.Point(546, 136);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(171, 102);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(596, 346);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(171, 61);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMarcaMaterial
            // 
            this.btnMarcaMaterial.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMarcaMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcaMaterial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMarcaMaterial.Location = new System.Drawing.Point(57, 270);
            this.btnMarcaMaterial.Name = "btnMarcaMaterial";
            this.btnMarcaMaterial.Size = new System.Drawing.Size(171, 102);
            this.btnMarcaMaterial.TabIndex = 5;
            this.btnMarcaMaterial.Text = "Marca de Materiales";
            this.btnMarcaMaterial.UseVisualStyleBackColor = false;
            this.btnMarcaMaterial.Click += new System.EventHandler(this.btnMarcaMaterial_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mantenedorLineaCalzado.Properties.Resources.materialescal;
            this.pictureBox1.Location = new System.Drawing.Point(662, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMaterialDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMarcaMaterial);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnCategoriaMateriales);
            this.Controls.Add(this.btnMateriales);
            this.Controls.Add(this.label1);
            this.Name = "FrmMaterialDatos";
            this.Text = "FrmMaterialDatos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMateriales;
        private System.Windows.Forms.Button btnCategoriaMateriales;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnMarcaMaterial;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}