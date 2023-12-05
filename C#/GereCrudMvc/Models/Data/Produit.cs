namespace GereCrudMvc.Models.Data
{
    public class Produit
    {
        public int IdProduit { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public double CoutProduction { get; set; }
        public int Quantite { get; set; }
        public string LieuxProduction { get; set; }

        public Produit(int idProduit, string nom, double prix, int quantite, string lieuxProduction)
        {
            IdProduit = idProduit;
            Nom = nom;
            Prix = prix;
            Quantite = quantite;
            CoutProduction = CoutProduction;
            LieuxProduction = lieuxProduction;
        }
    }
}