using AkilliFitApp.Application;
using AkilliFitApp.Application.DTOs.Kullanici;
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
    public class KullaniciService : IKullaniciService
    {
        private readonly IKullaniciRepository _repository;
        private readonly IGenericService<Kullanici> _genericService;
        public KullaniciService(IKullaniciRepository repository, IGenericService<Kullanici> genericService)
        {
            _repository = repository;
            _genericService = genericService;
        }

        public async Task<Kullanici?> GetByIdAsync(int id)
        {
            var found = await _genericService.GetByIdAsync(id);
            return found;
        }

        public async Task<Kullanici> AddAsync(Kullanici entity)
        {
            var created = await _genericService.AddAsync(entity);
            return created;
        }

        public async Task<Kullanici> UpdateAsync(Kullanici entity)
        {
            var updated = await _genericService.UpdateAsync(entity);
            return updated;
        }

        public async Task DeleteAsync(Kullanici entity)
        {
            await _genericService.DeleteAsync(entity);
        }
    }
}
