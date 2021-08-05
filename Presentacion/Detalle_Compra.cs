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
    public partial class Detalle_Compra : Form
    {
        ComprasModel objCompras = new ComprasModel();
        public decimal Monto;
        public decimal Monto_iva;
        public decimal Monto_subtotal;

        public decimal Subtotal;
        public decimal Total;
        public string estado;


        //VARIABLES PARA LA TASA DE CAMBIO
        decimal calculo_subtotal;
        decimal calculo_total;

        decimal calculo_subtotal_g; //para guardar el valor completo
        decimal calculo_total_g; //para guardar el valor completo

        decimal calculo_monto;

        //Variable para ayudar a la eliminacion de una linea pedido
        public decimal aux_monto;
        public decimal aux_precio;
        public decimal aux_cantidad;

        public Detalle_Compra()
        {
            InitializeComponent();
        }

        private void Detalle_Compra_Load(object sender, EventArgs e)
        {
            llenar_Datos();
            Listarproducto();
            radio_cordoba.Checked = true;
            lblsimbolo_subtotal.Text = "C$";
            lblsimbolo_total.Text = "C$";
        }

        private void brnCerrarSuperior_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar ventana?, Si lo haces la compra sera anulada", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                objCompras.Anular_Pedido(CompraCache.idcompra, "Anulada", "La compra fue cancelada por el usuario");
                Formulario_Principal ventana = Owner as Formulario_Principal;
                habilitar_botones(ventana);
                this.Close();
            }
        }

        public void Listarproducto()
        {
            FacturaModel objFact = new FacturaModel();
            cmbProducto.DataSource = objFact.Listar_Producto();
            cmbProducto.DisplayMember = "Fullproducto";
            cmbProducto.ValueMember = "idarticulo";
        }

        public void ListarLineaPedido()
        {
            ComprasModel objcompras = new ComprasModel();
            Lista_de_Lineapedido.DataSource = objCompras.Lista_de_LineaPedido();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        public void llenar_Datos()
        {
            objCompras.obtenerDatos_cabecera();
            textNumCompra.Text = CompraCache.Codigo_compra;
            textFecha.Text = CompraCache.Fecha;
            textNombreProvee.Text = CompraCache.Nombre_Proveedor;
            textNumProvee.Text = CompraCache.codigo_Proveedor;
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Operacion_producto frm = new Operacion_producto();
            frm.Operacion = "Insertar";
            frm.lblSubMenu.Text = "Nuevo Producto";
            frm.ListarCategoria();
            frm.obtener_id_producto();
            frm.ShowDialog();
            Listarproducto();
        }

        public void habilitar_botones(Formulario_Principal ventana)
        {
            if (UserLoginCache.UserPrivilegios == Cargos.Vendedor)
            {
                ventana.btnProducto.Enabled = true;
                ventana.btnFactura.Enabled = true;
                ventana.btnCliente.Enabled = true;
                ventana.btncategoria.Enabled = true;
                ventana.btnDatos_user.Enabled = true;
                ventana.btn_tasacambio.Enabled = true;
            }
            else if (UserLoginCache.UserPrivilegios == Cargos.Administrador)
            {
                ventana.btnProducto.Enabled = true;
                ventana.btnFactura.Enabled = true;
                ventana.btnCliente.Enabled = true;
                ventana.btnProveedor.Enabled = true;
                ventana.btnCompra.Enabled = true;
                ventana.btncategoria.Enabled = true;
                ventana.btnEmpleador.Enabled = true;
                ventana.btnUsuario.Enabled = true;
                ventana.btnDatos_user.Enabled = true;
                ventana.btn_tasacambio.Enabled = true;
            }
        }

        private void textBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComprasModel objcompra = new ComprasModel();
            if (textBusqueda.Text == "")
            {
                cmbProducto.DataSource = objcompra.Listar_Producto();
                cmbProducto.DisplayMember = "Fullproducto";
                cmbProducto.ValueMember = "idarticulo";
            }
            else
            {
                cmbProducto.DataSource = objcompra.Lista_de_producto_especifico(textBusqueda.Text);
                cmbProducto.DisplayMember = "Fullproducto";
                cmbProducto.ValueMember = "idarticulo";
            }           
            calcular_monto();
        }

        public void calcular_monto()
        {
            if (textCantidad.Text != "")
            {
                try
                {
                    Monto = Convert.ToDecimal(textCantidad.Text) * Convert.ToDecimal(textPrecioCompra.Text);
                    textMonto.Text = Convert.ToString(Monto);
                    Monto_subtotal = Monto;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Formato erroneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                textMonto.Text = "";
            }
        }

        public void calcular_monto_iva()
        {
            if (textCantidad.Text != "")
            {
                try
                {
                    Monto_iva = Convert.ToDecimal(textCantidad.Text) * Convert.ToDecimal(textPrecioIva.Text);
                    Monto = Convert.ToDecimal(textCantidad.Text) * Convert.ToDecimal(textPrecioCompra.Text);
                    textMonto.Text = Convert.ToString(Monto_iva);
                    Monto_subtotal = Monto;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Formato erroneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                textMonto.Text = "";
            }
        }

        private void cmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(textPrecioCompra.Text=="")
            {
                textPrecioCompra.Text = "0";
            }

            if (check_Iva.Checked == true)
            {
                decimal aux = Convert.ToDecimal(textPrecioCompra.Text) + (Convert.ToDecimal(textPrecioCompra.Text) * Convert.ToDecimal(text_Iva.Text));
                textPrecioIva.Text = Convert.ToString(aux);
                calcular_monto_iva();
            }
            else
            {
                calcular_monto();
            }
        }

        private bool campos_vacios()
        {
            if (textCantidad.Text == "" || textPrecioCompra.Text == "" || textMonto.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool campos_vacios_guardar()
        {
            if (text_subtotal.Text == "" || text_total.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void check_Iva_CheckedChanged(object sender, EventArgs e)
        {
            if (text_Iva.Visible == false)
            {
                text_Iva.Visible = true;
            }
            else
            {
                text_Iva.Visible = false;
            }

            if (check_Iva.Checked == true)
            {
                text_Iva.Text = "0,15";
                decimal aux = Convert.ToDecimal(textPrecioCompra.Text) + (Convert.ToDecimal(textPrecioCompra.Text) * Convert.ToDecimal(text_Iva.Text));
                textPrecioIva.Text = Convert.ToString(aux);
                calcular_monto_iva();
                textPrecioIva.Visible = true;
                lblprecio_iva.Visible = true;
            }
            else
            {
                text_Iva.Text = "0";
                textPrecioIva.Text = textPrecioCompra.Text;
                calcular_monto();
                textPrecioIva.Visible = false;
                lblprecio_iva.Visible = false;
            }
        }

        private void btnLineaPedido_Click(object sender, EventArgs e)
        {
            if (!campos_vacios())
            {
                try
                {
                    objCompras.Agregar_LineaPedido(Convert.ToDecimal(textCantidad.Text), Convert.ToDecimal(textPrecioCompra.Text), Convert.ToDecimal(text_Iva.Text),
                    Convert.ToDecimal(textMonto.Text), CompraCache.idcompra, Convert.ToInt32(cmbProducto.SelectedValue));
                    Subtotal += Monto_subtotal;
                    Total += Convert.ToDecimal(textMonto.Text);
                    text_subtotal.Text = Convert.ToString(Subtotal);
                    text_total.Text = Convert.ToString(Total);
                    MessageBox.Show("Producto agregado a pedido correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarLineaPedido();
                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Generic Exception Handler: {ex}");
                    MessageBox.Show("Error en el Formato de los precios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpiarFormulario()
        {
            textCantidad.Text = "";
            textMonto.Text = "";
            textPrecioCompra.Text = "0";
            textPrecioIva.Text = "0";
        }

        private void textCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void textCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (check_Iva.Checked == true)
            {
                try
                {
                    calculo_monto = Convert.ToDecimal(textPrecioCompra.Text) + (Convert.ToDecimal(textPrecioCompra.Text) * Convert.ToDecimal(text_Iva.Text));
                    textPrecioIva.Text = Convert.ToString(calculo_monto);
                    calcular_monto_iva();
                }
                catch(Exception Exception)
                {
                    MessageBox.Show("Campos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                calcular_monto();
            }
        }

        private void textPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void textPrecioCompra_KeyUp(object sender, KeyEventArgs e)
        {
            if (check_Iva.Checked == true)
            {
                try
                {
                    calculo_monto = Convert.ToDecimal(textPrecioCompra.Text) + (Convert.ToDecimal(textPrecioCompra.Text) * Convert.ToDecimal(text_Iva.Text));
                    textPrecioIva.Text = Convert.ToString(calculo_monto);
                    calcular_monto_iva();
                }
                catch (Exception Exception)
                {
                    MessageBox.Show("Campos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                calcular_monto();
            }
        }

        private void radio_cordoba_MouseClick(object sender, MouseEventArgs e)
        {
            lblsimbolo_subtotal.Text = "C$";
            lblsimbolo_total.Text = "C$";

            if (text_subtotal.Text != "" && text_total.Text != "")
            {
                //calculo_subtotal_g = calculo_subtotal * FacturaCache.tasa_de_cambio_dolar;
                //calculo_total_g = calculo_total * FacturaCache.tasa_de_cambio_dolar;
                //calculo_subtotal = Math.Round(calculo_subtotal_g, 2);
                //calculo_total = Math.Round(calculo_total_g, 2);
                text_subtotal.Text = Convert.ToString(Subtotal);
                text_total.Text = Convert.ToString(Total);
            }
        }

        private void radio_dolar_MouseClick(object sender, MouseEventArgs e)
        {
            lblsimbolo_subtotal.Text = "$";
            lblsimbolo_total.Text = "$";

            if (text_subtotal.Text != "" || text_total.Text != "")
            {
                calculo_subtotal_g = Subtotal / FacturaCache.tasa_de_cambio_dolar;
                calculo_total_g = Total / FacturaCache.tasa_de_cambio_dolar;
                calculo_subtotal = Math.Round(calculo_subtotal_g, 2);
                calculo_total = Math.Round(calculo_total_g, 2);
                text_subtotal.Text = Convert.ToString(calculo_subtotal);
                text_total.Text = Convert.ToString(calculo_total);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!campos_vacios_guardar())
            {
                Formulario_Principal ventana = Owner as Formulario_Principal;
                //Compras ventana_compras = new Compras();
                estado = "Pendiente";
                habilitar_botones(ventana);
                objCompras.Editar_pedido(CompraCache.idcompra, Convert.ToDecimal(text_subtotal.Text), Convert.ToDecimal(text_total.Text),estado,lblsimbolo_total.Text);
                MessageBox.Show("Cambios Realizados en la compra", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                //ventana.AbrirFormPanel(ventana_compras);
            }
            else
            {
                MessageBox.Show("Campos Subtotal o total vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista_de_Lineapedido.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estas seguro de eliminar el producto seleccionado de la compra?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                     aux_monto = Convert.ToDecimal(Lista_de_Lineapedido.CurrentRow.Cells[6].Value);// el monto va con el iva incluido
                     aux_cantidad = Convert.ToDecimal(Lista_de_Lineapedido.CurrentRow.Cells[3].Value);// cantidad de la linea compra seleccionado
                     aux_precio = Convert.ToDecimal(Lista_de_Lineapedido.CurrentRow.Cells[4].Value);// precio de la linea compra seleccionado

                    try
                    {
                        objCompras.Eliminar_Linea_Pedido(Convert.ToInt32(Lista_de_Lineapedido.CurrentRow.Cells[0].Value));
                        Subtotal -= (aux_precio * aux_cantidad);
                        Total -= aux_monto;
                        text_subtotal.Text = Convert.ToString(Subtotal);
                        text_total.Text = Convert.ToString(Total);
                        MessageBox.Show("Se elimino correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Al perecer a ocurrido un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ListarLineaPedido();
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila para Eliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




    }
}
