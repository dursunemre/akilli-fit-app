using AkilliFitApp.Application.DTOs.Kullanici;
using AkilliFitApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.Interfaces.IService
{
    public interface IKullaniciService
    {
        Task<Kullanici?> GetByIdAsync(int kullaniciId);
        Task<Kullanici> AddAsync(Kullanici kullanici);
        Task<Kullanici> UpdateAsync(Kullanici kullanici);
        Task DeleteAsync(Kullanici kullanici);
    }
}
