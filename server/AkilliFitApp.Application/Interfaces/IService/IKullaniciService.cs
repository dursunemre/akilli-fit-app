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
        Task<Kullanici?> GetByIdAsync(int id);
        Task<Kullanici> AddAsync(Kullanici entity);
        Task<Kullanici> UpdateAsync(Kullanici entity);
        Task DeleteAsync(Kullanici entity);
    }
}
