namespace SmartFitnessApp.Application.DTOs.Diet.Food
{
    public class FoodCreateDto
    {
        public string Name { get; set; } = null!;
        public int CaloriesPer100g { get; set; }
        public double ProteinPer100g { get; set; }
        public double FatPer100g { get; set; }
        public double CarbohydratePer100g { get; set; }
    }
}
