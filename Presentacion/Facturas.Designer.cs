namespace Presentacion
{
    partial class Facturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturas));
            this.Lista_de_Facturas = new System.Windows.Forms.DataGridView();
            this.Encabezado_lista = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnNuevoFactura = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrarInferior = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_Opcion = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.PictureBox();
            this.Fecha_select = new System.Windows.Forms.DateTimePicker();
            this.btn_vista_imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Lista_de_Facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // Lista_de_Facturas
            // 
            this.Lista_de_Facturas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Lista_de_Facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Lista_de_Facturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Lista_de_Facturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.Lista_de_Facturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lista_de_Facturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lista_de_Facturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Lista_de_Facturas.ColumnHeadersHeight = 30;
            this.Lista_de_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Lista_de_Facturas.EnableHeadersVisualStyles = false;
            this.Lista_de_Facturas.GridColor = System.Drawing.Color.DarkCyan;
            this.Lista_de_Facturas.Location = new System.Drawing.Point(17, 103);
            this.Lista_de_Facturas.Name = "Lista_de_Facturas";
            this.Lista_de_Facturas.ReadOnly = true;
            this.Lista_de_Facturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lista_de_Facturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Lista_de_Facturas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Lista_de_Facturas.Size = new System.Drawing.Size(848, 433);
            this.Lista_de_Facturas.TabIndex = 4;
            this.Lista_de_Facturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lista_de_Facturas_CellContentClick);
            this.Lista_de_Facturas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lista_de_Facturas_CellDoubleClick);
            this.Lista_de_Facturas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Lista_de_Facturas_CellFormatting);
            // 
            // Encabezado_lista
            // 
            this.Encabezado_lista.AutoSize = true;
            this.Encabezado_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encabezado_lista.ForeColor = System.Drawing.Color.White;
            this.Encabezado_lista.Location = new System.Drawing.Point(21, 72);
            this.Encabezado_lista.Name = "Encabezado_lista";
            this.Encabezado_lista.Size = new System.Drawing.Size(143, 24);
            this.Encabezado_lista.TabIndex = 6;
            this.Encabezado_lista.Text = "Lista de facturas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(398, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(96, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Facturas";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.rectangleShape1.Location = new System.Drawing.Point(893, 222);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(206, 211);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1160, 569);
            this.shapeContainer1.TabIndex = 7;
            this.shapeContainer1.TabStop = false;
            // 
            // btnAnular
            // 
            this.btnAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnAnular.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(920, 290);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(154, 36);
            this.btnAnular.TabIndex = 12;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnNuevoFactura
            // 
            this.btnNuevoFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(109)))));
            this.btnNuevoFactura.FlatAppearance.BorderSize = 0;
            this.btnNuevoFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnNuevoFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(75)))));
            this.btnNuevoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoFactura.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnNuevoFactura.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNuevoFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoFactura.Location = new System.Drawing.Point(920, 247);
            this.btnNuevoFactura.Name = "btnNuevoFactura";
            this.btnNuevoFactura.Size = new System.Drawing.Size(154, 36);
            this.btnNuevoFactura.TabIndex = 10;
            this.btnNuevoFactura.Text = "Nuevo";
            this.btnNuevoFactura.UseVisualStyleBackColor = false;
            this.btnNuevoFactura.Click += new System.EventHandler(this.btnNuevoFactura_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(952, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "OPCIONES";
            // 
            // btnCerrarInferior
            // 
            this.btnCerrarInferior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCerrarInferior.FlatAppearance.BorderSize = 0;
            this.btnCerrarInferior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCerrarInferior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarInferior.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCerrarInferior.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrarInferior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarInferior.Location = new System.Drawing.Point(935, 500);
            this.btnCerrarInferior.Name = "btnCerrarInferior";
            this.btnCerrarInferior.Size = new System.Drawing.Size(187, 36);
            this.btnCerrarInferior.TabIndex = 22;
            this.btnCerrarInferior.Text = "Cerrar";
            this.btnCerrarInferior.UseVisualStyleBackColor = false;
            this.btnCerrarInferior.Click += new System.EventHandler(this.btnCerrarInferior_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1139, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 17);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalle.BackColor = System.Drawing.Color.White;
            this.btnDetalle.FlatAppearance.BorderSize = 0;
            this.btnDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnDetalle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDetalle.Image = global::Presentacion.Properties.Resources.ojo_detalle;
            this.btnDetalle.Location = new System.Drawing.Point(921, 334);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(154, 36);
            this.btnDetalle.TabIndex = 24;
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(921, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_Opcion
            // 
            this.cmb_Opcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(105)))));
            this.cmb_Opcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Opcion.ForeColor = System.Drawing.SystemColors.Window;
            this.cmb_Opcion.FormattingEnabled = true;
            this.cmb_Opcion.IntegralHeight = false;
            this.cmb_Opcion.ItemHeight = 18;
            this.cmb_Opcion.Items.AddRange(new object[] {
            "Hoy",
            "Dia Especifico"});
            this.cmb_Opcion.Location = new System.Drawing.Point(704, 71);
            this.cmb_Opcion.Name = "cmb_Opcion";
            this.cmb_Opcion.Size = new System.Drawing.Size(161, 26);
            this.cmb_Opcion.TabIndex = 46;
            this.cmb_Opcion.Text = "Seleccione opcion:";
            this.cmb_Opcion.SelectionChangeCommitted += new System.EventHandler(this.cmb_Opcion_SelectionChangeCommitted);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(1084, 70);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(36, 27);
            this.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_buscar.TabIndex = 50;
            this.btn_buscar.TabStop = false;
            this.btn_buscar.Visible = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Fecha_select
            // 
            this.Fecha_select.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_select.Location = new System.Drawing.Point(871, 71);
            this.Fecha_select.Name = "Fecha_select";
            this.Fecha_select.Size = new System.Drawing.Size(205, 26);
            this.Fecha_select.TabIndex = 51;
            this.Fecha_select.Visible = false;
            // 
            // btn_vista_imprimir
            // 
            this.btn_vista_imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_vista_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.btn_vista_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_vista_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_vista_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_vista_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vista_imprimir.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btn_vista_imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_vista_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("btn_vista_imprimir.Image")));
            this.btn_vista_imprimir.Location = new System.Drawing.Point(920, 378);
            this.btn_vista_imprimir.Name = "btn_vista_imprimir";
            this.btn_vista_imprimir.Size = new System.Drawing.Size(155, 36);
            this.btn_vista_imprimir.TabIndex = 75;
            this.btn_vista_imprimir.UseVisualStyleBackColor = false;
            this.btn_vista_imprimir.Click += new System.EventHandler(this.btn_vista_imprimir_Click);
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1160, 569);
            this.Controls.Add(this.btn_vista_imprimir);
            this.Controls.Add(this.Fecha_select);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cmb_Opcion);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrarInferior);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnNuevoFactura);
            this.Controls.Add(this.Encabezado_lista);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.Lista_de_Facturas);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lista_de_Facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Lista_de_Facturas;
        private System.Windows.Forms.Label lblTitulo;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnNuevoFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrarInferior;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label Encabezado_lista;
        private System.Windows.Forms.Button btnDetalle;
        public System.Windows.Forms.ComboBox cmb_Opcion;
        private System.Windows.Forms.PictureBox btn_buscar;
        private System.Windows.Forms.DateTimePicker Fecha_select;
        private System.Windows.Forms.Button btn_vista_imprimir;
    }
}