using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGestionStock1.Models.Dtos
{
    
        public class TypesProduitDTOIn
        {

            public TypesProduitDTOIn()
            { }
        public string LibelleTypeProduit { get; set; } = null!;

    }


    public class TypesProduitDTOOut
        {

            public TypesProduitDTOOut()
            { }


        public string LibelleTypeProduit { get; set; } = null!;


    }
    public class TypesProduitDTOAvecCategorie
        {
            public TypesProduitDTOAvecCategorie()
            { }

        public string LibelleTypeProduit { get; set; } = null!;
        public virtual ICollection<CategorieDTOOut> Categorie { get; set; }
    }


}

