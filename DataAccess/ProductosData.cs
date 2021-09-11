using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ProductosData : ConnectionToSql
    {
        private SqlDataReader LeerFilas;

        //ATRIBUTOS
        private int idproducto;
        private int idcategoria;
        private string codigo;
        private string descripcion;
        private decimal precio;
        private decimal precioPromo;

        private string codigo_busqueda;
        private string descripcion_busqueda;
        private int idcategoria_busqueda;

        public int Idproducto
        {
            get => idproducto;
            set => idproducto = value;
        }
        public int Idcategoria
        {
            get => idcategoria;
            set => idcategoria = value;
        }
        public string Codigo
        {
            get => codigo;
            set => codigo = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        public decimal Precio
        {
            get => precio;
            set => precio = value;
        }
        public string Descripcion_busqueda
        {
            get => descripcion_busqueda;
            set => descripcion_busqueda = value;
        }
        public decimal PrecioPromo
        {
            get => precioPromo;
            set => precioPromo = value;
        }
        public string Codigo_busqueda
        {
            get => codigo_busqueda;
            set => codigo_busqueda = value;
        }
        public int Idcategoria_busqueda
        {
            get => idcategoria_busqueda;
            set => idcategoria_busqueda = value;
        }

        //Funcion para listar productos
        public DataTable Listarproductos()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "listarProductos";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }  
        }

        public DataTable Listarcategoria()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "listarcategoria";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public void InsertarProducto()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insertar_producto";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idcategoria", idcategoria);
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@precioU", precio);
                    command.Parameters.AddWithValue("@PrecioP", precioPromo);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public void EditarProducto()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Editar_producto";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idproducto", idproducto);
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@idcategoria", idcategoria);
                    command.Parameters.AddWithValue("@precioU", precio);
                    command.Parameters.AddWithValue("@PrecioP", precioPromo);                  
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public void EliminarProducto()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Eliminar_producto";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idproducto", idproducto);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        //Listar productos por nombre
        public DataTable ListarProducto_especificos()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Listar_Producto_especifico";
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

        //Listar productos por codigo
        public DataTable ListarProducto_x_codigo()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Listar_Producto_x_codigo";
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

        //Listar productos por categoria
        public DataTable ListarProducto_x_categoria()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Listar_producto_x_categoria";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idcategoria", Idcategoria_busqueda);
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public int obtener_idproducto()
        {
            int aux = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tbl_producto where idarticulo = (select MAX(idarticulo) from tbl_producto);";
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

    }
}
