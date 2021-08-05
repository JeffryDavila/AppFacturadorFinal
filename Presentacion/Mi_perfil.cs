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
using Common.Cache;

namespace Presentacion
{
    public partial class Mi_perfil : Form
    {
        UserModel objuser = new UserModel();
        public Mi_perfil()
        {
            InitializeComponent();
        }

        private void Mi_perfil_Load(object sender, EventArgs e)
        {
            ver_datos_empleados();
            ver_datos_usuario();
            textContraseña.UseSystemPasswordChar = true;
            textConfirmar.UseSystemPasswordChar = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ver_datos_empleados()
        {
            UserModel userdatos = new UserModel();
            userdatos.Mostrar_DatosEmpleados(UserLoginCache.User_idempleado);
            textNombre.Text = UserLoginCache.Nombre;
            textApellido.Text = UserLoginCache.Apellido;
            textCedula.Text = UserLoginCache.Cedula;
            textTelefono.Text = UserLoginCache.Telefono;
            textDireccion.Text = UserLoginCache.Direccion;
        }

        public void ver_datos_usuario()
        {
            textUserNombre.Text = UserLoginCache.UserName;
            textEmail.Text = UserLoginCache.UserEmail;
            textPrivilegio.Text = UserLoginCache.UserPrivilegios;
            textContraseña.Text = UserLoginCache.password;
            textConfirmar.Text = UserLoginCache.password;
        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            btnCambiarPass.Visible = false;
            textContraseña.Enabled = true;
            textConfirmar.Enabled = true;
            btn_mostrar_pass.Visible = true;
            textUserNombre.Enabled = true;
            textEmail.Enabled = true;

            btnCancelar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnCambiarPass.Visible = true;
            btnGuardar.Visible = false;
            textContraseña.Enabled = false;
            textConfirmar.Enabled = false;
            btn_mostrar_pass.Visible = false;
            textUserNombre.Enabled = false;
            textEmail.Enabled = false;

            btnCancelar.Visible = false;

            if(!campos_vacios())
            {
                if (textContraseña.Text == textConfirmar.Text)
                {
                    try
                    {
                        objuser.cambiar_contraseña(UserLoginCache.idusuario, textUserNombre.Text, textEmail.Text, textContraseña.Text);
                        MessageBox.Show("Perfil se edito correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textContraseña.UseSystemPasswordChar = true;
                        textConfirmar.UseSystemPasswordChar = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Username ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reset();
                    }

                }
                else
                {
                    MessageBox.Show("La contraseña no coincide con la comfirmacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                 MessageBox.Show("Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCambiarPass.Visible = true;
            btnGuardar.Visible = false;
            textContraseña.Enabled = false;
            textConfirmar.Enabled = false;
            btn_mostrar_pass.Visible = false;
            textUserNombre.Enabled = false;
            textEmail.Enabled = false;
            btnCancelar.Visible = false;
        }

        private void btn_mostrar_pass_Click(object sender, EventArgs e)
        {
            textContraseña.UseSystemPasswordChar = false;
            textConfirmar.UseSystemPasswordChar = false;
            btn_mostrar_pass.Visible = false;
            btn_ocultar_pass.Visible = true;
        }

        private void btn_ocultar_pass_Click(object sender, EventArgs e)
        {
            textContraseña.UseSystemPasswordChar = true;
            textConfirmar.UseSystemPasswordChar = true;
            btn_mostrar_pass.Visible = true;
            btn_ocultar_pass.Visible = false;
        }

        private bool campos_vacios()
        {
            if (textUserNombre.Text == "" || textEmail.Text == "" || textContraseña.Text == "" || textConfirmar.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void reset()
        {
            textUserNombre.Text = UserLoginCache.UserName;
            textEmail.Text = UserLoginCache.UserEmail;
            textContraseña.Text = UserLoginCache.password;
            textConfirmar.Text = UserLoginCache.password;
        }
    }
}
