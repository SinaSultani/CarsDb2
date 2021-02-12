using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CarsDb2
{
    public class CarContextFactory : IDesignTimeDbContextFactory<CarsDbContext>
    {
        public CarsDbContext CreateDbContext(string[] args = null)
        {
            var configuartion = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var optionsBuilder = new DbContextOptionsBuilder<CarsDbContext>();

            //optionsBuilder.UseSqlServer(configuartion["ConnectionStrings:DefaultConnection"]);
            optionsBuilder.UseSqlServer(configuartion.GetConnectionString("DefaultConnection"));

            return new CarsDbContext(optionsBuilder.Options);
        }
    }
}
