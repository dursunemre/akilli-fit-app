using AkilliFitApp.Application;
using AkilliFitApp.Application.DTOs.Kullanici;
using AkilliFitApp.Application.Interfaces.IRepository;
using AkilliFitApp.Application.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.Services
{
    public class KullaniciService<TEntity> : IKullaniciService<TEntity>
        where TEntity : class
    {
        private readonly IKullanıcıRepository<TEntity> _repository;
        private readonly IGenericService<TEntity> _genericService;
        public KullaniciService(IKullanıcıRepository<TEntity> repository, IGenericService<TEntity> genericService)
        {
            _repository = repository;
            _genericService = genericService;
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            var found = await _genericService.GetByIdAsync(id);
            return found;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var created = await _genericService.AddAsync(entity);
            return created;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var updated = await _genericService.UpdateAsync(entity);
            return updated;
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await _genericService.DeleteAsync(entity);
        }
    }
}
