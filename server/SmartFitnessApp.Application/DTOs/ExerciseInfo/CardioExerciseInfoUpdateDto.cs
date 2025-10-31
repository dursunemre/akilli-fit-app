using System;

namespace SmartFitnessApp.Application.DTOs.ExerciseInfo
{
    public class CardioExerciseInfoUpdateDto : ExerciseInfoUpdateDto
    {
        public double DistanceMtr { get; set; }
        public TimeOnly Duration { get; set; }
        public double TargetDistance { get; set; }
        public TimeOnly TargetDuration { get; set; }
    }
}
