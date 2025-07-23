using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AkilliFitApp.Domain.Entities;
using AkilliFitApp.Application.DTOs;

namespace AkilliFitApp.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<KullaniciCreateDto, Kullanici>()
                .ForMember(dest => dest.ProfilResmiUrl, opt => opt.Ignore());

            CreateMap<Kullanici, KullaniciReadDto>();

            CreateMap<KullaniciUpdateDto, Kullanici>()
                .ForAllMembers(opt =>
                    opt.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<EgzersizProgramCreateDto, EgzersizProgram>();
            CreateMap<EgzersizProgram, EgzersizProgramReadDto>();
            CreateMap<EgzersizProgramUpdateDto, EgzersizProgram>();


            CreateMap<AgirlikEgzersizBilgiCreateDto, AgirlikEgzersizBilgi>();
            CreateMap<AgirlikEgzersizBilgi, AgirlikEgzersizBilgiReadDto>();
            CreateMap<AgirlikEgzersizBilgiUpdateDto, AgirlikEgzersizBilgi>()
                .ForAllMembers(opt =>
                    opt.Condition((src, dest, srcMember) => srcMember != null));


            CreateMap<KardiyoEgzersizBilgiCreateDto, KardiyoEgzersizBilgi>();
            CreateMap<KardiyoEgzersizBilgi, KardiyoEgzersizBilgiReadDto>();
            CreateMap<KardiyoEgzersizBilgiUpdateDto, KardiyoEgzersizBilgi>()
                .ForAllMembers(opt =>
                    opt.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<BesinCreateDto, Besin>();
            CreateMap<Besin, BesinReadDto>();
            CreateMap<BesinUpdateDto, Besin>();

            CreateMap<DiyetProgramCreateDto, DiyetProgram>();
            CreateMap<DiyetProgram, DiyetProgramReadDto>();
            CreateMap<DiyetProgramUpdateDto, DiyetProgram>();

            CreateMap<DiyetBesinCreateDto, DiyetBesin>();
            CreateMap<DiyetBesin, DiyetBesinReadDto>();
            CreateMap<DiyetBesinUpdateDto, DiyetBesin>();
        }
    }
}
