namespace APIfootball
{
    public class JoueurDTO
    {

        public JoueurDTOIn()
        {
        }

        public string JoueurName { get; set; }
        public string Description { get; set; }

    }


    public class JoueurDTOOut
    {
        public JoueurDTOOut()
        {
        }

        public string JoueurName { get; set; }
        public string Description { get; set; }

    }


    public class JoueurDTOAvecStudentJoueur
    {
        public JoueurDTOAvecStudentJoueur()
        {
            Relations = new HashSet<RelationDTOAvecEquipe>();
        }

        public string JoueurName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RelationDTOAvecEquipe> Relations { get; set; }
    }
}
