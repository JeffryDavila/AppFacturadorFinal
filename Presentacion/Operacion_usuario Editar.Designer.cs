namespace Presentacion
{
    partial class Operacion_usuario
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
            this.btnCerrarSuperior = new System.Windows.Forms.PictureBox();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lblSubMenu = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.lblPrivilegio = new System.Windows.Forms.Label();
            this.textPrivilegio = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSuperior)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarSuperior
            // 
            this.btnCerrarSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSuperior.Image = global::Presentacion.Properties.Resources.Salir_blanco_login;
            this.btnCerrarSuperior.Location = new System.Drawing.Point(313, 2);
            this.btnCerrarSuperior.Name = "btnCerrarSuperior";
            this.btnCerrarSuperior.Size = new System.Drawing.Size(40, 28);
            this.btnCerrarSuperior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSuperior.TabIndex = 38;
            this.btnCerrarSuperior.TabStop = false;
            this.btnCerrarSuperior.Click += new System.EventHandler(this.btnCerrarSuperior_Click);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.Location = new System.Drawing.Point(10, 35);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(335, 230);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(356, 280);
            this.shapeContainer1.TabIndex = 39;
            this.shapeContainer1.TabStop = false;
            // 
            // lblSubMenu
            // 
            this.lblSubMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubMenu.AutoSize = true;
            this.lblSubMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubMenu.ForeColor = System.Drawing.Color.White;
            this.lblSubMenu.Location = new System.Drawing.Point(117, 26);
            this.lblSubMenu.Name = "lblSubMenu";
            this.lblSubMenu.Size = new System.Drawing.Size(64, 20);
            this.lblSubMenu.TabIndex = 40;
            this.lblSubMenu.Text = "Usuario";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(31, 61);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 44;
            this.lblUsername.Text = "Username";
            // 
            // textUsername
            // 
            this.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textUsername.Location = new System.Drawing.Point(121, 61);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(198, 19);
            this.textUsername.TabIndex = 41;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(31, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 43;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // textEmail
            // 
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textEmail.Location = new System.Drawing.Point(121, 95);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(198, 19);
            this.textEmail.TabIndex = 42;
            // 
            // lblPrivilegio
            // 
            this.lblPrivilegio.AutoSize = true;
            this.lblPrivilegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivilegio.ForeColor = System.Drawing.Color.White;
            this.lblPrivilegio.Location = new System.Drawing.Point(31, 130);
            this.lblPrivilegio.Name = "lblPrivilegio";
            this.lblPrivilegio.Size = new System.Drawing.Size(70, 20);
            this.lblPrivilegio.TabIndex = 46;
            this.lblPrivilegio.Text = "Privilegio";
            // 
            // textPrivilegio
            // 
            this.textPrivilegio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrivilegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrivilegio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textPrivilegio.Location = new System.Drawing.Point(121, 130);
            this.textPrivilegio.Name = "textPrivilegio";
            this.textPrivilegio.Size = new System.Drawing.Size(198, 19);
            this.textPrivilegio.TabIndex = 45;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblEmpleado.Location = new System.Drawing.Point(31, 165);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(81, 20);
            this.lblEmpleado.TabIndex = 48;
            this.lblEmpleado.Text = "Empleado";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.IntegralHeight = false;
            this.cmbEmpleado.ItemHeight = 20;
            this.cmbEmpleado.Location = new System.Drawing.Point(121, 165);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(198, 28);
            this.cmbEmpleado.TabIndex = 47;
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
            this.btnGuardar.Location = new System.Drawing.Point(104, 213);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(154, 36);
            this.btnGuardar.TabIndex = 49;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Operacion_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(356, 280);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.lblPrivilegio);
            this.Controls.Add(this.textPrivilegio);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.lblSubMenu);
            this.Controls.Add(this.btnCerrarSuperior);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operacion_usuario";
            this.Text = "Operacion_usuario";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSuperior)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrarSuperior;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        public System.Windows.Forms.Label lblSubMenu;
        private System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label lblPrivilegio;
        public System.Windows.Forms.TextBox textPrivilegio;
        private System.Windows.Forms.Label lblEmpleado;
        public System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Button btnGuardar;
    }
}