using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFitnessApp.Application.Interfaces.IRepository;
using SmartFitnessApp.Domain.Entities;
using SmartFitnessApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace SmartFitnessApp.Infrastructure.Repositories
{
    public class DietFoodRepository : IDietFoodRepository
    {
        private readonly IGenericRepository<DietFood> _repository;
        private readonly SmartFitnessAppDbContext _context;
        private readonly DbSet<DietFood> _dbSet;

        public DietFoodRepository(IGenericRepository<DietFood> repository, SmartFitnessAppDbContext context)
        {
            _repository = repository;
            _context = context;
            _dbSet = _context.Set<DietFood>();
        }

        public async Task<IEnumerable<DietFood?>> GetAllAsync(int dietProgramId)
        {
            return await _dbSet
                .Where(e => e.DietProgramId == dietProgramId)
                .ToListAsync();
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
