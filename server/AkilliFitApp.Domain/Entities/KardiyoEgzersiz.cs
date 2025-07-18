using System.ComponentModel.DataAnnotations;

namespace AkilliFitApp.Domain.Entities
{
    public class KardiyoEgzersiz 
    {
        public int Id { get; set; }
        public required string Ad { get; set; }
        public ICollection<KardiyoEgzersizBilgi> KardiyoEgzersizBilgileri { get; set; } = new List<KardiyoEgzersizBilgi>();

        public KardiyoEgzersiz() { }

        public KardiyoEgzersiz(string ad)
        {
            Ad = ad;
        }
    }
}
