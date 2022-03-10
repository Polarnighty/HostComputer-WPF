using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.Entity
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RealName { get; set; }
        public string Avatar { get; set; }
        public bool IsCanLogin { get; set; }
    }

}
