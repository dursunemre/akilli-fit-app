namespace SmartFitnessApp.Domain.Entities
{
    public class WeightExerciseInfo : ExerciseInfo 
    {
        public int Set { get; set; }
        public int Repetition { get; set; }
        public double WeightKG { get; set; }
        public double TargetWeightKG { get; set; }
        public double ExerciseVolumeKG => Set * Repetition * WeightKG;

        public WeightExerciseInfo() { }

        public WeightExerciseInfo(int set, int repetition, double weightKG, double targetWeightKG, Exercise weightExercise, ExerciseProgram exerciseProgram)
        {
            if (weightExercise is not WeightExercise)
                throw new ArgumentException(
                  "WeightExerciseInfo must receive a WeightExercise instance.",
                  nameof(weightExercise)
                );

            Set = set;
            Repetition = repetition;
            WeightKG = weightKG;
            TargetWeightKG = targetWeightKG;
            Exercise = weightExercise;
            ExerciseProgram = exerciseProgram;
        }
    }
}
