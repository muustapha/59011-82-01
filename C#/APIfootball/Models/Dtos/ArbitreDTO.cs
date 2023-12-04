using static APIfootball.ArbitresPartitaDTO;

namespace APIfootball
{
    public class ArbitreDTO
    {
        public class ArbitreDTOIn
        {
            

            public string Nom { get; set; } = null!;

            public string Prenom { get; set; } = null!;

            public int Age { get; set; }

            public string Poste { get; set; } = null!;

          

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


        public class ArbitreDTOAvecArbitresPartita
        {
            public CourseDTOAvecArbitresPartita()
            {
                ArbitresPartita = new HashSet<ArbitresPartitaDTOAvecEquipe>();
            }


            public string Nom { get; set; } = null!;

            public string Prenom { get; set; } = null!;

            public int Age { get; set; }

            public string Poste { get; set; } = null!;

       

            public virtual ArbitresPartitaDTOOut ArbitresPartita { get; set; }
        }
    }
}
