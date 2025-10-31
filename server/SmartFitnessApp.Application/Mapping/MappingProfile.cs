using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmartFitnessApp.Domain.Entities;
using SmartFitnessApp.Application.DTOs.Exercise.Program;
using SmartFitnessApp.Application.DTOs.ExerciseInfo;
using SmartFitnessApp.Application.DTOs.Diet.Food;
using SmartFitnessApp.Application.DTOs.Diet.Program;
using SmartFitnessApp.Application.DTOs.User;

namespace SmartFitnessApp.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserCreateDto, User>()
                .ForMember(dest => dest.ProfilePictureUrl, opt => opt.Ignore());

            CreateMap<User, UserReadDto>();

            CreateMap<UserUpdateDto, User>()
                .ForAllMembers(opt =>
                    opt.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ExerciseProgramCreateDto, ExerciseProgram>();
            CreateMap<ExerciseProgram, ExerciseProgramReadDto>();
            CreateMap<ExerciseProgramUpdateDto, ExerciseProgram>();

            CreateMap<ExerciseInfo, ExerciseInfoReadDto>()
                .Include<WeightExerciseInfo, WeightExerciseInfoReadDto>()
                .Include<CardioExerciseInfo, CardioExerciseInfoReadDto>();
            CreateMap<ExerciseInfo, ExerciseInfoCreateDto>()
                .Include<WeightExerciseInfo, WeightExerciseInfoCreateDto>()
                .Include<CardioExerciseInfo, CardioExerciseInfoCreateDto>();
            CreateMap<ExerciseInfo, ExerciseInfoUpdateDto>()
                .Include<WeightExerciseInfo, WeightExerciseInfoUpdateDto>()
                .Include<CardioExerciseInfo, CardioExerciseInfoUpdateDto>();

            CreateMap<WeightExerciseInfoCreateDto, WeightExerciseInfo>();
            CreateMap<WeightExerciseInfo, WeightExerciseInfoReadDto>();
            CreateMap<WeightExerciseInfoUpdateDto, WeightExerciseInfo>()
                .ForAllMembers(opt =>
                    opt.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<CardioExerciseInfoCreateDto, CardioExerciseInfo>();
            CreateMap<CardioExerciseInfo, CardioExerciseInfoReadDto>();
            CreateMap<CardioExerciseInfoUpdateDto, CardioExerciseInfo>()
                .ForAllMembers(opt =>
                    opt.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<FoodCreateDto, Food>();
            CreateMap<Food, FoodReadDto>();
            CreateMap<FoodUpdateDto, Food>();

            CreateMap<DietProgramCreateDto, DietProgram>();
            CreateMap<DietProgram, DietProgramReadDto>();
            CreateMap<DietProgramUpdateDto, DietProgram>();

            CreateMap<DietFoodCreateDto, DietFood>();
            CreateMap<DietFood, DietFoodReadDto>();
            CreateMap<DietFoodUpdateDto, DietFood>();
        }
    }
}
