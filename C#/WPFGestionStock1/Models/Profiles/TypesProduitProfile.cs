﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFGestionStock1.Models.Dtos;

namespace WPFGestionStock1.Models.Profiles
{
    public class TypesProduitProfile : Profile
    {
        public TypesProduitProfile()
        {
            CreateMap<TypesProduit, TypesProduitDTOIn>();
            CreateMap<TypesProduitDTOIn, TypesProduit>();
                
            CreateMap<TypesProduit, TypesProduitDTOOut>();
            CreateMap<TypesProduitDTOOut, TypesProduit>();

            CreateMap<TypesProduit, TypesProduitDTOAvecCategorie>();
            CreateMap<TypesProduitDTOAvecCategorie, TypesProduit>();

        }
    }
}