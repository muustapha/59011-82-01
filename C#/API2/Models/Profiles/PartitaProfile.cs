using API2.Models.data;
using API2.Models.Dtos;
using AutoMapper;

namespace API2.Models.Profiles
{
    public class PartitaProfile : Profile
    {
        
            public PartitaProfile()
            {
                CreateMap<Partita, PartitaDTO>();
                CreateMap<PartitaDTO, Partita>();
            }
        }
    }

