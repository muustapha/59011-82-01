using static APIfootball.EquipesDTO;

namespace APIfootball
{
    public class RelationDTOIn
    {      

        public int IdEquipe { get; set; }

        public int IdJoueur { get; set; }

        public DateTime DateDebutContract { get; set; }

        public int NumeroDeMaillot { get; set; }

        public int Salaire { get; set; }
           
    }

    public class RelationDTOOut
    {
        public int IdRelation { get; set; }

        public int IdEquipe { get; set; }

        public int IdJoueur { get; set; }

        public DateTime DateDebutContract { get; set; }

        public int NumeroDeMaillot { get; set; }

        public int Salaire { get; set; }
         

    }
    public class RelationDTOAvecEquipe
    {
        public virtual EquipeDTOOut Equipe { get; set; }
    }

    public class RelationDTOAvecEquipeEtJoueur
    {
        public virtual Joueur Joueur { get; set; }
        public virtual Equipe Equipe { get; set; }
    }

    public class RelationDTOAvecJoueurs
    {
        public virtual JoueurDTOOut Joueur { get; set; }
    }
}
