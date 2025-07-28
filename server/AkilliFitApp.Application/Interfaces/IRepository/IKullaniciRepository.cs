using AkilliFitApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.Interfaces.IRepository
{
    public interface IKullaniciRepository
    {
        Task<Kullanici?> GetByIdAsync(int kullaniciId);
        Task<Kullanici> AddAsync(Kullanici entity);
        Task<Kullanici> UpdateAsync(Kullanici entity);
        Task DeleteAsync(Kullanici entity);
    }
}
