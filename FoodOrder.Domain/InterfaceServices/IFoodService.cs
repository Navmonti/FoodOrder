using FoodOrder.Domain.Entities;

namespace FoodOrder.Domain.Services
{
    public interface IFoodService
    {
        Task<Food> CreateFood(Food model);
        Task<Food> UpdateFood(Food model);
        Task<Food> DeleteFood(int foodId);
        Task<List<Food>> GetAllFood(Food model);
        Task<Food> GetByFoodId(int foodId);
    }
}
