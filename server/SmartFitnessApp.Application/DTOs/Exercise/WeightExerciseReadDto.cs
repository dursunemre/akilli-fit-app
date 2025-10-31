using SmartFitnessApp.Application.DTOs.ExerciseInfo;

namespace SmartFitnessApp.Application.DTOs.Exercise
{
    public class WeightExerciseReadDto : ExerciseReadDto
    {
        public ICollection<WeightExerciseInfoReadDto> WeightExerciseInfos { get; set; } = [];
    }
}
