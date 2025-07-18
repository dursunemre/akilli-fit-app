namespace AkilliFitApp.Domain.Entities
{
    public class AgirlikEgzersizBilgi : EgzersizBilgi 
    {
        public override string Ad => agirlikEgzersiz.Ad;

        public int Set { get; set; }
        public int Tekrar { get; set; }
        public double AgirlikKG { get; set; }
        public double HedeflenenAgirlikKG { get; set; }
        public double EgzersizVolumeKG => Set * Tekrar * AgirlikKG; 

        public required AgirlikEgzersiz agirlikEgzersiz { get; set; }
        public required EgzersizProgram egzersizProgram { get; set; }

        public AgirlikEgzersizBilgi() { }

        public AgirlikEgzersizBilgi(int set, int tekrar, double agirlikKG, double hedeflenenAgirlikKG, AgirlikEgzersiz agirlikEgzersiz, EgzersizProgram egzersizProgram)
        {
            Set = set;
            Tekrar = tekrar;
            AgirlikKG = agirlikKG;
            HedeflenenAgirlikKG = hedeflenenAgirlikKG;
            this.kardiyoEgzersiz = agirlikEgzersiz;
            this.egzersizProgram = egzersizProgram;
        }
    }
}
