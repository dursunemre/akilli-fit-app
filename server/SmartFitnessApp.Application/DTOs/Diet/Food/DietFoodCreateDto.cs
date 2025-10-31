namespace SmartFitnessApp.Application.DTOs.Diet.Food
{
    public class DietFoodCreateDto
    {
        public int FoodId { get; set; }
        public double Amount { get; set; }
        public int DietProgramId { get; set; }
    }
}
