using System.ComponentModel.DataAnnotations;

namespace AkilliFitApp.Domain.Entities
{
    public class KardiyoEgzersiz : Egzersiz
    {
        public ICollection<KardiyoEgzersizBilgi> KardiyoEgzersizBilgileri { get; set; } = [];

        public KardiyoEgzersiz() { }

        public KardiyoEgzersiz(string ad)
        {
            Ad = ad;
        }
    }
}
