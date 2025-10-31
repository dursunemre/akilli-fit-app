using SmartFitnessApp.Application;
using SmartFitnessApp.Application.DTOs.Exercise.Program;
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
    public class ExerciseProgramService : IExerciseProgramService
    {
        private readonly IExerciseProgramRepository _repository;

        public ExerciseProgramService(IExerciseProgramRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ExerciseProgram?>> GetAllAsync(int userId)
        {
            return await _repository.GetAllAsync(userId);   
        }

        public async Task<ExerciseProgram?> GetByIdAsync(int programId)
        {
            return await _repository.GetByIdAsync(programId);
        }

        public async Task<ExerciseProgram> AddAsync(ExerciseProgram exerciseProgram)
        {
            return await _repository.AddAsync(exerciseProgram);
        }

        public async Task<ExerciseProgram> UpdateAsync(ExerciseProgram exerciseProgram)
        {
            return await _repository.UpdateAsync(exerciseProgram);
        }

        public async Task DeleteAsync(ExerciseProgram exerciseProgram)
        {
            await _repository.DeleteAsync(exerciseProgram);
        }
    }
}
