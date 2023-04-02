using FoodOrder.Domain.Entities;
using FoodOrder.Domain.Repositories;
using FoodOrder.Application.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace FoodOrder.Application.ImplementRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly IFoodOrderDbContext _context;
        private readonly DbSet<T> _entities;

        public GenericRepository(IFoodOrderDbContext context)
        {
            _context = context;
        }

        public async Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
