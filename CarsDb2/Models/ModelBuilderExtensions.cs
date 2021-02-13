using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarsDb2.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
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
                }
                );
            modelBuilder.Entity<Car>().HasData(
           new Car
           {
               Id = 1,
               Model = "V70",
               Motor = "2.0",
               EngineType = "Gas",
               Year = 2018,
               Price = 500000,
               ManufacturerId = 1,
               CarDealerId = 3

           }
           );
        }
        
    }
}
