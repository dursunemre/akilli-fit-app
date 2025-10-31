using SmartFitnessApp.Application.DTOs.Diet.Food;
using SmartFitnessApp.Application.DTOs.User;
using SmartFitnessApp.Domain.Entities;

namespace SmartFitnessApp.Application.DTOs.Diet.Program
{
    public class DietProgramReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public int UserId { get; set; }
        public required UserReadDto User { get; set; }
        public ICollection<DietFoodReadDto> DietFoods { get; set; } = [];
    }
}
