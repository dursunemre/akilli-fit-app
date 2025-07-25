using AkilliFitApp.Application.DTOs.Kullanici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.Interfaces
{
    public interface IKullaniciBilgiService
    {
        Task<KullaniciReadDto> GetKullaniciBilgileriAsync(int kullaniciId);
    }
}
