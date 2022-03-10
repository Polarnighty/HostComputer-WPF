using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.Entity
{
    public class P_Modbus: BaseEntity
    {
        public Device device { get; set; }
        public int? deviceId { get; set; }
        public string ip { get; set; }
        public int port { get; set; }
        public int baudrate { get; set; }

    }
}
