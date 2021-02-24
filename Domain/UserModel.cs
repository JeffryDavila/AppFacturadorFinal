using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        UserData userdata = new UserData();
        public bool LoginUser(string user,string pass)
        {
            return userdata.Login(user, pass);
        }

    }
}
