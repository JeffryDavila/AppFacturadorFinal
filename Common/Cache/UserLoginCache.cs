using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        //Datos usuarios
        public static int idusuario { get; set; }
        public static string UserName  { get; set; }
        public static string password { get; set; }
        public static string UserEmail { get; set; }
        public static string UserPrivilegios { get; set; }
        public static int User_idempleado { get; set; }

        //Datos Empleados
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Cedula { get; set; }
        public static string Telefono { get; set; }
        public static string Direccion { get; set; }

    }
}
