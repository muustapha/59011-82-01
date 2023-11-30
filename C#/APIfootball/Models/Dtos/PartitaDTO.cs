using static APIfootball.ArbitreDTOcs;

namespace APIfootball
{
    public class PartitaDTO
    {
        public class PartitaDTOIn
        {
            public PartitaDTOIn()
            {
            }

            public string PartitaName { get; set; }

        }

        public class PartitaDTOOut
        {
            public PartitaDTOOut()
            {
            }

            public string PartitaName { get; set; }
        }


        public class PartitaDTOAvecEquipe
        {
            public PartitaDTOAvecEquipe()
            {
                Equipe = new HashSet<EquipeDTOOut>();
            }

            public string PartitaName { get; set; }

            public virtual ICollection<EquipeDTOOut> Equipe { get; set; }
        }
        public class PartitaDTOAvecArbitre
        {
            public PartitaDTOAvecArbitre()
            {
                Arbitre = new HashSet<ArbitreDTOOut>();
            }

            public string PartitaName { get; set; }

            public virtual ICollection<ArbitreDTOOut> Arbitre { get; set; }
        }   
        
        }
    }
