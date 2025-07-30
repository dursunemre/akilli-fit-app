namespace AkilliFitApp.Domain.Entities
{
    public class EgzersizProgram
    {
        public int Id { get; set; }
        public required string Ad { get; set; }

        public int KullaniciId { get; set; }
        public required Kullanici Kullanici { get; set; }

        public ICollection<EgzersizBilgi> EgzersizBilgi { get; set; } = [];

        public EgzersizProgram() { }

        public EgzersizProgram(string ad, Kullanici kullanici)
        {
            Ad = ad;
            Kullanici = kullanici;
        }
    }
}
