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
    public partial class Operacion_nueva_Compra : Form
    {
        ComprasModel objcompra = new ComprasModel();
        public Operacion_nueva_Compra()
        {
            InitializeComponent();
        }

        private void brnCerrarSuperior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void Operacion_nueva_Compra_Load(object sender, EventArgs e)
        {

        }

        public void ListarProveedor()
        {
            ComprasModel objcompra = new ComprasModel();
            cmbProveedor.DataSource = objcompra.Listar_proveedor_compra();
            cmbProveedor.DisplayMember = "Proveedor";
            cmbProveedor.ValueMember = "ID";
        }


        public void obtener_id_compra()
        {
            string cadena = "COMP00";
            int sumador = objcompra.obtenerIdCompras();
            sumador += 1;
            textcodigoCompra.Text = cadena + "" + Convert.ToString(sumador);
        }

        private void textNombre_prov_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComprasModel objproveedor = new ComprasModel();
            if (textNombre_prov.Text == "")
            {
                cmbProveedor.DataSource = objproveedor.Listar_proveedor_compra();
                cmbProveedor.DisplayMember = "Proveedor";
                cmbProveedor.ValueMember = "ID";
            }
            else
            {
                cmbProveedor.DataSource = objproveedor.Lista_de_proveedor_especifico(textNombre_prov.Text);
                cmbProveedor.DisplayMember = "Proveedor";
                cmbProveedor.ValueMember = "ID";
            }
        }

        private bool campos_vacios()
        {
            if (textcodigoCompra.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Formulario_Principal ventana = Owner as Formulario_Principal;

            if(!campos_vacios())
            {
                Detalle_Compra detalle_comp = new Detalle_Compra();
                ventana.AddOwnedForm(detalle_comp);
                string fecha = DateTime.Now.ToString("dd-MM-yy");
                string estado = "Incompleta";
                objcompra.Agregar_compra(textcodigoCompra.Text,fecha, Convert.ToInt32(cmbProveedor.SelectedValue),estado);
                MessageBox.Show("La cotizacion de compra fue creada correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Deshabilitar_botones(ventana);
                CompraCache.idcompra = objcompra.obtenerIdCompras();
                ventana.AbrirFormPanel(detalle_comp);
            }

        }

        public void Deshabilitar_botones(Formulario_Principal ventana)
        {
            ventana.btnProducto.Enabled = false;
            ventana.btnFactura.Enabled = false;
            ventana.btnCliente.Enabled = false;
            ventana.btnProveedor.Enabled = false;
            ventana.btnCompra.Enabled = false;
            ventana.btncategoria.Enabled = false;
            ventana.btnEmpleador.Enabled = false;
            ventana.btnUsuario.Enabled = false;
            ventana.btnDatos_user.Enabled = false;
            ventana.btn_tasacambio.Enabled = false;
            ventana.iconcerrar.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(textNombre_prov.Visible==false)
            {
                textNombre_prov.Visible = true;
            }
            else
            {
                textNombre_prov.Visible = false;
            }
        }
    }
}
