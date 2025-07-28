using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkilliFitApp.Domain.Entities;

namespace AkilliFitApp.Application.Interfaces.IService
{
    public interface IEgzersizProgramService
    {
        Task<IEnumerable<EgzersizProgram?>> GetAllAsync(int kullaniciId);
        Task<EgzersizProgram?> GetByIdAsync(int programId);
        Task<EgzersizProgram> AddAsync(EgzersizProgram egzersizProgram);
        Task<EgzersizProgram> UpdateAsync(EgzersizProgram egzersizProgram);
        Task DeleteAsync(EgzersizProgram entity);
    }
}
