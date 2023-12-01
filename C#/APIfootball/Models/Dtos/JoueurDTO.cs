namespace APIfootball
{
    public class JoueurDTOIn
    {
        public string Nom { get; set; } = null!;

        public string Prenom { get; set; } = null!;

        public int Age { get; set; }

        public string Poste { get; set; } = null!;

        public string Nationalite { get; set; } = null!;

    }


    public class JoueurDTOOut
    {
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
            Relation = new HashSet<RelationDTOAvecEquipe>();
        }
        public int IdJoueur { get; set; }

        public string Nom { get; set; } = null!;

        public string Prenom { get; set; } = null!;

        public int Age { get; set; }

        public string Poste { get; set; } = null!;

        public string Nationalite { get; set; } = null!;

        public virtual ICollection<RelationDTOAvecEquipe> Relation { get; set; }
    }
}
