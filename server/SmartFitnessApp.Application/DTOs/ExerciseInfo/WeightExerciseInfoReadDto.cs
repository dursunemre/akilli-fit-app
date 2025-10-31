using SmartFitnessApp.Domain.Entities;

namespace SmartFitnessApp.Application.DTOs.ExerciseInfo
{
    public class WeightExerciseInfoReadDto : ExerciseInfoReadDto
    {
        public int Set { get; set; }
        public int Repetition { get; set; }
        public double WeightKG { get; set; }
        public double TargetWeightKG { get; set; }
        public double ExerciseVolumeKG { get; set; }
        public int WeightExerciseId { get; set; }
    }
}
