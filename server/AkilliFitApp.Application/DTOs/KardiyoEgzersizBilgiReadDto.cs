using System;

namespace AkilliFitApp.Application.DTOs
{
    public class KardiyoEgzersizBilgiReadDto
    {
        public int Id { get; set; }
        public int EgzersizProgramId { get; set; }
        public double MesafeMtr { get; set; }
        public TimeOnly Sure { get; set; }
        public double Hız { get; set; }
        public double HedeflenenMesafe { get; set; }
        public TimeOnly HedeflenenSure { get; set; }
        public int KardiyoEgzersizId { get; set; }
    }
}
