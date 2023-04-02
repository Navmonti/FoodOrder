using FoodOrder.Domain.Entities;
using FoodOrder.Domain.Services;
using FoodOrder.Domain.UnitOfWork;

namespace FoodOrder.Application.ImplementServices
{
    public class FoodService : IFoodService
    {
        private readonly IUnitOfWork _unitOfwork;
        public FoodService(IUnitOfWork unitOfwork)
        {
            _unitOfwork = unitOfwork;
        }

        public Task<Food> CreateFood(Food model)
        {
            throw new NotImplementedException();
        }

        public Task<Food> DeleteFood(int foodId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Food>> GetAllFood(Food model)
        {
            throw new NotImplementedException();
        }

        public Task<Food> GetByFoodId(int foodId)
        {
            throw new NotImplementedException();
        }

        public Task<Food> UpdateFood(Food model)
        {
            throw new NotImplementedException();
        }
    }
}
