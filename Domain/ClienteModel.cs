using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Domain
{
    public class ClienteModel
    {
        ClientesData cliente = new ClientesData();
        public DataTable Lista_de_cliente()
        {
            return cliente.Listarclientes();
        }

        public void Agregar_cliente(string codigo, string nombre, string apellido,string cedula, int edad)
        {
            cliente.Codigo = codigo;
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.Cedula = cedula;
            cliente.Edad = edad;
            cliente.InsertarCliente();
        }

        public void Editar_Cliente(int idcliente, string cedula, string nombre, string apellido, int edad)
        {
            cliente.Idcliente = idcliente;
            cliente.Cedula = cedula;
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.Edad = edad;
            cliente.EditarCliente();
        }

        public void Eliminar_Cliente(int idcliente)
        {
            cliente.Idcliente = idcliente;
            cliente.EliminarCliente();
        }

        public int obtenerIdCliente()
        {
            return cliente.obtener_idcliente();
        }

        public void Editar_cliente_varios(string nombre)
        {
            cliente.Nombre_temporal = nombre;
            cliente.Editar_cliente_varios();
        }
    }
}
