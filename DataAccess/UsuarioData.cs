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
    public class UsuarioData : ConnectionToSql
    {
        private SqlDataReader LeerFilas;

        //ATRIBUTOS
        private int idusuario;
        private string username;
        private string password;
        private string email;
        private string privilegio;
        private int idempleado;

        public int Idusuario
        {
            get => idusuario;
            set => idusuario = value;
        }
        public string Username
        {
            get => username;
            set => username = value;
        }
        public string Password
        {
            get => password;
            set => password = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Privilegio
        {
            get => privilegio;
            set => privilegio = value;
        }
        public int Idempleado
        {
            get => idempleado;
            set => idempleado = value;
        }

        public DataTable ListarUsuario()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "listarUsuario";
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
                    command.CommandText = "listarempleado_user";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public void InsertarUsuario()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insertar_Usuario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@privilegio", privilegio); 
                    command.Parameters.AddWithValue("@idempleado", idempleado);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public void EditarUsuario()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Editar_Usuario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idusuario", idusuario);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@privilegio", privilegio);
                    command.Parameters.AddWithValue("@idempleado", idempleado);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public void EliminarUsuario()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Eliminar_Usuario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idusuario", idusuario);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

    }
}
