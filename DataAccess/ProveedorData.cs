using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ProveedorData : ConnectionToSql
    {
        private SqlDataReader LeerFilas;

        //ATRIBUTOS
        private int idproveedor;
        private string codigo;
        private string nombre;
        private string telefono;
        private string direccion;
        private string email;

        public int Idproveedor
        {
            get => idproveedor;
            set => idproveedor = value;
        }
        public string Codigo
        {
            get => codigo;
            set => codigo = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Telefono
        {
            get => telefono;
            set => telefono = value;
        }
        public string Direccion
        {
            get => direccion;
            set => direccion = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }

        public DataTable Listarproveedor()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "listarProveedor";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public void InsertarProveedor()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insertar_proveedor";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@email", email);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public void EditarProveedor()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Editar_proveedor";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idproveedor", idproveedor);
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@email", email);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public void EliminarProveedor()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Eliminar_proveedor";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idproveedor", idproveedor);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public int obtener_idproveedor()
        {
            int aux = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tbl_proveedor where idproveedor = (select MAX(idproveedor) from tbl_proveedor);";
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
