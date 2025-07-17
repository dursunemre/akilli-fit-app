namespace AkilliFitApp.API.Entities
{
    public class EgzersizProgramı
    {
        public required string Uid { get; set; }
        public int Id { get; set; }
        public required string Ad { get; set; }
        public required Kullanici Kullanici { get; set; }
        public ICollection<IEgzersiz> Egzersizler { get; set; } = new List<IEgzersiz>();
    }
}
