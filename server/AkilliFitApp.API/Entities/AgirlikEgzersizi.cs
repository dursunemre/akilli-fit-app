namespace AkilliFitApp.API.Entities
{
    public class AgirlikEgzersizi : IEgzersiz
    {
        public int Id { get; set; }
        public required string Ad { get; set; }
        public int Set { get; set; }
        public int Tekrar { get; set; }
        public double Agirlik { get; set; }
        public double HedeflenenAgirlik { get; set; }
        public double EgzersizVolume { get { return Set * Tekrar * Agirlik; } }
    }
}
