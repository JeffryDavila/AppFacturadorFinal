using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Common.Cache;

namespace DataAccess
{
    public class ComprasData : ConnectionToSql
    {
        private SqlDataReader LeerFilas;

        //ATRIBUTOS COMPRAS
        private int idpedido;
        private string codigopedido;
        private string fechapedido;
        private decimal subtotal;
        private decimal total;
        private int idproveedor;
        private string estado;
        private string tipo_cambio;
        private string motivo;

        private string nombreproveedor;
        private string descripcion_busqueda;

        //ATRIBUTOS LINEA COMPRAS
        private int idlineapedido;
        private decimal cantidad;
        private decimal precio;
        private decimal iva;
        private decimal monto;
        private int idpedido_llaveforanea;
        private int idarticulo_llaveforanea;

        //Listas para obtener datos de detalle de las compras, tanto de idarticulo como del la cantidad
        public List<Compra_stock> list_producto = new List<Compra_stock>();
        private int list_idarticulo;
        private int list_cantidad;

        private string fecha_I;
        private string fecha_F;

        public int Idpedido
        {
            get => idpedido;
            set => idpedido = value;
        }
        public string Codigopedido
        {
            get => codigopedido;
            set => codigopedido = value;
        }
        public string Fechapedido
        {
            get => fechapedido;
            set => fechapedido = value;
        }
        public decimal Subtotal
        {
            get => subtotal;
            set => subtotal = value;
        }
        public decimal Total
        {
            get => total;
            set => total = value;
        }
        public string Nombreproveedor
        {
            get => nombreproveedor;
            set => nombreproveedor = value;
        }
        public int Idproveedor
        {
            get => idproveedor;
            set => idproveedor = value;
        }
        public string Estado
        {
            get => estado;
            set => estado = value;
        }
        public string Descripcion_busqueda
        {
            get => descripcion_busqueda;
            set => descripcion_busqueda = value;
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
        public decimal Iva
        {
            get => iva;
            set => iva = value;
        }
        public decimal Monto
        {
            get => monto;
            set => monto = value;
        }
        public int Idpedido_llaveforanea
        {
            get => idpedido_llaveforanea;
            set => idpedido_llaveforanea = value;
        }
        public int Idarticulo_llaveforanea
        {
            get => idarticulo_llaveforanea;
            set => idarticulo_llaveforanea = value;
        }
        public string Tipo_cambio
        {
            get => tipo_cambio;
            set => tipo_cambio = value;
        }

        public string Motivo
        {
            get => motivo;
            set => motivo = value;
        }
        public int List_idarticulo
        {
            get => list_idarticulo;
            set => list_idarticulo = value;
        }
        public int List_cantidad
        {
            get => list_cantidad;
            set => list_cantidad = value;
        }
        public int Idlineapedido
        {
            get => idlineapedido;
            set => idlineapedido = value;
        }
        public string Fecha_I
        {
            get => fecha_I;
            set => fecha_I = value;
        }
        public string Fecha_F
        {
            get => fecha_F;
            set => fecha_F = value;
        }

        public int obtener_idcompra()
        {
            int aux = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tbl_pedido where idpedido = (select MAX(idpedido) from tbl_pedido);";
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

        public DataTable ListarproveedorCompra()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Listar_ProveedorCompra";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public DataTable ListarproveedorCompra_especificos()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Listar_ProveedorCompra_especifico";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre", nombreproveedor);
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public void InsertarCompra()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insertar_compra";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigopedido);
                    command.Parameters.AddWithValue("@fecha", fechapedido);
                    command.Parameters.AddWithValue("@idproveedor",idproveedor);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }

        }

        public void EditarPedido()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Editar_Pedido";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idpedido", idpedido);
                    command.Parameters.AddWithValue("@subtotal", subtotal);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@tipo_cambio", tipo_cambio);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public DataTable Listar_Pedidos()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarPedidos";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public void ConfirmarPedido()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Confirmar_Pedido";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idpedido", idpedido);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public void AnularPedido()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Anular_Pedido";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idpedido", idpedido);
                    command.Parameters.AddWithValue("@estado", estado);
                    command.Parameters.AddWithValue("@motivo", motivo);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        //Con este procedimiento obtendermos una consulta de toda el pedido o compra
        public void consulta_vista_compra()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select tbl_pedido.idpedido, tbl_pedido.idlpedido, tbl_pedido.fechapedido,tbl_pedido.tipo_cambio, tbl_proveedor.nombreproveedor," +
                    "tbl_proveedor.telefono, tbl_proveedor.email,tbl_proveedor.direccion, tbl_pedido.estado, tbl_pedido.motivo, tbl_pedido.subtotal, tbl_pedido.total " +
                    "from tbl_pedido inner join tbl_lineapedido on tbl_pedido.idpedido=tbl_lineapedido.idpedido inner join tbl_proveedor on tbl_pedido.idproveedor = tbl_proveedor.idproveedor " +
                    "inner join tbl_producto on tbl_lineapedido.idarticulo = tbl_producto.idarticulo where tbl_pedido.idpedido = @idpedido;";
                    command.Parameters.AddWithValue("@idpedido", idpedido);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CompraCache.Codigo_compra = reader.GetString(1);
                            CompraCache.Fecha = Convert.ToString(reader.GetDateTime(2).ToString("dd/MM/yyyy"));
                            CompraCache.tipo_cambio = reader.GetString(3);
                            CompraCache.Nombre_Proveedor = reader.GetString(4);
                            CompraCache.telefono = reader.GetString(5);
                            CompraCache.email = reader.GetString(6);
                            CompraCache.direccion = reader.GetString(7);
                            CompraCache.estado = reader.GetString(8);
                            try
                            {
                                CompraCache.motivo = reader.GetString(9);
                            }
                            catch (Exception e)
                            {

                            }
                            CompraCache.subtotal = reader.GetDecimal(10);
                            CompraCache.total = reader.GetDecimal(11);

                        }

                    }
                }
                connection.Close();
            }
        }


        public DataTable Listar_Pedidos_Fecha()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarPedidos_Fecha";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@fecha", fechapedido);
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public DataTable Listar_Pedidos_Rango()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarPedidos_Rango";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@fecha_I", fecha_I);
                    command.Parameters.AddWithValue("@fecha_F", fecha_F);
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        //DETALLE COMPRA-------------------------------------------------------------------
        public void Obtener_datos_cabecera_superior()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tbl_pedido where idpedido=@idpedido";
                    command.Parameters.AddWithValue("@idpedido", CompraCache.idcompra);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CompraCache.Codigo_compra = reader.GetString(1);
                            CompraCache.Fecha= Convert.ToString(reader.GetDateTime(2).ToString("dd/MM/yyyy"));
                            CompraCache.idproveedor = reader.GetInt32(5);
                        }

                    }
                    reader.Close();
                    command.CommandText = "select * from tbl_proveedor where idproveedor=@idproveedor";
                    command.Parameters.AddWithValue("@idproveedor", CompraCache.idproveedor);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CompraCache.codigo_Proveedor = reader.GetString(1);
                            CompraCache.Nombre_Proveedor = reader.GetString(2);
                        }

                    }

                }
            }
        }


        //Reutilizamos codigo
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

        //Reutilizando codigo para mostrar producto especifico
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

        public void Insertar_LineaPedido()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insertar_LineaPedido";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@iva", iva);
                    command.Parameters.AddWithValue("@monto", monto);
                    command.Parameters.AddWithValue("@idpedido", idpedido_llaveforanea);
                    command.Parameters.AddWithValue("@idarticulo", idarticulo_llaveforanea);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }

        }

        public DataTable Listar_LineaPedido()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Listar_LineaPedido";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idpedido", CompraCache.idcompra);
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

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
                    command.CommandText = "select idarticulo,cantidadpedido from tbl_lineapedido where idpedido=@idpedido";
                    command.Parameters.AddWithValue("@idpedido", idpedido);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            list_producto.Add(new Compra_stock { s_idarticulo=reader.GetInt32(0), s_cantidad=reader.GetDecimal(1) });
                        }

                        foreach (Compra_stock comp in list_producto)
                        {
                            Console.WriteLine(comp.s_idarticulo  +" "+ comp.s_cantidad + "\n");
                        }
                    }

                }
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

        public void Eliminar_Linea_Factura()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Eliminar_Linea_Pedido";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idlineapedido", idlineapedido);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public DataTable Mini_consulta_compra()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Consultar_Compra_completa";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idpedido", idpedido);
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        //Mostrar Mini consulta para la ventana de mostrar detalle de las compras

        // FUNCION PARA LISTAR LAS COMPRAS COMPLETAS --------------------------------------------------------------
        public DataTable Listar_compra_completa()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Listar_compra_completa";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idpedido", idpedido);
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
