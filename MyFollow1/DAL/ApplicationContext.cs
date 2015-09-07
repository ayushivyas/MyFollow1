using MyFollow1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MyFollow1.DAL
{
        public class ApplicationContext : DbContext
        {

            public ApplicationContext() : base("ApplicatiContext")
            {
            }

            public DbSet<EndUser> EndUsers { get; set; }
            public DbSet<AppOwner> AppOwners { get; set; }
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
    }
