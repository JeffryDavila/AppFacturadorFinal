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
using Domain;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class Ver_detalle_factura : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsq, int wparam, int lparam);

        public Ver_detalle_factura()
        {
            InitializeComponent();
        }

        private void Ver_detalle_factura_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void Listar_Mini_consultaFactura(int idfactura)
        {
            FacturaModel objfactura = new FacturaModel();
            Lista_detalle_Factura.DataSource = objfactura.Mini_consulta_factura(idfactura);
        }

        private void Ver_detalle_factura_Load(object sender, EventArgs e)
        {
            textCodigo.Text=FacturaCache.Codigo_factura;
            textFecha.Text = FacturaCache.Fecha_Hora;
            textVendedor.Text = FacturaCache.Nombre_Empleado;
            textCliente.Text = FacturaCache.Nombre_Cliente;
            textTipo_cambio.Text = FacturaCache.tipo_cambio;
            lblEstado.Text = FacturaCache.estado;
            if(FacturaCache.estado=="Facturada")
            {
                lblEstado.ForeColor = Color.Green;
            }
            else
            {
                lblEstado.ForeColor = Color.Red;
                lbl_motivo.Visible = true;
                lbl_motivo.Text= FacturaCache.motivo;
            }
            textPago.Text = Convert.ToString(FacturaCache.pago);
            textVuelto.Text = Convert.ToString(FacturaCache.vuelto);
            textSubtotal.Text = Convert.ToString(FacturaCache.subtotal);
            textTotal.Text = Convert.ToString(FacturaCache.total);


        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSuperior_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
