using SmartFitnessApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Application.Interfaces.IRepository
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(int userId);
        Task<User> AddAsync(User user);
        Task<User> UpdateAsync(User user);
        Task DeleteAsync(User user);
    }
}
