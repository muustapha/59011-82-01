using static APIfootball.ArbitreDTOcs;
using static APIfootball.EquipesDTO;

namespace APIfootball
{
    public class PartitaDTO
    {
        public class PartitaDTOIn
        {

            public DateTime DateHeure { get; set; }

            public string Ligue { get; set; } = null!;

            public bool VideoAssistantReferees { get; set; }

            public int Score { get; set; }

        }

        public class PartitaDTOOut
        {
            public DateTime DateHeure { get; set; }

            public string Ligue { get; set; } = null!;

            public bool VideoAssistantReferees { get; set; }

            public int Score { get; set; }
        }


        public class PartitaDTOAvecEquipe
        {
            public PartitaDTOAvecEquipe()
            {
                Equipe = new HashSet<EquipeDTOOut>();
            }

            public DateTime DateHeure { get; set; }

            public string Ligue { get; set; } = null!;

            public bool VideoAssistantReferees { get; set; }

            public int Score { get; set; }

            public virtual ICollection<EquipeDTOOut> Equipe { get; set; }
        }
        public class PartitaDTOAvecArbitre
        {
            public PartitaDTOAvecArbitre()
            {
                Arbitre = new HashSet<ArbitreDTOOut>();
            }

            public DateTime DateHeure { get; set; }

            public string Ligue { get; set; } = null!;

            public bool VideoAssistantReferees { get; set; }

            public int Score { get; set; }

            public virtual ICollection<ArbitreDTOOut> Arbitre { get; set; }
        }   
        public class PartitaDTOAvecEquipeEtArbitre
        {
            public PartitaDTOAvecEquipeEtArbitre()
            {
                Equipe = new HashSet<EquipeDTOOut>();
                Arbitre = new HashSet<ArbitreDTOOut>();
            }

            public DateTime DateHeure { get; set; }

            public string Ligue { get; set; } = null!;

            public bool VideoAssistantReferees { get; set; }

            public int Score { get; set; }

            public virtual ICollection<EquipeDTOOut> Equipe { get; set; }
            public virtual ICollection<ArbitreDTOOut> Arbitre { get; set; } 
        }
        }
    }
