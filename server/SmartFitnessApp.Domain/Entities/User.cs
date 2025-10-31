using System.ComponentModel.DataAnnotations;

namespace SmartFitnessApp.Domain.Entities
{
    public class User
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public required string Gender { get; set; }
        public double Weight { get; set; }
        public double TargetWeight { get; set; }
        public int ActivityLevel { get; set; }
        public required string ProfilePictureUrl { get; set; }

        public ICollection<ExerciseProgram> ExercisePrograms { get; set; }
        = new List<ExerciseProgram>();
        public ICollection<DietProgram> DietPrograms { get; set; }
        = new List<DietProgram>();
    }
}
