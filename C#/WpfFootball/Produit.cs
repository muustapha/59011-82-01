using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpffootball
{
    class Produit
    {
        private readonly int coutDeProduction;

        public string Nom { get; set; }
        public int Prix { get; set; }
        public int Quantite { get; set; }
        public DateTime DateDeMiseEnVente { get; set; }
        public int CoutDeProduction { get; set; }



        public Produit(string nom, int prix, int quantite,DateTime dateDeMiseEnVente, int CoutDeProduction)
        {
            Nom = nom;
            Prix = prix;
            Quantite = quantite;
            DateDeMiseEnVente = dateDeMiseEnVente;
            CoutDeProduction = coutDeProduction;       
        }
    }
}
