using SmartFitnessApp.Application;
using SmartFitnessApp.Application.DTOs.User;
using SmartFitnessApp.Application.Interfaces.IRepository;
using SmartFitnessApp.Application.Interfaces.IService;
using SmartFitnessApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
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
