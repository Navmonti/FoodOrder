using FoodOrder.Application.DatabaseContext;
using FoodOrder.Domain.Entities;
using Microsoft.EntityFrameworkCore; 

namespace FoodOrder.Infrastructure.DatabaseContext
{
    public sealed class FoodOrderDbContext : DbContext, IFoodOrderDbContext
    {
        public FoodOrderDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
