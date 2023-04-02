using System.ComponentModel.DataAnnotations;

namespace FoodOrder.Domain.Entities
{
    public sealed class Restaurant
    {
        [Key]
        public int RestaurantId { get; private set; }
        public string Name { get; private set; } = "";
    }
}
