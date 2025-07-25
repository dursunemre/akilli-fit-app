using AkilliFitApp.Application.DTOs.EgzersizBilgi;
using AkilliFitApp.Application.DTOs.Kullanici;

namespace AkilliFitApp.Application.DTOs.Egzersiz.Program
{
    public class EgzersizProgramReadDto
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;

        public int KullaniciId { get; set; }
        public required KullaniciReadDto Kullanici { get; set; }
        public ICollection<EgzersizBilgiReadDto> EgzersizBilgi { get; set; } = [];
    }
}
