﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStock.Models.Dtos
{
 public class ArticleDTOIn
    {

        public ArticleDTOIn()
        { }
            public string LibelleArticle { get; set; } = null!;

            public int QuantiteStockee { get; set; }

            public int IdCategorie { get; set; }
        }
    

 public class ArticleDTOOut
    {

       public ArticleDTOOut()
        { }
       

        public string LibelleArticle { get; set; } = null!;

        public int QuantiteStockee { get; set; }

    }   
 public class ArticleDTOAvecCategorie
    {
    public ArticleDTOAvecCategorie()
        { }
       

        public string LibelleArticle { get; set; } = null!;

        public int QuantiteStockee { get; set; }

        public int IdCategorie { get; set; }

        public virtual CategorieDTOOut Categorie { get; set; }
    }


}
