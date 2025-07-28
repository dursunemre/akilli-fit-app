using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkilliFitApp.Application.Interfaces.IRepository;
using AkilliFitApp.Domain.Entities;
using AkilliFitApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AkilliFitApp.Infrastructure.Repositories
{
    internal class DİyetBesinRepository : IDiyetBesinRepository
    {
        private readonly IGenericRepository<DiyetBesin> _repository;
        private readonly AkilliFitAppDbContext _context;
        private readonly DbSet<DiyetBesin> _dbSet;

        public DİyetBesinRepository(IGenericRepository<DiyetBesin> repository, AkilliFitAppDbContext context)
        {
            _repository = repository;
            _context = context;
            _dbSet = _context.Set<DiyetBesin>();
        }

        public async Task<IEnumerable<DiyetBesin?>> GetAllAsync(int diyetProgramId)
        {
            return await _dbSet
                .Where(e => e.DiyetProgramId == diyetProgramId)
                .ToListAsync();
        }

        public async Task<DiyetBesin?> GetByIdAsync(int diyetBesinId)
        {
            return await _repository.GetByIdAsync(diyetBesinId);
        }

        public async Task<DiyetBesin> AddAsync(DiyetBesin diyetBesin)
        {
            return await _repository.AddAsync(diyetBesin);
        }

        public async Task<DiyetBesin> UpdateAsync(DiyetBesin diyetBesin)
        {
            return await _repository.UpdateAsync(diyetBesin);
        }

        public async Task DeleteAsync(DiyetBesin diyetBesin)
        {
            await _repository.DeleteAsync(diyetBesin);
        }
    }
}
