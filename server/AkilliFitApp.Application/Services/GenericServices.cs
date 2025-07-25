using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AkilliFitApp.Application.Interfaces;

namespace AkilliFitApp.Application.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity>
        where TEntity : class
    {
        private readonly IGenericRepository<TEntity> _repository;

        public GenericService(IGenericRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null)
                throw new KeyNotFoundException($"Entity with ID {id} not found.");
            return entity;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            await _repository.UpdateAsync(entity);
            return entity;
        }

        public Task DeleteAsync(TEntity entity)
        {
            return _repository.DeleteAsync(entity);
        }
    }
}
