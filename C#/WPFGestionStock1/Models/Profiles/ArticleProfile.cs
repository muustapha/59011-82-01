using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFGestionStock1.Models.Dtos;
using WPFGestionStock1.Models.Data;

namespace WPFGestionStock1.Models.Profiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article, ArticleDTOIn>();
            CreateMap<ArticleDTOIn, Article>();

            CreateMap<Article, ArticleDTOOut>();
            CreateMap<ArticleDTOOut, Article>();

            CreateMap<Categorie, CategorieDTOOut>();
            CreateMap<CategorieDTOOut, Categorie>();

            CreateMap<Article, ArticleDTOAvecCategorie>()
                .ForMember(dest => dest.Categorie, opt => opt.MapFrom(src => src.Categorie));
            CreateMap<ArticleDTOAvecCategorie, Article>()
                .ForMember(dest => dest.Categorie, opt => opt.MapFrom(src => src.Categorie));
        }
    }
}