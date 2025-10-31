using SmartFitnessApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Application.Interfaces.IRepository
{
    public interface IExerciseProgramRepository
    {
        Task<IEnumerable<ExerciseProgram?>> GetAllAsync(int userId);
        Task<ExerciseProgram?> GetByIdAsync(int exerciseProgramId);
        Task<ExerciseProgram> AddAsync(ExerciseProgram exerciseProgram);
        Task<ExerciseProgram> UpdateAsync(ExerciseProgram exerciseProgram);
        Task DeleteAsync(ExerciseProgram exerciseProgram);
    }
}
