using ARSENAL_API_2.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Emit;

namespace ARSENAL_API_2.Data
{
    public class PlayerContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data
            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1, ShirtNumber = 1, FirstName = "DAVID", LastName = "RAYA", Age = 25, Nationality = "SPAIN", Position = "GK", Photo = "raya.jpg" }
            );
        }
    }
}
