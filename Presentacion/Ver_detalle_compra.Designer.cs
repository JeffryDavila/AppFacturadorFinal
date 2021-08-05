namespace Presentacion
{
    partial class Ver_detalle_compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_detalle_compra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnCerrarSuperior = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_tipo_cambio = new System.Windows.Forms.Label();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.text_TipoCambio = new System.Windows.Forms.TextBox();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.textProveedor = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.Lista_detalle_Compra = new System.Windows.Forms.DataGridView();
            this.lbl_motivo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.textSubtotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lista_detalle_Compra)).BeginInit();
            this.SuspendLayout();
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Black;
            this.rectangleShape1.Location = new System.Drawing.Point(6, 31);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(708, 481);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(721, 519);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // btnCerrarSuperior
            // 
            this.btnCerrarSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSuperior.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSuperior.Image")));
            this.btnCerrarSuperior.Location = new System.Drawing.Point(675, 1);
            this.btnCerrarSuperior.Name = "btnCerrarSuperior";
            this.btnCerrarSuperior.Size = new System.Drawing.Size(40, 28);
            this.btnCerrarSuperior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSuperior.TabIndex = 39;
            this.btnCerrarSuperior.TabStop = false;
            this.btnCerrarSuperior.Click += new System.EventHandler(this.btnCerrarSuperior_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Enabled = false;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_titulo.Location = new System.Drawing.Point(193, 4);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(348, 25);
            this.lbl_titulo.TabIndex = 65;
            this.lbl_titulo.Text = "Detalle de la compra seleccionada:";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.Black;
            this.lbl_ID.Location = new System.Drawing.Point(31, 43);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(87, 20);
            this.lbl_ID.TabIndex = 66;
            this.lbl_ID.Text = "Id Compra:";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.Color.Black;
            this.lbl_codigo.Location = new System.Drawing.Point(31, 77);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(63, 20);
            this.lbl_codigo.TabIndex = 67;
            this.lbl_codigo.Text = "Codigo:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.Black;
            this.lbl_fecha.Location = new System.Drawing.Point(31, 114);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(58, 20);
            this.lbl_fecha.TabIndex = 68;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // lbl_tipo_cambio
            // 
            this.lbl_tipo_cambio.AutoSize = true;
            this.lbl_tipo_cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_cambio.ForeColor = System.Drawing.Color.Black;
            this.lbl_tipo_cambio.Location = new System.Drawing.Point(31, 150);
            this.lbl_tipo_cambio.Name = "lbl_tipo_cambio";
            this.lbl_tipo_cambio.Size = new System.Drawing.Size(120, 20);
            this.lbl_tipo_cambio.TabIndex = 69;
            this.lbl_tipo_cambio.Text = "Tipo de cambio:";
            // 
            // text_ID
            // 
            this.text_ID.Enabled = false;
            this.text_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.text_ID.Location = new System.Drawing.Point(123, 40);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(151, 26);
            this.text_ID.TabIndex = 70;
            // 
            // textCodigo
            // 
            this.textCodigo.Enabled = false;
            this.textCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textCodigo.Location = new System.Drawing.Point(109, 74);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(165, 26);
            this.textCodigo.TabIndex = 71;
            // 
            // textFecha
            // 
            this.textFecha.Enabled = false;
            this.textFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFecha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textFecha.Location = new System.Drawing.Point(109, 111);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(165, 26);
            this.textFecha.TabIndex = 72;
            // 
            // text_TipoCambio
            // 
            this.text_TipoCambio.Enabled = false;
            this.text_TipoCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_TipoCambio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.text_TipoCambio.Location = new System.Drawing.Point(157, 147);
            this.text_TipoCambio.Name = "text_TipoCambio";
            this.text_TipoCambio.Size = new System.Drawing.Size(117, 26);
            this.text_TipoCambio.TabIndex = 73;
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedor.ForeColor = System.Drawing.Color.Black;
            this.lbl_proveedor.Location = new System.Drawing.Point(422, 43);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(85, 20);
            this.lbl_proveedor.TabIndex = 74;
            this.lbl_proveedor.Text = "Proveedor:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.ForeColor = System.Drawing.Color.Black;
            this.lbl_telefono.Location = new System.Drawing.Point(422, 77);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(75, 20);
            this.lbl_telefono.TabIndex = 75;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.ForeColor = System.Drawing.Color.Black;
            this.lbl_direccion.Location = new System.Drawing.Point(422, 150);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(79, 20);
            this.lbl_direccion.TabIndex = 76;
            this.lbl_direccion.Text = "Direccion:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Black;
            this.lbl_email.Location = new System.Drawing.Point(422, 114);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(52, 20);
            this.lbl_email.TabIndex = 77;
            this.lbl_email.Text = "Email:";
            this.lbl_email.Click += new System.EventHandler(this.label7_Click);
            // 
            // textProveedor
            // 
            this.textProveedor.Enabled = false;
            this.textProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProveedor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textProveedor.Location = new System.Drawing.Point(512, 40);
            this.textProveedor.Name = "textProveedor";
            this.textProveedor.Size = new System.Drawing.Size(172, 26);
            this.textProveedor.TabIndex = 78;
            // 
            // textTelefono
            // 
            this.textTelefono.Enabled = false;
            this.textTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textTelefono.Location = new System.Drawing.Point(512, 72);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(172, 26);
            this.textTelefono.TabIndex = 79;
            // 
            // textEmail
            // 
            this.textEmail.Enabled = false;
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textEmail.Location = new System.Drawing.Point(512, 111);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(172, 24);
            this.textEmail.TabIndex = 80;
            // 
            // textDireccion
            // 
            this.textDireccion.Enabled = false;
            this.textDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textDireccion.Location = new System.Drawing.Point(512, 147);
            this.textDireccion.Multiline = true;
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(172, 48);
            this.textDireccion.TabIndex = 81;
            // 
            // Lista_detalle_Compra
            // 
            this.Lista_detalle_Compra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Lista_detalle_Compra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Lista_detalle_Compra.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Lista_detalle_Compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lista_detalle_Compra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lista_detalle_Compra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Lista_detalle_Compra.ColumnHeadersHeight = 30;
            this.Lista_detalle_Compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Lista_detalle_Compra.EnableHeadersVisualStyles = false;
            this.Lista_detalle_Compra.Location = new System.Drawing.Point(29, 209);
            this.Lista_detalle_Compra.Name = "Lista_detalle_Compra";
            this.Lista_detalle_Compra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Lista_detalle_Compra.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista_detalle_Compra.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Lista_detalle_Compra.Size = new System.Drawing.Size(655, 167);
            this.Lista_detalle_Compra.TabIndex = 82;
            // 
            // lbl_motivo
            // 
            this.lbl_motivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motivo.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_motivo.Location = new System.Drawing.Point(154, 399);
            this.lbl_motivo.Name = "lbl_motivo";
            this.lbl_motivo.Size = new System.Drawing.Size(532, 49);
            this.lbl_motivo.TabIndex = 84;
            this.lbl_motivo.Text = "Motivo";
            this.lbl_motivo.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Green;
            this.lblEstado.Location = new System.Drawing.Point(27, 392);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(88, 29);
            this.lblEstado.TabIndex = 83;
            this.lblEstado.Text = "Estado";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Black;
            this.lbl_total.Location = new System.Drawing.Point(443, 476);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(48, 20);
            this.lbl_total.TabIndex = 88;
            this.lbl_total.Text = "Total:";
            // 
            // textTotal
            // 
            this.textTotal.Enabled = false;
            this.textTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textTotal.Location = new System.Drawing.Point(519, 473);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(165, 26);
            this.textTotal.TabIndex = 87;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.ForeColor = System.Drawing.Color.Black;
            this.lbl_subtotal.Location = new System.Drawing.Point(33, 476);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(73, 20);
            this.lbl_subtotal.TabIndex = 86;
            this.lbl_subtotal.Text = "Subtotal:";
            // 
            // textSubtotal
            // 
            this.textSubtotal.Enabled = false;
            this.textSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSubtotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textSubtotal.Location = new System.Drawing.Point(109, 473);
            this.textSubtotal.Name = "textSubtotal";
            this.textSubtotal.Size = new System.Drawing.Size(165, 26);
            this.textSubtotal.TabIndex = 85;
            // 
            // Ver_detalle_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 519);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.textSubtotal);
            this.Controls.Add(this.lbl_motivo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.Lista_detalle_Compra);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textProveedor);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_proveedor);
            this.Controls.Add(this.text_TipoCambio);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.text_ID);
            this.Controls.Add(this.lbl_tipo_cambio);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btnCerrarSuperior);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ver_detalle_compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver_detalle_compra";
            this.Load += new System.EventHandler(this.Ver_detalle_compra_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ver_detalle_compra_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lista_detalle_Compra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.PictureBox btnCerrarSuperior;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_tipo_cambio;
        public System.Windows.Forms.TextBox text_ID;
        public System.Windows.Forms.TextBox textCodigo;
        public System.Windows.Forms.TextBox textFecha;
        public System.Windows.Forms.TextBox text_TipoCambio;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_email;
        public System.Windows.Forms.TextBox textProveedor;
        public System.Windows.Forms.TextBox textTelefono;
        public System.Windows.Forms.TextBox textEmail;
        public System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.DataGridView Lista_detalle_Compra;
        private System.Windows.Forms.Label lbl_motivo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lbl_total;
        public System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label lbl_subtotal;
        public System.Windows.Forms.TextBox textSubtotal;
    }
}