using AutoMapper;
using PersonnesApi.data.Models;
using PersonnesApi.data.Dtos;
namespace api.data.profiles
{
    public class PersonnesProfiles : Profile
    {
        public PersonnesProfiles()
        {
            CreateMap<Personne, PersonnesDTO>();
            CreateMap<PersonnesDTO, Personne>();
        }
    }
}