using API2.Models.data;

namespace API2.Models.Dtos
{
    public class PartitaDTO
    {

        public int IdPartita { get; set; }

        public DateTime Date { get; set; }

        public string Ligue { get; set; } = null!;

        public bool VideoAssistantReferees { get; set; }

        public virtual ICollection<Equipe> Equipes { get; set; }
        public virtual ICollection<Arbitre> Arbitres { get; set; }
    }
}
