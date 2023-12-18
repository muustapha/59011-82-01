using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfStock.Models.Dtos;
using WpfStock.Models.Data;

namespace WpfStock.Models.Profiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article, ArticleDTOIn>();
            CreateMap<ArticleDTOIn, Article>();

            CreateMap<Article, ArticleDTOOut>();
            CreateMap<ArticleDTOOut, Article>();

            CreateMap<Article, ArticleDTOAvecCategorie>();
            CreateMap<ArticleDTOAvecCategorie,Article  >();

        }
    }
}
