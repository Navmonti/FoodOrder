using FoodOrder.Domain.Entities;
using FoodOrder.Domain.Repositories;
using FoodOrder.Application.DatabaseContext;

namespace FoodOrder.Application.ImplementRepository
{
    public  class RestaurantRepository : IRestaurantRepository
    {
        private readonly IFoodOrderDbContext _foodOrderDbContext;
        public RestaurantRepository(IFoodOrderDbContext foodOrderDbContext) =>
            _foodOrderDbContext = foodOrderDbContext;

        public Task Add(Restaurant entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Restaurant entity)
        {
            throw new NotImplementedException();
        }

        public Task<Restaurant> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Restaurant>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Restaurant entity)
        {
            throw new NotImplementedException();
        }
    }
}
