using AkilliFitApp.Application.DTOs.Diyet.Besin;
using AkilliFitApp.Application.DTOs.Diyet.Program;
using AkilliFitApp.Application.DTOs.Egzersiz.Program;
using AkilliFitApp.Application.DTOs.Kullanici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.DTOs.Wrapper
{
    public class KullaniciBilgileriReadDto
    {
        public required KullaniciReadDto kullaniciBilgileri { get; set; }
        public IEnumerable<EgzersizProgramReadDto>? egzersizProgram { get; set; }
        public IEnumerable<EgzersizVeBilgiReadDto>? egzersizVeBilgi { get; set; } 
        public IEnumerable<DiyetProgramReadDto>? diyetProgram { get; set;}
        public IEnumerable<DiyetBesinReadDto>? diyetBesin { get; set; }
    }
}
