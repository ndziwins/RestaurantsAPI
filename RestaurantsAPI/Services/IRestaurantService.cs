using RestaurantsAPI.Models;
using System.Collections.Generic;

namespace RestaurantsAPI.Services
{
    public interface IRestaurantService
    {
        int Create(CreateRestaurantDto dto);
        IEnumerable<RestaurantDto> GetAll();
        RestaurantDto GetById(int id);
        public bool Delete(int id);
        public bool Update(UpdateRestaurantDto dto, int id);
    }
}