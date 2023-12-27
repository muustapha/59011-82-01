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

            CreateMap<Categorie, CategorieDTOAvecTypesProduit>();
            CreateMap<CategorieDTOAvecTypesProduit, Categorie>();

            CreateMap<Categorie, CategorieDTOAvecTypesProduitEtArticle>();
            CreateMap<CategorieDTOAvecTypesProduitEtArticle, Categorie>();


        }
    }
}