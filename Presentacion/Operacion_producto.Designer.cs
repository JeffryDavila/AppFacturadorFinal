namespace Presentacion
{
    partial class Operacion_producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operacion_producto));
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.textdescripcion = new System.Windows.Forms.TextBox();
            this.textcodigoProducto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblSubMenu = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.textPrecioU = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.brnCerrarSuperior = new System.Windows.Forms.PictureBox();
            this.textPrecioPromocion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brnCerrarSuperior)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.IntegralHeight = false;
            this.cmbCategoria.ItemHeight = 20;
            this.cmbCategoria.Location = new System.Drawing.Point(130, 59);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(199, 28);
            this.cmbCategoria.TabIndex = 19;
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.ForeColor = System.Drawing.Color.Black;
            this.lblcategoria.Location = new System.Drawing.Point(18, 62);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(78, 20);
            this.lblcategoria.TabIndex = 22;
            this.lblcategoria.Text = "Categoria";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcion.ForeColor = System.Drawing.Color.Black;
            this.lbldescripcion.Location = new System.Drawing.Point(18, 137);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(92, 20);
            this.lbldescripcion.TabIndex = 21;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.ForeColor = System.Drawing.Color.Black;
            this.lblcodigo.Location = new System.Drawing.Point(18, 97);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(59, 20);
            this.lblcodigo.TabIndex = 20;
            this.lblcodigo.Text = "Codigo";
            // 
            // textdescripcion
            // 
            this.textdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdescripcion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textdescripcion.Location = new System.Drawing.Point(131, 136);
            this.textdescripcion.Name = "textdescripcion";
            this.textdescripcion.Size = new System.Drawing.Size(199, 26);
            this.textdescripcion.TabIndex = 24;
            // 
            // textcodigoProducto
            // 
            this.textcodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcodigoProducto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textcodigoProducto.Location = new System.Drawing.Point(131, 102);
            this.textcodigoProducto.Name = "textcodigoProducto";
            this.textcodigoProducto.Size = new System.Drawing.Size(198, 26);
            this.textcodigoProducto.TabIndex = 23;
            this.textcodigoProducto.TextChanged += new System.EventHandler(this.textcodigoProducto_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(104, 254);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(154, 36);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblSubMenu
            // 
            this.lblSubMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubMenu.AutoSize = true;
            this.lblSubMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMenu.ForeColor = System.Drawing.Color.Black;
            this.lblSubMenu.Location = new System.Drawing.Point(126, 24);
            this.lblSubMenu.Name = "lblSubMenu";
            this.lblSubMenu.Size = new System.Drawing.Size(73, 20);
            this.lblSubMenu.TabIndex = 27;
            this.lblSubMenu.Text = "Producto";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(356, 324);
            this.shapeContainer1.TabIndex = 28;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Black;
            this.rectangleShape1.Location = new System.Drawing.Point(10, 34);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(335, 275);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            this.rectangleShape1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rectangleShape1_KeyPress);
            // 
            // textPrecioU
            // 
            this.textPrecioU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecioU.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textPrecioU.Location = new System.Drawing.Point(130, 171);
            this.textPrecioU.Name = "textPrecioU";
            this.textPrecioU.Size = new System.Drawing.Size(199, 26);
            this.textPrecioU.TabIndex = 30;
            this.textPrecioU.TextChanged += new System.EventHandler(this.textPrecioU_TextChanged);
            this.textPrecioU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrecioU_KeyPress);
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.ForeColor = System.Drawing.Color.Black;
            this.lblprecio.Location = new System.Drawing.Point(17, 172);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(53, 20);
            this.lblprecio.TabIndex = 29;
            this.lblprecio.Text = "Precio";
            // 
            // brnCerrarSuperior
            // 
            this.brnCerrarSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brnCerrarSuperior.Image = ((System.Drawing.Image)(resources.GetObject("brnCerrarSuperior.Image")));
            this.brnCerrarSuperior.Location = new System.Drawing.Point(313, 2);
            this.brnCerrarSuperior.Name = "brnCerrarSuperior";
            this.brnCerrarSuperior.Size = new System.Drawing.Size(40, 28);
            this.brnCerrarSuperior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brnCerrarSuperior.TabIndex = 26;
            this.brnCerrarSuperior.TabStop = false;
            this.brnCerrarSuperior.Click += new System.EventHandler(this.brnCerrarSuperior_Click);
            // 
            // textPrecioPromocion
            // 
            this.textPrecioPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecioPromocion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textPrecioPromocion.Location = new System.Drawing.Point(156, 206);
            this.textPrecioPromocion.Name = "textPrecioPromocion";
            this.textPrecioPromocion.Size = new System.Drawing.Size(170, 26);
            this.textPrecioPromocion.TabIndex = 32;
            this.textPrecioPromocion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDescuento_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Precio Promocion";
            // 
            // Operacion_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 324);
            this.Controls.Add(this.textPrecioPromocion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPrecioU);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblSubMenu);
            this.Controls.Add(this.brnCerrarSuperior);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textdescripcion);
            this.Controls.Add(this.textcodigoProducto);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operacion_producto";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo_producto";
            this.Load += new System.EventHandler(this.Operacion_producto_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Operacion_producto_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.brnCerrarSuperior)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox brnCerrarSuperior;
        public System.Windows.Forms.ComboBox cmbCategoria;
        public System.Windows.Forms.TextBox textdescripcion;
        public System.Windows.Forms.TextBox textcodigoProducto;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        public System.Windows.Forms.Label lblSubMenu;
        public System.Windows.Forms.TextBox textPrecioU;
        private System.Windows.Forms.Label lblprecio;
        public System.Windows.Forms.TextBox textPrecioPromocion;
        private System.Windows.Forms.Label label1;
        //private Datos_facturaTableAdapters.Listar_Factura_completaTableAdapter listar_Factura_completaTableAdapter1;
    }
}