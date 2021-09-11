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
    public partial class Anulacion_compra : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsq, int wparam, int lparam);

        public int idpedido;
        public string estado;

        ComprasModel objcompra = new ComprasModel();
        public Anulacion_compra()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!Campos_vacios())
            {
                if (MessageBox.Show("¿Estas seguro de Anular la compra?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        estado = "Anulada";
                        objcompra.Anular_Pedido(idpedido, estado, textMotivo.Text);
                        MessageBox.Show("La compra ha sido Anulada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch(Exception exception)
                    {
                        MessageBox.Show("Al Parecer ha ocurrido un error Inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Campo Motivo Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool Campos_vacios()
        {
            if(textMotivo.Text=="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Anulacion_compra_Load(object sender, EventArgs e)
        {

        }

        private void Anulacion_compra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
