using AutoMapper;

namespace APIfootball.Models.Services
{
    public class ArbitresPartitaProfile : Profile
    {
       
     
            public ArbitresPartitaProfile()
            {

                CreateMap<ArbitresPartita ArbitresPartitaDTOIn>();
                CreateMap<ArbitresPartitaDTOIn, ArbitresPartita>();

                CreateMap<ArbitresPartita ArbitresPartitaDTOAvecArbitreEtPartita>();
                CreateMap<ArbitresPartitaDTOAvecArbitreEtPartita, ArbitresPartita>();

                CreateMap<ArbitresPartita ArbitresPartitaDTOAvecArbitre>();
                CreateMap<ArbitresPartitaDTOAvecArbitre, ArbitresPartita>();

                CreateMap<ArbitresPartita ArbitresPartitaDTOOut>();
                CreateMap<ArbitresPartitaDTOOut, ArbitresPartita>();

                CreateMap<ArbitresPartita ArbitresPartitaDTOAvecPartita>();
                CreateMap<ArbitresPartitaDTOAvecPartita, ArbitresPartita>();

            }
        }
    }

