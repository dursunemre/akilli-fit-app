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
    public class EgzersizNotRepository : IEgzersizNotRepository
    {
        private readonly IGenericRepository<EgzersizNot> _repository;
        private readonly AkilliFitAppDbContext _context;
        private readonly DbSet<EgzersizNot> _dbSet;

        public EgzersizNotRepository(IGenericRepository<EgzersizNot> repository, AkilliFitAppDbContext context)
        {
            _repository = repository;
            _context = context;
            _dbSet = _context.Set<EgzersizNot>();
        }

        public async Task<EgzersizNot?> GetByEgzersizBilgiIdAsync(int egzersizBilgiId)
        {
            return await _dbSet.FirstOrDefaultAsync(n => n.EgzersizBilgiId == egzersizBilgiId);
        }

        public async Task<EgzersizNot?> GetByIdAsync(int egzersizNotId)
        {
            return await _repository.GetByIdAsync(egzersizNotId);
        }

        public async Task<EgzersizNot> AddAsync(EgzersizNot egzersizNot)
        {
            return await _repository.AddAsync(egzersizNot);
        }

        public async Task<EgzersizNot> UpdateAsync(EgzersizNot egzersizNot)
        {
            return await _repository.UpdateAsync(egzersizNot);
        }

        public async Task DeleteAsync(EgzersizNot egzersizNot)
        {
            await _repository.DeleteAsync(egzersizNot);
        }
    }
}
