using ARSENAL_API_2.Core;
using Microsoft.EntityFrameworkCore;

namespace ARSENAL_API_2.Data
{
    public class ArsenalContext : DbContext
    {
        public ArsenalContext(DbContextOptions<ArsenalContext> ops): base (ops)
        {

            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Manager>() ;
            modelBuilder.Entity<Player>();

        }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Player> Players { get; set; }



    }
}
