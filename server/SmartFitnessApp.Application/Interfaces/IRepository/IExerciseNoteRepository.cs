using SmartFitnessApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Application.Interfaces.IRepository
{
    public interface IExerciseNoteRepository
    {
        Task<ExerciseNote?> GetByExerciseInfoIdAsync(int exerciseInfoId);
        Task<ExerciseNote?> GetByIdAsync(int exerciseNoteId);
        Task<ExerciseNote> AddAsync(ExerciseNote exerciseNote);
        Task<ExerciseNote> UpdateAsync(ExerciseNote exerciseNote);
        Task DeleteAsync(ExerciseNote exerciseNote);
    }
}
