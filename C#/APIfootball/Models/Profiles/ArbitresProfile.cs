using AutoMapper;
using System.Diagnostics;
using static APIfootball.ArbitreDTO;

namespace APIfootball
{
    public class ArbitresProfile : Profile
    {


        public ArbitresProfile()
        {

            CreateMap<Arbitre, ArbitreDTOIn>();
            CreateMap<ArbitreDTOIn, Arbitre>();

            CreateMap<Arbitre, ArbitreDTOOut>();
            CreateMap<ArbitreDTOOut, Arbitre>();

            CreateMap<ArbitreDTOAvecPartita, Arbitre>();
            CreateMap<Arbitre, ArbitreDTOAvecPartita>();
        }
        }
    }

