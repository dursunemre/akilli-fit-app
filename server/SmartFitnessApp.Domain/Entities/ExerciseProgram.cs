namespace SmartFitnessApp.Domain.Entities
{
    public class ExerciseProgram
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public int UserId { get; set; }
        public required User User { get; set; }

        public ICollection<ExerciseInfo> ExerciseInfos { get; set; } = [];

        public ExerciseProgram() { }

        public ExerciseProgram(string name, User user)
        {
            Name = name;
            User = user;
        }
    }
}
