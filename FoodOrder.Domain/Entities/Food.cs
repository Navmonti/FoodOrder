using System.ComponentModel.DataAnnotations;

namespace FoodOrder.Domain.Entities
{
    public sealed class Food
    {
        [Key]
        public int FoodId { get; private set; }
        public string Name { get; private set; } = "";
    }
}
