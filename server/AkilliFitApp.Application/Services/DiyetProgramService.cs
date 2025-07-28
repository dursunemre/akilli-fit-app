using AkilliFitApp.Application.Interfaces.IRepository;
using AkilliFitApp.Application.Interfaces.IService;
using AkilliFitApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.Services
{
    public class DiyetProgramService : IDiyetProgramService
    {
        private readonly IDiyetProgramRepository _repository;

        public DiyetProgramService(IDiyetProgramRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<DiyetProgram?>> GetAllAsync(int kullaniciId)
        {
            return await _repository.GetAllAsync(kullaniciId);
        }

        public async Task<DiyetProgram?> GetByIdAsync(int diyetProgramId)
        {
            return await _repository.GetByIdAsync(diyetProgramId);
        }

        public async Task<DiyetProgram> AddAsync(DiyetProgram diyetProgram)
        {
            return await _repository.AddAsync(diyetProgram);
        }

        public async Task<DiyetProgram> UpdateAsync(DiyetProgram diyetProgram)
        {
            return await _repository.UpdateAsync(diyetProgram);
        }

        public async Task DeleteAsync(DiyetProgram diyetProgram)
        {
            await _repository.DeleteAsync(diyetProgram);
        }
    }
}
