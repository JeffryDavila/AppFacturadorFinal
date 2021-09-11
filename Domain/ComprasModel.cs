using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Domain
{
    public class ComprasModel
    {
        ComprasData compras = new ComprasData();
        public List<Compra_stock> lista_stock = new List<Compra_stock>();

        public int obtenerIdCompras()
        {
            return compras.obtener_idcompra();
        }

        public DataTable Listar_proveedor_compra()
        {
            return compras.ListarproveedorCompra();
        }

        public DataTable Lista_de_proveedor_especifico(string nombre)
        {
            compras.Nombreproveedor = nombre;
            return compras.ListarproveedorCompra_especificos();
        }

        public DataTable Lista_de_proveedor_x_codigo(string codigo)
        {
            compras.Codigo_busqueda = codigo;
            return compras.Listar_Producto_x_codigo();
        }

        public void Agregar_compra(string codigo, string fecha, int idproveedor, string estado)
        {
            compras.Codigopedido = codigo;
            compras.Fechapedido = fecha;
            compras.Idproveedor = idproveedor;
            compras.Estado = estado;
            compras.InsertarCompra();
        }

        public void Editar_pedido(int idpedido, decimal subtotal, decimal total, string estado, string tipo_cambio)
        {
            compras.Idpedido = idpedido;
            compras.Subtotal = subtotal;
            compras.Total = total;
            compras.Estado = estado;
            compras.Tipo_cambio = tipo_cambio;
            compras.EditarPedido();
        }

        public DataTable Listar_pedidos()
        {
            return compras.Listar_Pedidos();
        }

        public void Confirmar_pedido(int idpedido)
        {
            compras.Idpedido = idpedido;
            compras.ConfirmarPedido();
        }

        public void Anular_Pedido(int idpedido, string estado, string motivo)
        {
            compras.Idpedido = idpedido;
            compras.Estado = estado;
            compras.Motivo = motivo;
            compras.AnularPedido();
        }

        public void Consultar_Compra(int idpedido)
        {
            compras.Idpedido = idpedido;
            compras.consulta_vista_compra();
        }

        public DataTable Listar_pedidos_Fecha(string fecha)
        {
            compras.Fechapedido = fecha;
            return compras.Listar_Pedidos_Fecha();
        }

        public DataTable Listar_pedidos_Rango(string fechaInicio,string fechaFin)
        {
            compras.Fecha_I = fechaInicio;
            compras.Fecha_F = fechaFin;
            return compras.Listar_Pedidos_Rango();
        }

        //DETALLE COMPRAS--------------------------------------------------
        public void obtenerDatos_cabecera()
        {
            compras.Obtener_datos_cabecera_superior();
        }

        //Reutilizamos Codigo para mostrar productos
        public DataTable Listar_Producto()
        {
            return compras.Listar_Producto();
        }

        //Reutilizando Codigo para mostrar productos especificos
        public DataTable Lista_de_producto_especifico(string descripcion)
        {
            compras.Descripcion_busqueda = descripcion;
            return compras.Listar_Producto_especificos();
        }

        public void Agregar_LineaPedido(decimal cantidad, decimal precio, decimal iva, decimal monto, int idpedido, int idarticulo)
        {
            compras.Cantidad = cantidad;
            compras.Precio = precio;
            compras.Iva = iva;
            compras.Monto = monto;
            compras.Idpedido_llaveforanea = idpedido;
            compras.Idarticulo_llaveforanea = idarticulo;
            compras.Insertar_LineaPedido();
        }

        public DataTable Lista_de_LineaPedido()
        {
            return compras.Listar_LineaPedido();
        }

        public void obtener_articulo_cantidad(int idpedido)
        {
            compras.Idpedido = idpedido;
            compras.obtener_articulo_cantidad();
        }

        public void sumar_articulo_stock()
        {
            foreach (Compra_stock comp in compras.list_producto)
            {
                compras.List_idarticulo = comp.s_idarticulo;
                compras.List_cantidad = Convert.ToInt32(comp.s_cantidad);
                compras.sumar_articulo_stock();
                Console.WriteLine(comp.s_idarticulo + " " + comp.s_cantidad + "\n");
            }
            compras.list_producto.Clear();
        }

        public void Eliminar_Linea_Pedido(int idlineapedido)
        {
            compras.Idlineapedido = idlineapedido;
            compras.Eliminar_Linea_Factura();
        }

        //Minis consulta prar mostrar detalle de compra
        public DataTable Mini_consulta_compra(int idpedido)
        {
            compras.Idpedido = idpedido;
            return compras.Mini_consulta_compra();
        }
        
        //Listar compra completa-----------------------------------------------
        public DataTable Listar_Compra_completa(int idpedido)
        {
            compras.Idpedido = idpedido;
            return compras.Listar_compra_completa();
        }

    }
}
