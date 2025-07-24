using AkilliFitApp.Application.DTOs.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.Interfaces
{
    public interface IKullaniciBilgiService
    {
        Task<KullaniciBilgileriReadDto> GetKullaniciBilgileriAsync(int kullaniciId);
    }
}
