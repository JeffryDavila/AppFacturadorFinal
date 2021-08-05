using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class Compra_Factura : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsq, int wparam, int lparam);

        public Compra_Factura()
        {
            InitializeComponent();
        }

        private void Compra_Factura_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Compra_Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Datos_Compras_Factura.Listar_compra_completa' Puede moverla o quitarla según sea necesario.
            //this.Listar_compra_completaTableAdapter.Fill(this.Datos_Compras_Factura.Listar_compra_completa);

            this.reportViewer1.RefreshReport();
        }

        private void brnCerrarSuperior_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
