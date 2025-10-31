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
    public class DietProgramService : IDietProgramService
    {
        private readonly IDietProgramRepository _repository;

        public DietProgramService(IDietProgramRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<DietProgram?>> GetAllAsync(int userId)
        {
            return await _repository.GetAllAsync(userId);
        }

        public async Task<DietProgram?> GetByIdAsync(int dietProgramId)
        {
            return await _repository.GetByIdAsync(dietProgramId);
        }

        public async Task<DietProgram> AddAsync(DietProgram dietProgram)
        {
            return await _repository.AddAsync(dietProgram);
        }

        public async Task<DietProgram> UpdateAsync(DietProgram dietProgram)
        {
            return await _repository.UpdateAsync(dietProgram);
        }

        public async Task DeleteAsync(DietProgram dietProgram)
        {
            await _repository.DeleteAsync(dietProgram);
        }
    }
}
