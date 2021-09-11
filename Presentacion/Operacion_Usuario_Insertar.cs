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

namespace Presentacion
{
    public partial class Operacion_Usuario_Insertar : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsq, int wparam, int lparam);

        UsuarioModel objuser = new UsuarioModel();
        public string iduser;
        public Operacion_Usuario_Insertar()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                if (!campos_vacios())
                {
                    if(confirmar())
                    {
                       try
                       {
                           objuser.Agregar_Usuario(textUsername.Text, textContraseña.Text, textEmail.Text, cmbPrivilegio.Text, Convert.ToInt32(cmbEmpleado.SelectedValue));
                           MessageBox.Show("Insertado correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           LimpiarFormulario();
                       }
                       catch(Exception ex)
                       {
                           MessageBox.Show("Username ya esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void Operacion_Usuario_Insertar_Load(object sender, EventArgs e)
        {
            
        }

        private bool campos_vacios()
        {
            if (textUsername.Text == "" || textContraseña.Text == "" || textContraseñaConfirm.Text == "" || textEmail.Text == "" || cmbPrivilegio.Text=="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool confirmar()
        {
            if(textContraseña.Text == textContraseñaConfirm.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LimpiarFormulario()
        {
            textUsername.Text = "";
            textContraseña.Text = "";
            textContraseñaConfirm.Text = "";
            textEmail.Text = "";
            cmbPrivilegio.SelectedIndex = 1;
            cmbEmpleado.SelectedIndex = 0;
        }

        public void ListarEmpleado()
        {
            UsuarioModel objusuario = new UsuarioModel();
            cmbEmpleado.DataSource = objusuario.Lista_de_empleado();
            cmbEmpleado.DisplayMember = "Empleado";
            cmbEmpleado.ValueMember = "idempleado";
        }

        private void brnCerrarSuperior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Operacion_Usuario_Insertar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
