using API2.Models.data;
using AutoMapper;
using API2.Models.Dtos;

namespace API2.Models.profiles
    {
        public class EquipesProfile : Profile
        {
            public EquipesProfile()
            {
                CreateMap<Equipe, EquipesDTO>();
                CreateMap<EquipesDTO, Equipe>();
            }
        }
    }

