using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarsDb2.Models
{
    public class Car
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string Model { get; set; }
        public string Motor { get; set; }
        public string EngineType { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        //Foreign Key
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int CarDealerId { get; set; }
        public CarDealer Dealer { get; set; }

    }
}
