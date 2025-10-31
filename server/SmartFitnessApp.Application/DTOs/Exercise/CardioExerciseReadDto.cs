using SmartFitnessApp.Domain.Entities;
using SmartFitnessApp.Application.DTOs.ExerciseInfo;

namespace SmartFitnessApp.Application.DTOs.Exercise
{
    public class CardioExerciseReadDto : ExerciseReadDto
    {
        public ICollection<CardioExerciseInfoReadDto> CardioExerciseInfos { get; set; } = [];
    }
}
