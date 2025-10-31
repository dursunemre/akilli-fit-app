using SmartFitnessApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Application.Interfaces.IRepository
{
    public interface IExerciseInfoRepository
    {
        Task<IEnumerable<ExerciseInfo?>> GetAllAsync(int exerciseProgramId);
        Task<ExerciseInfo?> GetByIdAsync(int exerciseInfoId);
        Task<ExerciseInfo> AddAsync(ExerciseInfo exerciseInfo);
        Task<ExerciseInfo> UpdateAsync(ExerciseInfo exerciseInfo);
        Task DeleteAsync(ExerciseInfo exerciseInfo);
    }
}
