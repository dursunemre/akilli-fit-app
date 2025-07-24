using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.DTOs.EgzersizBilgi
{
    public abstract class EgzersizBilgiReadDto
    {
        public int Id { get; set; }
        public int EgzersizProgramId { get; set; }
    }
}
