namespace AkilliFitApp.Application.DTOs
{
    public class BesinUpdateDto
    {
        public string Ad { get; set; } = null!;
        public int Kalori100gr { get; set; }
        public double Protein100gr { get; set; }
        public double Yag100gr { get; set; }
        public double Karbonhidrat100gr { get; set; }
    }
}
