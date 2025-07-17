namespace AkilliFitApp.API.Entities
{
    public class DiyetProgram
    {
        public int Id { get; set; }
        public required string Ad { get; set; }
        public ICollection<DiyetBesin> DiyetBesinleri { get; set; } = new List<DiyetBesin>();

        public DiyetProgram() { }

        public DiyetProgram(string ad)
        {
            this.Ad = ad;
        }
    }
}
