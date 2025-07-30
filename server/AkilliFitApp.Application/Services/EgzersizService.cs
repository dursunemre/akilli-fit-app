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
    public class EgzersizService : IEgzersizService
    {
        private readonly IEgzersizRepository _repository;

        public EgzersizService(IEgzersizRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Egzersiz>> GetAllByTipAsync(string tip)
        {
            return await _repository.GetAllByTipAsync(tip);
        }
    }

}
