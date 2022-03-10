using HostComputer.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostComputer.Service
{
    public class BaseService
    {
        protected SqlContext context = new SqlContext();


    }
}
