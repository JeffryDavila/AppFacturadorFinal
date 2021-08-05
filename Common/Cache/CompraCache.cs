using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class CompraCache
    {
        //Datos Compra
        public static int idcompra { get; set; }
        public static string Codigo_compra { get; set; }
        public static string Fecha { get; set; }

        public static int idproveedor { get; set; }
        public static string codigo_Proveedor { get; set; }
        public static string Nombre_Proveedor { get; set; }
        public static string tipo_cambio { get; set; }
        public static string telefono { get; set; }
        public static string email { get; set; }
        public static string direccion { get; set; }
        public static string estado { get; set; }
        public static string motivo { get; set; }
        public static decimal subtotal { get; set; }
        public static decimal total { get; set; }

        //Variable para obtener id articulo y cantidad de pedido
        public static int aux_idcompra { get; set; }
        public static decimal aux_cantidad { get; set; }

    }
}
