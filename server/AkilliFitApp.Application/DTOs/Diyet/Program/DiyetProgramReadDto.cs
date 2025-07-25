using AkilliFitApp.Application.DTOs.Diyet.Besin;
using AkilliFitApp.Application.DTOs.Kullanici;
using AkilliFitApp.Domain.Entities;

namespace AkilliFitApp.Application.DTOs.Diyet.Program
{
    public class DiyetProgramReadDto
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;

        public int KullaniciId { get; set; }
        public required KullaniciReadDto Kullanici { get; set; }
        public ICollection<DiyetBesinReadDto> DiyetBesinleri { get; set; } = [];
    }
}
