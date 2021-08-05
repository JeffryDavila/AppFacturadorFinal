namespace Presentacion
{
    partial class Operacion_proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operacion_proveedor));
            this.lblSubMenu = new System.Windows.Forms.Label();
            this.brnCerrarSuperior = new System.Windows.Forms.PictureBox();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.brnCerrarSuperior)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubMenu
            // 
            this.lblSubMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubMenu.AutoSize = true;
            this.lblSubMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMenu.ForeColor = System.Drawing.Color.Black;
            this.lblSubMenu.Location = new System.Drawing.Point(128, 24);
            this.lblSubMenu.Name = "lblSubMenu";
            this.lblSubMenu.Size = new System.Drawing.Size(81, 20);
            this.lblSubMenu.TabIndex = 29;
            this.lblSubMenu.Text = "Proveedor";
            // 
            // brnCerrarSuperior
            // 
            this.brnCerrarSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brnCerrarSuperior.Image = ((System.Drawing.Image)(resources.GetObject("brnCerrarSuperior.Image")));
            this.brnCerrarSuperior.Location = new System.Drawing.Point(315, 2);
            this.brnCerrarSuperior.Name = "brnCerrarSuperior";
            this.brnCerrarSuperior.Size = new System.Drawing.Size(40, 28);
            this.brnCerrarSuperior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brnCerrarSuperior.TabIndex = 28;
            this.brnCerrarSuperior.TabStop = false;
            this.brnCerrarSuperior.Click += new System.EventHandler(this.brnCerrarSuperior_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Black;
            this.rectangleShape1.Location = new System.Drawing.Point(9, 34);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(335, 270);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(356, 319);
            this.shapeContainer1.TabIndex = 30;
            this.shapeContainer1.TabStop = false;
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
            this.btnGuardar.Location = new System.Drawing.Point(108, 254);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(154, 36);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.ForeColor = System.Drawing.Color.Black;
            this.lblcodigo.Location = new System.Drawing.Point(41, 57);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(59, 20);
            this.lblcodigo.TabIndex = 42;
            this.lblcodigo.Text = "Codigo";
            // 
            // textCodigo
            // 
            this.textCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textCodigo.Location = new System.Drawing.Point(117, 54);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(198, 26);
            this.textCodigo.TabIndex = 35;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.Black;
            this.lblnombre.Location = new System.Drawing.Point(41, 93);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(65, 20);
            this.lblnombre.TabIndex = 41;
            this.lblnombre.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textNombre.Location = new System.Drawing.Point(117, 90);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(198, 26);
            this.textNombre.TabIndex = 36;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.ForeColor = System.Drawing.Color.Black;
            this.lbldireccion.Location = new System.Drawing.Point(41, 164);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(75, 20);
            this.lbldireccion.TabIndex = 40;
            this.lbldireccion.Text = "Direccion";
            // 
            // textDireccion
            // 
            this.textDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textDireccion.Location = new System.Drawing.Point(117, 161);
            this.textDireccion.Multiline = true;
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(198, 49);
            this.textDireccion.TabIndex = 38;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.ForeColor = System.Drawing.Color.Black;
            this.lbltelefono.Location = new System.Drawing.Point(41, 128);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(71, 20);
            this.lbltelefono.TabIndex = 39;
            this.lbltelefono.Text = "Telefono";
            // 
            // textTelefono
            // 
            this.textTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textTelefono.Location = new System.Drawing.Point(117, 125);
            this.textTelefono.MaxLength = 8;
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(198, 26);
            this.textTelefono.TabIndex = 37;
            this.textTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelefono_KeyPress);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Black;
            this.lblemail.Location = new System.Drawing.Point(41, 219);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 20);
            this.lblemail.TabIndex = 44;
            this.lblemail.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textEmail.Location = new System.Drawing.Point(117, 216);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(198, 26);
            this.textEmail.TabIndex = 43;
            // 
            // Operacion_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 319);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblSubMenu);
            this.Controls.Add(this.brnCerrarSuperior);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operacion_proveedor";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operacion_proveedor";
            this.Load += new System.EventHandler(this.Operacion_proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brnCerrarSuperior)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSubMenu;
        private System.Windows.Forms.PictureBox brnCerrarSuperior;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblcodigo;
        public System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label lblnombre;
        public System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lbldireccion;
        public System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label lbltelefono;
        public System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label lblemail;
        public System.Windows.Forms.TextBox textEmail;
    }
}