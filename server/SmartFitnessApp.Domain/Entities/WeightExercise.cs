namespace SmartFitnessApp.Domain.Entities
{
    public class WeightExercise : Exercise
    {
        public ICollection<WeightExerciseInfo> WeightExerciseInfos { get; set; } = [];

        public WeightExercise() { }

        public WeightExercise(string name)
        {
            Name = name;
        }
    }
}
