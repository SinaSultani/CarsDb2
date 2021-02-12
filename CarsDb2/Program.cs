using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CarsDb2.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CarsDb2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var factory = new CarContextFactory();
            //using var context = factory.CreateDbContext();


            //var city = new City { Name = "Stockholm" };
            //context.Cities.Add(city);
            //context.SaveChanges();

            //Console.WriteLine($"\tAdded ({JsonSerializer.Serialize(city)})");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
