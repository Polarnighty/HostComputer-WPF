using HostComputer.DataBase;
using HostComputer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.Service
{
    public class LoginService : BaseService
    {
        //public LoginService(SqlContext context) :base(context)
        //{

        //}
        public bool CheckLogin(string username, string password)
        {
            var user = context.userInfos.Where(u => u.UserName == username && u.Password == password).SingleOrDefault();
            if (user==null)
            {
                throw new Exception("用户名或密码错误");
            }
            if (!user.IsCanLogin)
            {
                throw new Exception("当前用户无权限使用此平台！");
            }
            return true;
        }


    }
}
