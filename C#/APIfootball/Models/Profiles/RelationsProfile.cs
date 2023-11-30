using AutoMapper;

namespace APIfootball
{
    public class RelationsProfile : Profile
    {
        public RelationsProfile()
        {

            CreateMap<Relation, RelationDTOIn>();
            CreateMap<RelationDTOIn, Relation>();

            CreateMap<Relation, RelationDTOAvecRelation>();
            CreateMap<RelationDTOAvecRelation, Relation>();

            CreateMap<Relation, RelationDTOAvecJoueurs>();
            CreateMap<RelationDTOAvecJoueurs, Relation>();

            CreateMap<Relation, RelationDTOOut>();
            CreateMap<RelationDTOOut, Relation>();

            CreateMap<Relation, RelationDTOAvecEquipe>();
            CreateMap<RelationDTOAvecEquipe, Relation>();

        }
    }
}
