using AkilliFitApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkilliFitApp.Application.DTOs.Egzersiz;
using AkilliFitApp.Application.DTOs.Egzersiz.Program;

namespace AkilliFitApp.Application.DTOs.EgzersizBilgi
{
    public abstract class EgzersizBilgiReadDto
    {
        public int Id { get; set; }

        public int EgzersizProgramId { get; set; }
        public EgzersizProgramReadDto EgzersizProgram { get; set; } = null!;
        public int EgzersizId { get; set; }
        public EgzersizReadDto Egzersiz { get; set; } = null!;
    }
}
