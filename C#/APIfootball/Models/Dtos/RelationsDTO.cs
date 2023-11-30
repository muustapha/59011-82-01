namespace APIfootball
{
    public class RelationsDTO
    {
        public int? IdEquipe { get; set; }
        public int? IdJoueur { get; set; }

    }

    public class RelationDTOOut
    {
        public int Relation { get; set; }
        public int? IdEquipe { get; set; }
        public int? IdJoueur { get; set; }

    }
    public class RelationDTOAvecEtudiant
    {
        public virtual EquipeDTOOut Equipe { get; set; }
    }

    public class RelationDTOAvecEtudiantEtCours
    {
        public virtual JoueurDTOOut Joueur { get; set; }
        public virtual EquipeDTOOut Equipe { get; set; }
    }

    public class RelationDTOAvecCours
    {
        public virtual JoueurDTOOut Joueur { get; set; }
    }
}
