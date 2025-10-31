using SmartFitnessApp.Domain.Entities;
using SmartFitnessApp.Application.DTOs.Exercise.Program;
using SmartFitnessApp.Application.DTOs.Diet.Program;

namespace SmartFitnessApp.Application.DTOs.User
{
    public class UserReadDto
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateOnly BirthDate { get; set; }
        public string Gender { get; set; } = null!;
        public double Weight { get; set; }
        public double TargetWeight { get; set; }
        public int ActivityLevel { get; set; }
        public string? ProfilePictureUrl { get; set; }

        public ICollection<ExerciseProgramReadDto> ExercisePrograms { get; set; } = [];
        public ICollection<DietProgramReadDto> DietPrograms { get; set; } = [];
    }
}
