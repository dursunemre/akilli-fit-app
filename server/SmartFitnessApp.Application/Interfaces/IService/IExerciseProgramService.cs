using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFitnessApp.Domain.Entities;

namespace SmartFitnessApp.Application.Interfaces.IService
{
    public interface IExerciseProgramService
    {
        Task<IEnumerable<ExerciseProgram?>> GetAllAsync(int userId);
        Task<ExerciseProgram?> GetByIdAsync(int exerciseProgramId);
        Task<ExerciseProgram> AddAsync(ExerciseProgram exerciseProgram);
        Task<ExerciseProgram> UpdateAsync(ExerciseProgram exerciseProgram);
        Task DeleteAsync(ExerciseProgram exerciseProgram);
    }
}
