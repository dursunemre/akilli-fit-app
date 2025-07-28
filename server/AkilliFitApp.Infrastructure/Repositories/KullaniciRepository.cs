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
    internal class KullaniciRepository : IKullaniciRepository
    {
        private readonly IGenericRepository<Kullanici> _repository;
        private readonly AkilliFitAppDbContext _context;
        private readonly DbSet<Kullanici> _dbSet;

        public KullaniciRepository(IGenericRepository<Kullanici> genericRepository, AkilliFitAppDbContext context)
        {
            _repository = genericRepository;
            _context = context;
            _dbSet = _context.Set<Kullanici>();
        }

        public async Task<Kullanici?> GetByIdAsync(int kullaniciId)
        {
            var found = await _repository.GetByIdAsync(kullaniciId);
            return found;
        }

        public async Task<Kullanici> AddAsync(Kullanici entity)
        {
            var created = await _repository.AddAsync(entity);
            return created;
        }

        public async Task<Kullanici> UpdateAsync(Kullanici entity)
        {
            var updated = await _repository.UpdateAsync(entity);
            return updated;
        }

        public async Task DeleteAsync(Kullanici entity)
        {
            await _repository.DeleteAsync(entity);
        }
    }
}
