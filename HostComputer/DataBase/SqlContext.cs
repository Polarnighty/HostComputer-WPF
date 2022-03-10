using HostComputer.Entity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace HostComputer.DataBase
{
    public class SqlContext : DbContext
    {
        public DbSet<UserInfo> userInfos { get; set; }
        public DbSet<Device> devices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString);
        }


    }
}
