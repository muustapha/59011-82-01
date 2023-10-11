<?php

public static function add($obj)
	{
		$db = DbConnect::getDb();
		$class = get_class($obj);
		$colonnes = $class::getAttributes();
		$requ = "INSERT INTO ville_" . $class . "(";
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
		return $db->lastInsertId();}
		


		public static funtion update($objet){

		$db = DbConnect::getDb();
		$class = get_class($objet);
		$colonnes = $class::getAttributes();
		$reque .= "UPDATE ville_" . $class . " SET ";
		$bindValue = [];

		for ($i = 1; $i < count($colonnes); $i++) {
			$methode = "get" . ucfirst($colonnes[$i]);
			if ($objet->$methode() !== null) {
				$requ .= $colonnes[$i] . "=:" . $colonnes[$i] . ",";
			}
		}
		$requ = substr($requ, 0,- 1);
		$requ .= " WHERE " . $colonnes[0] . " = " . $objet->$colonnes[0] . "";
		$q = $db->prepare($requ);

		for ($i=1 ; $i<count ($colonnes);i++){
			$methode = "get" . ucfirst($colonnes[$i]);
			if ($objet->$methode() !== null)
				$q->bindValue(":" . $colonnes[$i], $objet->$methode());
		}  
		$q->execute();
		return $db->lastInsertId();}
		
		