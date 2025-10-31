using SmartFitnessApp.Application.Interfaces.IRepository;
using SmartFitnessApp.Domain.Entities;
using SmartFitnessApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Infrastructure.Repositories
{
    public class ExerciseProgramRepository : IExerciseProgramRepository
    {
        private readonly IGenericRepository<ExerciseProgram> _repository;
        private readonly SmartFitnessAppDbContext _context;
        private readonly DbSet<ExerciseProgram> _dbSet;

        public ExerciseProgramRepository(IGenericRepository<ExerciseProgram> repository, SmartFitnessAppDbContext context)
        {
            _repository = repository;
            _context = context;
            _dbSet = _context.Set<ExerciseProgram>();
        }

        public async Task<IEnumerable<ExerciseProgram?>> GetAllAsync(int userId)
        {
            return await _dbSet
                .Where(e => e.UserId == userId)
                .ToListAsync();
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
