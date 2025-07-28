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
        public KullaniciService(IKullaniciRepository repository)
        {
            _repository = repository;
        }

        public async Task<Kullanici?> GetByIdAsync(int kullaniciId)
        {
            var found = await _repository.GetByIdAsync(kullaniciId);
            return found;
        }

        public async Task<Kullanici> AddAsync(Kullanici kullanici)
        {
            var created = await _repository.AddAsync(kullanici);
            return created;
        }

        public async Task<Kullanici> UpdateAsync(Kullanici kullanici)
        {
            var updated = await _repository.UpdateAsync(kullanici);
            return updated;
        }

        public async Task DeleteAsync(Kullanici kullanici)
        {
            await _repository.DeleteAsync(kullanici);
        }
    }
}
