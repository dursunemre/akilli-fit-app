using System.ComponentModel.DataAnnotations;

namespace SmartFitnessApp.Domain.Entities
{
    public abstract class ExerciseInfo
    {
        public int Id { get; private set; }

        public int ExerciseProgramId { get; set; }
        public ExerciseProgram ExerciseProgram { get; set; } = null!;
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; } = null!;

        public ExerciseNote? ExerciseNote { get; set; }
    }
}
