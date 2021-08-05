namespace Presentacion
{
    partial class Tasa_cambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasa_cambio));
            this.lblSubMenu = new System.Windows.Forms.Label();
            this.btnCerrarSuperior = new System.Windows.Forms.PictureBox();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.textdolar_cordoba = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSuperior)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubMenu
            // 
            this.lblSubMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubMenu.AutoSize = true;
            this.lblSubMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMenu.ForeColor = System.Drawing.Color.Black;
            this.lblSubMenu.Location = new System.Drawing.Point(125, 36);
            this.lblSubMenu.Name = "lblSubMenu";
            this.lblSubMenu.Size = new System.Drawing.Size(121, 20);
            this.lblSubMenu.TabIndex = 47;
            this.lblSubMenu.Text = "Tasa de cambio";
            // 
            // btnCerrarSuperior
            // 
            this.btnCerrarSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSuperior.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSuperior.Image")));
            this.btnCerrarSuperior.Location = new System.Drawing.Point(316, 1);
            this.btnCerrarSuperior.Name = "btnCerrarSuperior";
            this.btnCerrarSuperior.Size = new System.Drawing.Size(40, 28);
            this.btnCerrarSuperior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSuperior.TabIndex = 46;
            this.btnCerrarSuperior.TabStop = false;
            this.btnCerrarSuperior.Visible = false;
            this.btnCerrarSuperior.Click += new System.EventHandler(this.btnCerrarSuperior_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Black;
            this.rectangleShape1.Location = new System.Drawing.Point(11, 47);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(335, 193);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(357, 251);
            this.shapeContainer1.TabIndex = 48;
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
            this.btnGuardar.Location = new System.Drawing.Point(104, 186);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(154, 36);
            this.btnGuardar.TabIndex = 49;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.ForeColor = System.Drawing.Color.Black;
            this.lblcodigo.Location = new System.Drawing.Point(50, 86);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(259, 20);
            this.lblcodigo.TabIndex = 51;
            this.lblcodigo.Text = "Ingresar cambio de dolar a cordoba";
            // 
            // textdolar_cordoba
            // 
            this.textdolar_cordoba.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textdolar_cordoba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdolar_cordoba.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textdolar_cordoba.Location = new System.Drawing.Point(83, 122);
            this.textdolar_cordoba.Name = "textdolar_cordoba";
            this.textdolar_cordoba.Size = new System.Drawing.Size(198, 26);
            this.textdolar_cordoba.TabIndex = 50;
            this.textdolar_cordoba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodigo_KeyPress);
            // 
            // Tasa_cambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 251);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.textdolar_cordoba);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblSubMenu);
            this.Controls.Add(this.btnCerrarSuperior);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tasa_cambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasa_cambio";
            this.Load += new System.EventHandler(this.Tasa_cambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSuperior)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSubMenu;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblcodigo;
        public System.Windows.Forms.TextBox textdolar_cordoba;
        public System.Windows.Forms.PictureBox btnCerrarSuperior;
    }
}