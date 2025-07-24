using AkilliFitApp.Application.DTOs.Egzersiz;
using AkilliFitApp.Application.DTOs.EgzersizBilgi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkilliFitApp.Application.DTOs.Wrapper
{
    public class EgzersizVeBilgiReadDto
    {
        public required EgzersizReadDto egzersiz {  get; set; }
        public required EgzersizBilgiReadDto EgzersizBilgi { get; set; }
    }
}
