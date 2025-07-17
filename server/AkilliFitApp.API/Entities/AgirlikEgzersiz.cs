namespace AkilliFitApp.API.Entities
{
    public class AgirlikEgzersiz : Egzersiz
    {
        public int Set { get; set; }
        public int Tekrar { get; set; }
        public double AgirlikKG { get; set; }
        public double HedeflenenAgirlikKG { get; set; }
        public double EgzersizVolumeKG { get { return Set * Tekrar * AgirlikKG; } }
    }
}
