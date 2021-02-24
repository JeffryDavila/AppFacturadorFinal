using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        Formulario_Principal logueo;

        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (textusuario.Text != "USERNAME")
            {
                if (textcontra.Text != "CONTRASEÑA")
                {

                }
                else msgError("Please enter Password");
            }
            else msgError("Please enter username");

        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = " " + msg;
            lblErrorMessage.Visible = true;
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
    }
}
