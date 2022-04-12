using FiapWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Oracle.EntityFrameworkCore;
namespace FiapWebAPI.Repository.Context
    {
        public class DataBaseContext : DbContext
        {
            public DbSet<Remedio> Remedio { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                    optionsBuilder.UseOracle(config.GetConnectionString("FiapWebAPIConnection"));
                    //optionsBuilder.UseOracle(config.GetConnectionString("FiapSmartCityConnection"));
                }

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

            }

        }
}
