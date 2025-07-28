using AkilliFitApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.Interfaces.IRepository
{
    public interface IEgzersizProgramRepository
    {
        Task<IEnumerable<EgzersizProgram?>> GetAllAsync(int kullaniciId);
        Task<EgzersizProgram?> GetByIdAsync(int programId);
        Task<EgzersizProgram> AddAsync(EgzersizProgram entity);
        Task<EgzersizProgram> UpdateAsync(EgzersizProgram entity);
        Task DeleteAsync(EgzersizProgram entity);
    }
}
