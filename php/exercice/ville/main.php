<?php

function ChargerClasse($classe)
{
    if (file_exists("./CONTROLLER/".$classe.".Class.php"))
    require "./CONTROLLER/".$classe.".Class.php";
    else if (file_exists("./MODEL/".$classe.".Class.php"))
    require "./MODEL/".$classe.".Class.php";
}
spl_autoload_register('ChargerClasse');

DbConnect::init();
// Instanciation de l'objet Ville$ville
// $ville = new Ville();

// Définition des paramètres de la requête
$colonnes = ['nomVille', 'codePostal', 'superficie'];
$conditions = ['superficie' => '<10000'];
$orderBy = ['superficie' => 'ASC'];

// Exécution de la requête
$villes = VilleManager::select($colonnes, $conditions, $orderBy);

// Affichage des résultats
foreach ($villes as $ville) {
    echo $ville->getNomVille() . ' - ' . $ville->getCodePostal() . ' - ' . $ville->getSuperficie() . '<br>';
}



// $ville= new Ville(["idVille"=>5,"nomVille"=>'Dunkerque',"codePostal"=>"59140","superficie"=>'4389000',"nbHabitant"=>"43000"]);
// $ville= VilleManager::add($ville);


