namespace APIfootball
{
    public class EquipesDTO
    {
    }
    public EquipeDTOIn()
    {
    }

    // les données présentes dans la tables uniquement
    public string Name { get; set; }
    public int IdPartita { get; set; }

}


public class EquipeDTOOut
{
    public EquipeDTOOut()
    {

    }
    // les données de la table sans les id et sans les clés etrangères
    public string Name { get; set; }
}

public class EquipeDTOAvecPartita
{
    public EquipeDTOAvecPartita()
    {
    }
    // les colonnes de la table sans les id
    public string Name { get; set; }
    public int IdPartita { get; set; }

    // ajouter les données attachées
    // ATTENTION il faut retourner un DTOOut
    public virtual PartitaDTOOut Partita { get; set; }
}

public class EquipeDTOAvecPartitaEtCourses
{
    public EquipeDTOAvecPartitaEtCourses()
    {
        Relation = new HashSet<RelationDTOAvecCours>();
    }

    public string Name { get; set; }
    public int Idpartita { get; set; }

    public virtual PartitaDTOOut Partita { get; set; }
    public virtual ICollection<RelationDTOAvecJoueur> Relation { get; set; }
}


