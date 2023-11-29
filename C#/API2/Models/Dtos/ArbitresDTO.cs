using API2.Models.data;

namespace API2.Models.Dtos
{
    public class ArbitresDTOin
    {
        public ArbitresDTOin()
        {
        }
        public string Nom { get; set; } = null!;

        public string Prenom { get; set; } = null!;

        public int Age { get; set; }

        public string Poste { get; set; } = null!;

        public int IdPartita { get; set; }
    }
    public class ArbitresDTOout
    {
        public ArbitresDTOout()
        {
        }
     
        public string Nom { get; set; } = null!;

        public string Prenom { get; set; } = null!;

        public int Age { get; set; }

        public string Poste { get; set; } = null!;
    }
  
    public class ArbitresDTOAvecPartita
    {
        public ArbitresDTOAvecPartita()
        {
              }

        public string Nom { get; set; } = null!;

        public string Prenom { get; set; } = null!;

        public int Age { get; set; }

        public string Poste { get; set; } = null!;

        public virtual PartitaDTOOut Partita { get; set; }
    }
}
}
