using FoodOrder.Domain.Entities;

namespace RestaurantOrder.Domain.Services
{
    public interface IRestaurantService
    {
        Task<Restaurant> CreateRestaurant(Restaurant model);
        Task<Restaurant> UpdateRestaurant(Restaurant model);
        Task<Restaurant> DeleteRestaurant(int restaurantId);
        Task<List<Restaurant>> GetAllRestaurant(Restaurant model);
        Task<Restaurant> GetByRestaurantId(int restaurantId);
    }
}
