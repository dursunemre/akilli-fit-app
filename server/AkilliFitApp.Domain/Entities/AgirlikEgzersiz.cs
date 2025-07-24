namespace AkilliFitApp.Domain.Entities
{
    public class AgirlikEgzersiz : Egzersiz
    {
        public ICollection<AgirlikEgzersizBilgi> AgirlikEgzersizBilgileri { get; set; } = new List<AgirlikEgzersizBilgi>();

        public AgirlikEgzersiz() { }

        public AgirlikEgzersiz(string ad)
        {
            Ad = ad;
        }
    }
}
