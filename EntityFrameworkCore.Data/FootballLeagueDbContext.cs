using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Data
{
    public class FootballLeagueDbContext: DbContext
    {
        public FootballLeagueDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Combine(path, "FootballLeague_EFCore.db");
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public string DbPath { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}")
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
            //Do not enable sensitive data logging and detailed errors in production
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
