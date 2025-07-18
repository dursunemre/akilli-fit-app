using System.Security.Cryptography.X509Certificates;

namespace AkilliFitApp.Domain.Entities
{
    public class KardiyoEgzersizBilgi : EgzersizBilgi
    {
        public override string Ad => KardiyoEgzersiz.Ad;
        public double MesafeMtr { get; set; }
        public TimeOnly Sure { get; set; }
        public double Hız => MesafeMtr / (Sure.Hour + Sure.Minute / 60.0 + Sure.Second / 3600.0);
        public double HedeflenenMesafe { get; set; }
        public TimeOnly HedeflenenSure { get; set; }

        public int KardiyoEgzersizId { get; set; }
        public required KardiyoEgzersiz KardiyoEgzersiz { get; set; }

        public KardiyoEgzersizBilgi() { }

        public KardiyoEgzersizBilgi(double mesafeMtr, TimeOnly sure, double hedeflenenMesafe, TimeOnly hedeflenenSure, KardiyoEgzersiz kardiyoEgzersiz, EgzersizProgram egzersizProgram)
        {
            MesafeMtr = mesafeMtr;
            Sure = sure;
            HedeflenenMesafe = hedeflenenMesafe;
            HedeflenenSure = hedeflenenSure;
            this.KardiyoEgzersiz = kardiyoEgzersiz;
            this.EgzersizProgram = egzersizProgram;
        }
    }
}
