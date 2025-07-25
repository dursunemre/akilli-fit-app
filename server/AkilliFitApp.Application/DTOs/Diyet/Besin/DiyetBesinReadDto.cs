using AkilliFitApp.Domain.Entities;
using AkilliFitApp.Application.DTOs.Diyet.Program;

namespace AkilliFitApp.Application.DTOs.Diyet.Besin
{
    public class DiyetBesinReadDto
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public double Gramaj { get; set; }
        public double TotalKalori;
        public double TotalProtein;
        public double TotalYag;
        public double TotalKarbonhidrat;
        
        public int BesinId { get; set; }
        public required BesinReadDto Besin { get; set; }
        public int DiyetProgramId { get; set; }
        public required DiyetProgramReadDto DiyetProgram { get; set; }
    }
}
