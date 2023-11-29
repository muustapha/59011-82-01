using API2.Models.data;
using API2.Models.Dtos.API2.Models.Dtos;
using AutoMapper;

namespace API2.Models.profiles
    {
        public class JoueursProfile : Profile
        {
            public JoueursProfile()
            {
                CreateMap<Joueur, JoueursDTO>();
                CreateMap<JoueursDTO, Joueur>();
            }
        }
    }
