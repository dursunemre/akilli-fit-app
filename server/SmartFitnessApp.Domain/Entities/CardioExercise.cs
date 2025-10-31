using System.ComponentModel.DataAnnotations;

namespace SmartFitnessApp.Domain.Entities
{
    public class CardioExercise : Exercise
    {
        public ICollection<CardioExerciseInfo> CardioExerciseInfos { get; set; } = [];

        public CardioExercise() { }

        public CardioExercise(string name)
        {
            Name = name;
        }
    }
}
