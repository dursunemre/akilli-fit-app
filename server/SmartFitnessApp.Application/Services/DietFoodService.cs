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
    public class DietFoodService : IDietFoodService
    {
        private readonly IDietFoodRepository _repository;

        public DietFoodService(IDietFoodRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<DietFood?>> GetAllAsync(int dietProgramId)
        {
            return await _repository.GetAllAsync(dietProgramId);
        }

        public async Task<DietFood?> GetByIdAsync(int dietFoodId)
        {
            return await _repository.GetByIdAsync(dietFoodId);
        }

        public async Task<DietFood> AddAsync(DietFood dietFood)
        {
            return await _repository.AddAsync(dietFood);
        }

        public async Task<DietFood> UpdateAsync(DietFood dietFood)
        {
            return await _repository.UpdateAsync(dietFood);
        }

        public async Task DeleteAsync(DietFood dietFood)
        {
            await _repository.DeleteAsync(dietFood);
        }
    }
}
