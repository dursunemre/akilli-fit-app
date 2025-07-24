using System;

namespace AkilliFitApp.Application.DTOs.Kullanici
{
    public class KullaniciReadDto
    {
        public string Id { get; set; } = null!;
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public DateOnly DogumTarihi { get; set; }
        public string Cinsiyet { get; set; } = null!;
        public double Kilo { get; set; }
        public double HedefKilo { get; set; }
        public int AktiviteSeviyesi { get; set; }
        public string? ProfilResmiUrl { get; set; }
    }
}
