using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Domain
{
    public class EmpleadoModel
    {
        EmpleadosData empleado = new EmpleadosData();

        public DataTable Lista_de_empleado()
        {
            return empleado.Listarempleado();
        }

        public void Agregar_empleado(string codigo, string nombre, string apellido, string cedula, string telefono, string direccion)
        {
            empleado.Codigo = codigo;
            empleado.Nombre = nombre;
            empleado.Apellido = apellido;
            empleado.Cedula = cedula;
            empleado.Telefono = telefono;
            empleado.Direccion = direccion;
            empleado.InsertarEmpleado();
        }

        public void Editar_categoria(int idempleado,string codigo, string nombre, string apellido, string cedula, string telefono, string direccion)
        {
            empleado.Idempleado = idempleado;
            empleado.Codigo = codigo;
            empleado.Nombre = nombre;
            empleado.Apellido = apellido;
            empleado.Cedula = cedula;
            empleado.Telefono = telefono;
            empleado.Direccion = direccion;
            empleado.EditarEmpleado();
        }

        public void Eliminar_empleado(int idempleado)
        {
            empleado.Idempleado = idempleado;
            empleado.EliminarEmpleado();
        }

        public int obtenerIdCategoria()
        {
            return empleado.obtener_idEmpleado();
        }

    }
}
