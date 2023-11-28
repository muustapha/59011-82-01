namespace API1.Models.Dtos
{
    public class JoueursDTO
    {

        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public int Age { get; set; }
        public string Poste { get; set; } = null!;
        public string Nationalite { get; set; } = null!;
    }
}
