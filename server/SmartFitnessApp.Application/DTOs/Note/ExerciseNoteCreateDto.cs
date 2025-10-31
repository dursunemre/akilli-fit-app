using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Application.DTOs.Note
{
    public class ExerciseNoteCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int ExerciseInfoId { get; set; }
    }
}
