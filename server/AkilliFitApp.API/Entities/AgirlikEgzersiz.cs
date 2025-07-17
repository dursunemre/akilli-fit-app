namespace AkilliFitApp.API.Entities
{
    public class AgirlikEgzersiz 
    {
        public int Id { get; set; }
        public required string Ad { get; set; }
        public ICollection<AgirlikEgzersizBilgi> AgirilkEgzersizBilgi { get; set; } = new List<AgirlikEgzersizBilgi>();

        public AgirlikEgzersiz() { }

        public AgirlikEgzersiz(string ad)
        {
            Ad = ad;
        }
    }
}
