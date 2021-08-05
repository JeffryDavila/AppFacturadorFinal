using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Presentacion
{
    public partial class Proveedores : Form
    {
        ProveedorModel objproveedor = new ProveedorModel();
        public Proveedores()
        {
            InitializeComponent();
        }
        public void ListarProveedores()
        {
            ProveedorModel objprov = new ProveedorModel();
            Lista_de_proveedor.DataSource = objprov.Lista_de_proveedor();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            ListarProveedores();
        }

        private void btnCerrarInferior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Operacion_proveedor frm = new Operacion_proveedor();
            frm.Operacion = "Insertar";
            frm.lblSubMenu.Text = "Nuevo Proveedor";
            frm.obtener_id_proveedor();
            frm.ShowDialog();
            ListarProveedores();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Lista_de_proveedor.SelectedRows.Count > 0)
            {
                Operacion_proveedor frm = new Operacion_proveedor();
                frm.Operacion = "Editar";
                frm.lblSubMenu.Text = "Editar Proveedor";
                frm.idprov = Lista_de_proveedor.CurrentRow.Cells["ID"].Value.ToString();
                frm.textCodigo.Text = Lista_de_proveedor.CurrentRow.Cells["Codigo"].Value.ToString();
                frm.textNombre.Text = Lista_de_proveedor.CurrentRow.Cells["Nombre"].Value.ToString();
                frm.textTelefono.Text = Lista_de_proveedor.CurrentRow.Cells["Telefono"].Value.ToString();
                frm.textDireccion.Text = Lista_de_proveedor.CurrentRow.Cells["Direccion"].Value.ToString();
                frm.textEmail.Text = Lista_de_proveedor.CurrentRow.Cells["Email"].Value.ToString();

                frm.ShowDialog();
                ListarProveedores();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista_de_proveedor.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estas seguro de eliminar el Proveedor seleccionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        objproveedor.Eliminar_Proveedor(Convert.ToInt32(Lista_de_proveedor.CurrentRow.Cells["ID"].Value));
                        MessageBox.Show("Se elimino correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarProveedores();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede eliminar por que el proveedor seleccionado esta ligado alguna compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
