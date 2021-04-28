using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsAPI.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
        public bool HasDelivery { get; set; }
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }
        public virtual List<Dish> Dishes { get; set; }



    }
}
