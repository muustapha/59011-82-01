<?php

function ChargerClasse($Cercle)
{
require $Cercle.'.Class.php';
}
spl_autoload_register('ChargerClasse');

$Cercle1 = new Cercle(["diametre" => 50]);
echo $Cercle1->__toString();