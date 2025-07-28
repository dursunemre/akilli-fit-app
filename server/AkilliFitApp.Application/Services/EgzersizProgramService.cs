using AkilliFitApp.Application;
using AkilliFitApp.Application.DTOs.Egzersiz.Program;
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
    public class EgzersizProgramService : IEgzersizProgramService
    {
        private readonly IEgzersizProgramRepository _repository;

        public EgzersizProgramService(IEgzersizProgramRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<EgzersizProgram?>> GetAllAsync(int kullaniciId)
        {
            return await _repository.GetAllAsync(kullaniciId);   
        }

        public async Task<EgzersizProgram?> GetByIdAsync(int programId)
        {
            return await _repository.GetByIdAsync(programId);
        }

        public async Task<EgzersizProgram> AddAsync(EgzersizProgram egzersizProgram)
        {
            return await _repository.AddAsync(egzersizProgram);
        }

        public async Task<EgzersizProgram> UpdateAsync(EgzersizProgram egzersizProgram)
        {
            return await _repository.UpdateAsync(egzersizProgram);
        }

        public async Task DeleteAsync(EgzersizProgram egzersizProgram)
        {
            await _repository.DeleteAsync(egzersizProgram);
        }
    }
}
