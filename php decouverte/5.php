<?php
// tableau associatifs

$tab = array (
    'zero'=>0,
    'un'=>1,
    'deux'=>2,
    'trois'=>3,
    'quatre'=>4,
    'cinq'=>5,
    'six'=>6,
    'sept'=>7,
    'huit'=>8,
    'neuf'=>9,

);
// afficher rechercher une valeur 
foreach ($tab as $key => $value) {
    echo "$value \n";
}
    
echo $tab["sept"];

// trier tableau

arsort($tab);

// algorithme qui demande le nombre de depard et calcul la factriel

$depard = 1;
$fact = 8;

for ($depard = 1; $depard <= 8; $depard++) {