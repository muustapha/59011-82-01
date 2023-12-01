using AutoMapper;

namespace APIfootball
{
    public class JoueursProfile : Profile
    {

        public JoueursProfile()
        {

            CreateMap<Joueur, JoueurDTOIn>();
            CreateMap<JoueurDTOIn, Joueur>();

            

            CreateMap<Joueur, JoueurDTOOut>();
            CreateMap<JoueurDTOOut, Joueur>();

            CreateMap<Joueur, JoueurDTOAvecRelation>();
            CreateMap<JoueurDTOAvecRelation, Joueur>();

        }
    }
}
