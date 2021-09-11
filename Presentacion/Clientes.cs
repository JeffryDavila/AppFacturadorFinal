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
    public partial class Clientes : Form
    {
        ClienteModel objcliente = new ClienteModel();
        int aux_id;
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Listarclientes();
        }

        public void Listarclientes()
        {
            ClienteModel objcliente = new ClienteModel();
            Lista_de_cliente.DataSource = objcliente.Lista_de_cliente();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarInferior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Operacion_cliente frm = new Operacion_cliente();
            frm.lblSubMenu.Text = "Nuevo Cliente";
            frm.Operacion = "Insertar";
            frm.obtener_id_cliente();
            frm.ShowDialog();
            Listarclientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Lista_de_cliente.SelectedRows.Count > 0)
            {
                aux_id=Convert.ToInt32(Lista_de_cliente.CurrentRow.Cells["ID"].Value.ToString());
                if(aux_id != 1)
                {
                    Operacion_cliente frm = new Operacion_cliente();
                    frm.Operacion = "Editar";
                    frm.lblSubMenu.Text = "Editar Cliente";
                    frm.idclient = Lista_de_cliente.CurrentRow.Cells["ID"].Value.ToString();
                    frm.textCodigo.Text = Lista_de_cliente.CurrentRow.Cells["Codigo"].Value.ToString();
                    frm.textCedula.Text = Lista_de_cliente.CurrentRow.Cells["Cedula"].Value.ToString();
                    frm.textNombre.Text = Lista_de_cliente.CurrentRow.Cells["Nombre"].Value.ToString();
                    frm.textApellido.Text = Lista_de_cliente.CurrentRow.Cells["Apellido"].Value.ToString();
                    frm.textEdad.Text = Lista_de_cliente.CurrentRow.Cells["Edad"].Value.ToString();

                    frm.ShowDialog();
                    Listarclientes();
                }
                else
                {
                    MessageBox.Show("El Usuario Clientes varios no se puede editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista_de_cliente.SelectedRows.Count > 0)
            {
                aux_id = Convert.ToInt32(Lista_de_cliente.CurrentRow.Cells["ID"].Value.ToString());
                if (aux_id != 1)
                {
                    if (MessageBox.Show("¿Estas seguro de eliminar el cliente seleccionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            objcliente.Eliminar_Cliente(Convert.ToInt32(Lista_de_cliente.CurrentRow.Cells[0].Value));
                            MessageBox.Show("Se elimino correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Listarclientes();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se puede eliminar el cliente seleccionado porque esta relacionado a facturas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("El Usuario Clientes varios no se puede eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila para Eliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Lista_de_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Encabezado_listacliente_Click(object sender, EventArgs e)
        {

        }
    }
}
