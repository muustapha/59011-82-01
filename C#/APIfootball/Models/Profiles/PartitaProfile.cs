using AutoMapper;

namespace APIfootball
{
    public class PartitaProfile : Profile
    {

        public PartitaProfile()
        {

            CreateMap<Partita, PartitaDTOIn>();
            CreateMap<PartitaDTOIn, Partita>();

            CreateMap<Partita, PartitaDTOAvecArbitre>();
            CreateMap<PartitaDTOAvecArbitre, Partita>();

            CreateMap<Partita, PartitaDTOAvecEquipe>();
            CreateMap<PartitaDTOAvecEquipe, Partita>();

            CreateMap<Partita, PartitaDTOOut>();
            CreateMap<PartitaDTOOut, Partita>();


        }
    }
}
