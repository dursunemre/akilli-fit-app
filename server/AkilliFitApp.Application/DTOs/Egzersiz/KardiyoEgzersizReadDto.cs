using AkilliFitApp.Domain.Entities;
using AkilliFitApp.Application.DTOs.EgzersizBilgi;

namespace AkilliFitApp.Application.DTOs.Egzersiz
{
    public class KardiyoEgzersizReadDto : EgzersizReadDto
    {
        public ICollection<KardiyoEgzersizBilgiReadDto> KardiyoEgzersizBilgileri { get; set; } = [];
    }
}
