using FoodOrder.Domain.Entities;
using FoodOrder.Domain.Repositories;
using FoodOrder.Application.DatabaseContext;

namespace FoodOrder.Application.ImplementRepository
{
    internal class FoodRepository : IFoodRepository
    {
        private readonly IFoodOrderDbContext _context;
        public FoodRepository(IFoodOrderDbContext context)
        {
            _context = context;
        }

        public async Task<Food> AddAsync(Food entity)
        {
            return await _context.Foods.AddAsync(entity);
        }

        public void Delete(Food entity)
        {
            throw new NotImplementedException();
        }

        public Task<Food> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Food>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Food entity)
        {
            throw new NotImplementedException();
        }
    }
}
