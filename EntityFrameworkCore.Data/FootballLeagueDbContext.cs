using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Data
{
    public class FootballLeagueDbContext: DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source=FootballLeague_EFCore.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    TeamId = 1,
                    Name = "Orlando Pirates F.C.",
                    CreatedDated = new DateTime(2025,05,03)
                },
                new Team
                {
                    TeamId = 2,
                    Name = "Kaizer Chiefs F.C.",
                    CreatedDated = new DateTime(2025, 05, 03)
                },
                new Team
                {
                    TeamId = 3,
                    Name = "Mamelodi Sundowns F.C.",
                    CreatedDated = new DateTime(2025, 05, 03)
                },
                new Team
                {
                    TeamId = 4,
                    Name = "SuperSport United F.C.",
                    CreatedDated = new DateTime(2025, 05, 03)
                },
                new Team
                {
                    TeamId = 5,
                    Name = "Sekhukhune United F.C.",
                    CreatedDated = new DateTime(2025, 05, 03)
                },
                new Team
                {
                    TeamId = 6,
                    Name = "Stellenbosch F.C.",
                    CreatedDated = new DateTime(2025, 05, 03)
                }

            );
        }
    }
}
