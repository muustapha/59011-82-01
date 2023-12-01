namespace APIfootball
{
    public class JoueurDTOIn
    {

        public JoueurDTOIn()
        {
        }

       

        public string Nom { get; set; } = null!;

        public string Prenom { get; set; } = null!;

        public int Age { get; set; }

        public string Poste { get; set; } = null!;

        public string Nationalite { get; set; } = null!;

    }


    public class JoueurDTOOut
    {
        public JoueurDTOOut()
        {
        }
        public string Nom { get; set; } = null!;

        public string Prenom { get; set; } = null!;

        public int Age { get; set; }

        public string Poste { get; set; } = null!;

        public string Nationalite { get; set; } = null!;

       

    }


    public class JoueurDTOAvecRelation
    {
        public JoueurDTOAvecRelation()
        {
            Relations = new HashSet<RelationDTOAvecEquipe>();
        }

        public string JoueurName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RelationDTOAvecEquipe> Relations { get; set; }
    }
}
