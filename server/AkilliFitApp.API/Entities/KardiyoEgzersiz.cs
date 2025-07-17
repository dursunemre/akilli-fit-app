using System.ComponentModel.DataAnnotations;

namespace AkilliFitApp.API.Entities
{
    public class KardiyoEgzersiz 
    {
        public int Id { get; set; }
        public required string Ad { get; set; }
        public ICollection<KardiyoEgzersizBilgi> ProgramKardiyoEgzersizler { get; set; } = new List<KardiyoEgzersizBilgi>();

        public KardiyoEgzersiz() { }

        public KardiyoEgzersiz(string ad)
        {
            Ad = ad;
        }
    }
}
