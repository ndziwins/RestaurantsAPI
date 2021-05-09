using RestaurantsAPI.Models;
using System.Collections.Generic;

namespace RestaurantsAPI.Services
{
    public interface IRestaurantService
    {
        int Create(CreateRestaurantDto dto);
        IEnumerable<RestaurantDto> GetAll();
        RestaurantDto GetById(int id);
        public void Delete(int id);
        public void Update(UpdateRestaurantDto dto, int id);
    }
}