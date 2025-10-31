using SmartFitnessApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Application.Interfaces.IRepository
{
    public interface IDietProgramRepository
    {
        Task<IEnumerable<DietProgram?>> GetAllAsync(int userId);
        Task<DietProgram?> GetByIdAsync(int dietProgramId);
        Task<DietProgram> AddAsync(DietProgram dietProgram);
        Task<DietProgram> UpdateAsync(DietProgram dietProgram);
        Task DeleteAsync(DietProgram dietProgram);
    }
}
