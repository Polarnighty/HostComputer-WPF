using HostComputer.Entity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace HostComputer.DataBase
{
    public class SqlContext:DbContext
    {
        public DbSet<UserInfo> userInfos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString);
        }

    }
}
