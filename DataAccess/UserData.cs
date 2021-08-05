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
    public class UserData : ConnectionToSql
    {
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

        public bool Login(string user,string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tbl_usuario where username=@user and password=@pass";
                    command.Parameters.AddWithValue("@user",user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.idusuario = reader.GetInt32(0);
                            UserLoginCache.UserName = reader.GetString(1);
                            UserLoginCache.password = reader.GetString(2);
                            UserLoginCache.UserEmail = reader.GetString(3);
                            UserLoginCache.UserPrivilegios = reader.GetString(4);
                            UserLoginCache.User_idempleado = reader.GetInt32(5);

                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public void AnyMethod()
        {
            if(UserLoginCache.UserPrivilegios == Cargos.Administrador)
            {
                //Codigo
            }
            if(UserLoginCache.UserPrivilegios == Cargos.Vendedor)
            {
                //Codigo
            }
        }

        public void MostrarEmpleado(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tbl_empleado where idempleado=@idempleado";
                    command.Parameters.AddWithValue("@idempleado", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.Nombre = reader.GetString(2);
                            UserLoginCache.Apellido = reader.GetString(3);
                            UserLoginCache.Cedula = reader.GetString(4);
                            UserLoginCache.Telefono = reader.GetString(5);
                            UserLoginCache.Direccion = reader.GetString(6);
                        }
                        
                    }
                }
            }
        }

        public void cambiarContraseña()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "cambiar_PassUser";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idusuario", idusuario);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }
    }
}
