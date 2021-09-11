using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess
{
    public class FacturaData : ConnectionToSql
    {
        private SqlDataReader LeerFilas;

        //ATRIBUTOS FACTURA
        private int idfactura;
        private string codigo;
        private string fechafactura;
        private decimal subtotal;
        private decimal iva;
        private decimal precioPromo;
        private decimal total;
        private int idcliente;
        private int idempleado;
        private int num_fact;       

        private decimal pago;
        private decimal vuelto;
        private string estado;
        private string motivo;
        private string tipo_cambio;

        //ATRIBUTOS DETALLE FACTURA

        private int idetallefactura;
        private decimal cantidad;
        private decimal precio;
        private decimal monto;
        private int idfactura_llaveforanea;
        private int idarticulo_llaveforanea;

        private string descripcion_busqueda;
        private string codigo_busqueda;

        //Lista para obtener la cantidad de productos en las facturas
        public List<Factura_stock> list_producto = new List<Factura_stock>();
        private int list_idarticulo;
        private int list_cantidad;

        //Fecha especifica para buscar facturas de ese dia
        private string fecha_select;

        //Id del articulo para encontrar su nombre
        private int id_articulo_nombre;

        public int Idfactura
        {
            get => idfactura;
            set => idfactura = value;
        }
        public string Codigo
        {
            get => codigo;
            set => codigo = value;
        }
        public string Fechafactura
        {
            get => fechafactura;
            set => fechafactura = value;
        }
        public decimal Subtotal
        {
            get => subtotal;
            set => subtotal = value;
        }
        public decimal Iva
        {
            get => iva;
            set => iva = value;
        }
        public decimal PrecioPromo
        {
            get => precioPromo;
            set => precioPromo = value;
        }

        public decimal Total
        {
            get => total;
            set => total = value;
        }
        public int Idcliente
        {
            get => idcliente;
            set => idcliente = value;
        }
        public int Idempleado
        {
            get => idempleado;
            set => idempleado = value;
        }
        public int Idetallefactura
        {
            get => idetallefactura;
            set => idetallefactura = value;
        }
        public decimal Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }
        public decimal Precio
        {
            get => precio;
            set => precio = value;
        }
        public decimal Monto
        {
            get => monto;
            set => monto = value;
        }
        public int Idfactura_llaveforanea
        {
            get => idfactura_llaveforanea;
            set => idfactura_llaveforanea = value;
        }
        public int Idarticulo_llaveforanea
        {
            get => idarticulo_llaveforanea;
            set => idarticulo_llaveforanea = value;
        }
        public string Descripcion_busqueda
        {
            get => descripcion_busqueda;
            set => descripcion_busqueda = value;
        }
        public int Num_fact
        {
            get => num_fact;
            set => num_fact = value;
        }
        public decimal Pago
        {
            get => pago;
            set => pago = value;
        }
        public decimal Vuelto
        {
            get => vuelto;
            set => vuelto = value;
        }
        public string Estado
        {
            get => estado;
            set => estado = value;
        }
        public string Tipo_cambio
        {
            get => tipo_cambio;
            set => tipo_cambio = value;
        }
        public int List_idarticulo
        {
            get => list_idarticulo; set => list_idarticulo = value;
        }
        public int List_cantidad
        {
            get => list_cantidad; set => list_cantidad = value;
        }
        public string Motivo
        {
            get => motivo;
            set => motivo = value;
        }
        public string Fecha_select
        {
            get => fecha_select;
            set => fecha_select = value;
        }
        public int Id_articulo_nombre
        {
            get => id_articulo_nombre;
            set => id_articulo_nombre = value;
        }
        public string Codigo_busqueda
        {
            get => codigo_busqueda;
            set => codigo_busqueda = value;
        }

        //-----FUNCIONES FACTURA-----------------------------------------

        public DataTable Listarclientes()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "listarCliente_newFactura";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public DataTable ListarEmpleado()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "listarEmpleado_newFactura";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idempleado", idempleado);
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public void InsertarFactura()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insertar_Factura";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@fecha", fechafactura);
                    command.Parameters.AddWithValue("@idcliente", idcliente);
                    command.Parameters.AddWithValue("@idempleado", idempleado);
                    command.Parameters.AddWithValue("@num_fact", num_fact);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }

        }

        public int obtener_idFactura()
        {
            int aux=0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tbl_factura where idfactura = (select MAX(idfactura) from tbl_factura);";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            aux = reader.GetInt32(0);
                        }
                        return aux;
                    }
                    else
                    {
                        return 0;
                    }

                }
            }
        }

        public void EditarFactura()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Editar_Factura";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idfactura", idfactura);
                    command.Parameters.AddWithValue("@subtotal", subtotal);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@pago", pago);
                    command.Parameters.AddWithValue("@vuelto", vuelto);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@tipo_cambio", tipo_cambio);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public DataTable Listar_FacturaHoy()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarFactura_Hoy";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public int obtenerNumFact()
        {
            int aux = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT NEXT VALUE FOR [dbo].seq_NumFact";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                           aux = reader.GetInt32(0);                          
                        }
                        return aux;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        public void AnularFactura()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Anular_Factura";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idfactura", idfactura);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@motivo", motivo);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        //Con este procedimiento obtendermos una consulta de toda la factura
        public void consulta_vista_factura()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select tbl_factura.idfactura,tbl_factura.idlfactura,tbl_factura.fechafactura,(tbl_empleado.nombreempleado+' '+tbl_empleado.apellidoempleado) as empleado,"+
                    "(tbl_cliente.nombre + ' ' + tbl_cliente.apellido) as cliente,tbl_factura.tipo_cambio,tbl_factura.estado,tbl_factura.motivo,tbl_factura.pago,tbl_factura.vuelto," +
                    "tbl_factura.subtotal,tbl_factura.total from tbl_factura "+
                    "inner join tbl_empleado on tbl_factura.idempleado = tbl_empleado.idempleado inner join tbl_cliente on " +
                    "tbl_factura.idcliente = tbl_cliente.idcliente where tbl_factura.idfactura = @idfactura;";
                    command.Parameters.AddWithValue("@idfactura", idfactura);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            FacturaCache.Codigo_factura = reader.GetString(1);
                            FacturaCache.Fecha_Hora = Convert.ToString(reader.GetDateTime(2));
                            FacturaCache.Nombre_Empleado = reader.GetString(3);
                            FacturaCache.Nombre_Cliente = reader.GetString(4);
                            FacturaCache.tipo_cambio = reader.GetString(5);
                            FacturaCache.estado = reader.GetString(6);
                            try
                            {
                                FacturaCache.motivo = reader.GetString(7);
                            }
                            catch(Exception e)
                            {

                            }                           
                            FacturaCache.pago = reader.GetDecimal(8);
                            FacturaCache.vuelto = reader.GetDecimal(9);
                            FacturaCache.subtotal = reader.GetDecimal(10);
                            FacturaCache.total = reader.GetDecimal(11);
                        }

                    }
                }
                connection.Close();
            }
        }

        // Mini consulta para ver el detalle de la factura seleccionada
        public DataTable Mini_consulta_factura()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Consultar_factura_completa";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idfactura", idfactura);
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        //Listra facturas con fecha especifica
        public DataTable Listar_FacturaFecha()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarFactura_Fecha_especifica";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@fecha",fecha_select);
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        //DETALLE FACTURA-------------------------------------------

        public void Obtener_datos_cabecera_superior()
        {
            
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tbl_factura where idfactura=@idfactura";
                    command.Parameters.AddWithValue("@idfactura", FacturaCache.idfactura);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            FacturaCache.Codigo_factura = reader.GetString(1);
                            FacturaCache.Fecha_Hora = Convert.ToString(reader.GetDateTime(2));
                            FacturaCache.idcliente = reader.GetInt32(5);                     
                        }
                        
                    }
                    reader.Close();
                    command.CommandText = "select idcliente,idlcliente,(nombre+' '+apellido) as 'Full Nombre' from tbl_cliente where idcliente=@idcliente";
                    command.Parameters.AddWithValue("@idcliente", FacturaCache.idcliente);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            FacturaCache.Codigo_cliente = reader.GetString(1);
                            FacturaCache.Nombre_Cliente = reader.GetString(2);
                        }

                    }

                }
            }
        }

        public DataTable Listar_Producto()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "listarProducto_Factura";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        //Obtener los precios unitario y promocion y el stock de ese producto
        public void obtener_precio_stock()
        {   
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select precioUnidad,precioPromocion,cantidad from tbl_producto where idarticulo=@idarticulo";
                    command.Parameters.AddWithValue("@idarticulo", FacturaCache.idproducto);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            FacturaCache.precio_unitario = reader.GetDecimal(0);
                            FacturaCache.precio_promocion = reader.GetDecimal(1);
                            FacturaCache.stock = reader.GetInt32(2);
                        }

                    }
                }
            }
        }

        public void Insertar_DetalleFactura()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insertar_DetalleFactura";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@iva", iva);
                    command.Parameters.AddWithValue("@monto", monto);
                    command.Parameters.AddWithValue("@idfactura", idfactura_llaveforanea);
                    command.Parameters.AddWithValue("@idarticulo", idarticulo_llaveforanea);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }

        }

        public DataTable Listar_DetalleFactura()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Listar_DetalleFactura";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idfactura", FacturaCache.idfactura);
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public DataTable Listar_Producto_especificos()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "listarProducto_Factura_especifico";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@descripcion", descripcion_busqueda);
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public DataTable Listar_Producto_x_codigo()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "listarProducto_Factura_x_codigo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo_busqueda);
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public void EliminarDetalleFactura()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Eliminar_Detalle_Factura";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idfacturadetalle", idetallefactura);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public void obtener_articulo_cantidad()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select idarticulo,cantidad from tbl_detallefactura where idfactura=@idfactura";
                    command.Parameters.AddWithValue("@idfactura", idfactura);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            list_producto.Add(new Factura_stock { s_idarticulo = reader.GetInt32(0), s_cantidad = reader.GetDecimal(1) });
                        }

                        foreach (Factura_stock fact in list_producto)
                        {
                            Console.WriteLine(fact.s_idarticulo + " " + fact.s_cantidad + "\n");
                        }
                    }

                }
            }
        }

        public void restar_articulo_stock()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Restar_stock_producto";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idarticulo", list_idarticulo);
                    command.Parameters.AddWithValue("@cantidad", list_cantidad);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public void sumar_articulo_stock()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Sumar_stock_producto";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idarticulo", list_idarticulo);
                    command.Parameters.AddWithValue("@cantidad", list_cantidad);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        //Mostrar Nombre de prodcuto determinado-------
        public void Mostra_nombre_articulo()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select descripcion from tbl_producto where idarticulo=@idarticulo";
                    command.Parameters.AddWithValue("@idarticulo", id_articulo_nombre);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            FacturaCache.temp_nombre_producto = reader.GetString(0);
                        }

                    }
                }
            }
        }

        //Limpiar nombre del cliente varios
        public void Limpiar_Nombre_Temporal()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Limpiar_nombre_temporal";
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        //Factura Completa-------------------------------------------------------------------

        public DataTable Listar_Factura_completa()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Listar_Factura_completa";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idfactura", idfactura);
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }


    }
}
