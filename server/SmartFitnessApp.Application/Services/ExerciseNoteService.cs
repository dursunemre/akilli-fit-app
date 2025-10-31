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
    public class ExerciseNoteService : IExerciseNoteService
    {
        private readonly IExerciseNoteRepository _repository;

        public ExerciseNoteService(IExerciseNoteRepository repository)
        {
            _repository = repository;
        }

        public async Task<ExerciseNote?> GetByExerciseInfoIdAsync(int exerciseInfoId)
        {
            return await _repository.GetByExerciseInfoIdAsync(exerciseInfoId);
        }

        public async Task<ExerciseNote?> GetByIdAsync(int exerciseNoteId)
        {
            return await _repository.GetByIdAsync(exerciseNoteId);
        }

        public async Task<ExerciseNote> AddAsync(ExerciseNote exerciseNote)
        {
            return await _repository.AddAsync(exerciseNote);
        }

        public async Task<ExerciseNote> UpdateAsync(ExerciseNote exerciseNote)
        {
            return await _repository.UpdateAsync(exerciseNote);
        }

        public async Task DeleteAsync(ExerciseNote exerciseNote)
        {
            await _repository.DeleteAsync(exerciseNote);
        }
    }
}
