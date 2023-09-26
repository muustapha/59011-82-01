<?php
require 'Employe.php';


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

echo "Montant de la prime de : " . $employe1->getNom() . " : " . $employe1->primeTotale() . " euros\n";
echo "Montant de la prime de : " . $employe2->getNom() . " : " . $employe2->primeTotale() . " euros\n";
echo "Montant de la prime de : " . $employe3->getNom() . " : " . $employe3->primeTotale() . " euros\n";
echo "Montant de la prime de : " . $employe4->getNom() . " : " . $employe4->primeTotale() . " euros\n";
echo "Montant de la prime de : " . $employe5->getNom() . " : " . $employe5->primeTotale() . " euros\n";

