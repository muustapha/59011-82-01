using System.ComponentModel.DataAnnotations;

namespace ObjetModels.Models.data
{
    public class Personnes
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Prenom { get; set; }
        [MaxLength(50)]
        public string Nom { get; set; }
        public int Age { get; set; }
    }
}
