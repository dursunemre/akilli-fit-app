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
    public class ExerciseNoteRepository : IExerciseNoteRepository
    {
        private readonly IGenericRepository<ExerciseNote> _repository;
        private readonly SmartFitnessAppDbContext _context;
        private readonly DbSet<ExerciseNote> _dbSet;

        public ExerciseNoteRepository(IGenericRepository<ExerciseNote> repository, SmartFitnessAppDbContext context)
        {
            _repository = repository;
            _context = context;
            _dbSet = _context.Set<ExerciseNote>();
        }

        public async Task<ExerciseNote?> GetByExerciseInfoIdAsync(int exerciseInfoId)
        {
            return await _dbSet.FirstOrDefaultAsync(n => n.ExerciseInfoId == exerciseInfoId);
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
