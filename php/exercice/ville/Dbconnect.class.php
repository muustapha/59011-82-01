<?php
class DbConnect

{

    /*****************Attributs***************** */
    private static $db;

public static function getDb()
{
    return self::$db;
}
public static function init()
{ try {
    self::$db = new PDO('mysql:host=localhost;dbname=villedb;charset=utf8', 'root', '');
    self::$db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
} catch (Exception $e) {
    die('Erreur : ' . $e->getMessage());
}
}

}
   
