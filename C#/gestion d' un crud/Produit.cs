namespace gestion_d__un_crud
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
            this.IdProduit = idProduit;
            this.Nom = nom;
            this.Prix = prix;
            this.Quantite = quantite;
            this.LieuxFabrication = lieuxFabrication;
        }
    }
}