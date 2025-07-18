namespace AkilliFitApp.Domain.Entities
{
    public class EgzersizProgram
    {
        public int Id { get; set; }
        public required string Ad { get; set; }
        public required Kullanici Kullanici { get; set; }
        public ICollection<EgzersizBilgi> KardiyoEgzersizBilgi { get; set; } = new List<EgzersizBilgi>();
        public EgzersizProgram() { }

        public EgzersizProgram(string ad, Kullanici kullanici)
        {
            Ad = ad;
            Kullanici = kullanici;
        }
    }
}
