using static APIfootball.PartitaDTO;

namespace APIfootball
{
    public class ArbitreDTOcs
    {
        public class ArbitreDTOIn
        {
            

            public string Nom { get; set; } = null!;

            public string Prenom { get; set; } = null!;

            public int Age { get; set; }

            public string Poste { get; set; } = null!;

            public int IdPartita { get; set; }

            }

        public class ArbitreDTOOut
        {
            public ArbitreDTOOut()
            {
            }
            public string Nom { get; set; } = null!;

            public string Prenom { get; set; } = null!;

            public int Age { get; set; }

            public string Poste { get; set; } = null!;

        }


        public class ArbitreDTOAvecPartita
        {
            public string Nom { get; set; } = null!;

            public string Prenom { get; set; } = null!;

            public int Age { get; set; }

            public string Poste { get; set; } = null!;

            public int IdPartita { get; set; }

            public virtual PartitaDTOOut Partita { get; set; }
        }
    }
}
