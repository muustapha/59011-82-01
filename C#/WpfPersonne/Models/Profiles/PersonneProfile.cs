using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using WpfDbPersonne.Models.Data;
using WpfDbPersonne.Models.Dtos;

namespace WpfDbPersonne.Models.Profiles
{
    public class PersonneProfile : Profile
    {
        public PersonneProfile()
        {
            CreateMap<Personne, PersonneDTO>();
            CreateMap<PersonneDTO, Personne>();
        }
    }
}