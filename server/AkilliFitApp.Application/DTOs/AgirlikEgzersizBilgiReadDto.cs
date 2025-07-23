namespace AkilliFitApp.Application.DTOs
{
    public class AgirlikEgzersizBilgiReadDto
    {
        public int Id { get; set; }
        public int EgzersizProgramId { get; set; }
        public int Set { get; set; }
        public int Tekrar { get; set; }
        public double AgirlikKG { get; set; }
        public double HedeflenenAgirlikKG { get; set; }
        public double EgzersizVolumeKG { get; set; }
        public int AgirlikEgzersizId { get; set; }
    }
}
