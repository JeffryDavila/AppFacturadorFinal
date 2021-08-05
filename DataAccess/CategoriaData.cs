using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class CategoriaData : ConnectionToSql
    {
        private SqlDataReader LeerFilas;

        //ATRIBUTOS
        private int idcategoria;
        private string codigo;
        private string nombre;

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
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
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
                    command.CommandText = "listarCategoria_form";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                }
                connection.Close();
                return Tabla;

            }
        }

        public void InsertarCategoria()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Insertar_categoria";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public void EditarCategoria()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Editar_categoria";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idcategoria", idcategoria);
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public void EliminarCategoria()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Eliminar_categoria";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idcategoria", idcategoria);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
                connection.Close();
            }
        }

        public int obtener_idcategoria()
        {
            int aux = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tbl_categoria where idcategoria = (select MAX(idcategoria) from tbl_categoria);";
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
