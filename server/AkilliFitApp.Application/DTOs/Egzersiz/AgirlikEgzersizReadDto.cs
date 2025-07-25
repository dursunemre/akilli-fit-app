using AkilliFitApp.Application.DTOs.EgzersizBilgi;

namespace AkilliFitApp.Application.DTOs.Egzersiz
{
    public class AgirlikEgzersizReadDto 
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;

        public ICollection<AgirlikEgzersizBilgiReadDto> AgirlikEgzersizBilgileri { get; set; } = [];
    }
}
