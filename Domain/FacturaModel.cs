using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;
using Common.Cache;

namespace Domain
{
    public class FacturaModel
    {
        FacturaData factura = new FacturaData();

        public DataTable Lista_de_cliente()
        {
            return factura.Listarclientes();
        }

        public DataTable Lista_de_empleado(int idempleado)
        {
            factura.Idempleado = idempleado;
            return factura.ListarEmpleado();
        }

        public void Agregar_factura(string codigo, string fechafactura, int idcliente,int idempleado,int num_fact,string estado)
        {
            factura.Codigo = codigo;
            factura.Fechafactura = fechafactura;
            factura.Idcliente = idcliente;
            factura.Idempleado = idempleado;
            factura.Num_fact = num_fact;
            factura.Estado = estado;
            factura.InsertarFactura();
        }

        public int obtenerIdFactura()
        {
            return factura.obtener_idFactura();
        }

        public void Editar_factura(int idfactura, decimal subtotal,decimal total,decimal pago,decimal vuelto,string estado,string tipo_cambio)
        {
            factura.Idfactura = idfactura;
            factura.Subtotal = subtotal;
            factura.Total = total;
            factura.Pago = pago;
            factura.Vuelto = vuelto;
            factura.Estado = estado;
            factura.Tipo_cambio = tipo_cambio;
            factura.EditarFactura();
        }

        public DataTable Lista_Factura_Hoy()
        {
            return factura.Listar_FacturaHoy();
        }

        public int obtener_NumFact()
        {
            return factura.obtenerNumFact();
        }

        public void Anular_Factura(int idfactura, string estado, string motivo)
        {
            factura.Idfactura = idfactura;
            factura.Estado = estado;
            factura.Motivo = motivo;
            factura.AnularFactura();
        }

        public void Consultar_Factura(int idfactura)
        {
            factura.Idfactura = idfactura;
            factura.consulta_vista_factura();
        }

        public DataTable Mini_consulta_factura(int idfactura)
        {
            factura.Idfactura = idfactura;
            return factura.Mini_consulta_factura();
        }

        public DataTable Listar_FacturaFecha(string fecha)
        {
            factura.Fecha_select = fecha;
            return factura.Listar_FacturaFecha();
        }

        //DETALLE FACTURA--------------------------------------------------------------

        public void obtenerDatos_cabecera()
        {
            factura.Obtener_datos_cabecera_superior();
        }


        public DataTable Listar_Producto()
        {
            return factura.Listar_Producto();
        }

        public void obtenerPrecioStock()
        {
            factura.obtener_precio_stock();
        }

        public void Agregar_DetalleFactura(decimal cantidad, decimal precio,decimal iva,decimal monto,int idfactura,int idarticulo)
        {
            factura.Cantidad = cantidad;
            factura.Precio = precio;
            factura.Iva = iva;
            factura.Monto = monto;
            factura.Idfactura_llaveforanea = idfactura;
            factura.Idarticulo_llaveforanea = idarticulo;
            factura.Insertar_DetalleFactura();
        }

        public DataTable Lista_de_DetalleFactura()
        {
            return factura.Listar_DetalleFactura();
        }

        public DataTable Lista_de_producto_especifico(string descripcion)
        {
            factura.Descripcion_busqueda = descripcion;
            return factura.Listar_Producto_especificos();
        }

        public void Eliminar_Detalle_Factura(int iddetallefactura)
        {
            factura.Idetallefactura = iddetallefactura;
            factura.EliminarDetalleFactura();
        }

        public void obtener_articulo_cantidad(int idfactura)
        {
            factura.Idfactura = idfactura;
            factura.obtener_articulo_cantidad();
        }

        public void restar_articulo_stock()
        {
            foreach (Factura_stock comp in factura.list_producto)
            {
                factura.List_idarticulo = comp.s_idarticulo;
                factura.List_cantidad = Convert.ToInt32(comp.s_cantidad);
                factura.restar_articulo_stock();
                Console.WriteLine(comp.s_idarticulo + " " + comp.s_cantidad + "\n");
            }
            factura.list_producto.Clear();
        }

        public void sumar_articulo_stock()
        {
            foreach (Factura_stock comp in factura.list_producto)
            {
                factura.List_idarticulo = comp.s_idarticulo;
                factura.List_cantidad = Convert.ToInt32(comp.s_cantidad);
                factura.sumar_articulo_stock();
                Console.WriteLine(comp.s_idarticulo + " " + comp.s_cantidad + "\n");
            }
            factura.list_producto.Clear();
        }

        //Obtener el nombre del producto para mostrar en pantalla al momento de que este sobrepase el stock
        public void mostra_nombre_articulo(int idarticulo)
        {
            factura.Id_articulo_nombre = idarticulo;
            factura.Mostra_nombre_articulo();
        }

        //Factura completa-----------------------------------------------

        public DataTable Listar_Factura_completa(int idfactura)
        {
            factura.Idfactura = idfactura;
            return factura.Listar_Factura_completa();
        }

    }
}
