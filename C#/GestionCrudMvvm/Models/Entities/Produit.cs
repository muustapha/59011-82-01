using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCrudMvvm
{
    public class Produit
    {
        public int IdProduit { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public double CoutProduction { get; set; }
        public int Quantite { get; set; }
        public string LieuxProduction { get; set; }

        public Produit(int idProduit, string nom, double prix, double coutProduction, int quantite, string lieuxProduction)
        {
            IdProduit = idProduit;
            Nom = nom;
            Prix = prix;
            CoutProduction = coutProduction;
            Quantite = quantite;
            LieuxProduction = lieuxProduction;
        }

        public Produit()
        {
        }

    }
}
