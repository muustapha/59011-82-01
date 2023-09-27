<?php           

function ChargerClasse($Employe)
{
require $Employe.'.Class.php';
}
spl_autoload_register('ChargerClasse');



// $DateVersement = new DateTime("2023-09-27");
// $DateDuJour = new DateTime("2023-09-27");
// echo "Ordre de transfert envoyé à la banque pour un montant de : " . $this->primeTotale() . " euros.";

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

$employe3 = new Employe
([
    "Nom" => "Ali",
    "Prenom" => "Mohamed",
    "DateEmbauche" => "01/01/2010",
    "Fonction" => "directeur",
    "SalaireAnnuel" => 40000
]);

$employe4 = new Employe
([
    "Nom" => "Parks",
    "Prenom" => "Rosa",
    "DateEmbauche" => "01/01/2015",
    "Fonction" => "directeur",
    "SalaireAnnuel" => 45000
]);

$employe5 = new Employe
([
    "Nom" => "Nascimiento",
    "Prenom" => "Edson",
    "DateEmbauche" => "01/01/2020",
    "Fonction" => "directeur",
    "SalaireAnnuel" => 50000

]);
$
$listeEmploye=[$employe1,$employe2,$employe3,$employe4,$employe5];

echo "Montant de la prime de : " . $employe1->getNom() . " : " . $employe1->primeTotale() . " euros\n";
echo "Montant de la prime de : " . $employe2->getNom() . " : " . $employe2->primeTotale() . " euros\n";
echo "Montant de la prime de : " . $employe3->getNom() . " : " . $employe3->primeTotale() . " euros\n";
echo "Montant de la prime de : " . $employe4->getNom() . " : " . $employe4->primeTotale() . " euros\n";
echo "Montant de la prime de : " . $employe5->getNom() . " : " . $employe5->primeTotale() . " euros\n";

function MasseSalariale ($listeEmploye){
$somme=0;
    foreach ($listeEmploye as $key => $value) {
       $somme += $value->getSalaireAnnuel+$value->getPrimeTotal ;
    }
return $somme

}
