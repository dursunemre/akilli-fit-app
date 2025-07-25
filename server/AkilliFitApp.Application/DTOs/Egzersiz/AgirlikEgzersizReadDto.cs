using AkilliFitApp.Application.DTOs.EgzersizBilgi;

namespace AkilliFitApp.Application.DTOs.Egzersiz
{
    public class AgirlikEgzersizReadDto : EgzersizReadDto
    {
        public ICollection<AgirlikEgzersizBilgiReadDto> AgirlikEgzersizBilgileri { get; set; } = [];
    }
}
