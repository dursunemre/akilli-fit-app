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
    public class DiyetProgramRepository : IDiyetProgramRepository
    {
        private readonly IGenericRepository<DiyetProgram> _repository;
        private readonly AkilliFitAppDbContext _context;
        private readonly DbSet<DiyetProgram> _dbSet;

        public DiyetProgramRepository(IGenericRepository<DiyetProgram> repository, AkilliFitAppDbContext context)
        {
            _repository = repository;
            _context = context;
            _dbSet = _context.Set<DiyetProgram>();
        }

        public async Task<IEnumerable<DiyetProgram?>> GetAllAsync(int kullaniciId)
        {
            return await _dbSet
                .Where(e => e.KullaniciId == kullaniciId)
                .ToListAsync();
        }

        public async Task<DiyetProgram?> GetByIdAsync(int programId)
        {
            return await _repository.GetByIdAsync(programId);
        }

        public async Task<DiyetProgram> AddAsync(DiyetProgram diyetProgram)
        {
            return await _repository.AddAsync(diyetProgram);
        }

        public async Task<DiyetProgram> UpdateAsync(DiyetProgram diyetProgram)
        {
            return await _repository.UpdateAsync(diyetProgram);
        }

        public async Task DeleteAsync(DiyetProgram diyetProgram)
        {
            await _repository.DeleteAsync(diyetProgram);
        }
    }
}
