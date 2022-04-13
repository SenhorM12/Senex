using FiapWebAPI.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace FiapWebAPI.Repository.Context
{
    public class FiapContext : System.Data.Entity.DbContext
    {
        public FiapContext() : base("name-OracleConnectionString")
        {
            System.Data.Entity.Database.SetInitializer(new MigrateDatabaseToLatestVersion<FiapContext, Senex.Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("PF0954");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Idoso> Idoso { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Posologia> Posologia { get; set; }
        public DbSet<Remedio> Remedio { get; set; }
        public DbSet<User> User{ get; set; }


    }
}
