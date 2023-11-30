using static APIfootball.PartitaDTO;

namespace APIfootball
{
    public class ArbitreDTOcs
    {
        public class ArbitreDTOIn
        {
            public ArbitreDTOIn()
            {
            }

            public string ArbitreName { get; set; }

        }

        public class ArbitreDTOOut
        {
            public ArbitreDTOOut()
            {
            }

            public string ArbitreName { get; set; }
        }


        public class ArbitreDTOAvecPartita
        {
            public ArbitreDTOAvecPartita()
            {
                Partita = new HashSet<PartitaDTOOut>();
            }

            public string ArbitreName { get; set; }

            public virtual ICollection<PartitaDTOOut> Partita { get; set; }
        }
    }
}
