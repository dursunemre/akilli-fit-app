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
    public class EgzersizBilgiService : IEgzersizBilgiService
    {
        private readonly IEgzersizBilgiRepository _repository;

        public EgzersizBilgiService(IEgzersizBilgiRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<EgzersizBilgi?>> GetAllAsync(int egzersizProgramId)
        {
            return await _repository.GetAllAsync(egzersizProgramId);
        }

        public async Task<EgzersizBilgi?> GetByIdAsync(int egzersizBilgiId)
        {
            return await _repository.GetByIdAsync(egzersizBilgiId);
        }

        public async Task<EgzersizBilgi> AddAsync(EgzersizBilgi egzersizBilgi)
        {
            return await _repository.AddAsync(egzersizBilgi);
        }

        public async Task<EgzersizBilgi> UpdateAsync(EgzersizBilgi egzersizBilgi)
        {
            return await _repository.UpdateAsync(egzersizBilgi);
        }

        public async Task DeleteAsync(EgzersizBilgi egzersizBilgi)
        {
            await _repository.DeleteAsync(egzersizBilgi);
        }
    }
}
