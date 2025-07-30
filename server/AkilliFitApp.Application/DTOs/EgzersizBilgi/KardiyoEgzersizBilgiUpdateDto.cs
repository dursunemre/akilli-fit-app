using System;

namespace AkilliFitApp.Application.DTOs.EgzersizBilgi
{
    public class KardiyoEgzersizBilgiUpdateDto : EgzersizBilgiUpdateDto
    {
        public double MesafeMtr { get; set; }
        public TimeOnly Sure { get; set; }
        public double HedeflenenMesafe { get; set; }
        public TimeOnly HedeflenenSure { get; set; }
    }
}
