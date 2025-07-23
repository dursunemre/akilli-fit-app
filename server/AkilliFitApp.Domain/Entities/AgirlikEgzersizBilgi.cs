namespace AkilliFitApp.Domain.Entities
{
    public class AgirlikEgzersizBilgi : EgzersizBilgi 
    {
        public int Set { get; set; }
        public int Tekrar { get; set; }
        public double AgirlikKG { get; set; }
        public double HedeflenenAgirlikKG { get; set; }
        public double EgzersizVolumeKG => Set * Tekrar * AgirlikKG;

        public int AgirlikEgzersizId { get; set; }
        public required AgirlikEgzersiz AgirlikEgzersiz { get; set; }

        public AgirlikEgzersizBilgi() { }

        public AgirlikEgzersizBilgi(int set, int tekrar, double agirlikKG, double hedeflenenAgirlikKG, AgirlikEgzersiz agirlikEgzersiz, EgzersizProgram egzersizProgram)
        {
            Set = set;
            Tekrar = tekrar;
            AgirlikKG = agirlikKG;
            HedeflenenAgirlikKG = hedeflenenAgirlikKG;
            AgirlikEgzersiz = agirlikEgzersiz;
            EgzersizProgram = egzersizProgram;
        }
    }
}
