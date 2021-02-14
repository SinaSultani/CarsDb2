using System;
using System.Collections.Generic;
using System.Linq;
using CarsDb2.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
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
                },
                new Manufacturer
                {
                    Id = 3,
                    Name = "Ford"
                },
                new Manufacturer
                {
                    Id = 4,
                    Name = "BMW"
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

           },
           new Car
           {
                Id = 2,
               Model = "X",
               Motor = "Powertrain",
               EngineType = "Electric",
               Year = 2020,
               Price = 900000,
               ManufacturerId = 2,
               CarDealerId = 4

           },
           new Car
           {
               Id = 3,
               Model = "Mustang",
               Motor = "V8",
               EngineType = "Diesel",
               Year = 2016,
               Price = 800000,
               ManufacturerId = 3,
               CarDealerId = 2

           }
           );
        }
    }
}
