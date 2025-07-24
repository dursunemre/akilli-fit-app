namespace AkilliFitApp.Application.DTOs.Diyet.Besin
{
    public class DiyetBesinReadDto
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public double Gramaj { get; set; }
        public double TotalKalori { get; set; }
        public double TotalProtein { get; set; }
        public double TotalYag { get; set; }
        public double TotalKarbonhidrat { get; set; }
        public int BesinId { get; set; }
        public int DiyetProgramId { get; set; }
    }
}
