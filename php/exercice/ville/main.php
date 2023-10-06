<?php

function ChargerClasse($ville)
{
require $ville.'.Class.php';
}
spl_autoload_register('ChargerClasse');

// Instanciation de l'objet Ville$ville
$ville = new $ville();

// Définition des paramètres de la requête
$colonnes = ['nomVille', 'codePostal', 'superficie'];
$conditions = ['superficie->' => '<10000'];
$orderBy = ['superficie' => 'ASC'];

// Exécution de la requête
$villes = $ville->select($colonnes, $conditions, $orderBy);

// Affichage des résultats
foreach ($villes as $ville) {
    echo $ville->getNomVille() . ' - ' . $ville->getCodePostal() . ' - ' . $ville->getSuperficie() . '<br>';
}

gmp_testbit()