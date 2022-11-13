using Senex.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Senex.Repository.Context
{
    public class SenexContext : DbContext
    {
        public SenexContext() : base("name-OracleConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("RM86579");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Idoso> Idoso { get; set; }
        public DbSet<Remedio> Remedio { get; set; }
        public DbSet<User> User { get; set; }


    }
}
