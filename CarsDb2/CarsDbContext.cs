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
            modelBuilder.Seed();
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<CarDealer> CarDealers { get; set; }
    }
}
