namespace APIfootball.Models.Dtos
{
    public class ArbitresPartitaDTO
    {

        public class ArbitresPartitaDTOIn
        {
            public int? IDArbitre { get; set; }
            public int? IdPartita { get; set; }

        }

        public class ArbitresPartitaDTOOut
        {
            public int IdArbitresPartita { get; set; }
            public int IDArbitre { get; set; }
            public int IdPartita { get; set; }

        }
        public class ArbitresPartitaDTOAvecArbitre
        {
            public virtual ArbitreDTOOut Arbitre { get; set; }
        }
       

        public class ArbitresPartitaDTOAvecArbitreEtPartita
        {
            public virtual ArbitreDTOOut Arbitre { get; set; }
            public virtual PartitaDTOOut Partita { get; set; }
        }
     

        public class ArbitresPartitaDTOAvecPartita
        {
            public virtual PartitaDTOOut Partita { get; set; }
        }
    }

}
}
