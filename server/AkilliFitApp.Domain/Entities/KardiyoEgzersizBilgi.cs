using System.Security.Cryptography.X509Certificates;

namespace AkilliFitApp.Domain.Entities
{
    public class KardiyoEgzersizBilgi : EgzersizBilgi
    {
        public double MesafeMtr { get; set; }
        public TimeOnly Sure { get; set; }
        public double Hız => MesafeMtr / (Sure.Hour + Sure.Minute / 60.0 + Sure.Second / 3600.0);
        public double HedeflenenMesafe { get; set; }
        public TimeOnly HedeflenenSure { get; set; }

        public KardiyoEgzersizBilgi() { }

        public KardiyoEgzersizBilgi(double mesafeMtr, TimeOnly sure, double hedeflenenMesafe, TimeOnly hedeflenenSure, Egzersiz kardiyoEgzersiz, EgzersizProgram egzersizProgram)
        {
            if (kardiyoEgzersiz is not KardiyoEgzersiz)
                throw new ArgumentException(
                  "KardiyoEgzersizBilgi için mutlaka KardiyoEgzersiz örneği gelmeli.",
                  nameof(kardiyoEgzersiz)
                );

            MesafeMtr = mesafeMtr;
            Sure = sure;
            HedeflenenMesafe = hedeflenenMesafe;
            HedeflenenSure = hedeflenenSure;
            Egzersiz = kardiyoEgzersiz;
            EgzersizProgram = egzersizProgram;
        }
    }
}
