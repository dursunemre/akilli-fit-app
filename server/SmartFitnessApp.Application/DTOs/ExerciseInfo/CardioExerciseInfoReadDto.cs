using System;

namespace SmartFitnessApp.Application.DTOs.ExerciseInfo
{
    public class CardioExerciseInfoReadDto : ExerciseInfoReadDto
    {
        public double DistanceMtr { get; set; }
        public TimeOnly Duration { get; set; }
        public double Speed { get; set; }
        public double TargetDistance { get; set; }
        public TimeOnly TargetDuration { get; set; }
        public int CardioExerciseId { get; set; }
    }
}
