using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.DTOs.Egzersiz
{
    public abstract class EgzersizReadDto
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
    }
}
