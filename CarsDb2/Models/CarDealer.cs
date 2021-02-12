using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarsDb2.Models
{
    public class CarDealer
    {

        public int Id { get; set; }

        public string Name { get; set; }


        //Foreign Key
        //public int CarId { get; set; }
        //public virtual Car Car { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
