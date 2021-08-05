using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using System.Runtime.InteropServices;
using Common.Cache;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsq, int wparam, int lparam);

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (textusuario.Text != "USUARIO")
            {
                if (textcontra.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();
                    var validlogin = user.LoginUser(textusuario.Text,textcontra.Text);
                    if (validlogin == true)
                    {
                        Formulario_Principal MainMenu = new Formulario_Principal();
                        Tasa_cambio cambio_tasa = new Tasa_cambio();
                        MainMenu.Show();
                        MainMenu.FormClosed += Logout;
                        this.Hide();
                        cambio_tasa.ShowDialog();
                    }
                    else
                    {
                        msgError("Usuario o Contraseña Incorrecta. \n Intentelo de nuevo.");
                        textcontra.Text = "CONTRASEÑA";
                        textcontra.UseSystemPasswordChar = false;
                        textusuario.Focus();
                
                    }
                }
                else msgError("Por Favor ingrese la contraseña.");
            }
            else msgError("Por Favor ingrese el nombre Usuario.");

        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = "   " + msg;
            lblErrorMessage.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            textcontra.Text = "CONTRASEÑA";
            textcontra.UseSystemPasswordChar = false;
            textusuario.Text="USUARIO";
            lblErrorMessage.Visible = false;
            this.Show();
            //textusuario.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textusuario_Enter(object sender, EventArgs e)
        {
            if (textusuario.Text == "USUARIO")
            {
                textusuario.Text = "";
                textusuario.ForeColor = Color.LightGray;
            }
        }

        private void textusuario_Leave(object sender, EventArgs e)
        {
            if (textusuario.Text == "")
            {
                textusuario.Text = "USUARIO";
                textusuario.ForeColor = Color.DimGray;
            }
        }

        private void textcontra_Enter(object sender, EventArgs e)
        {
            if (textcontra.Text == "CONTRASEÑA")
            {
                textcontra.Text = "";
                textcontra.ForeColor = Color.LightGray;
                textcontra.UseSystemPasswordChar = true;
            }
        }

        private void textcontra_Leave(object sender, EventArgs e)
        {
            if (textcontra.Text == "")
            {
                textcontra.Text = "CONTRASEÑA";
                textcontra.ForeColor = Color.DimGray;
                textcontra.UseSystemPasswordChar = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void iconSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
