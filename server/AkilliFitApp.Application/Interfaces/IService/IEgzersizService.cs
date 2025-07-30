using AkilliFitApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.Interfaces.IService
{
    public interface IEgzersizService
    {
        Task<IEnumerable<Egzersiz>> GetAllByTipAsync(string tip);
    }

}
