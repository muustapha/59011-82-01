using AutoMapper;
using static APIfootball.EquipesDTO;

namespace APIfootball
{
    public class EquipesProfile : Profile
    {
    

    public EquipesProfile()
    {

        CreateMap<Equipe, EquipeDTOIn>();
        CreateMap<EquipeDTOIn, Equipe>();

        CreateMap<Equipe, EquipeDTOOut>();
        CreateMap<EquipeDTOOut, Equipe>();

        CreateMap<Equipe, EquipeDTOAvecPartita>();
        CreateMap<EquipeDTOAvecPartita, Equipe>();

        CreateMap<Equipe, EquipeDTORelationAvecJoueur>();
            CreateMap<EquipeDTORelationAvecJoueur, Equipe>();

    }
}
}

