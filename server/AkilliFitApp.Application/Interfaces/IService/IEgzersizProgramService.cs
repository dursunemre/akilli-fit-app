using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkilliFitApp.Domain.Entities;

namespace AkilliFitApp.Application.Interfaces.IService
{
    public interface IEgzersizProgramService<TEntity> 
    {
        Task<List<TEntity?>> GetAllAsync(int id);
        Task<TEntity?> GetByIdAsync(int id);
        Task<TEntity> CreateAsync(EgzersizProgram egzersizProgram);
        Task<TEntity> UpdateAsync(EgzersizProgram egzersizProgram);
        Task DeleteAsync(TEntity entity);
    }
}
