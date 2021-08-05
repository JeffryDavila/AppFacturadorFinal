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

namespace Presentacion
{
    public partial class Operacion_Usuario_Editar : Form
    {
        UsuarioModel objUsuario = new UsuarioModel();
        public string idusuario;
        public Operacion_Usuario_Editar()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void Operacion_Usuario_Editar_Load(object sender, EventArgs e)
        {

        }

        private void brnCerrarSuperior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ListarEmpleado()
        {
            UsuarioModel objusuario = new UsuarioModel();
            cmbEmpleado.DataSource = objusuario.Lista_de_empleado();
            cmbEmpleado.DisplayMember = "Empleado";
            cmbEmpleado.ValueMember = "idempleado";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!campos_vacios())
            {
                objUsuario.Editar_Usuario(Convert.ToInt32(idusuario), textEmail.Text,cmbPrivilegio.Text, Convert.ToInt32(cmbEmpleado.SelectedValue));
                MessageBox.Show("Se edito correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool campos_vacios()
        {
            if (textEmail.Text == "" || cmbPrivilegio.Text == "" || cmbEmpleado.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
