using AutoMapper;
using API1.Models.Dtos;
using API1.Models.data;

namespace API1.Models.profiles
{
    public class ArbitresProfile : Profile
    {
        public ArbitresProfile()
        {
            CreateMap<Arbitre, ArbitresDTO>();
            CreateMap<ArbitresDTO, Arbitre>();
        }
    }
}