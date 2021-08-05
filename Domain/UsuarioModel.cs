using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Domain
{
    public class UsuarioModel
    {
        UsuarioData usuario = new UsuarioData();
        public DataTable Lista_de_usuario()
        {
            return usuario.ListarUsuario();
        }

        public DataTable Lista_de_empleado()
        {
            return usuario.ListarEmpleado();
        }

        public void Agregar_Usuario(string username,string password,string email,string privilegio,int idempleado)
        {
            usuario.Username = username;
            usuario.Password = password;
            usuario.Email = email;
            usuario.Privilegio = privilegio;
            usuario.Idempleado = idempleado;
            usuario.InsertarUsuario();
        }

        public void Editar_Usuario(int idusuario, string email, string privilegio, int idempleado)
        {
            usuario.Idusuario = idusuario;
            usuario.Email = email;
            usuario.Privilegio = privilegio;
            usuario.Idempleado = idempleado;
            usuario.EditarUsuario();
        }

        public void Eliminar_Usuario(int idusuario)
        {
            usuario.Idusuario = idusuario;
            usuario.EliminarUsuario();
        }

    }
}
