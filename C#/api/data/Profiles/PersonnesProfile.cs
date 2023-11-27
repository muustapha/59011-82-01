
using AutoMapper;


namespace API.DATA.Profiles
{
    public class PersonnesProfile : Profile
    {
        public PersonnesProfile()
        {
            CreateMap<Models.Personne, Dtos.PersonnesDTO>();
            CreateMap<Dtos.PersonnesDTO, Models.Personne>();
        }
    }
}
