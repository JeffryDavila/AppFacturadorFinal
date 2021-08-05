using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Presentacion
{
    public partial class Productos : Form
    {
        ProductosModel objproducto = new ProductosModel();   
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            PermisosUsuario();
            ListarProductos();
        }

        public void ListarProductos()
        {
            ProductosModel objpro = new ProductosModel();
            Lista_de_producto.DataSource = objpro.Lista_de_productos();
        }

        private void PermisosUsuario()
        {
            if (UserLoginCache.UserPrivilegios == Cargos.Vendedor)
            {
                btnNuevoProducto.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lista_de_producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrarInferior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Encabezado_listaproducto_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Operacion_producto frm = new Operacion_producto();
            frm.Operacion = "Insertar";
            frm.lblSubMenu.Text = "Nuevo Producto";
            frm.ListarCategoria();
            frm.obtener_id_producto();
            frm.ShowDialog();
            ListarProductos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Lista_de_producto.SelectedRows.Count > 0)
            {           
                Operacion_producto frm = new Operacion_producto();
                frm.Operacion = "Editar";
                frm.ListarCategoria();
                frm.lblSubMenu.Text = "Editar Producto";
                frm.idprod = Lista_de_producto.CurrentRow.Cells["ID"].Value.ToString();
                frm.cmbCategoria.Text = Lista_de_producto.CurrentRow.Cells["Categoria"].Value.ToString();
                frm.textcodigoProducto.Text = Lista_de_producto.CurrentRow.Cells["Codigo"].Value.ToString();
                frm.textdescripcion.Text = Lista_de_producto.CurrentRow.Cells["Descripcion"].Value.ToString();
                frm.textPrecioU.Text = Lista_de_producto.CurrentRow.Cells["Precio"].Value.ToString();
                frm.textPrecioPromocion.Text = Lista_de_producto.CurrentRow.Cells["Precio Promocion"].Value.ToString();
                frm.ShowDialog();
                ListarProductos();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila","Atencion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(Lista_de_producto.SelectedRows.Count>0)
            {
                if (MessageBox.Show("¿Estas seguro de eliminar el producto seleccionado?", "Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        objproducto.Eliminar_Producto(Convert.ToInt32(Lista_de_producto.CurrentRow.Cells["ID"].Value));
                        MessageBox.Show("Se elimino correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarProductos();
                    }catch(Exception ex)
                    {
                        MessageBox.Show("No se puede eliminar por que el producto seleccionado esta ligado a varias facturas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }  
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila para Eliminar","Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }

        private void textBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProductosModel objpro = new ProductosModel();
            if (textBusqueda.Text=="")
            {
                Lista_de_producto.DataSource = objpro.Lista_de_productos();
            }
            else
            {
                Lista_de_producto.DataSource = objpro.Lista_de_producto_especifico(textBusqueda.Text);
            }
        }
    }
}
