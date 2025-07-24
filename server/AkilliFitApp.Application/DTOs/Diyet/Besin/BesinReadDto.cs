namespace AkilliFitApp.Application.DTOs.Diyet.Besin
{
    public class BesinReadDto
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public int Kalori100gr { get; set; }
        public double Protein100gr { get; set; }
        public double Yag100gr { get; set; }
        public double Karbonhidrat100gr { get; set; }
    }
}
