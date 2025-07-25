namespace AkilliFitApp.Domain.Entities
{
    public class DiyetProgram
    {
        public int Id { get; set; }
        public required string Ad { get; set; }

        public required int KullaniciId { get; set; }
        public required Kullanici Kullanici { get; set; } 
        public ICollection<DiyetBesin> DiyetBesinleri { get; set; } = [];

        public DiyetProgram() { }

        public DiyetProgram(string ad)
        {
            Ad = ad;
        }
    }
}
