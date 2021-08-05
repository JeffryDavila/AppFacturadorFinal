using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;

namespace Presentacion
{
    public partial class Factura_Reporte : Form
    {
        public Factura_Reporte()
        {
            InitializeComponent();
        }

        private void Factura_Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Datos_factura.Listar_Factura_completa' Puede moverla o quitarla según sea necesario.
           // this.Listar_Factura_completaTableAdapter.Fill(this.Datos_factura.Listar_Factura_completa);
            // TODO: esta línea de código carga datos en la tabla 'Datos_factura.Listar_Factura_completa' Puede moverla o quitarla según sea necesario.
            //this.Listar_Factura_completaTableAdapter.Fill(this.Datos_factura.Listar_Factura_completa,FacturaCache.idfactura);
            this.reportViewer1.RefreshReport();
        }

        private void brnCerrarSuperior_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
