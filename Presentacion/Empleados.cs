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
    public partial class Empleados : Form
    {
        EmpleadoModel objempleado = new EmpleadoModel();
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            Listarempleado();
        }

        public void Listarempleado()
        {
            EmpleadoModel objempleado = new EmpleadoModel();
            Lista_de_empleado.DataSource = objempleado.Lista_de_empleado();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarInferior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lista_de_empleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevoCategoria_Click(object sender, EventArgs e)
        {
            Operacion_empleado frm = new Operacion_empleado();
            frm.lblSubMenu.Text = "Nuevo Empleado";
            frm.Operacion = "Insertar";
            frm.obtener_id_empleado();
            frm.ShowDialog();
            Listarempleado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Lista_de_empleado.SelectedRows.Count > 0)
            {
                Operacion_empleado frm = new Operacion_empleado();
                frm.Operacion = "Editar";
                frm.lblSubMenu.Text = "Editar Empleado";
                frm.idempleado = Lista_de_empleado.CurrentRow.Cells["ID"].Value.ToString();
                frm.textCodigo.Text = Lista_de_empleado.CurrentRow.Cells["Codigo"].Value.ToString();
                frm.textNombre.Text = Lista_de_empleado.CurrentRow.Cells["Nombre"].Value.ToString();
                frm.textApellido.Text = Lista_de_empleado.CurrentRow.Cells["Apellido"].Value.ToString();
                frm.textCedula.Text = Lista_de_empleado.CurrentRow.Cells["Cedula"].Value.ToString();
                frm.textTelefono.Text = Lista_de_empleado.CurrentRow.Cells["Telefono"].Value.ToString();
                frm.textDireccion.Text = Lista_de_empleado.CurrentRow.Cells["Direccion"].Value.ToString();
                frm.ShowDialog();
                Listarempleado();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista_de_empleado.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estas seguro de eliminar el Empleado seleccionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        objempleado.Eliminar_empleado(Convert.ToInt32(Lista_de_empleado.CurrentRow.Cells[0].Value));
                        MessageBox.Show("Se elimino correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listarempleado();

                    }catch (Exception ex)
                    {
                        MessageBox.Show("No se puede eliminar por que el Empleado seleccionado esta ligado a varias facturas o algun Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila para Eliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
