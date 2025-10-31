using System.Security.Cryptography.X509Certificates;

namespace SmartFitnessApp.Domain.Entities
{
    public class CardioExerciseInfo : ExerciseInfo
    {
        public double DistanceMtr { get; set; }
        public TimeOnly Duration { get; set; }
        public double Speed => DistanceMtr / (Duration.Hour + Duration.Minute / 60.0 + Duration.Second / 3600.0);
        public double TargetDistance { get; set; }
        public TimeOnly TargetDuration { get; set; }

        public CardioExerciseInfo() { }

        public CardioExerciseInfo(double distanceMtr, TimeOnly duration, double targetDistance, TimeOnly targetDuration, Exercise cardioExercise, ExerciseProgram exerciseProgram)
        {
            if (cardioExercise is not CardioExercise)
                throw new ArgumentException(
                  "CardioExerciseInfo must receive a CardioExercise instance.",
                  nameof(cardioExercise)
                );

            DistanceMtr = distanceMtr;
            Duration = duration;
            TargetDistance = targetDistance;
            TargetDuration = targetDuration;
            Exercise = cardioExercise;
            ExerciseProgram = exerciseProgram;
        }
    }
}
