using FoodOrder.Domain.Repositories;
using FoodOrder.Domain.UnitOfWork;

namespace FoodOrder.Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IFoodRepository _foodRepo;
        private IRestaurantRepository _restaurantRepo;
         
        public IFoodRepository foodRepository { get; set; }
        public IRestaurantRepository restaurantRepository { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
