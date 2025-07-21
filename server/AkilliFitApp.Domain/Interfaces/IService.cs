using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Domain.Interfaces
{
    public interface IService
    {
        Task<IEnumerable<T>> GetAllAsync<T>() where T : class;
    }
}
