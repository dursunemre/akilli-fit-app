namespace SmartFitnessApp.Application.DTOs.ExerciseInfo
{
    public class WeightExerciseInfoCreateDto : ExerciseInfoCreateDto
    {
        public int Set { get; set; }
        public int Repetition { get; set; }
        public double WeightKG { get; set; }
        public double TargetWeightKG { get; set; }
        public int WeightExerciseId { get; set; }
    }
}
