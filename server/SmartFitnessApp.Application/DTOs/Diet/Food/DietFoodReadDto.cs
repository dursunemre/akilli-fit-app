using SmartFitnessApp.Domain.Entities;
using SmartFitnessApp.Application.DTOs.Diet.Program;

namespace SmartFitnessApp.Application.DTOs.Diet.Food
{
    public class DietFoodReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Amount { get; set; }
        public double TotalCalories;
        public double TotalProtein;
        public double TotalFat;
        public double TotalCarbohydrate;
        
        public int FoodId { get; set; }
        public required FoodReadDto Food { get; set; }
        public int DietProgramId { get; set; }
        public required DietProgramReadDto DietProgram { get; set; }
    }
}
