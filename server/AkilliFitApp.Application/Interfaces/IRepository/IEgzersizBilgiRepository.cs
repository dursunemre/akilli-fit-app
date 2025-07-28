using AkilliFitApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.Interfaces.IRepository
{
    public interface IEgzersizBilgiRepository
    {
        Task<IEnumerable<EgzersizBilgi?>> GetAllAsync(int egzeriszProgramId);
        Task<EgzersizBilgi?> GetByIdAsync(int egzersizBilgiId);
        Task<EgzersizBilgi> AddAsync(EgzersizBilgi egzersizBilgi);
        Task<EgzersizBilgi> UpdateAsync(EgzersizBilgi egzersizBilgi);
        Task DeleteAsync(EgzersizBilgi egzersizBilgi);
    }
}
