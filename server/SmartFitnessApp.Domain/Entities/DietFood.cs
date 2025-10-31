namespace SmartFitnessApp.Domain.Entities
{
    public class DietFood
    {
        public int Id { get; set; }
        public string? Name => Food.Name;
        public double Amount { get; set; }

        public double TotalCalories { get { return Food.CaloriesPer100g * (Amount / 100.0); } }
        public double TotalProtein { get { return Food.ProteinPer100g * (Amount / 100.0); } }
        public double TotalFat { get { return Food.FatPer100g * (Amount / 100.0); } }
        public double TotalCarbohydrate { get { return Food.CarbohydratePer100g * (Amount / 100.0); } }

        public int FoodId { get; set; }
        public required Food Food { get; set; }
        public int DietProgramId { get; set; }
        public required DietProgram DietProgram { get; set; } 

        public DietFood() { }

        public DietFood(double amount, Food food, DietProgram dietProgram)
        {
            Amount = amount;
            Food = food;
            DietProgram = dietProgram;
        }
    }
}
