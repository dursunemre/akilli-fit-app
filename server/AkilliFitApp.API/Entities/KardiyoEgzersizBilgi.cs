using AkilliFitApp.API.Entities;
using System.Security.Cryptography.X509Certificates;

namespace AkilliFitApp.API.Entities
{
    public class KardiyoEgzersizBilgi : EgzersizBilgi
    {
        public override string Ad => KardiyoEgzersiz.Ad;
        public double MesafeMtr { get; set; }
        public TimeOnly Sure { get; set; }
        public double Hız
        {
            get
            {
                double saat = Sure.Hour + Sure.Minute / 60.0 + Sure.Second / 3600.0;
                return MesafeMtr / saat;
            }
        }
        public double HedeflenenMesafe { get; set; }
        public TimeOnly HedeflenenSure { get; set; }

        public required KardiyoEgzersiz KardiyoEgzersiz { get; set; }
        public required EgzersizProgram EgzersizProgram { get; set; }

        public KardiyoEgzersizBilgi() { }

        public KardiyoEgzersizBilgi(double mesafeMtr, TimeOnly sure, double hedeflenenMesafe, TimeOnly hedeflenenSure, KardiyoEgzersiz kardiyoEgzersizi, EgzersizProgram egzersizProgrami)
        {
            MesafeMtr = mesafeMtr;
            Sure = sure;
            HedeflenenMesafe = hedeflenenMesafe;
            HedeflenenSure = hedeflenenSure;
            KardiyoEgzersiz = kardiyoEgzersizi;
            EgzersizProgram = egzersizProgrami;
        }
    }
}
