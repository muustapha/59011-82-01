using Salariés;

Entreprise entreprise = new Entreprise("Promo IRIS");

// Ajouter les vendeurs
entreprise.Commerciaux.Add(new Vendeur("Paul", "Dupont", 30, 2000m, 10m));
entreprise.Commerciaux.Add(new Vendeur("Pierre", "Martin", 35, 2500m, 5m));
entreprise.Commerciaux.Add(new Vendeur("Jacques", "Durand", 40, 3000m, 1m));

// Ajouter les représentants
entreprise.Commerciaux.Add(new Representant("Giselle", "Lefevre", 45, 3500m, 3m, 10));
entreprise.Commerciaux.Add(new Representant("Georges", "Lemaire", 50, 4000m, 2m, 8));

// Ajouter les techniciens
entreprise.Techniciens.Add(new Technicien("Robert", "Petit", 55));
entreprise.Techniciens.Add(new Technicien("Raymond", "Blanc", 60));

// Ajouter les intérimaires
entreprise.Techniciens.Add(new Interimaire("Jean-Claude", "Moreau", 65, 75));
entreprise.Techniciens.Add(new Interimaire("Jean-Paul", "Leroy", 70, 50));
entreprise.Techniciens.Add(new Interimaire("Jean-Marie", "Roux", 75, 50));
entreprise.Techniciens.Add(new Interimaire("Jean-Jean", "Simon", 80, 0));

// Calculer  les salaires pour le mois de février
entreprise.CalculerSalaireMoyen();
entreprise.CalculerSommeSalaires();  
entreprise.AfficherSalaires();