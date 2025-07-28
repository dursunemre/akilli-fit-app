using AkilliFitApp.Application.Interfaces.IRepository;
using AkilliFitApp.Domain.Entities;
using AkilliFitApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Infrastructure.Repositories
{
    public class EgzersizBilgiRepository
    {
        private readonly IGenericRepository<EgzersizBilgi> _repository;
        private readonly AkilliFitAppDbContext _context;
        private readonly DbSet<EgzersizBilgi> _dbSet;

        public EgzersizBilgiRepository(IGenericRepository<EgzersizBilgi> repository, AkilliFitAppDbContext context)
        {
            _repository = repository;
            _context = context;
            _dbSet = _context.Set<EgzersizBilgi>();
        }

        public async Task<IEnumerable<EgzersizBilgi?>> GetAllAsync(int egzersizProgramId)
        {
            return await _dbSet
                .Where(e => e.EgzersizProgramId == egzersizProgramId)
                .ToListAsync();
        }

        public async Task<EgzersizBilgi?> GetByIdAsync(int egzersizBilgiId)
        {
            return await _repository.GetByIdAsync(egzersizBilgiId);
        }

        public async Task<EgzersizBilgi> AddAsync(EgzersizBilgi egzersizBilgi)
        {
            return await _repository.AddAsync(egzersizBilgi);
        }

        public async Task<EgzersizBilgi> UpdateAsync(EgzersizBilgi egzersizBilgi)
        {
            return await _repository.UpdateAsync(egzersizBilgi);
        }

        public async Task DeleteAsync(EgzersizBilgi egzersizBilgi)
        {
            await _repository.DeleteAsync(egzersizBilgi);
        }
    }
}
