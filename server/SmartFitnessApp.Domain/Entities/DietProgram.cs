namespace SmartFitnessApp.Domain.Entities
{
    public class DietProgram
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public required int UserId { get; set; }
        public required User User { get; set; }
        
        public ICollection<DietFood> DietFoods { get; set; } = [];

        public DietProgram() { }

        public DietProgram(string name)
        {
            Name = name;
        }
    }
}
