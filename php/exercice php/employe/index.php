<?php           

function ChargerClasse($Employe)
{
    require $Employe.'.Class.php';
}
spl_autoload_register('ChargerClasse');

function afficheTableau($tab)
{
    echo "\n";
    foreach ($tab as $elt) // le tableau est parcouru de la 1ere à la dernière case, les cases sont mises tou $elt
    {
        echo $elt->toString() . "\n";r à tous dans
    }
    echo "\n";
}

$employe1 = new Employe([
    "Nom" => "Moulin",
    "Prenom" => "Jean",
    "DateEmbauche" => "01/01/2000",
    "Fonction" => "résistant",
    "SalaireAnnuel" => 30000,
    "agence" =>"miracle"
]);

$employe2 = new Employe([
    "Nom" => "Nguyen",
    "Prenom" => "Xinh",
    "DateEmbauche" => "01/01/2005",
    "Fonction" => "general",
    "SalaireAnnuel" => 35000,
    "agence" =>"horizon"
]);

$employe3 = new Employe([
    "Nom" => "Ali",
    "Prenom" => "Mohamed",
    "DateEmbauche" => "01/01/2010",
    "Fonction" => "boxeur",
    "SalaireAnnuel" => 40000,
    "agence" =>"abondance"
]);

$employe4 = new Employe([
    "Nom" => "Parks",
    "Prenom" => "Rosa",
    "DateEmbauche" => "01/01/2015",
    "Fonction" => "conductrice de bus",
    "SalaireAnnuel" => 45000,
    "agence" =>"miracle"
]);

$employe5 = new Employe([
    "Nom" => "Nascimiento",
    "Prenom" => "Edson",
    "DateEmbauche" => "01/01/2020",
    "Fonction" => "footballeur",
    "SalaireAnnuel" => 50000,
    "agence" =>"horizon"
]);

// echo "Il y a " . Employe::getCompteur() . " employé créé \n";

$agence1 = new agence([
    "Nom" => "miracle",
    "adresse" => "21 rue des miracles",
    "codePostal" => "69007",
    "ville" => "lyon",
"modeRestauration" => "ticket restaurant"
]);

$agence2 = new agence([
    "Nom" => "horizon",
    "adresse" => "33 rue horizon",
    "codePostal" => "75001",
    "ville" => "Paris",
"modeRestauration" => "restaurant d'entreprise"
]);

$agence3 = new agence([
    "Nom" => "abondance",
    "adresse" => "55 rue abondance",
    "codePostal" => "06000",
    "ville" => "Nice",
"modeRestauration" => "ticket restaurant"
]);

$listeEmploye = [$employe1, $employe2, $employe3, $employe4, $employe5];

echo "Montant de la prime de : " . $employe1->getNom() . " : " . $employe1->PrimeTotale() . " euros\n";
echo "Montant de la prime de : " . $employe2->getNom() . " : " . $employe2->PrimeTotale() . " euros\n";
echo "Montant de la prime de : " . $employe3->getNom() . " : " . $employe3->PrimeTotale() . " euros\n";
echo "Montant de la prime de : " . $employe4->getNom() . " : " . $employe4->PrimeTotale() . " euros\n";
echo "Montant de la prime de : " . $employe5->getNom() . " : " . $employe5->PrimeTotale() . " euros\n";

afficheTableau($listeEmploye);
usort($listeEmploye, array("Employe", "compareToNomPrenom"));
afficheTableau($listeEmploye);
usort($listeEmploye, array("Employe", "compareToServiceNomPrenom"));
afficheTableau($listeEmploye);

function MasseSalariale($listeEmploye)
{
    $somme = 0;
    foreach ($listeEmploye as $key => $value) {
        $somme += $value->getSalaireAnnuel() + $value->PrimeTotale();
    }
    return $somme;
}

echo "La masse salariale est de : " . MasseSalariale($listeEmploye) . " euros\n";

function afficheTableau2($listeEmploye)
{
    echo "\n";
    foreach ($listeEmploye as $elt) // le tableau est parcouru de la 1ere à la dernière case, les cases sont mises tour à tous dans $elt
    {
        echo $elt->toString() . "\n";
    }
    echo "\n";
}

// verif chèque vacance
if ($employe->peutAvoirChequesVacances()) {
    echo $employe->getNom() . " " . $employe->getPrenom() . " peut avoir des chèques vacances\n";
} else {
    echo $employe->getNom() . " " . $employe->getPrenom() . " ne peut pas avoir des chèques vacances\n";
}



// / Création des enfants
$enfant1 = new enfant([
    "nom" => "moulin",
    "prenom" => "paul",
    "dateNaissance" => "01/01/2010"
]);

$enfant2 = new enfant([
    "nom" => "moulin",
    "prenom" => "Pierre",
    "dateNaissance" => "01/01/2005"
]);

$enfant3 = new enfant([
    "nom" => "moulin",
    "prenom" => "Marie",
    "dateNaissance" => "01/01/2002"
]);
$enfant4 = new enfant([
    "nom" => "nguyen",
    "prenom" => "chun-lee",
    "dateNaissance" => "01/05/2000"
]);
$enfant5 = new enfant([
    "nom" => "ali",
    "prenom" => "maryum",
    "dateNaissance" => "11/05/2005"
]);   
// Ajout des enfants à l'employé
$employe($employe1)->ajouterEnfant($enfant1);
$employe($employe1)->ajouterEnfant($enfant2);
$employe($employe1)->ajouterEnfant($enfant3);
$employe($employe2)->ajouterEnfant($enfant4);
$employe($employe3)->ajouterEnfant($enfant5);
// Attribution des chèques Noël
$employe->getChequesNoel();

?>