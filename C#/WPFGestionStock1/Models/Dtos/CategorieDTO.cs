using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFGestionStock1.Models.Data;

namespace WPFGestionStock1.Models.Dtos
{
    public class CategorieDTOIn
    {

        public CategorieDTOIn()
        { }
        

        public string LibelleCategorie { get; set; } = null!;

        public int IdTypeProduit { get; set; }

        public virtual ICollection<Categorie> Articles { get; set; } = new List<Categorie>();

        
    }


    public class CategorieDTOOut
    {

        public CategorieDTOOut()
        { }

        public string LibelleCategorie { get; set; } = null!;


    }
    public class CategorieDTOAvecTypesProduit
    {
        public CategorieDTOAvecTypesProduit()
        { }


        public string LibelleCategorie { get; set; } = null!;

        public int IdTypeProduit { get; set; }

        public virtual TypesProduitDTOOut TypesProduit { get; set; }
    }
    public class CategorieDTOAvecTypesProduitEtArticle
    {
        public CategorieDTOAvecTypesProduitEtArticle()
        { 
            Article = new HashSet<ArticleDTOAvecCategorie>();
        }


        public string LibelleCategorie { get; set; } = null!;

        public int IdTypeProduit { get; set; }

        public virtual TypesProduitDTOOut TypesProduit { get; set; }
        public virtual ICollection<ArticleDTOAvecCategorie> Article { get; set; }
    }


}
