using System.ComponentModel.DataAnnotations;

namespace AkilliFitApp.Domain.Entities
{
    public class KardiyoEgzersiz : Egzersiz
    {
        public ICollection<KardiyoEgzersizBilgi> KardiyoEgzersizBilgileri { get; set; } = new List<KardiyoEgzersizBilgi>();

        public KardiyoEgzersiz() { }

        public KardiyoEgzersiz(string ad)
        {
            Ad = ad;
        }
    }
}
