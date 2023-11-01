<?php

function ChargerClasse($Cercle)
{
require $Cercle.'.Class.php';
}
spl_autoload_register('ChargerClasse');

$Cercle1 = new Cercle(["diametre" => 50]);
echo $Cercle1->__toString();

function ChargerClasse1($Rectangle)
{
require $Rectangle.'.Class.php';
}
spl_autoload_register('ChargerClasse1');
$Rectangle1 = new Rectangle(["longueur" => 50, "largeur" => 30]);
echo $Rectangle1->__toString();       

function ChargerClasse2($TriangleRectangle)
{
require $TriangleRectangle.'.Class.php';
}
spl_autoload_register('ChargerClasse2');
$TriangleRectangle1 = new TriangleRectangle(["base" => 50, "hauteur" => 30]);
echo $TriangleRectangle1->__toString();

function ChargerClasse3($sShepere)
{
require $classe.'.Class.php';
}
spl_autoload_register('ChargerClasse3');
$Sphere1 = new Sphere(["rayon" => 50]);
echo $Sphere1->__toString();

