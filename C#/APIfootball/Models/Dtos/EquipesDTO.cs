using static APIfootball.PartitaDTO;

namespace APIfootball
{
    public class EquipesDTO
    {
        public class EquipeDTOIn
        {
                 
            public string Nom { get; set; } = null!;

            public string Ville { get; set; } = null!;

            public string Pays { get; set; } = null!;

            public string StadePrincipal { get; set; } = null!;

            public string SiteWeb { get; set; } = null!;

            public int IdPartita { get; set; }
        }

        public class EquipeDTOOut
        {
            public int IdEquipe { get; set; }

            public string Nom { get; set; } = null!;

            public string Ville { get; set; } = null!;

            public string Pays { get; set; } = null!;

            public string StadePrincipal { get; set; } = null!;

            public string SiteWeb { get; set; } = null!;
        }
    }
    public class EquipeDTOAvecPartita
    {
        public string Nom { get; set; } = null!;

        public string Ville { get; set; } = null!;

        public string Pays { get; set; } = null!;

        public string StadePrincipal { get; set; } = null!;

        public string SiteWeb { get; set; } = null!;

        public virtual PartitaDTOOut Partita { get; set; }
    }

    public class EquipeDTOAvecPartitaEtRelation

    {
        public EquipeDTOAvecPartitaEtRelation()
        {
            Relation = new HashSet<RelationDTOAvecJoueurs>();

        }

        public string Nom { get; set; } = null!;

        public string Ville { get; set; } = null!;

        public string Pays { get; set; } = null!;

        public string StadePrincipal { get; set; } = null!;

        public string SiteWeb { get; set; } = null!;

        public int Idpartita { get; set; }

        public virtual PartitaDTOOut Partita { get; set; }
        public virtual ICollection<RelationDTOAvecJoueurs> Relation { get; set; }
    }
}


