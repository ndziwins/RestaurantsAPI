using RestaurantsAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantsAPI
{
    public class RestaurantSeeder
    {
        private readonly RestaurantDbContext _dbContext;
        public RestaurantSeeder(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Restaurants.Any())
                {
                    var restaurants = GetRestaurants();
                    _dbContext.Restaurants.AddRange(restaurants);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {
            new Restaurant()
            {
                Name = "Rest1",
                Category = "Cat1",
                Description = "Des1",
                ContactEmail = "contact@1.com",
                HasDelivery = true,
                Dishes = new List<Dish>()
                {
                    new Dish()
                    {
                        Name = "Dish1",
                        Price = 10.30M,
                    },

                    new Dish()
                    {
                        Name = "Dish2",
                        Price = 20.50M,
                    }
                },
                Address = new Address()
                {
                    City = "City1",
                    Street = "Street1",
                    PostalCode = "00-001"
                }
            },


            new Restaurant()
            {
                Name = "Rest2",
                Category = "Cat1",
                Description = "Des2",
                ContactEmail = "contact@2.com",
                HasDelivery = true,
                Dishes = new List<Dish>()
                {
                    new Dish()
                    {
                        Name = "Dish3",
                        Price = 33.30M,
                    },
                },
                Address = new Address()
                {
                    City = "City2",
                    Street = "Street1",
                    PostalCode = "01-001"
                }
            }
            
            };

        return restaurants;
    }

    }
}
