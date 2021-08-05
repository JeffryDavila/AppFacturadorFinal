using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class ClientesData : ConnectionToSql
    {
        private SqlDataReader LeerFilas;

        //ATRIBUTOS
        private int idcliente;
        private string codigo;
        private string cedula;
        private string nombre;
        private string apellido;
        private int edad;
        private string nombre_temporal;

        public int Idcliente
        {
            get => idcliente;
            set => idcliente = value;
        }
        public string Codigo
        {
            get => codigo;
            set => codigo = value;
        }
        public string Cedula
        {
            get => cedula;
            set => cedula = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public int Edad
        {
            get => edad;
            set => edad = value;
        }
        public string Nombre_temporal
        {
            get => nombre_temporal;
            set => nombre_temporal = value;
        }


        public DataTable Listarclientes()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "listarClientes";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public void InsertarCliente()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insertar_cliente";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public void EditarCliente()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Editar_cliente";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idcliente", idcliente);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public void EliminarCliente()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Eliminar_cliente";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idcliente", idcliente);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public int obtener_idcliente()
        {
            int aux = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tbl_cliente where idcliente = (select MAX(idcliente) from tbl_cliente);";
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

        public void Editar_cliente_varios()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Editar_cliente_varios";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Full_nombre", nombre_temporal);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

    }
}
