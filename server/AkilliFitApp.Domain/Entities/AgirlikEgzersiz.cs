namespace AkilliFitApp.Domain.Entities
{
    public class AgirlikEgzersiz : Egzersiz
    {
        public ICollection<AgirlikEgzersizBilgi> AgirlikEgzersizBilgileri { get; set; } = [];

        public AgirlikEgzersiz() { }

        public AgirlikEgzersiz(string ad)
        {
            Ad = ad;
        }
    }
}
