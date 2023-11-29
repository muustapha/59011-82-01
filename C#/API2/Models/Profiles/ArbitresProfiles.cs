using API2.Models.Dtos;
using AutoMapper;
using API2.Models.data;

namespace API2.Models.Profiles
{
    public class ArbitresProfiles
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
}
