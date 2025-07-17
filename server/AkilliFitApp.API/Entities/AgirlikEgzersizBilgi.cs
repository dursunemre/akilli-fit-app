namespace AkilliFitApp.API.Entities
{
    public class AgirlikEgzersizBilgi : EgzersizBilgi 
    {
        public override string Ad => kardiyoEgzersiz.Ad;

        public int Set { get; set; }
        public int Tekrar { get; set; }
        public double AgirlikKG { get; set; }
        public double HedeflenenAgirlikKG { get; set; }
        public double EgzersizVolumeKG => Set * Tekrar * AgirlikKG; 

        public required KardiyoEgzersiz kardiyoEgzersiz { get; set; }
        public required EgzersizProgram egzersizProgram { get; set; }

        public AgirlikEgzersizBilgi() { }

        public AgirlikEgzersizBilgi(int set, int tekrar, double agirlikKG, double hedeflenenAgirlikKG, KardiyoEgzersiz kardiyoEgzersiz, EgzersizProgram egzersizProgram)
        {
            Set = set;
            Tekrar = tekrar;
            AgirlikKG = agirlikKG;
            HedeflenenAgirlikKG = hedeflenenAgirlikKG;
            this.kardiyoEgzersiz = kardiyoEgzersiz;
            this.egzersizProgram = egzersizProgram;
        }
    }
}
