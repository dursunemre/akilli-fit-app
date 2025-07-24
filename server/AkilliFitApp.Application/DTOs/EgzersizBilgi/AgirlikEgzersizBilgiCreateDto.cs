namespace AkilliFitApp.Application.DTOs.EgzersizBilgi
{
    public class AgirlikEgzersizBilgiCreateDto
    {
        public int EgzersizProgramId { get; set; }
        public int Set { get; set; }
        public int Tekrar { get; set; }
        public double AgirlikKG { get; set; }
        public double HedeflenenAgirlikKG { get; set; }
        public int AgirlikEgzersizId { get; set; }
    }
}
