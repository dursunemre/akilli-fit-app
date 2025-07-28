using AkilliFitApp.Application.Interfaces.IRepository;
using AkilliFitApp.Domain.Entities;
using AkilliFitApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Infrastructure.Repositories
{
    public class EgzersizProgramRepository : IEgzersizProgramRepository
    {
        private readonly IGenericRepository<EgzersizProgram> _repository;
        private readonly AkilliFitAppDbContext _context;
        private readonly DbSet<EgzersizProgram> _dbSet;

        public EgzersizProgramRepository(IGenericRepository<EgzersizProgram> repository, AkilliFitAppDbContext context)
        {
            _repository = repository;
            _context = context;
            _dbSet = _context.Set<EgzersizProgram>();
        }

        public async Task<IEnumerable<EgzersizProgram?>> GetAllAsync(int kullaniciId)
        {
            return await _dbSet
                .Where(e => e.KullaniciId == kullaniciId)
                .ToListAsync();
        }

        public async Task<EgzersizProgram?> GetByIdAsync(int programId)
        {
            return await _repository.GetByIdAsync(programId);
        } 

        public async Task<EgzersizProgram> AddAsync(EgzersizProgram entity)
        {
            return await _repository.AddAsync(entity);
        }

        public async Task<EgzersizProgram> UpdateAsync(EgzersizProgram entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(EgzersizProgram entity)
        {
            await _repository.DeleteAsync(entity);
        }
    }
}
