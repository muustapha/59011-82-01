<?php


$tab = array(
    array('x'),
    array('y')
);
//affichage tableau2d 
echo $tab[0][0];
echo $tab[0][1];

for ($ligne = 0; $ligne < 2; $ligne++) {
    echo "<ul>";
}
for ($colonne = 0; $colonne < 2; $colonne++) {
    echo "<li> .$tab[$ligne][$colonne]. </li>";
}

echo '</ul>'; {
    $traits = "";
    for ($j = 0; $j < $nbColonne; $j++) {

        $traits .= "----------------";
    }
    $traits .= "\n";
    return $traits;


/**
 * Création d'un tableau à 2 dimensions
 *
 * @param int $x
 * @param int $y
 * @return array  Le tableau rempli
 */
function creeTableau2Dim(int $x,int $y){
    $tab=[];
    // ajout des lignes
    // colonnes
    for($i=0;$i<$y;$i++){
        // lignes
        $col=[];
        for($j=0;$j<$x;$j++){
            $col[]=readline("Nombre : ");;
        }
        $tab[]=$col;
    }
    return $tab;
    
};


/**
 * Affichage au format tableau
 *
 * @param array $tab Le tableau à 2 dimensions rempli
 * @param int $x Le nombre de colonnes
 * @param int $y
 */
function AffichageFormeTableau(array $tab,int $x,int $y){
    
    // Ajout des colonnes du format tableau
    $trait="";
    for($i=0;$i<=$x;$i++) {
        $trait.='----------------';
    }
    $trait.="\n";
    echo $trait;
    // ajout de l'espace dans première case
    echo "|\t \t";

    // entetes
    for($i=0;$i<$x;$i++) {
        echo "|\t". chr(65+$i) ."\t";
    }
    echo "|\n".$trait;


    // affichage tableau par nb colonne
    for($i=0;$i<$y;$i++){
        echo "|\t". ($i+1) ."\t";
        // affichage des lignes
        for($j=0;$j<$x;$j++){
            echo "|\t".$tab[$i][$j]." \t";
        }
        echo "|\n".$trait;
    }  
}

$y=readline("\nNombre de ligne(s) :");
$x=readline("\nNombre de colonne(s) :");
//ajout d'une colonne pour l'index des lignes
$tab=creeTableau2Dim($x,$y);
AffichageFormeTableau($tab,$x,$y);