<?php
/** 
 

//saisi de la valeur jusqu a se que l utilisateur saisie 0
function saisirEntier(string$invit,bool$positif=false){}
do {
$nombre=readligne ($invite);}
while (!preg_match("/^¨(-)?[/d]+$/",$nombre)||($positif&&$nombre<0));return $nombre; 
//saisie tableau de valeur x avec invite variable controle type
function creerTableau(string$invite){}
do{
    $nombre=demanderEntier($invite);
    $tab[]=($nombre)}
while($nombre!=0);
array_pop($tab);
return $tab;

//triez le tableau
sort($tab);
//afficher tableau
print_r ($array);
//saisie tableau a 2 dimension de valeur x par y(x et y en parametre)
function creerTableau2d (variable $x,variable $y)
//afficher tableau 2d 
<?php
// Les fonctions de bases


/**
 * Bonus : Demande à l'utilisateur de saisir une valeur avec l'invite en paramètre
 * Vérifie que la saisie correspond au besoin c'est à dire un entier
 * Si $positif est vrai alors l'entier saisi doit être positif
 *
 * @param string $invite
 * @param boolean $positif définit si l'entier doit être positif
 * @return int renvoi l'entier saisi par l'utilisateur
 */
function DemanderEntier(string $invite,bool $positif=false)
{
    // on demande un nombre à l'utilisateur
    do
    {
        $nb = readline($invite);
    }
    while (!preg_match("/^(-)?[\d]+$/", $nb) || ($positif && $nb < 0)); // test si la saisie correpond au modèle de la regex c'est à dire numéric sans virgule
    return $nb;
}

function CreerTableau(string $invite)
{
    do
    {
        // on demande les prix un par un
        $nombre = DemanderEntier($invite);
        $tab[]=$nombre;
    } while ($nombre != 0); // on s'arrete quand le nombre est = à 0
    array_pop($tab);
    return $tab;
}

//
echo DemanderEntier("note :", false)."\n";
// echo DemanderEntier("note positive:", true)."\n";
// echo DemanderEntier("entrer une valeur :", false)."\n";
//afficher tableau

print_r($tab);
//trier tableau
//croissant par valeur
sort($tab,$invite());
//decroissant par valeur
rsort($tab,$invite);
//croissant par valeur et par association clé-valeur