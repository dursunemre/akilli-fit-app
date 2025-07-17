using System.ComponentModel.DataAnnotations;

namespace AkilliFitApp.API.Entities
{
    public class KardiyoEgzersizi : IEgzersiz
    {
        public int Id { get; set; }
        public required string Ad { get; set; }
        public double Mesafe { get; set; }
        public TimeOnly Sure { get; set; }
        public double Hız {
            get {
                double saat = Sure.Hour + Sure.Minute / 60.0 + Sure.Second / 3600.0;
                return Mesafe / saat;
                } } 
        public double HedeflenenMesafe { get; set; }
        public TimeOnly HedeflenenSure { get; set; }
    }
}
