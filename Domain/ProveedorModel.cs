using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Domain
{
    public class ProveedorModel
    {
        ProveedorData proveedor = new ProveedorData();
        public DataTable Lista_de_proveedor()
        {
            return proveedor.Listarproveedor();
        }

        public void Agregar_Proveedor(string codigo, string nombre, string telefono, string direccion, string email)
        {
            proveedor.Codigo = codigo;
            proveedor.Nombre = nombre;
            proveedor.Telefono = telefono;
            proveedor.Direccion = direccion;
            proveedor.Email = email;
            proveedor.InsertarProveedor();
        }

        public void Editar_Proveedor(int idproveedor,string codigo, string nombre, string telefono, string direccion, string email)
        {
            proveedor.Idproveedor = idproveedor;
            proveedor.Codigo = codigo;
            proveedor.Nombre = nombre;
            proveedor.Telefono = telefono;
            proveedor.Direccion = direccion;
            proveedor.Email = email;
            proveedor.EditarProveedor();
        }

        public void Eliminar_Proveedor(int idproveedor)
        {
            proveedor.Idproveedor = idproveedor;
            proveedor.EliminarProveedor();
        }

        public int obtenerIdProveedor()
        {
            return proveedor.obtener_idproveedor();
        }

    }
}
