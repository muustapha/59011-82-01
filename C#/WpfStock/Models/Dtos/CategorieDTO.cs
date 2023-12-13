using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStock.Models.Dtos
{
    public class CategorieDTOIn
    {

        public CategorieDTOIn()
        { }
        

        public string LibelleCategorie { get; set; } = null!;

        public int IdTypeProduit { get; set; }

        public virtual ICollection<Article> Articles { get; set; } = new List<Article>();

        
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


}
