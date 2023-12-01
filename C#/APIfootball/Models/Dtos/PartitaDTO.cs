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

            public bool VideoAssistance { get; set; }

            public int Score { get; set; }

        }

        public class PartitaDTOOut
        {
            public DateTime DateHeure { get; set; }

            public string Ligue { get; set; } = null!;

            public bool VideoAssistance { get; set; }

            public int Score { get; set; }
        }


        public class PartitaDTOAvecEquipe
        {
            public PartitaDTOAvecEquipe()
            {
                Equipes = new HashSet<EquipeDTOOut>();
            }

            public DateTime DateHeure { get; set; }

            public string Ligue { get; set; } = null!;

            public bool VideoAssistance { get; set; }

            public int Score { get; set; }

            public virtual ICollection<EquipeDTOOut> Equipes { get; set; }
        }
        public class PartitaDTOAvecArbitre
        {
            public PartitaDTOAvecArbitre()
            {
                Arbitres = new HashSet<ArbitreDTOOut>();
            }

            public DateTime DateHeure { get; set; }

            public string Ligue { get; set; } = null!;

            public bool VideoAssistance { get; set; }

            public int Score { get; set; }

            public virtual ICollection<ArbitreDTOOut> Arbitres { get; set; }
        }   
        public class PartitaDTOAvecEquipeEtArbitre
        {
            public PartitaDTOAvecEquipeEtArbitre()
            {
                Equipes = new HashSet<EquipeDTOOut>();
                Arbitres = new HashSet<ArbitreDTOOut>();
            }

            public DateTime DateHeure { get; set; }

            public string Ligue { get; set; } = null!;

            public bool VideoAssistance { get; set; }

            public int Score { get; set; }

            public virtual ICollection<EquipeDTOOut> Equipes { get; set; }
            public virtual ICollection<ArbitreDTOOut> Arbitres { get; set; } 
        }
        }
    }
