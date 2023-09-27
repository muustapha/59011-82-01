<?php           

function ChargerClasse($Employe)
{
    require $Employe.'.Class.php';
}
spl_autoload_register('ChargerClasse');

function afficheTableau($tab)
{
    echo "\n";
    foreach ($tab as $elt) // le tableau est parcouru de la 1ere à la dernière case, les cases sont mises tour à tous dans $elt
    {
        echo $elt->toString() . "\n";
    }
    echo "\n";
}

$employe1 = new Employe([
    "Nom" => "Moulin",
    "Prenom" => "Jean",
    "DateEmbauche" => "01/01/2000",
    "Fonction" => "directeur",
    "SalaireAnnuel" => 30000
]);

$employe2 = new Employe([
    "Nom" => "Nguyen",
    "Prenom" => "Xinh",
    "DateEmbauche" => "01/01/2005",
    "Fonction" => "directeur",
    "SalaireAnnuel" => 35000
]);

$employe3 = new Employe([
    "Nom" => "Ali",
    "Prenom" => "Mohamed",
    "DateEmbauche" => "01/01/2010",
    "Fonction" => "directeur",
    "SalaireAnnuel" => 40000
]);

$employe4 = new Employe([
    "Nom" => "Parks",
    "Prenom" => "Rosa",
    "DateEmbauche" => "01/01/2015",
    "Fonction" => "directeur",
    "SalaireAnnuel" => 45000
]);

$employe5 = new Employe([
    "Nom" => "Nascimiento",
    "Prenom" => "Edson",
    "DateEmbauche" => "01/01/2020",
    "Fonction" => "directeur",
    "SalaireAnnuel" => 50000
]);

echo "Il y a " . Employe::getCompteur() . " employé créé \n";

$agence1 = new agence([
    "Nom" => "miracle",
    "adresse" => "21 rue des miracles",
    "codePostal" => "69007",
    "ville" => "lyon"
]);

$agence2 = new agence([
    "Nom" => "horizon",
    "adresse" => "33 rue horizon",
    "codePostal" => "75001",
    "ville" => "Paris"
]);

$agence3 = new agence([
    "Nom" => "abondance",
    "adresse" => "55 rue abondance",
    "codePostal" => "06000",
    "ville" => "Nice"
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




?>