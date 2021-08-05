namespace Presentacion
{
    partial class Factura_Reporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura_Reporte));
            this.Listar_Factura_completaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Datos_factura = new Presentacion.Datos_factura();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.brnCerrarSuperior = new System.Windows.Forms.PictureBox();
            this.Listar_Factura_completaTableAdapter = new Presentacion.Datos_facturaTableAdapters.Listar_Factura_completaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Listar_Factura_completaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnCerrarSuperior)).BeginInit();
            this.SuspendLayout();
            // 
            // Listar_Factura_completaBindingSource
            // 
            this.Listar_Factura_completaBindingSource.DataMember = "Listar_Factura_completa";
            this.Listar_Factura_completaBindingSource.DataSource = this.Datos_factura;
            // 
            // Datos_factura
            // 
            this.Datos_factura.DataSetName = "Datos_factura";
            this.Datos_factura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "Data_factura";
            reportDataSource1.Value = this.Listar_Factura_completaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(175, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(685, 508);
            this.reportViewer1.TabIndex = 0;
            // 
            // brnCerrarSuperior
            // 
            this.brnCerrarSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brnCerrarSuperior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnCerrarSuperior.Image = ((System.Drawing.Image)(resources.GetObject("brnCerrarSuperior.Image")));
            this.brnCerrarSuperior.Location = new System.Drawing.Point(944, 2);
            this.brnCerrarSuperior.Name = "brnCerrarSuperior";
            this.brnCerrarSuperior.Size = new System.Drawing.Size(40, 28);
            this.brnCerrarSuperior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brnCerrarSuperior.TabIndex = 29;
            this.brnCerrarSuperior.TabStop = false;
            this.brnCerrarSuperior.Click += new System.EventHandler(this.brnCerrarSuperior_Click);
            // 
            // Listar_Factura_completaTableAdapter
            // 
            this.Listar_Factura_completaTableAdapter.ClearBeforeFill = true;
            // 
            // Factura_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 532);
            this.Controls.Add(this.brnCerrarSuperior);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura_Reporte";
            this.Text = "Factura_Reporte";
            this.Load += new System.EventHandler(this.Factura_Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listar_Factura_completaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brnCerrarSuperior)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Listar_Factura_completaBindingSource;
        private Datos_factura Datos_factura;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.PictureBox brnCerrarSuperior;
        private Datos_facturaTableAdapters.Listar_Factura_completaTableAdapter Listar_Factura_completaTableAdapter;
    }
}