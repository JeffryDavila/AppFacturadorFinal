namespace Presentacion
{
    partial class Compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.btnCerrar = new System.Windows.Forms.Label();
            this.Lista_de_compras = new System.Windows.Forms.DataGridView();
            this.Encabezado_listaproducto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrarInferior = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.cmb_Opcion = new System.Windows.Forms.ComboBox();
            this.Fecha_select2 = new System.Windows.Forms.DateTimePicker();
            this.btn_buscar = new System.Windows.Forms.PictureBox();
            this.Fecha_select1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha2 = new System.Windows.Forms.Label();
            this.lbl_fecha1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Lista_de_compras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1138, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(17, 17);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.Text = "X";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Lista_de_compras
            // 
            this.Lista_de_compras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Lista_de_compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Lista_de_compras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Lista_de_compras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.Lista_de_compras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lista_de_compras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lista_de_compras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Lista_de_compras.ColumnHeadersHeight = 30;
            this.Lista_de_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Lista_de_compras.EnableHeadersVisualStyles = false;
            this.Lista_de_compras.GridColor = System.Drawing.Color.DarkCyan;
            this.Lista_de_compras.Location = new System.Drawing.Point(22, 118);
            this.Lista_de_compras.Name = "Lista_de_compras";
            this.Lista_de_compras.ReadOnly = true;
            this.Lista_de_compras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lista_de_compras.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.Lista_de_compras.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.Lista_de_compras.Size = new System.Drawing.Size(838, 413);
            this.Lista_de_compras.TabIndex = 23;
            this.Lista_de_compras.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Lista_de_compras_CellFormatting);
            // 
            // Encabezado_listaproducto
            // 
            this.Encabezado_listaproducto.AutoSize = true;
            this.Encabezado_listaproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encabezado_listaproducto.ForeColor = System.Drawing.Color.White;
            this.Encabezado_listaproducto.Location = new System.Drawing.Point(18, 85);
            this.Encabezado_listaproducto.Name = "Encabezado_listaproducto";
            this.Encabezado_listaproducto.Size = new System.Drawing.Size(152, 24);
            this.Encabezado_listaproducto.TabIndex = 24;
            this.Encabezado_listaproducto.Text = "Lista de compras";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(421, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(237, 25);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Cotizacion de Compras";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(946, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
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
            this.btnAnular.Location = new System.Drawing.Point(956, 286);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(154, 36);
            this.btnAnular.TabIndex = 28;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(109)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(75)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(956, 328);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(154, 36);
            this.btnConfirmar.TabIndex = 27;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.rectangleShape1.Location = new System.Drawing.Point(928, 223);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(207, 203);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1158, 569);
            this.shapeContainer1.TabIndex = 29;
            this.shapeContainer1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(987, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 30;
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
            this.btnCerrarInferior.Location = new System.Drawing.Point(946, 495);
            this.btnCerrarInferior.Name = "btnCerrarInferior";
            this.btnCerrarInferior.Size = new System.Drawing.Size(187, 36);
            this.btnCerrarInferior.TabIndex = 31;
            this.btnCerrarInferior.Text = "Cerrar";
            this.btnCerrarInferior.UseVisualStyleBackColor = false;
            this.btnCerrarInferior.Click += new System.EventHandler(this.btnCerrarInferior_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.btnNueva.FlatAppearance.BorderSize = 0;
            this.btnNueva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(141)))), ((int)(((byte)(0)))));
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnNueva.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNueva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNueva.Location = new System.Drawing.Point(956, 244);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(154, 36);
            this.btnNueva.TabIndex = 65;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.UseVisualStyleBackColor = false;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
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
            this.btnDetalle.Location = new System.Drawing.Point(956, 370);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(154, 36);
            this.btnDetalle.TabIndex = 66;
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
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
            "General",
            "Dia Especifico",
            "Rango Fechas"});
            this.cmb_Opcion.Location = new System.Drawing.Point(628, 85);
            this.cmb_Opcion.Name = "cmb_Opcion";
            this.cmb_Opcion.Size = new System.Drawing.Size(161, 26);
            this.cmb_Opcion.TabIndex = 67;
            this.cmb_Opcion.Text = "Seleccione opcion:";
            this.cmb_Opcion.SelectedIndexChanged += new System.EventHandler(this.cmb_Opcion_SelectedIndexChanged);
            this.cmb_Opcion.SelectionChangeCommitted += new System.EventHandler(this.cmb_Opcion_SelectionChangeCommitted);
            // 
            // Fecha_select2
            // 
            this.Fecha_select2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_select2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_select2.Location = new System.Drawing.Point(858, 84);
            this.Fecha_select2.Name = "Fecha_select2";
            this.Fecha_select2.Size = new System.Drawing.Size(205, 26);
            this.Fecha_select2.TabIndex = 69;
            this.Fecha_select2.Visible = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(1069, 83);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(36, 27);
            this.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_buscar.TabIndex = 68;
            this.btn_buscar.TabStop = false;
            this.btn_buscar.Visible = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Fecha_select1
            // 
            this.Fecha_select1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_select1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_select1.Location = new System.Drawing.Point(858, 52);
            this.Fecha_select1.Name = "Fecha_select1";
            this.Fecha_select1.Size = new System.Drawing.Size(205, 26);
            this.Fecha_select1.TabIndex = 70;
            this.Fecha_select1.Visible = false;
            // 
            // lbl_fecha2
            // 
            this.lbl_fecha2.AutoSize = true;
            this.lbl_fecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha2.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha2.Location = new System.Drawing.Point(799, 91);
            this.lbl_fecha2.Name = "lbl_fecha2";
            this.lbl_fecha2.Size = new System.Drawing.Size(54, 18);
            this.lbl_fecha2.TabIndex = 72;
            this.lbl_fecha2.Text = "Fecha";
            this.lbl_fecha2.Visible = false;
            // 
            // lbl_fecha1
            // 
            this.lbl_fecha1.AutoSize = true;
            this.lbl_fecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha1.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha1.Location = new System.Drawing.Point(799, 60);
            this.lbl_fecha1.Name = "lbl_fecha1";
            this.lbl_fecha1.Size = new System.Drawing.Size(33, 18);
            this.lbl_fecha1.TabIndex = 73;
            this.lbl_fecha1.Text = "Del";
            this.lbl_fecha1.Visible = false;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1158, 569);
            this.Controls.Add(this.lbl_fecha1);
            this.Controls.Add(this.lbl_fecha2);
            this.Controls.Add(this.Fecha_select1);
            this.Controls.Add(this.Fecha_select2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cmb_Opcion);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.btnCerrarInferior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.Encabezado_listaproducto);
            this.Controls.Add(this.Lista_de_compras);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lista_de_compras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.DataGridView Lista_de_compras;
        public System.Windows.Forms.Label Encabezado_listaproducto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnConfirmar;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrarInferior;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnDetalle;
        public System.Windows.Forms.ComboBox cmb_Opcion;
        private System.Windows.Forms.DateTimePicker Fecha_select2;
        private System.Windows.Forms.PictureBox btn_buscar;
        private System.Windows.Forms.DateTimePicker Fecha_select1;
        public System.Windows.Forms.Label lbl_fecha2;
        public System.Windows.Forms.Label lbl_fecha1;
    }
}