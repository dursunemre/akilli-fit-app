namespace AkilliFitApp.API.Entities
{
    public class Besin
    {
        public int Id { get; set; }

        public required string Ad { get; set; }
        public int Kalori100gr { get; set; }
        public double Protein100gr { get; set; }
        public double Yag100gr { get; set; }
        public double Karbonhidrat100gr { get; set; }

        public ICollection<DiyetBesin> DiyetBesinler { get; set; } = new List<DiyetBesin>();

        public Besin() { }

        public Besin(string ad, int kalori100gr, double protein100gr, double yag100gr, double karbonhidrat100gr)
        {
            Ad = ad;
            Kalori100gr = kalori100gr;
            Protein100gr = protein100gr;
            Yag100gr = yag100gr;
            Karbonhidrat100gr = karbonhidrat100gr;
        }
    }
}
