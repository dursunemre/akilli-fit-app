using AkilliFitApp.Domain.Entities;
using AkilliFitApp.Application.DTOs.EgzersizBilgi;

namespace AkilliFitApp.Application.DTOs.Egzersiz
{
    public class KardiyoEgzersizReadDto 
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;

        public ICollection<KardiyoEgzersizBilgiReadDto> KardiyoEgzersizBilgileri { get; set; } = [];
    }
}
