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
    public partial class Categoria : Form
    {
        CategoriaModel objCategoria = new CategoriaModel();
        public Categoria()
        {
            InitializeComponent();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            Listarcategoria();
            PermisosUsuario();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarInferior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PermisosUsuario()
        {
            if (UserLoginCache.UserPrivilegios == Cargos.Vendedor)
            {
                btnNuevoCategoria.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        public void Listarcategoria()
        {
            CategoriaModel objcategoria = new CategoriaModel();
            Lista_de_categoria.DataSource = objcategoria.Lista_de_categoria();
        }

        private void btnNuevoCategoria_Click(object sender, EventArgs e)
        {
            Operacion_categoria frm = new Operacion_categoria();
            frm.lblSubMenu.Text = "Nuevo Categoria";
            frm.Operacion = "Insertar";
            frm.obtener_id_categoria();
            frm.ShowDialog();
            Listarcategoria();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Lista_de_categoria.SelectedRows.Count > 0)
            {
                Operacion_categoria frm = new Operacion_categoria();
                frm.Operacion = "Editar";
                frm.lblSubMenu.Text = "Editar Categoria";
                frm.idCategoria = Lista_de_categoria.CurrentRow.Cells["ID"].Value.ToString();
                frm.textCodigo.Text = Lista_de_categoria.CurrentRow.Cells["Codigo"].Value.ToString();
                frm.textNombre.Text = Lista_de_categoria.CurrentRow.Cells["Nombre"].Value.ToString();

                frm.ShowDialog();
                Listarcategoria();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista_de_categoria.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estas seguro de eliminar el Categoria seleccionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        objCategoria.Eliminar_Categoria(Convert.ToInt32(Lista_de_categoria.CurrentRow.Cells[0].Value));
                        MessageBox.Show("Se elimino correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listarcategoria();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede eliminar por que la categoria seleccionado esta ligado algun producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
