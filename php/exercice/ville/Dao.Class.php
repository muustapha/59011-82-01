<?php
 class Dao
{
      static public function add ($objet)
    {
        $db = DbConnect::getDb();
        $requete = $db->prepare("INSERT INTO ville (Properties) VALUES (:Properties)");
        $requete->bindValue(":Properties", $objet->getProperties());
        $requete->execute();
    }


    static public function update($objet)
    {
        $db = DbConnect::getDb();
        $requete = $db->prepare("UPDATE ville SET Properties=:Properties WHERE idVille=:idVille");
        $requete->bindValue(":Properties", $objet->getProperties());
        $requete->bindValue(":idVille", $objet->getIdVille());
        $requete->execute();
    } 
    static public function delete($objet)
    {
        $db = DbConnect::getDb();
        $requete = $db->prepare("DELETE FROM ville WHERE idVille=:idVille");
        $requete->execute();
    }

    public static function add($obj)
	{
		$db = DbConnect::getDb();
		$class = get_class($obj);
		$colonnes = $class::getAttributes();
		$requ = "INSERT INTO Ville_" . $class . "(";
		$values = "";
		$bindValue = [];

		for ($i = 1; $i < count($colonnes); $i++) {
			$methode = "get" . ucfirst($colonnes[$i]);
			if ($obj->$methode() !== null) {
				$requ .= $colonnes[$i] . ",";
				$values .= ":" . $colonnes[$i] . ",";
			}
		}
		$requ = substr($requ, 0, strlen($requ) - 1);
		$values = substr($values, 0, strlen($values) - 1);
		$requ .= ") VALUES (" . $values . ")";
		$q = $db->prepare($requ);

		for ($i = 1; $i < count($colonnes); $i++) {
			$methode = "get" . ucfirst($colonnes[$i]);
			if ($obj->$methode() !== null)
				$q->bindValue(":" . $colonnes[$i], $obj->$methode());
		}
		$q->execute();
		return $db->lastInsertId();
    }






}