using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.Entity
{
    public class MonitorValue:BaseEntity
    {
        public string ValueId { get; set; }
        public string ValueName { get; set; }
        public string Address { get; set; }
        public string DataType { get; set; }
        public string Unit { get; set; }
        public Device Device { get; set; }
        public int DeviceId { get; set; }
    }
}
