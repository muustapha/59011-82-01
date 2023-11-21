using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_d__un_crud
{
    public class Produit
    {
        public int IdProduit { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public int Quantite { get; set; }
        public DateTime DateCreation { get; set; }

        public Produit(int idProduit, string nom, double prix, int quantite, DateTime dateCreation)
        {
            this.IdProduit = idProduit;
            this.Nom = nom;
            this.Prix = prix;
            this.Quantite = quantite;
            DateCreation = dateCreation;

        }
    }
}