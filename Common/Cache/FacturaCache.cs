using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class FacturaCache
    {
        //Datos Factura
        public static int idfactura { get; set; }
        public static string Codigo_factura { get; set; }
        public static string Fecha_Hora { get; set; }
        public static string Nombre_Empleado { get; set; }
        public static int idcliente { get; set; }
        public static string Codigo_cliente { get; set; }
        public static string Nombre_Cliente { get; set; }
        public static decimal tasa_de_cambio_dolar { get; set; }
        public static string tipo_cambio { get; set; }
        public static string estado { get; set; }
        public static string motivo { get; set; }
        public static decimal pago { get; set; }
        public static decimal vuelto { get; set; }
        public static decimal subtotal { get; set; }
        public static decimal total { get; set; }

        //Datos Detalle Factura
        public static int idproducto { get; set; }
        public static decimal precio_unitario { get; set; }
        public static decimal precio_promocion { get; set; }
        public static int stock { get; set; }

        //Nombre Temporal del producto
        public static string temp_nombre_producto { get; set; }

    }
}
