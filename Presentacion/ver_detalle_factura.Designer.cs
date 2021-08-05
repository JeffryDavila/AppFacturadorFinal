namespace Presentacion
{
    partial class Ver_detalle_factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_detalle_factura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnCerrarSuperior = new System.Windows.Forms.PictureBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.lbl_vendedor = new System.Windows.Forms.Label();
            this.textVendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTipo_cambio = new System.Windows.Forms.TextBox();
            this.Lista_detalle_Factura = new System.Windows.Forms.DataGridView();
            this.lbl_pago = new System.Windows.Forms.Label();
            this.textPago = new System.Windows.Forms.TextBox();
            this.lbl_vuelto = new System.Windows.Forms.Label();
            this.textVuelto = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.textSubtotal = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_motivo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lista_detalle_Factura)).BeginInit();
            this.SuspendLayout();
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Black;
            this.rectangleShape1.Location = new System.Drawing.Point(7, 32);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(708, 467);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(721, 506);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // btnCerrarSuperior
            // 
            this.btnCerrarSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSuperior.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSuperior.Image")));
            this.btnCerrarSuperior.Location = new System.Drawing.Point(670, 3);
            this.btnCerrarSuperior.Name = "btnCerrarSuperior";
            this.btnCerrarSuperior.Size = new System.Drawing.Size(40, 28);
            this.btnCerrarSuperior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSuperior.TabIndex = 38;
            this.btnCerrarSuperior.TabStop = false;
            this.btnCerrarSuperior.Click += new System.EventHandler(this.btnCerrarSuperior_Click);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.Color.Black;
            this.lbl_codigo.Location = new System.Drawing.Point(31, 88);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(63, 20);
            this.lbl_codigo.TabIndex = 41;
            this.lbl_codigo.Text = "Codigo:";
            // 
            // textCodigo
            // 
            this.textCodigo.Enabled = false;
            this.textCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textCodigo.Location = new System.Drawing.Point(106, 85);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(165, 26);
            this.textCodigo.TabIndex = 40;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.Black;
            this.lbl_ID.Location = new System.Drawing.Point(31, 53);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(86, 20);
            this.lbl_ID.TabIndex = 43;
            this.lbl_ID.Text = "Id Factura:";
            // 
            // text_ID
            // 
            this.text_ID.Enabled = false;
            this.text_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.text_ID.Location = new System.Drawing.Point(121, 50);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(151, 26);
            this.text_ID.TabIndex = 42;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.Black;
            this.lbl_fecha.Location = new System.Drawing.Point(31, 122);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(58, 20);
            this.lbl_fecha.TabIndex = 45;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // textFecha
            // 
            this.textFecha.Enabled = false;
            this.textFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFecha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textFecha.Location = new System.Drawing.Point(106, 119);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(165, 26);
            this.textFecha.TabIndex = 44;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.ForeColor = System.Drawing.Color.Black;
            this.lbl_cliente.Location = new System.Drawing.Point(427, 88);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(62, 20);
            this.lbl_cliente.TabIndex = 47;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // textCliente
            // 
            this.textCliente.Enabled = false;
            this.textCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textCliente.Location = new System.Drawing.Point(524, 85);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(165, 26);
            this.textCliente.TabIndex = 46;
            // 
            // lbl_vendedor
            // 
            this.lbl_vendedor.AutoSize = true;
            this.lbl_vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendedor.ForeColor = System.Drawing.Color.Black;
            this.lbl_vendedor.Location = new System.Drawing.Point(427, 53);
            this.lbl_vendedor.Name = "lbl_vendedor";
            this.lbl_vendedor.Size = new System.Drawing.Size(85, 20);
            this.lbl_vendedor.TabIndex = 49;
            this.lbl_vendedor.Text = "Empleado:";
            // 
            // textVendedor
            // 
            this.textVendedor.Enabled = false;
            this.textVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVendedor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textVendedor.Location = new System.Drawing.Point(524, 50);
            this.textVendedor.Name = "textVendedor";
            this.textVendedor.Size = new System.Drawing.Size(165, 26);
            this.textVendedor.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(427, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tipo de cambio:";
            // 
            // textTipo_cambio
            // 
            this.textTipo_cambio.Enabled = false;
            this.textTipo_cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTipo_cambio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textTipo_cambio.Location = new System.Drawing.Point(628, 122);
            this.textTipo_cambio.Name = "textTipo_cambio";
            this.textTipo_cambio.Size = new System.Drawing.Size(61, 26);
            this.textTipo_cambio.TabIndex = 50;
            // 
            // Lista_detalle_Factura
            // 
            this.Lista_detalle_Factura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Lista_detalle_Factura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Lista_detalle_Factura.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Lista_detalle_Factura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lista_detalle_Factura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lista_detalle_Factura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Lista_detalle_Factura.ColumnHeadersHeight = 30;
            this.Lista_detalle_Factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Lista_detalle_Factura.EnableHeadersVisualStyles = false;
            this.Lista_detalle_Factura.Location = new System.Drawing.Point(34, 166);
            this.Lista_detalle_Factura.Name = "Lista_detalle_Factura";
            this.Lista_detalle_Factura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Lista_detalle_Factura.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista_detalle_Factura.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Lista_detalle_Factura.Size = new System.Drawing.Size(655, 167);
            this.Lista_detalle_Factura.TabIndex = 52;
            // 
            // lbl_pago
            // 
            this.lbl_pago.AutoSize = true;
            this.lbl_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pago.ForeColor = System.Drawing.Color.Black;
            this.lbl_pago.Location = new System.Drawing.Point(31, 413);
            this.lbl_pago.Name = "lbl_pago";
            this.lbl_pago.Size = new System.Drawing.Size(50, 20);
            this.lbl_pago.TabIndex = 54;
            this.lbl_pago.Text = "Pago:";
            // 
            // textPago
            // 
            this.textPago.Enabled = false;
            this.textPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPago.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textPago.Location = new System.Drawing.Point(107, 410);
            this.textPago.Name = "textPago";
            this.textPago.Size = new System.Drawing.Size(165, 26);
            this.textPago.TabIndex = 53;
            // 
            // lbl_vuelto
            // 
            this.lbl_vuelto.AutoSize = true;
            this.lbl_vuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vuelto.ForeColor = System.Drawing.Color.Black;
            this.lbl_vuelto.Location = new System.Drawing.Point(30, 457);
            this.lbl_vuelto.Name = "lbl_vuelto";
            this.lbl_vuelto.Size = new System.Drawing.Size(59, 20);
            this.lbl_vuelto.TabIndex = 56;
            this.lbl_vuelto.Text = "Vuelto:";
            // 
            // textVuelto
            // 
            this.textVuelto.Enabled = false;
            this.textVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVuelto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textVuelto.Location = new System.Drawing.Point(106, 454);
            this.textVuelto.Name = "textVuelto";
            this.textVuelto.Size = new System.Drawing.Size(165, 26);
            this.textVuelto.TabIndex = 55;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Black;
            this.lbl_total.Location = new System.Drawing.Point(448, 457);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(48, 20);
            this.lbl_total.TabIndex = 60;
            this.lbl_total.Text = "Total:";
            // 
            // textTotal
            // 
            this.textTotal.Enabled = false;
            this.textTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textTotal.Location = new System.Drawing.Point(524, 454);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(165, 26);
            this.textTotal.TabIndex = 59;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.ForeColor = System.Drawing.Color.Black;
            this.lbl_subtotal.Location = new System.Drawing.Point(448, 413);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(73, 20);
            this.lbl_subtotal.TabIndex = 58;
            this.lbl_subtotal.Text = "Subtotal:";
            // 
            // textSubtotal
            // 
            this.textSubtotal.Enabled = false;
            this.textSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSubtotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textSubtotal.Location = new System.Drawing.Point(524, 410);
            this.textSubtotal.Name = "textSubtotal";
            this.textSubtotal.Size = new System.Drawing.Size(165, 26);
            this.textSubtotal.TabIndex = 57;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Green;
            this.lblEstado.Location = new System.Drawing.Point(30, 342);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(88, 29);
            this.lblEstado.TabIndex = 62;
            this.lblEstado.Text = "Estado";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(192, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Detalle de la factura seleccionada:";
            // 
            // lbl_motivo
            // 
            this.lbl_motivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motivo.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_motivo.Location = new System.Drawing.Point(157, 349);
            this.lbl_motivo.Name = "lbl_motivo";
            this.lbl_motivo.Size = new System.Drawing.Size(532, 49);
            this.lbl_motivo.TabIndex = 65;
            this.lbl_motivo.Text = "Motivo";
            this.lbl_motivo.Visible = false;
            // 
            // Ver_detalle_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 506);
            this.Controls.Add(this.lbl_motivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.textSubtotal);
            this.Controls.Add(this.lbl_vuelto);
            this.Controls.Add(this.textVuelto);
            this.Controls.Add(this.lbl_pago);
            this.Controls.Add(this.textPago);
            this.Controls.Add(this.Lista_detalle_Factura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTipo_cambio);
            this.Controls.Add(this.lbl_vendedor);
            this.Controls.Add(this.textVendedor);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.textCliente);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.text_ID);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.btnCerrarSuperior);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ver_detalle_factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver_detalle_factura";
            this.Load += new System.EventHandler(this.Ver_detalle_factura_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ver_detalle_factura_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lista_detalle_Factura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.PictureBox btnCerrarSuperior;
        private System.Windows.Forms.Label lbl_codigo;
        public System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label lbl_ID;
        public System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.Label lbl_fecha;
        public System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.Label lbl_cliente;
        public System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.Label lbl_vendedor;
        public System.Windows.Forms.TextBox textVendedor;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textTipo_cambio;
        private System.Windows.Forms.DataGridView Lista_detalle_Factura;
        private System.Windows.Forms.Label lbl_pago;
        public System.Windows.Forms.TextBox textPago;
        private System.Windows.Forms.Label lbl_vuelto;
        public System.Windows.Forms.TextBox textVuelto;
        private System.Windows.Forms.Label lbl_total;
        public System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label lbl_subtotal;
        public System.Windows.Forms.TextBox textSubtotal;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_motivo;
    }
}