using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Application.DTOs.Exercise
{
    public abstract class ExerciseReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
