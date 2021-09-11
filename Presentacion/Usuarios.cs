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
    public partial class Usuarios : Form
    {
        UsuarioModel objUsuario = new UsuarioModel();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            ListarUsuario();
        }

        public void ListarUsuario()
        {
            UsuarioModel objuser = new UsuarioModel();
            Lista_de_usuario.DataSource = objuser.Lista_de_usuario();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarInferior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            Operacion_Usuario_Insertar frm = new Operacion_Usuario_Insertar();
            frm.lbl_submenu.Text = "Nuevo Usuario";
            frm.ListarEmpleado();
            frm.cmbPrivilegio.SelectedIndex = 1;
            frm.ShowDialog();
            ListarUsuario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Lista_de_usuario.SelectedRows.Count > 0)
            {
                Operacion_Usuario_Editar frm = new Operacion_Usuario_Editar();
                frm.lblSubMenu.Text = "Editar Usuario";
                frm.ListarEmpleado();
                frm.idusuario = Lista_de_usuario.CurrentRow.Cells["ID"].Value.ToString();
                frm.textEmail.Text = Lista_de_usuario.CurrentRow.Cells["Email"].Value.ToString();
                frm.cmbPrivilegio.Text = Lista_de_usuario.CurrentRow.Cells["Privilegio"].Value.ToString();
                frm.cmbEmpleado.Text = Lista_de_usuario.CurrentRow.Cells["Empleado"].Value.ToString();           
                frm.ShowDialog();
                ListarUsuario();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string aux;
            aux= Lista_de_usuario.CurrentRow.Cells["Privilegio"].Value.ToString();
            if(aux != "Administrador")
            {
                if (Lista_de_usuario.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Estas seguro de eliminar el Usuario seleccionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            objUsuario.Eliminar_Usuario(Convert.ToInt32(Lista_de_usuario.CurrentRow.Cells["ID"].Value));
                            MessageBox.Show("Se elimino correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListarUsuario();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se puede eliminar por que el Usuario seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar una fila para Eliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Los Usuario con privilegios de administrador no se pueden eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
