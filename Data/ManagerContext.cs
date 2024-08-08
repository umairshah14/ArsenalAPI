using ARSENAL_API_2.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Emit;

namespace ARSENAL_API_2.Data
{
    public class ManagerContext : DbContext
    {
        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options)
        {
        }

        public DbSet<Manager> Managers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data
            modelBuilder.Entity<Manager>().HasData(
                new Manager {Id=1, FirstName = "MIKEL", LastName = "ARTETA", Nationality = "SPAIN", StartDate="Sep 2019", Photo = "Arteta.jpg" },
                new Manager { Id = 2, FirstName = "MIKE", LastName = "ARTA", Nationality = "SPIN", StartDate = "Sep 2019", Photo = "Arteta.jpg" }

            );
        }
    }
}
