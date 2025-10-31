using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Domain.Entities
{
    public class ExerciseNote
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Content { get; set; }

        public int ExerciseInfoId { get; set; }
        public required ExerciseInfo ExerciseInfo { get; set; }
    }
}
