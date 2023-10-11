<?php

function ChargerClasse($classe)
{
    if (file_exists("./CONTROLLER/".$classe.".Class.php"))
    require "./CONTROLLER/".$classe.".Class.php";
    else if (file_exists("./MODEL/".$classe.".Class.php"))
    require "./MODEL/".$classe.".Class.php";
}
spl_autoload_register("ChargerClasse");

DbConnect::init();
$ville = new Ville(["idVille"=>5,"nomVille"=>'Dunkerque',"codePostal"=>"59140","superficie"=>'4389000',"nbHabitant"=>"43000"]);
VilleManager::add($ville);
$ville = new Ville();
$ville->setIdville(1);
$ville->setNomVille("marseille");
VilleManager::update($ville);
VilleManager::delete($ville);
VilleManager::findById(2);
$tab = ["idVille"=>1,"nomVille"=>"Lyon","codePostal"=>"69000"];
echo json_encode($tab);
var_dump(VilleManager::select("Ville",["idville","nomVille","codePostal"],null,["nomVille"=>true,"codePostal"=>false],"2,3",true));