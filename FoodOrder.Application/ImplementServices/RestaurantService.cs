using FoodOrder.Domain.Entities; 
using FoodOrder.Domain.UnitOfWork;
using RestaurantOrder.Domain.Services;

namespace FoodOrder.Application.ImplementServices
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IUnitOfWork _unitOfwork;
        public RestaurantService(IUnitOfWork unitOfwork)
        {
            _unitOfwork = unitOfwork;
        }

        public Task<Restaurant> CreateRestaurant(Restaurant model)
        {
            throw new NotImplementedException();
        }

        public Task<Restaurant> DeleteRestaurant(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Restaurant>> GetAllRestaurant(Restaurant model)
        {
            throw new NotImplementedException();
        }

        public Task<Restaurant> GetByRestaurantId(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public Task<Restaurant> UpdateRestaurant(Restaurant model)
        {
            throw new NotImplementedException();
        }
    }
}
