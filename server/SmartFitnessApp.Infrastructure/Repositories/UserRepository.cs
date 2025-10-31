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
    public class UserRepository : IUserRepository
    {
        private readonly IGenericRepository<User> _repository;
        private readonly SmartFitnessAppDbContext _context;
        private readonly DbSet<User> _dbSet;

        public UserRepository(IGenericRepository<User> genericRepository, SmartFitnessAppDbContext context)
        {
            _repository = genericRepository;
            _context = context;
            _dbSet = _context.Set<User>();
        }

        public async Task<User?> GetByIdAsync(int userId)
        {
            var found = await _repository.GetByIdAsync(userId);
            return found;
        }

        public async Task<User> AddAsync(User user)
        {
            var created = await _repository.AddAsync(user);
            return created;
        }

        public async Task<User> UpdateAsync(User user)
        {
            var updated = await _repository.UpdateAsync(user);
            return updated;
        }

        public async Task DeleteAsync(User user)
        {
            await _repository.DeleteAsync(user);
        }
    }
}
