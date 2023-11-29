using API2.Models.data;

using API2.Models.Dtos;
using AutoMapper;

namespace API2.Models.profiles
{
    public class RelationsProfile : Profile
    {
        public RelationsProfile()
        {
            CreateMap<Relation, RelationsDTO>();
            CreateMap<RelationsDTO, Relation>();
        }
    }
}
