using AkilliFitApp.Domain.Entities;
using AkilliFitApp.Application.DTOs.Diyet.Besin;

namespace AkilliFitApp.Application.DTOs.Diyet.Program
{
    public class DiyetProgramReadDto
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;

        public ICollection<DiyetBesinReadDto> DiyetBesinleri { get; set; } = [];
    }
}
