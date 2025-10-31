using SmartFitnessApp.Application.Interfaces.IRepository;
using SmartFitnessApp.Application.Interfaces.IService;
using SmartFitnessApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Application.Services
{
    public class ExerciseInfoService : IExerciseInfoService
    {
        private readonly IExerciseInfoRepository _repository;

        public ExerciseInfoService(IExerciseInfoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ExerciseInfo?>> GetAllAsync(int exerciseProgramId)
        {
            return await _repository.GetAllAsync(exerciseProgramId);
        }

        public async Task<ExerciseInfo?> GetByIdAsync(int exerciseInfoId)
        {
            return await _repository.GetByIdAsync(exerciseInfoId);
        }

        public async Task<ExerciseInfo> AddAsync(ExerciseInfo exerciseInfo)
        {
            return await _repository.AddAsync(exerciseInfo);
        }

        public async Task<ExerciseInfo> UpdateAsync(ExerciseInfo exerciseInfo)
        {
            return await _repository.UpdateAsync(exerciseInfo);
        }

        public async Task DeleteAsync(ExerciseInfo exerciseInfo)
        {
            await _repository.DeleteAsync(exerciseInfo);
        }
    }
}
