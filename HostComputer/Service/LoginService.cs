using HostComputer.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.Service
{
    public class LoginService : BaseService
    {
        public LoginService(SqlContext context) :base(context)
        {

        }
        public bool CheckLogin(string username, string password)
        {

            return false;
            //return sqlServerAccess.CheckUserInfo(username, password);
        }


    }
}
