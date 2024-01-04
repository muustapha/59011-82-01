using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGestionStock1.Models.Dtos
{
    public class ArticleDTOIn
    {

        public ArticleDTOIn()
        { }
        public string LibelleArticle { get; set; } = null!;

        public int QuantiteStockee { get; set; }

        public string LibelleCategorie { get; set; }
    }


    public class ArticleDTOOut
    {

        public ArticleDTOOut()
        { }


        public string LibelleArticle { get; set; } = null!;

        public int QuantiteStockee { get; set; }

        //public string LibelleCategorie { get; set; } = null!;

    }
    public class ArticleDTOAvecCategorie
    {
        public ArticleDTOAvecCategorie()
        { }


        public string LibelleArticle { get; set; } = null!;

        public int QuantiteStockee { get; set; }

        public string LibelleCategorie { get; set; }

        public virtual CategorieDTOOut Categorie { get; set; }
        
}
        
    
}

