using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Domain.Entities
{
    public class EgzersizNot
    {
        public int Id { get; set; }
        public required string Ad { get; set; }
        public required string Icerik { get; set; }

        public int EgzersizBilgiId { get; set; }
        public required EgzersizBilgi EgzersizBilgi { get; set; }
    }
}
