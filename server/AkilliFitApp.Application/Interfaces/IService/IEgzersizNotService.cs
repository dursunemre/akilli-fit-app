using AkilliFitApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.Interfaces.IService
{
    public interface IEgzersizNotService
    {
        Task<EgzersizNot?> GetByEgzersizBilgiIdAsync(int egzersizBilgiId);
        Task<EgzersizNot?> GetByIdAsync(int egzersizNotId);
        Task<EgzersizNot> AddAsync(EgzersizNot egzersizNot);
        Task<EgzersizNot> UpdateAsync(EgzersizNot egzersizNot);
        Task DeleteAsync(EgzersizNot egzersizNot);
    }
}
