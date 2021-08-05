namespace Presentacion
{
    partial class Compra_Factura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra_Factura));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Listar_compra_completaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Datos_Compras_Factura = new Presentacion.Datos_Compras_Factura();
            this.brnCerrarSuperior = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Listar_compra_completaTableAdapter = new Presentacion.Datos_Compras_FacturaTableAdapters.Listar_compra_completaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Listar_compra_completaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Compras_Factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnCerrarSuperior)).BeginInit();
            this.SuspendLayout();
            // 
            // Listar_compra_completaBindingSource
            // 
            this.Listar_compra_completaBindingSource.DataMember = "Listar_compra_completa";
            this.Listar_compra_completaBindingSource.DataSource = this.Datos_Compras_Factura;
            // 
            // Datos_Compras_Factura
            // 
            this.Datos_Compras_Factura.DataSetName = "Datos_Compras_Factura";
            this.Datos_Compras_Factura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brnCerrarSuperior
            // 
            this.brnCerrarSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brnCerrarSuperior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnCerrarSuperior.Image = ((System.Drawing.Image)(resources.GetObject("brnCerrarSuperior.Image")));
            this.brnCerrarSuperior.Location = new System.Drawing.Point(946, 0);
            this.brnCerrarSuperior.Name = "brnCerrarSuperior";
            this.brnCerrarSuperior.Size = new System.Drawing.Size(40, 28);
            this.brnCerrarSuperior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brnCerrarSuperior.TabIndex = 30;
            this.brnCerrarSuperior.TabStop = false;
            this.brnCerrarSuperior.Click += new System.EventHandler(this.brnCerrarSuperior_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Datos_de_compra";
            reportDataSource1.Value = this.Listar_compra_completaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Informe_Compras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(90, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(793, 513);
            this.reportViewer1.TabIndex = 31;
            // 
            // Listar_compra_completaTableAdapter
            // 
            this.Listar_compra_completaTableAdapter.ClearBeforeFill = true;
            // 
            // Compra_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 537);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.brnCerrarSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compra_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra_Factura";
            this.Load += new System.EventHandler(this.Compra_Factura_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Compra_Factura_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Listar_compra_completaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Compras_Factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnCerrarSuperior)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox brnCerrarSuperior;
        private System.Windows.Forms.BindingSource Listar_compra_completaBindingSource;
        private Datos_Compras_Factura Datos_Compras_Factura;
        private Datos_Compras_FacturaTableAdapters.Listar_compra_completaTableAdapter Listar_compra_completaTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}