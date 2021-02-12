using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarsDb2.Models
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<CarDealer> CarDealers { get; set; }
    }
}
