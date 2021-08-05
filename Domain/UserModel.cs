using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        UserData userdata = new UserData();
        public bool LoginUser(string user,string pass)
        {
            return userdata.Login(user, pass);
        }

        public void AnyMethod()
        {
            if (UserLoginCache.UserPrivilegios == Cargos.Administrador)
            {
                //Codigo
            }
            if (UserLoginCache.UserPrivilegios == Cargos.Vendedor)
            {
                //Codigo

            }
        }

        public void Mostrar_DatosEmpleados(int idempleado)
        {
            userdata.MostrarEmpleado(idempleado);
        }


        public void cambiar_contraseña(int idusuario, string username, string email, string pass)
        {
            userdata.Idusuario = idusuario;
            userdata.Username = username;
            userdata.Password = pass;
            userdata.Email = email;
            userdata.cambiarContraseña();
            LoginUser(username, pass);
        }
    }
}
