using AkilliFitApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.Interfaces.IRepository
{
    public interface IDiyetBesinRepository
    {
        Task<IEnumerable<DiyetBesin?>> GetAllAsync(int diyetProgramId);
        Task<DiyetBesin?> GetByIdAsync(int diyetBesinId);
        Task<DiyetBesin> AddAsync(DiyetBesin diyetBesin);
        Task<DiyetBesin> UpdateAsync(DiyetBesin diyetBesin);
        Task DeleteAsync(DiyetBesin diyetBesin);
    }
}
