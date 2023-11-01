<?php
// tableau associatifs

$tab = array(
    'zero' => 0,
    'un' => 1,
    'deux' => 2,
    'trois' => 3,
    'quatre' => 4,
    'cinq' => 5,
    'six' => 6,
    'sept' => 7,
    'huit' => 8,
    'neuf' => 9,

);
// afficher rechercher une valeur 
foreach ($tab as $key => $value) {
    echo "$value \n";
}

echo $tab["sept"];

// trier tableau

arsort($tab);

// // algorithme qui demande le nombre de depard et calcul la factriel
// $depard = 8;
// $fact = 1;
// function facto($n)
// {
//     for ($depard = 0; $depard < 0; $depard++) {
//         $depard = $depard + 1;
//         $fact = $n * $depard;
//     }
// }
// $n = "";
function facto($nb){
    if ($nb==0)return-1;
    return $nb * facto($nb-1);
}
function epeler($mot){
    return substr($mot,0,1);
    (substr($mot,1)
);}