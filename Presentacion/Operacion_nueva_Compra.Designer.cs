namespace Presentacion
{
    partial class Operacion_nueva_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operacion_nueva_Compra));
            this.brnCerrarSuperior = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lblSubMenu = new System.Windows.Forms.Label();
            this.textcodigoCompra = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textNombre_prov = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.brnCerrarSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // brnCerrarSuperior
            // 
            this.brnCerrarSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brnCerrarSuperior.Image = global::Presentacion.Properties.Resources.Salir_blanco_login;
            this.brnCerrarSuperior.Location = new System.Drawing.Point(943, 3);
            this.brnCerrarSuperior.Name = "brnCerrarSuperior";
            this.brnCerrarSuperior.Size = new System.Drawing.Size(40, 28);
            this.brnCerrarSuperior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brnCerrarSuperior.TabIndex = 28;
            this.brnCerrarSuperior.TabStop = false;
            this.brnCerrarSuperior.Click += new System.EventHandler(this.brnCerrarSuperior_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.Location = new System.Drawing.Point(151, 78);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(740, 307);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(985, 532);
            this.shapeContainer1.TabIndex = 41;
            this.shapeContainer1.TabStop = false;
            // 
            // lblSubMenu
            // 
            this.lblSubMenu.AutoSize = true;
            this.lblSubMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMenu.ForeColor = System.Drawing.Color.White;
            this.lblSubMenu.Location = new System.Drawing.Point(500, 66);
            this.lblSubMenu.Name = "lblSubMenu";
            this.lblSubMenu.Size = new System.Drawing.Size(71, 21);
            this.lblSubMenu.TabIndex = 42;
            this.lblSubMenu.Text = "Compra";
            this.lblSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textcodigoCompra
            // 
            this.textcodigoCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textcodigoCompra.Enabled = false;
            this.textcodigoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcodigoCompra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textcodigoCompra.Location = new System.Drawing.Point(385, 113);
            this.textcodigoCompra.Name = "textcodigoCompra";
            this.textcodigoCompra.Size = new System.Drawing.Size(269, 19);
            this.textcodigoCompra.TabIndex = 44;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.ForeColor = System.Drawing.Color.White;
            this.lblcodigo.Location = new System.Drawing.Point(286, 113);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(59, 20);
            this.lblcodigo.TabIndex = 43;
            this.lblcodigo.Text = "Codigo";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.ForeColor = System.Drawing.Color.White;
            this.lblcategoria.Location = new System.Drawing.Point(287, 157);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(81, 20);
            this.lblcategoria.TabIndex = 46;
            this.lblcategoria.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.IntegralHeight = false;
            this.cmbProveedor.ItemHeight = 20;
            this.cmbProveedor.Location = new System.Drawing.Point(385, 150);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(269, 28);
            this.cmbProveedor.TabIndex = 45;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(109)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(75)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(386, 198);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(154, 36);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Crear Nueva";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textNombre_prov
            // 
            this.textNombre_prov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombre_prov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre_prov.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textNombre_prov.Location = new System.Drawing.Point(707, 150);
            this.textNombre_prov.Multiline = true;
            this.textNombre_prov.Name = "textNombre_prov";
            this.textNombre_prov.Size = new System.Drawing.Size(158, 28);
            this.textNombre_prov.TabIndex = 48;
            this.textNombre_prov.Visible = false;
            this.textNombre_prov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_prov_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(660, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Operacion_nueva_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(985, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textNombre_prov);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.textcodigoCompra);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.lblSubMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.brnCerrarSuperior);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operacion_nueva_Compra";
            this.Text = "Operacion_nueva_Compra";
            this.Load += new System.EventHandler(this.Operacion_nueva_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brnCerrarSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox brnCerrarSuperior;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        public System.Windows.Forms.Label lblSubMenu;
        public System.Windows.Forms.TextBox textcodigoCompra;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblcategoria;
        public System.Windows.Forms.ComboBox cmbProveedor;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox textNombre_prov;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}