using AkilliFitApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.Interfaces.IRepository
{
    public interface IEgzersizRepository
    {
        Task<IEnumerable<Egzersiz>> GetAllByTipAsync(string tip);
    }

}
