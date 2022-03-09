using HostComputer.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.Service
{
    public class DeviceService: BaseService
    {
        public DeviceService(SqlContext context) : base(context)
        {

        }
    }
}
