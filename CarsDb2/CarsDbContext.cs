using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsDb2.Models;
using Microsoft.EntityFrameworkCore;

namespace CarsDb2
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options) { }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City
                {
                    Id = 3,
                    Name = "Malmö"
                }
                );
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer
                {
                    Id = 1,
                    Name = "Volvo"
                },
                new Manufacturer
                {
                    Id = 2,
                    Name = "Tesla"
                }
                );
            modelBuilder.Entity<CarDealer>().HasData(
                new CarDealer
                {
                    Id = 1,
                    Name = "Hedin Bil"
                },
                new CarDealer
                {
                    Id = 2,
                    Name = "Bosses Bilar"
                },
                new CarDealer
                {
                    Id = 3,
                    Name = "Bilia"
                },
                new CarDealer
                {
                    Id = 4,
                    Name = "Platinum Cars"
                });
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<CarDealer> CarDealers { get; set; }
    }
}
