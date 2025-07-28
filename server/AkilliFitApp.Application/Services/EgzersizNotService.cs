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
    public class EgzersizNotService : IEgzersizNotService
    {
        private readonly IEgzersizNotRepository _repository;

        public EgzersizNotService(IEgzersizNotRepository repository)
        {
            _repository = repository;
        }

        public async Task<EgzersizNot?> GetByEgzersizBilgiIdAsync(int egzersizBilgiId)
        {
            return await _repository.GetByEgzersizBilgiIdAsync(egzersizBilgiId);
        }

        public async Task<EgzersizNot?> GetByIdAsync(int egzersizNotId)
        {
            return await _repository.GetByIdAsync(egzersizNotId);
        }

        public async Task<EgzersizNot> AddAsync(EgzersizNot egzersizNot)
        {
            return await _repository.AddAsync(egzersizNot);
        }

        public async Task<EgzersizNot> UpdateAsync(EgzersizNot egzersizNot)
        {
            return await _repository.UpdateAsync(egzersizNot);
        }

        public async Task DeleteAsync(EgzersizNot egzersizNot)
        {
            await _repository.DeleteAsync(egzersizNot);
        }
    }
}
