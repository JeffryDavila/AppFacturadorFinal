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
    public partial class Ver_detalle_compra : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsq, int wparam, int lparam);

        public Ver_detalle_compra()
        {
            InitializeComponent();
        }

        private void Ver_detalle_compra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Ver_detalle_compra_Load(object sender, EventArgs e)
        {
            textCodigo.Text = CompraCache.Codigo_compra;
            textFecha.Text = CompraCache.Fecha;
            text_TipoCambio.Text = CompraCache.tipo_cambio;
            textProveedor.Text = CompraCache.Nombre_Proveedor;
            textTelefono.Text = CompraCache.telefono;
            textEmail.Text = CompraCache.email;
            textDireccion.Text = CompraCache.direccion;
            lblEstado.Text = CompraCache.estado;

            if (CompraCache.estado=="Anulada")
            {
                lblEstado.ForeColor = Color.Red;
                lbl_motivo.Visible = true;
                lbl_motivo.Text = CompraCache.motivo;
            }
            else if(CompraCache.estado == "Confirmada")
            {
                lblEstado.ForeColor = Color.Green;
            }
            else
            {
                lblEstado.ForeColor = Color.Blue;
            }
            textSubtotal.Text = Convert.ToString(CompraCache.subtotal);
            textTotal.Text = Convert.ToString(CompraCache.total);

        }

        public void Listar_Mini_consultaCompra(int idpedido)
        {
            ComprasModel objcompra = new ComprasModel();
            Lista_detalle_Compra.DataSource = objcompra.Mini_consulta_compra(idpedido);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSuperior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
