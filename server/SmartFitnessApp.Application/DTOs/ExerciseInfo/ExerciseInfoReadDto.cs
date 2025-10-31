using SmartFitnessApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFitnessApp.Application.DTOs.Exercise;
using SmartFitnessApp.Application.DTOs.Exercise.Program;

namespace SmartFitnessApp.Application.DTOs.ExerciseInfo
{
    public abstract class ExerciseInfoReadDto
    {
        public int Id { get; set; }

        public int ExerciseProgramId { get; set; }
        public ExerciseProgramReadDto ExerciseProgram { get; set; } = null!;
        public int ExerciseId { get; set; }
        public ExerciseReadDto Exercise { get; set; } = null!;
    }
}
