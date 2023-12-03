namespace APIfootball.Models.Data
{
    public class arbitresPartita
    { 
        public int IdarbitresPartita { get; set; }
        public int IdArbitre { get; set; }
       
        public int IdPartita { get; set; }

        public virtual Arbitre Arbitre { get; set; }
        public virtual Partita Partita { get; set; }
    }
}
