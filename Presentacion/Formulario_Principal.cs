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
using Common.Cache;

namespace Presentacion
{
	public partial class Formulario_Principal : Form
	{
		public Formulario_Principal()
		{
			InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsq, int wparam, int lparam);

        private void Formulario_Principal_Load(object sender, EventArgs e)
        {
            LoadUserData();
            PermisosUsuario();

        }

        private void PermisosUsuario()
        {
            if (UserLoginCache.UserPrivilegios == Cargos.Vendedor)
            {
                btnProveedor.Visible = false;
                btnCompra.Visible = false;
                btnEmpleador.Visible = false;
                btnUsuario.Visible = false;
                
                btncategoria.Location = new Point(0, 251);
                btn_tasacambio.Location= new Point(0, 298);
            }
        }

        private void btnMenuBar_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro de cerrar la aplicacion?","Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestaurar.Visible = true;
            iconMaximizar.Visible = false;

        }

        private void iconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestaurar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AbrirFormPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Productos());
        }

        private void LoadUserData()
        {
            lblNombreUser.Text = UserLoginCache.UserName;
            lblcorreo.Text = UserLoginCache.UserEmail;
            lblprivilegio.Text = UserLoginCache.UserPrivilegios;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar la sesion?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void lblnumUser_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Clientes());
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Proveedores());
        }

        private void btncategoria_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Categoria());
        }

        private void btnEmpleador_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Empleados());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Usuarios());
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            Facturas fact = new Facturas();
            AddOwnedForm(fact);
            AbrirFormPanel(fact);

        }

        private void btnDatos_user_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Mi_perfil());
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            Compras comp = new Compras();
            AddOwnedForm(comp);
            AbrirFormPanel(comp);
        }

        private void btn_tasacambio_Click(object sender, EventArgs e)
        {
            Tasa_cambio cambio_tasa = new Tasa_cambio();
            cambio_tasa.btnCerrarSuperior.Visible = true;
            cambio_tasa.ShowDialog();
        }
    }
}
