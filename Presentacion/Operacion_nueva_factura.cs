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
    public partial class Operacion_nueva_factura : Form
    {
        FacturaModel objfact = new FacturaModel();
        ClienteModel objcliente = new ClienteModel();
        int Num_Fact=0;


        public Operacion_nueva_factura()
        {
            InitializeComponent();
        }


        private void Operacion_nueva_factura_Load(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void brnCerrarSuperior_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool combobox_vacios()
        {
            bool aux_c = false;
            bool aux_e = false;

            if (cmbCliente.Items.Count > 0)
            {
                aux_c = true;
            }
            else
            {
                aux_c = false;
            }

            if(cmbEmpleado.Items.Count > 0)
            {
                aux_e = true;
            }
            else
            {
                aux_e = false;
            }

            if(aux_c==aux_e)
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

            if (cmbCliente.SelectedIndex == 0)
            {
                objcliente.Editar_cliente_varios(textNombre_temporal.Text);
            }
           
            if(textNombre_temporal.Text == "" && textNombre_temporal.Visible==true)
            {
                MessageBox.Show("Cliente Varios Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else  if (!campos_vacios() && combobox_vacios())
            {
                Detalle_Factura detalle_fact = new Detalle_Factura();
                ventana.AddOwnedForm(detalle_fact);
                string fechahora = DateTime.Now.ToString("dd-MM-yy H:mm:ss");
                Num_Fact = objfact.obtener_NumFact();
                string estado = "No Facturada";
                //MessageBox.Show( "Num_Fact:" + Num_Fact , "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                objfact.Agregar_factura(textcodigoFactura.Text, fechahora, Convert.ToInt32(cmbCliente.SelectedValue), Convert.ToInt32(cmbEmpleado.SelectedValue), Num_Fact, estado);
                MessageBox.Show("La factura fue creada correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FacturaCache.idfactura = objfact.obtenerIdFactura();
                FacturaCache.Nombre_Empleado = cmbEmpleado.Text;
                //FacturaCache.Nombre_Cliente = cmbCliente.Text;
                Deshabilitar_botones(ventana);
                ventana.AbrirFormPanel(detalle_fact);
            }
            else
            {
                MessageBox.Show("Campos Vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void obtener_id_factura()
        {
            string cadena = "FAC00";
            int sumador = objfact.obtenerIdFactura();
            sumador += 1;
            textcodigoFactura.Text = cadena +""+ Convert.ToString(sumador);
        }

        public void Listarcliente()
        {
            FacturaModel objFact = new FacturaModel();
            cmbCliente.DataSource = objFact.Lista_de_cliente();
            cmbCliente.DisplayMember = "Fullname";
            cmbCliente.ValueMember = "idcliente";
        }

        public void ListarEmpleado()
        {
            FacturaModel objFact = new FacturaModel();
            cmbEmpleado.DataSource = objFact.Lista_de_empleado(UserLoginCache.User_idempleado);
            cmbEmpleado.DisplayMember = "Fullname";
            cmbEmpleado.ValueMember = "idempleado";
        }

        private bool campos_vacios()
        {
            if (textcodigoFactura.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblcategoria_Click(object sender, EventArgs e)
        {

        }

        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == 0)
            {
                textNombre_temporal.Visible = true;
            }
            else
            {
                textNombre_temporal.Visible = false;
            }

        }
    }
}
