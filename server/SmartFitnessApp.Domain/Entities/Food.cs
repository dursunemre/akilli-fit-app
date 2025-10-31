namespace SmartFitnessApp.Domain.Entities
{
    public class Food
    {
        public int Id { get; set; }

        public required string Name { get; set; }
        public int CaloriesPer100g { get; set; }
        public double ProteinPer100g { get; set; }
        public double FatPer100g { get; set; }
        public double CarbohydratePer100g { get; set; }

        public ICollection<DietFood> DietFoods { get; set; } = [];

        public Food() { }

        public Food(string name, int caloriesPer100g, double proteinPer100g, double fatPer100g, double carbohydratePer100g)
        {
            Name = name;
            CaloriesPer100g = caloriesPer100g;
            ProteinPer100g = proteinPer100g;
            FatPer100g = fatPer100g;
            CarbohydratePer100g = carbohydratePer100g;
        }
    }
}
