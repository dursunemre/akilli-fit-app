namespace AkilliFitApp.Application.DTOs.EgzersizBilgi
{
    public class AgirlikEgzersizBilgiReadDto : EgzersizBilgiReadDto
    {
        public int Set { get; set; }
        public int Tekrar { get; set; }
        public double AgirlikKG { get; set; }
        public double HedeflenenAgirlikKG { get; set; }
        public double EgzersizVolumeKG { get; set; }
        public int AgirlikEgzersizId { get; set; }
    }
}
