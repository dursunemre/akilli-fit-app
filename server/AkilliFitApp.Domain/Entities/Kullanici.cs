using System.ComponentModel.DataAnnotations;

namespace AkilliFitApp.Domain.Entities
{
    public class Kullanici
    {
        [Key]
        public required string Uid { get; set; }
        public required string Ad { get; set; }
        public required string Soyad { get; set; }
        public DateOnly DogumTarihi { get; set; }
        public required string Cinsiyet { get; set; }
        public double Kilo { get; set; }
        public double HedefKilo { get; set; }
        public int AktiviteSeviyesi { get; set; }
        public required string ProfilResmiUrl { get; set; }
        public ICollection<EgzersizProgram> Programlar { get; set; } = new List<EgzersizProgram>();
    }
}
