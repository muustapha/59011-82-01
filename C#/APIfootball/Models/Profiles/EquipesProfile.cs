using AutoMapper;

namespace APIfootball
{
    public class EquipesProfile : Profile
    {
    

    public EquipesProfile()
    {

        CreateMap<Equipe, EquipeDTOIn>();
        CreateMap<EquipeDTOIn, Equipe>();
        CreateMap<Equipe, EquipeDTOAvecArbitre>();
        CreateMap<EquipeDTOAvecArbitre, Equipe>();

        CreateMap<Equipe, EquipeDTOOut>();
        CreateMap<EquipeDTOOut, Equipe>();

        CreateMap<Equipe, EquipeDTOAvecArbitreEtPartita>();
        CreateMap<EquipeDTOAvecArbitreEtPartita, Equipe>(); 
        
        CreateMap<Equipe, EquipeDTOAvecRelation>();
        CreateMap<EquipeDTOAvecRelation, Equipe>();

    }
}
}

