namespace AkilliFitApp.Domain.Entities
{
    public class AgirlikEgzersizBilgi : EgzersizBilgi 
    {
        public int Set { get; set; }
        public int Tekrar { get; set; }
        public double AgirlikKG { get; set; }
        public double HedeflenenAgirlikKG { get; set; }
        public double EgzersizVolumeKG => Set * Tekrar * AgirlikKG;

        public AgirlikEgzersizBilgi() { }

        public AgirlikEgzersizBilgi(int set, int tekrar, double agirlikKG, double hedeflenenAgirlikKG, Egzersiz agirlikEgzersiz, EgzersizProgram egzersizProgram)
        {
            if (agirlikEgzersiz is not AgirlikEgzersiz)
                throw new ArgumentException(
                  "AgirlikEgzersizBilgi için mutlaka AgirlikEgzersiz örneği gelmeli.",
                  nameof(agirlikEgzersiz)
                );

            Set = set;
            Tekrar = tekrar;
            AgirlikKG = agirlikKG;
            HedeflenenAgirlikKG = hedeflenenAgirlikKG;
            Egzersiz = agirlikEgzersiz;
            EgzersizProgram = egzersizProgram;
        }
    }
}
