using API1.Models.data;
using API1.Models.Dtos;
using AutoMapper;

namespace API1.Models.profiles
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
