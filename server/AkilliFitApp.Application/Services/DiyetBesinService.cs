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
    public class DiyetBesinService : IDiyetBesinService
    {
        private readonly IDiyetBesinRepository _repository;

        public DiyetBesinService(IDiyetBesinRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<DiyetBesin?>> GetAllAsync(int diyetProgramId)
        {
            return await _repository.GetAllAsync(diyetProgramId);
        }

        public async Task<DiyetBesin?> GetByIdAsync(int diyetBesinId)
        {
            return await _repository.GetByIdAsync(diyetBesinId);
        }

        public async Task<DiyetBesin> AddAsync(DiyetBesin diyetBesin)
        {
            return await _repository.AddAsync(diyetBesin);
        }

        public async Task<DiyetBesin> UpdateAsync(DiyetBesin diyetBesin)
        {
            return await _repository.UpdateAsync(diyetBesin);
        }

        public async Task DeleteAsync(DiyetBesin diyetBesin)
        {
            await _repository.DeleteAsync(diyetBesin);
        }
    }
}
