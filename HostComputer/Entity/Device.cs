using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.Entity
{
    public class Device :BaseEntity
    {
        public string Name { get; set; }
        public string SN { get; set; }
        public int CommType { get; set; }

    }
}
