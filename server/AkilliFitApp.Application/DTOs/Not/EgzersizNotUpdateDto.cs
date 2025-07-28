using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.DTOs.Not
{
    internal class EgzersizNotUpdateDto
    {
        public string Ad { get; set; } = string.Empty;
        public string Icerik { get; set; } = string.Empty;
        public int EgzersizBilgiId { get; set; }
    }
}
