namespace Presentacion
{
    partial class Operacion_nueva_factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operacion_nueva_factura));
            this.brnCerrarSuperior = new System.Windows.Forms.PictureBox();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lblSubMenu = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textcodigoFactura = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textNombre_temporal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.brnCerrarSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // brnCerrarSuperior
            // 
            this.brnCerrarSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brnCerrarSuperior.Image = global::Presentacion.Properties.Resources.Salir_blanco_login;
            this.brnCerrarSuperior.Location = new System.Drawing.Point(945, 1);
            this.brnCerrarSuperior.Name = "brnCerrarSuperior";
            this.brnCerrarSuperior.Size = new System.Drawing.Size(40, 28);
            this.brnCerrarSuperior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brnCerrarSuperior.TabIndex = 27;
            this.brnCerrarSuperior.TabStop = false;
            this.brnCerrarSuperior.Click += new System.EventHandler(this.brnCerrarSuperior_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.Location = new System.Drawing.Point(173, 84);
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
            this.shapeContainer1.TabIndex = 28;
            this.shapeContainer1.TabStop = false;
            // 
            // lblSubMenu
            // 
            this.lblSubMenu.AutoSize = true;
            this.lblSubMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMenu.ForeColor = System.Drawing.Color.White;
            this.lblSubMenu.Location = new System.Drawing.Point(488, 73);
            this.lblSubMenu.Name = "lblSubMenu";
            this.lblSubMenu.Size = new System.Drawing.Size(67, 21);
            this.lblSubMenu.TabIndex = 29;
            this.lblSubMenu.Text = "Factura";
            this.lblSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.ForeColor = System.Drawing.Color.White;
            this.lblcategoria.Location = new System.Drawing.Point(256, 172);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(58, 20);
            this.lblcategoria.TabIndex = 31;
            this.lblcategoria.Text = "Cliente";
            this.lblcategoria.Click += new System.EventHandler(this.lblcategoria_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.IntegralHeight = false;
            this.cmbCliente.ItemHeight = 20;
            this.cmbCliente.Location = new System.Drawing.Point(354, 164);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(269, 28);
            this.cmbCliente.TabIndex = 30;
            this.cmbCliente.SelectionChangeCommitted += new System.EventHandler(this.cmbCliente_SelectionChangeCommitted);
            this.cmbCliente.SelectedValueChanged += new System.EventHandler(this.cmbCliente_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(256, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Empleado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textcodigoFactura
            // 
            this.textcodigoFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textcodigoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcodigoFactura.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textcodigoFactura.Location = new System.Drawing.Point(354, 119);
            this.textcodigoFactura.Name = "textcodigoFactura";
            this.textcodigoFactura.Size = new System.Drawing.Size(269, 19);
            this.textcodigoFactura.TabIndex = 35;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.ForeColor = System.Drawing.Color.White;
            this.lblcodigo.Location = new System.Drawing.Point(255, 119);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(59, 20);
            this.lblcodigo.TabIndex = 34;
            this.lblcodigo.Text = "Codigo";
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
            this.btnGuardar.Location = new System.Drawing.Point(354, 262);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(154, 36);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Crear Nueva";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Enabled = false;
            this.cmbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.IntegralHeight = false;
            this.cmbEmpleado.ItemHeight = 20;
            this.cmbEmpleado.Location = new System.Drawing.Point(354, 214);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(269, 28);
            this.cmbEmpleado.TabIndex = 37;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // textNombre_temporal
            // 
            this.textNombre_temporal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombre_temporal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre_temporal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textNombre_temporal.Location = new System.Drawing.Point(629, 164);
            this.textNombre_temporal.Multiline = true;
            this.textNombre_temporal.Name = "textNombre_temporal";
            this.textNombre_temporal.Size = new System.Drawing.Size(262, 28);
            this.textNombre_temporal.TabIndex = 40;
            this.textNombre_temporal.Visible = false;
            // 
            // Operacion_nueva_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(985, 532);
            this.Controls.Add(this.textNombre_temporal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textcodigoFactura);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblSubMenu);
            this.Controls.Add(this.brnCerrarSuperior);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operacion_nueva_factura";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operacion_nueva_factura";
            this.Load += new System.EventHandler(this.Operacion_nueva_factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brnCerrarSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox brnCerrarSuperior;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        public System.Windows.Forms.Label lblSubMenu;
        private System.Windows.Forms.Label lblcategoria;
        public System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textcodigoFactura;
        private System.Windows.Forms.Label lblcodigo;
        public System.Windows.Forms.ComboBox cmbEmpleado;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox textNombre_temporal;
    }
}