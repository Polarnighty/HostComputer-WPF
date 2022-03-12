using HostComputer.Entity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace HostComputer.DataBase
{
    public class SqlContext : DbContext
    {
        public DbSet<UserInfo> userInfos { get; set; }
        public DbSet<Device> devices { get; set; }
        public DbSet<ProtocolS7> protocolS7 { get; set; }
        public DbSet<ProtocolModbusEnity> protocolModbus { get; set; }
        public DbSet<MonitorValue> monitorValues { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString);
        }


    }
}
