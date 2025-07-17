namespace AkilliFitApp.API.Entities
{
    public class DiyetBesin
    {
        public int Id { get; set; }
        public string Ad => Besin.Ad;
        public double Gramaj { get; set; }
        public required Besin Besin { get; set; }

        public double TotalKalori { get { return Besin.Kalori100gr * ( Gramaj / 100.0); } }
        public double TotalProtein { get { return Besin.Protein100gr * ( Gramaj / 100.0); } }
        public double TotalYag { get { return Besin.Yag100gr * (Gramaj / 100.0); } }
        public double TotalKarbonhidrat { get { return Besin.Karbonhidrat100gr * (Gramaj / 100.0); } }

        public required DiyetProgram DiyetPrograms { get; set; } 

        public DiyetBesin() { }

        public DiyetBesin(Besin besin, double gramaj)
        {
            Besin = besin;
            Gramaj = gramaj;
        }
    }
}
