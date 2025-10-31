using SmartFitnessApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFitnessApp.Application.Interfaces.IRepository
{
    public interface IDietFoodRepository
    {
        Task<IEnumerable<DietFood?>> GetAllAsync(int dietProgramId);
        Task<DietFood?> GetByIdAsync(int dietFoodId);
        Task<DietFood> AddAsync(DietFood dietFood);
        Task<DietFood> UpdateAsync(DietFood dietFood);
        Task DeleteAsync(DietFood dietFood);
    }
}
