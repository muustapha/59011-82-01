using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFGestionStock1.Models.Dtos;
using WPFGestionStock1.Models.Data; 

namespace WPFGestionStock1.Models.Profiles
{ public class CategorieProfile : Profile
{
 public CategorieProfile()
    {
        CreateMap<Categorie, CategorieDTOIn>();
        CreateMap<CategorieDTOIn, Categorie>(); 

        CreateMap<Categorie, CategorieDTOOut>();
        CreateMap<CategorieDTOOut, Categorie>();

            CreateMap<TypesProduit, TypesProduitDTOOut>();
            CreateMap<TypesProduitDTOOut, TypesProduit>();

            CreateMap<Categorie, CategorieDTOAvecTypesProduit>()
            .ForMember(dest => dest.TypesProduit, opt => opt.MapFrom(src => src.TypesProduit));
            CreateMap<CategorieDTOAvecTypesProduit, Categorie>()
                .ForMember(dest => dest.TypesProduit, opt => opt.MapFrom(src => src.TypesProduit));

            //CreateMap<Categorie, CategorieDTOAvecTypesProduitEtArticle>()
            //    .ForMember(dest => dest.TypesProduit, opt => opt.MapFrom(src => src.TypesProduit))
            //    .ForMember(dest => dest.Article, opt => opt.MapFrom(src => src.Articles));

            //CreateMap<CategorieDTOAvecTypesProduitEtArticle, Categorie>()
            //    .ForMember(dest => dest.TypesProduit, opt => opt.MapFrom(src => src.TypesProduit))
            //    .ForMember(dest => dest.Articles, opt => opt.MapFrom(src => src.Article));

            //    CreateMap<Categorie, CategorieDTOOut>()
            //   .ForMember(dest => dest.LibelleCategorie, opt => opt.MapFrom(src => src.LibelleCategorie));

            //    CreateMap<CategorieDTOOut, Categorie>()
            //        .ForMember(dest => dest.LibelleCategorie, opt => opt.MapFrom(src => src.LibelleCategorie));

        }

    }
}