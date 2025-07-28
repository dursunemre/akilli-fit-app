using AkilliFitApp.Application;
using AkilliFitApp.Application.DTOs.Egzersiz.Program;
using AkilliFitApp.Application.Interfaces.IRepository;
using AkilliFitApp.Application.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AkilliFitApp.Application.Services
{
    internal class EgzersizProgramService<TEntity> : IEgzersizProgramService<TEntity>
        where TEntity : class
    {
        private readonly IGenericRepository<TEntity> _repository;
        private readonly IGenericService<TEntity> _genericService;

        public EgzersizProgramService(IGenericRepository<TEntity> repository, IGenericService<TEntity> genericService)
        {
            _repository = repository;
            _genericService = genericService;
        }

        public async Task<List<TEntity?>> GetAllAsync(int id)
        {
            
        }
    }
}
