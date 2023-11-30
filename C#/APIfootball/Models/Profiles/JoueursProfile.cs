using AutoMapper;
namespace APIfootball
{
    public class JoueursProfile : Profile
    {

        public JoueurssProfile()
        {

            CreateMap<Joueurs, JoueursDTOIn>();
            CreateMap<JoueursDTOIn, Joueurs>();

            CreateMap<Joueurs, JoueursDTOAvecEquipe>();
            CreateMap<JoueursDTOAvecEquipe, Joueurs>();

            CreateMap<Joueurs, JoueursDTOOut>();
            CreateMap<JoueursDTOOut, Joueurs>();

            CreateMap<Joueurs, JoueursDTOAvecRelation>();
            CreateMap<JoueursDTOAvecRelation, Joueurs>();

        }
    }
}
