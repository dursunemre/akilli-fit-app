

namespace AkilliFitApp.API.Entities
{
    public class Kullanici
    {
        public required string Uid { get; set; }
        public required string Ad { get; set; }
        public required string Soyad { get; set; }
        public DateOnly DogumTarihi { get; set; }
        public required string Cinsiyet { get; set; }
        public float Kilo { get; set; }
        public float HedefKilo { get; set; }
        public int AktiviteSeviyesi { get; set; }
        public required string ProfilResmiUrl { get; set; }
    }
}
