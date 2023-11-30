using AutoMapper;
using System.Diagnostics;

namespace APIfootball
{
    public class ArbitresProfile : Profile
    {

      
            public ArbitresProfile()
            {

                CreateMap<Arbitre, ArbitreDTOIn>();
                CreateMap<ArbitreDTOIn, Arbitre>();

                CreateMap<Arbitre, ArbitreDTOOut>();
                CreateMap<Arbitre, ArbitreDTOAvecPartita>();
                CreateMap<ArbitreDTOOut, Arbitre>();
                CreateMap<ArbitreDTOAvecPartita, Arbitre>();
            }
        }
    }

