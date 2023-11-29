namespace API2.Models.Dtos
{
    public class RelationDTO
    {
        public int IdRelation { get; set; }

        public int IdEquipe { get; set; }

        public int IdJoueur { get; set; }

        public DateTime DateDebutContract { get; set; }

        public int NumeroDeMaillot { get; set; }

        public int Salaire { get; set; }
    }
}
