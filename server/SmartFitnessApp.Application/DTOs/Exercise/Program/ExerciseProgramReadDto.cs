using SmartFitnessApp.Application.DTOs.ExerciseInfo;
using SmartFitnessApp.Application.DTOs.User;

namespace SmartFitnessApp.Application.DTOs.Exercise.Program
{
    public class ExerciseProgramReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public int UserId { get; set; }
        public required UserReadDto User { get; set; }
        public ICollection<ExerciseInfoReadDto> ExerciseInfos { get; set; } = [];
    }
}
