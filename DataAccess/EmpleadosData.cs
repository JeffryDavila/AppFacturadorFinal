using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class EmpleadosData : ConnectionToSql
    {
        private SqlDataReader LeerFilas;

        //ATRIBUTOS
        private int idempleado;
        private string codigo;
        private string nombre;
        private string apellido;
        private string cedula;
        private string telefono;
        private string direccion;

        public int Idempleado
        {
            get => idempleado;
            set => idempleado = value;
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
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public string Cedula
        {
            get => cedula;
            set => cedula = value;
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

        public DataTable Listarempleado()
        {
            DataTable Tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "listarEmpleado";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public void InsertarEmpleado()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insertar_Empleado";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public void EditarEmpleado()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Editar_Empleado";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idempleado", idempleado);
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public void EliminarEmpleado()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Eliminar_empleado";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idempleado", idempleado);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public int obtener_idEmpleado()
        {
            int aux = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tbl_empleado where idempleado = (select MAX(idempleado) from tbl_empleado);";
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
