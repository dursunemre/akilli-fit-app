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
    public class ExerciseInfoRepository : IExerciseInfoRepository
    {
        private readonly IGenericRepository<ExerciseInfo> _repository;
        private readonly SmartFitnessAppDbContext _context;
        private readonly DbSet<ExerciseInfo> _dbSet;

        public ExerciseInfoRepository(IGenericRepository<ExerciseInfo> repository, SmartFitnessAppDbContext context)
        {
            _repository = repository;
            _context = context;
            _dbSet = _context.Set<ExerciseInfo>();
        }

        public async Task<IEnumerable<ExerciseInfo?>> GetAllAsync(int exerciseProgramId)
        {
            return await _dbSet
                .Where(e => e.ExerciseProgramId == exerciseProgramId)
                .ToListAsync();
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
