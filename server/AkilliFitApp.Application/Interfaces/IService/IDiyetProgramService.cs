using AkilliFitApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.Interfaces.IService
{
    public interface IDiyetProgramService
    {
        Task<IEnumerable<DiyetProgram?>> GetAllAsync(int kullaniciId);
        Task<DiyetProgram?> GetByIdAsync(int diyetProgramId);
        Task<DiyetProgram> AddAsync(DiyetProgram diyetProgram);
        Task<DiyetProgram> UpdateAsync(DiyetProgram diyetProgram);
        Task DeleteAsync(DiyetProgram diyetProgram);
    }
}
