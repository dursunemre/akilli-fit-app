namespace AkilliFitApp.Domain.Entities
{
    public class AgirlikEgzersiz 
    {
        public int Id { get; set; }
        public required string Ad { get; set; }
        public ICollection<AgirlikEgzersizBilgi> AgirlikEgzersizBilgileri { get; set; } = new List<AgirlikEgzersizBilgi>();

        public AgirlikEgzersiz() { }

        public AgirlikEgzersiz(string ad)
        {
            Ad = ad;
        }
    }
}
