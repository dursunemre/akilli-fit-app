using SmartFitnessApp.Application.Interfaces.IRepository;
using SmartFitnessApp.Domain.Entities;
using SmartFitnessApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Infrastructure.Repositories
{
    public class DietProgramRepository : IDietProgramRepository
    {
        private readonly IGenericRepository<DietProgram> _repository;
        private readonly SmartFitnessAppDbContext _context;
        private readonly DbSet<DietProgram> _dbSet;

        public DietProgramRepository(IGenericRepository<DietProgram> repository, SmartFitnessAppDbContext context)
        {
            _repository = repository;
            _context = context;
            _dbSet = _context.Set<DietProgram>();
        }

        public async Task<IEnumerable<DietProgram?>> GetAllAsync(int userId)
        {
            return await _dbSet
                .Where(e => e.UserId == userId)
                .ToListAsync();
        }

        public async Task<DietProgram?> GetByIdAsync(int programId)
        {
            return await _repository.GetByIdAsync(programId);
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
