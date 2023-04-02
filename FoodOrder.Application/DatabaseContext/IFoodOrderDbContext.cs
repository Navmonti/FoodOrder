using FoodOrder.Domain.Entities;
using Microsoft.EntityFrameworkCore; 

namespace FoodOrder.Application.DatabaseContext
{
    public interface IFoodOrderDbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
