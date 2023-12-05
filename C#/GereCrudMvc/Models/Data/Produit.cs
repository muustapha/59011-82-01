namespace GereCrudMvc.Models.Data
{
    public class Produit
    {
        public int IdProduit { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public int Quantite { get; set; }
        public string LieuxFabrication { get; set; }

        public Produit(int idProduit, string nom, double prix, int quantite, string lieuxFabrication)
        {
            IdProduit = idProduit;
            Nom = nom;
            Prix = prix;
            Quantite = quantite;
            LieuxFabrication = lieuxFabrication;
        }
    }
}