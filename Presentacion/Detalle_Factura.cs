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
    public partial class Detalle_Factura : Form
    {
        FacturaModel objfactura = new FacturaModel();
        public decimal Monto;
        public decimal Monto_iva;
        public decimal Monto_subtotal;
        public decimal Subtotal;
        public string Iva;
        public string Descuento;
        public decimal Total;
        public decimal precio;
        public string estado;

        decimal comp_pago_dolar; //para el calculo de la tasa de cambio

        //Variable para ayudar a la eliminacion de un detalle factura
        public decimal aux_monto;
        public decimal aux_precio;
        public decimal aux_cantidad;

        //Esta lista nos servira para verificar el stock de los productos este en orden
        List<Verificacion_producto> lista_verificacion = new List<Verificacion_producto>();
        int acumulador_stock = 0;
        bool error_stock = false;// variable para verificar que no se venda mas de la cantidad del stock
        int id_articulo_temp; // obtener el id articulo temporal para poder mostrar el mensaje de error

        //variable para detectar si el total de la interfaz esta en 0
        decimal auxiliador;

        //contador de cantidad de productos en factura
        int contador_articulo=0;

        public Detalle_Factura()
        {
            InitializeComponent();
        }

        private void Detalle_Factura_Load(object sender, EventArgs e)
        {
            llenar_Datos();
            Listarproducto();
            radio_cordoba.Checked = true;
            lbl_simbolo.Text = "C$";
        }

        public void ListarDetalleFactura()
        {
            FacturaModel objfactura = new FacturaModel();
            Lista_de_detallefactura.DataSource = objfactura.Lista_de_DetalleFactura();
        }

        private void brnCerrarSuperior_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar la ventana?, Si lo haces la factura quedara anulada", "Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                objfactura.Anular_Factura(FacturaCache.idfactura, "Anulada", "La Factura fue cancelada por el usuario");
                Formulario_Principal ventana = Owner as Formulario_Principal;
                habilitar_botones(ventana);
                this.Close();
            }               
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSubMenu_Click(object sender, EventArgs e)
        {

        }

        private void check_Iva_CheckedChanged(object sender, EventArgs e)
        {
            if(text_Iva.Visible == false)
            {
                text_Iva.Visible = true;
            }
            else
            {
                text_Iva.Visible = false;
            }

            if(check_Iva.Checked==true)
            {
                
                text_Iva.Text = "0,15";
                decimal aux = Convert.ToDecimal(cmb_precios.Text) + (Convert.ToDecimal(cmb_precios.Text) * Convert.ToDecimal(text_Iva.Text));
                textPrecio.Text = Convert.ToString(aux);
                calcular_monto_iva();
                textPrecio.Visible = true;
                lblprecio_iva.Visible = true;
             
            }
            else
            {
                text_Iva.Text = "0";
                textPrecio.Text=Convert.ToString(FacturaCache.precio_unitario);
                calcular_monto();
                textPrecio.Visible = false;
                lblprecio_iva.Visible = false;
            }
            
        }

        private void check_Descuento_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        public void llenar_Datos()
        {
            objfactura.obtenerDatos_cabecera();
            textNumFactura.Text=FacturaCache.Codigo_factura;
            textFecha.Text = FacturaCache.Fecha_Hora;
            textEmpleado.Text = FacturaCache.Nombre_Empleado;
            textNombreCliente.Text = FacturaCache.Nombre_Cliente;
            textNumCliente.Text = FacturaCache.Codigo_cliente;
        }

        public void Listarproducto()
        {
            FacturaModel objFact = new FacturaModel();
            cmbProducto.DataSource = objFact.Listar_Producto();
            cmbProducto.DisplayMember = "Fullproducto";
            cmbProducto.ValueMember = "idarticulo";
            obtener_precio_producto();
        }

        public void obtener_precio_producto()
        {
            if (cmb_precios.Items.Count > 0)
            {
                cmb_precios.Items.Clear();
            }

            FacturaCache.idproducto = Convert.ToInt32(cmbProducto.SelectedValue);
            objfactura.obtenerPrecioStock();

            cmb_precios.Items.Add(FacturaCache.precio_unitario);
            cmb_precios.Items.Add(FacturaCache.precio_promocion);
            cmb_precios.SelectedIndex = 0;

            textPrecio.Text = Convert.ToString(FacturaCache.precio_unitario);
            textStock.Text = Convert.ToString(FacturaCache.stock);
        }

        private void cmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            obtener_precio_producto();

            if(check_Iva.Checked==true)
            {
                decimal aux = Convert.ToDecimal(cmb_precios.Text) + (Convert.ToDecimal(cmb_precios.Text) * Convert.ToDecimal(text_Iva.Text));
                textPrecio.Text = Convert.ToString(aux);
                calcular_monto_iva();
            }
            else
            {
                calcular_monto();
            }
           
        }

        private void cmb_precios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (check_Iva.Checked == true)
            {
                decimal aux = Convert.ToDecimal(cmb_precios.Text) + (Convert.ToDecimal(cmb_precios.Text) * Convert.ToDecimal(text_Iva.Text));
                textPrecio.Text = Convert.ToString(aux);
                calcular_monto_iva();
            }
            else
            {
                calcular_monto();
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProducto_Click(object sender, EventArgs e)
        {

        }

        private void cmbProducto_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void textCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void textPago_KeyPress(object sender, KeyPressEventArgs e)
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
            if(check_Iva.Checked==true)
            {
                decimal aux = Convert.ToDecimal(cmb_precios.Text) + (Convert.ToDecimal(cmb_precios.Text) * Convert.ToDecimal(text_Iva.Text));
                textPrecio.Text = Convert.ToString(aux);
                calcular_monto_iva();
            }
            else
            {
                calcular_monto();
            }
            
        }


        public void calcular_pago_vuelto()
        {
            if (textPago.Text != "" && text_total.Text != "")
            {
                decimal vuelto_aux;
                decimal comp_total = Convert.ToDecimal(text_total.Text);
                decimal comp_pago = Convert.ToDecimal(textPago.Text);

                if (radio_dolar.Checked == true)
                {
                    comp_pago_dolar = comp_pago * FacturaCache.tasa_de_cambio_dolar;
                    if (comp_pago_dolar >= comp_total)
                    {
                        vuelto_aux = comp_pago_dolar - Convert.ToDecimal(text_total.Text);
                        textVuelto.Text = Convert.ToString(vuelto_aux);
                    }
                    else
                    {
                        textVuelto.Text = "";
                    }
                }

                if (radio_cordoba.Checked == true)
                {
                    if (comp_pago >= comp_total)
                    {
                        vuelto_aux = Convert.ToDecimal(textPago.Text) - Convert.ToDecimal(text_total.Text);
                        textVuelto.Text = Convert.ToString(vuelto_aux);
                    }
                    else
                    {
                        textVuelto.Text = "";
                    }
                }
            }
            if (textPago.Text == "")
            {
                textVuelto.Text = "";
            }
        }

        private void textPago_KeyUp(object sender, KeyEventArgs e)
        {
            calcular_pago_vuelto();
        }

        public void calcular_monto()
        {
            if (textCantidad.Text != "")
            {
                try
                {
                    //Monto = Convert.ToDecimal(textCantidad.Text) * Convert.ToDecimal(textPrecio.Text);
                    Monto= Convert.ToDecimal(textCantidad.Text) * Convert.ToDecimal(cmb_precios.Text); 
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
                    Monto_iva = Convert.ToDecimal(textCantidad.Text) * Convert.ToDecimal(textPrecio.Text);
                    Monto = Convert.ToDecimal(textCantidad.Text) * Convert.ToDecimal(cmb_precios.Text);
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

        private bool campos_vacios()
        {
            if (textCantidad.Text == "" || textPrecio.Text == "" || textMonto.Text == "" || textStock.Text=="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool campos_vacios_pago()
        {
            if (textPago.Text == "" || text_total.Text == "" || textVuelto.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LimpiarFormulario()
        {
            textCantidad.Text = "";
            textMonto.Text = "";
            textPago.Text = "";
            textVuelto.Text = "";
        }

        private void text_Iva_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void text_Descuento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmbProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        public void verificacion_stock_completa(int idarticulo)
        {
            bool confirmar = false;// servira para confirmar si existe algun producto repetido
            acumulador_stock = Convert.ToInt32(textCantidad.Text);

            if (lista_verificacion.Count==0)
            {
                lista_verificacion.Add(new Verificacion_producto { v_idarticulo = idarticulo, v_stock = FacturaCache.stock, v_acumulador = acumulador_stock });
            }
            else
            {
                for (int i=0;i<lista_verificacion.Count;i++)
                {
                    if (lista_verificacion[i].v_idarticulo == idarticulo)
                    {
                        lista_verificacion[i].v_acumulador += acumulador_stock;
                        confirmar = true;
                    }

                    //codigo para ver si el acumulador supera al stock
                    if(lista_verificacion[i].v_acumulador> lista_verificacion[i].v_stock)
                    {
                        error_stock = true;
                        id_articulo_temp = lista_verificacion[i].v_idarticulo;
                    }

                }

                if(confirmar==false)
                {
                    lista_verificacion.Add(new Verificacion_producto { v_idarticulo = idarticulo, v_stock = FacturaCache.stock, v_acumulador = acumulador_stock });
                }
            }


        }

        public void borrar_en_verificacion_stock(int idarticulo,int cantidad)
        {
            bool confirmar = false;

            for (int i = 0; i < lista_verificacion.Count; i++)
            {
                if (lista_verificacion[i].v_idarticulo == idarticulo)
                {
                    lista_verificacion[i].v_acumulador -= cantidad;
                }

                //codigo para ver si el acumulador supera al stock
                if (lista_verificacion[i].v_acumulador > lista_verificacion[i].v_stock)
                {
                    error_stock = true;
                    confirmar = true;
                    id_articulo_temp = lista_verificacion[i].v_idarticulo;
                }
                else
                {
                    error_stock = false;
                }

            }

            if(confirmar==true)
            {
                error_stock = true;
            }
        }

        private void btnDetalleFactura_Click(object sender, EventArgs e)
        {
            if (!campos_vacios())
            {
                if(contador_articulo<15)
                {                
                  if(FacturaCache.stock == 0)
                  {
                      MessageBox.Show("El stock se encuentra en 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
                  else if(FacturaCache.stock >= Convert.ToInt32(textCantidad.Text))
                  {
                       objfactura.Agregar_DetalleFactura(Convert.ToDecimal(textCantidad.Text), Convert.ToDecimal(cmb_precios.SelectedItem), Convert.ToDecimal(text_Iva.Text),
                       Convert.ToDecimal(textMonto.Text), FacturaCache.idfactura, Convert.ToInt32(cmbProducto.SelectedValue));
                       Subtotal += Monto_subtotal;
                       Total += Convert.ToDecimal(textMonto.Text);
                       //Total = (Subtotal + Convert.ToDecimal(Iva))- Convert.ToDecimal(Descuento);
                       //Total = Subtotal;
                       text_subtotal.Text = Convert.ToString(Subtotal);
                       text_total.Text = Convert.ToString(Total);
                       MessageBox.Show("Producto agregado a factura correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       //codigo para mostrar la suma de los productos agregados a la factura por Jeffry
                       verificacion_stock_completa(Convert.ToInt32(cmbProducto.SelectedValue));
                       Console.WriteLine("Verificacion de linea stock");
                       foreach (Verificacion_producto ver_art in lista_verificacion)
                       {                     
                          Console.WriteLine(ver_art.v_idarticulo + " " + ver_art.v_stock + " " + ver_art.v_acumulador + "\n");
                       }
                       ListarDetalleFactura();
                       LimpiarFormulario();
                       contador_articulo++;
                       Console.WriteLine("la cantidad de productos en la factura es:" + contador_articulo);
                  }
                  else
                  {
                    MessageBox.Show("La cantidad digitada es mayor a la del stock actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
                }
                else
                {
                    MessageBox.Show("Ya no se puede agregar mas productos a la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Descuento_Iva_Click(object sender, EventArgs e)
        {
            Iva = text_Iva.Text;
            //Descuento = text_Descuento.Text;
            Iva_descuento_vacio();

            Total = (Subtotal + Convert.ToDecimal(Iva)) - Convert.ToDecimal(Descuento);
            text_total.Text = Convert.ToString(Total);
            MessageBox.Show("Iva o Descuento Actualizado", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Iva_descuento_vacio()
        {
            if (Iva == "")
            {
                Iva = "0";
            }

            if (Descuento == "")
            {
                Descuento = "0";
            }
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
                ventana.iconcerrar.Enabled = true;
            }
            else if(UserLoginCache.UserPrivilegios == Cargos.Administrador)
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
                ventana.iconcerrar.Enabled = true;
            }
        }

        public void buscar_x_nombre()
        {
            FacturaModel objFact = new FacturaModel();
            if (textBusqueda.Text == "")
            {
                cmbProducto.DataSource = objFact.Listar_Producto();
                cmbProducto.DisplayMember = "Fullproducto";
                cmbProducto.ValueMember = "idarticulo";
            }
            else
            {
                cmbProducto.DataSource = objFact.Lista_de_producto_especifico(textBusqueda.Text);
                cmbProducto.DisplayMember = "Fullproducto";
                cmbProducto.ValueMember = "idarticulo";
            }
            obtener_precio_producto();
            check_Iva.Checked = false;
            calcular_monto();
        }

        public void buscar_x_codigo()
        {
            FacturaModel objFact = new FacturaModel();
            if (textBusqueda.Text == "")
            {
                cmbProducto.DataSource = objFact.Listar_Producto();
                cmbProducto.DisplayMember = "Fullproducto";
                cmbProducto.ValueMember = "idarticulo";
            }
            else
            {
                cmbProducto.DataSource = objFact.Lista_de_producto_x_codigo(textBusqueda.Text);
                cmbProducto.DisplayMember = "Fullproducto";
                cmbProducto.ValueMember = "idarticulo";
            }
            obtener_precio_producto();
            check_Iva.Checked = false;
            calcular_monto();
        }

        private void textBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cmb_Opcion.SelectedIndex==0)
            {
                buscar_x_codigo();
            }
            else if (cmb_Opcion.SelectedIndex==1)
            {
                buscar_x_nombre();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista_de_detallefactura.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estas seguro de eliminar el producto de la factura seleccionada?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    aux_monto = Convert.ToDecimal(Lista_de_detallefactura.CurrentRow.Cells[6].Value);// el monto va con el iva incluido
                    aux_cantidad = Convert.ToDecimal(Lista_de_detallefactura.CurrentRow.Cells[3].Value);// cantidad del detalle factura seleccionado
                    aux_precio = Convert.ToDecimal(Lista_de_detallefactura.CurrentRow.Cells[4].Value);// precio del detalle factura seleccionado

                    try
                    {
                        objfactura.Eliminar_Detalle_Factura(Convert.ToInt32(Lista_de_detallefactura.CurrentRow.Cells[0].Value));
                        Subtotal -= (aux_precio * aux_cantidad);
                        Total -= aux_monto;
                        text_subtotal.Text = Convert.ToString(Subtotal);
                        text_total.Text = Convert.ToString(Total);
                        MessageBox.Show("Se elimino correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        borrar_en_verificacion_stock(Convert.ToInt32(Lista_de_detallefactura.CurrentRow.Cells[1].Value),Convert.ToInt32(aux_cantidad));
                        Console.WriteLine("Verificacion despues de eliminar-linea stock");
                        foreach (Verificacion_producto ver_art in lista_verificacion)
                        {
                            Console.WriteLine(ver_art.v_idarticulo + " " + ver_art.v_stock + " " + ver_art.v_acumulador + "\n");
                        }
                        contador_articulo--;
                        Console.WriteLine("la cantidad de productos en la factura es:" + contador_articulo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Al perecer a ocurrido un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LimpiarFormulario();
                    ListarDetalleFactura();
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila para Eliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblMonto_Click(object sender, EventArgs e)
        {

        }

        private void radio_cordoba_MouseClick(object sender, MouseEventArgs e)
        {
            textVuelto.Text = "";
            lbl_simbolo.Text = "C$";
            calcular_pago_vuelto();
        }

        private void radio_dolar_MouseClick(object sender, MouseEventArgs e)
        {
            textVuelto.Text = "";
            lbl_simbolo.Text = "$";
            calcular_pago_vuelto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            auxiliador = Convert.ToDecimal(text_total.Text);
            if (!campos_vacios_pago() && auxiliador>0)
            {
                if (MessageBox.Show("¿Estas seguro Finalizar la factura?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (error_stock == false)
                    {
                        if (radio_dolar.Checked == true)
                        {
                            textPago.Text = Convert.ToString(comp_pago_dolar);
                        }

                        Formulario_Principal ventana = Owner as Formulario_Principal;
                        Factura_Reporte hoja = new Factura_Reporte();
                        Iva_descuento_vacio();
                        estado = "Facturada";
                        habilitar_botones(ventana);
                        objfactura.Editar_factura(FacturaCache.idfactura, Subtotal, Total, Convert.ToDecimal(textPago.Text), Convert.ToDecimal(textVuelto.Text), estado, lbl_simbolo.Text);
                        MessageBox.Show("Factura ha sido completada con exito", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        objfactura.obtener_articulo_cantidad(FacturaCache.idfactura);
                        objfactura.restar_articulo_stock();
                        //ventana.Imagen_Fondo.BackColor = Color.White;
                        DataTable dt = objfactura.Listar_Factura_completa(FacturaCache.idfactura);
                        DataSet ds = new DataSet();
                        ds.Tables.Add(dt);
                        hoja.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                        hoja.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;//todo el ancho de pagina
                        ventana.AbrirFormPanel(hoja);
                        //ventana.Imagen_Fondo.BackColor = Color.FromArgb(45, 66, 105);
                    }
                    else
                    {
                        objfactura.mostra_nombre_articulo(id_articulo_temp);
                        MessageBox.Show(FacturaCache.temp_nombre_producto + " Elimine una linea de este producto, ya que la suma de sus lineas sobrepasa el stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Campos vacios o campos en cero. Revise campo pago,vuelto,subtotal o total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lista_de_detallefactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
