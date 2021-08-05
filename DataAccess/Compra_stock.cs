using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    //con esta clase obtendremos tanto id articulo como la cantidad comprada
    public class Compra_stock
    {
        public int s_idarticulo { get; set; }
        public decimal s_cantidad { get; set; }
    }
}
