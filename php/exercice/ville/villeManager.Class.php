<?php
class VilleManager
{    static public function add ($objet)
    {
        $db = DbConnect::getDb();
        $colonnes = $class::getAttributes();
        $requete = $db->prepare("INSERT INTO villeDb (Properties) VALUES (:Properties)");
        $requete->bindValue(":Properties", $objet->getProperties());
        $requete->execute();
    }
    // public static function add($obj)
	// {
	// 	$db = DbConnect::getDb();
	// 	$class = get_class($obj);
	// 	$colonnes = $class::getAttributes();
	// 	$requ = "INSERT INTO Ville_" . $class . "(";
	// 	$values = "";
	// 	$bindValue = [];

	// 	for ($i = 1; $i < count($colonnes); $i++) {
	// 		$methode = "get" . ucfirst($colonnes[$i]);
	// 		if ($obj->$methode() !== null) {
	// 			$requ .= $colonnes[$i] . ",";
	// 			$values .= ":" . $colonnes[$i] . ",";
	// 		}
	// 	}
	// 	$requ = substr($requ, 0, strlen($requ) - 1);
	// 	$values = substr($values, 0, strlen($values) - 1);
	// 	$requ .= ") VALUES (" . $values . ")";
	// 	$q = $db->prepare($requ);

	// 	for ($i = 1; $i < count($colonnes); $i++) {
	// 		$methode = "get" . ucfirst($colonnes[$i]);
	// 		if ($obj->$methode() !== null)
	// 			$q->bindValue(":" . $colonnes[$i], $obj->$methode());
	// 	}
	// 	$q->execute();
	// 	return $db->lastInsertId();
    // }
    // static public function add(Ville $ville)
    // {
    //     $db = DbConnect::getDb();
    //     $requete = $db->prepare("INSERT INTO ville (nomVille, codePostal,superficie,nbHabitant) VALUES (:nomVille, :codePostal,superficie,nbHabitant)");
    //     $requete->bindValue(":nomVille", $ville->getNomVille());
    //     $requete->bindValue(":codePostal", $ville->getCodePostal());
    //     $requete->bindValue(":superficie", $ville->getSuperficie());
    //     $requete->execute();
    // }

    static public function update(Ville $ville)
    {
        $db = DbConnect::getDb();
        $requete = $db->prepare("UPDATE ville SET nomVille=:nomVille, codePostal=:codePostal WHERE idVille=:idVille");
        $requete->bindValue(":nomVille", $ville->getNomVille());
        $requete->bindValue(":codePostal", $ville->getCodePostal());
        $requete->bindValue(":idVille", $ville->getIdVille());
        $requete->execute();
    }
    static public function delete(Ville $ville)
    {
        $db = DbConnect::getDb();
        $requete = $db->prepare("DELETE FROM ville WHERE idVille=:idVille");
        $requete->execute();
    }


    static public function findById($id)
    {
        $db = DbConnect::getDb();
        $requete = $db->prepare("SELECT * FROM ville WHERE idVille=:idVille");
        $requete->bindValue(":idVille", $id);
        $requete->execute();
        $resultat = $requete->fetch(PDO::FETCH_ASSOC);
        if ($resultat != false) {
            return new Ville($resultat);
        } else {
            return false;
        }
    }

    static public function select(?array $colonnes = null, ?array $conditions = null, ?array $orderBy = null, ?string $limit = null, ?bool $debug = false)
    {
        $db = DbConnect::getDb();
        $requete = "SELECT ";
        if ($colonnes == null) {
            $requete .= "*";
        } else {
            foreach ($colonnes as $colonne) {
                $requete .= $colonne . ",";
            }
            $requete = substr($requete, 0, strlen($requete) - 1);
        }
        $requete .= " FROM ville";
        if ($conditions != null) {
            $requete .= " WHERE ";
            foreach ($conditions as $key => $value) {
                $requete .= $key .  $value . " AND ";
            }
            $requete = substr($requete, 0, strlen($requete) - 4);
        }
        if ($orderBy != null) {
            $requete .= " ORDER BY ";
            foreach ($orderBy as $key => $value) {
                $requete .= $key . " " . $value . ",";
            }
            $requete = substr($requete, 0, strlen($requete) - 1);
        }
        if ($limit != null) {
            $requete .= " LIMIT " . $limit;
        }
        var_dump($requete);
        $resultat = $db->query($requete);
        if ($debug) {
            $liste = [];
            while ($donnees = $resultat->fetch(PDO::FETCH_ASSOC)) {
                if ($donnees != false) {
                    $liste[] = $donnees;
                }
            }
            return $liste;
        } else {
            $liste = [];
            while ($donnees = $resultat->fetch(PDO::FETCH_ASSOC)) {
                if ($donnees != false) {
                    $liste[] = new Ville($donnees);
                }
            }
            return $liste;
        }
    }

    static public function count(?array $colonnes = null, ?array $conditions = null, ?string $orderBy = null, ?string $limit = null, ?bool $debug = false)
    {
        // $colonnes = ($colonnes == null) ? Ville::getAttributes() : $colonnes;
        $liste = self::select($colonnes, $conditions, $orderBy, $limit, $debug);
        if ($liste != false) {
            return count($liste);
        }
        return 0;
    }

    private static function conditionSelect($conditions, $table)
    {
        $req = " WHERE ";
        foreach ($conditions as $colonne => $valeur) {
            if ($colonne != "fullTexte") {
                // cas du in
                if (is_array($valeur)) {
                    $req .= $colonne . " IN (" . implode(",", $valeur) . ") AND ";
                } else if (!(strpos((string) $valeur, "%") === false)) { //cas like
                    $req .= $colonne . ' LIKE "' . $valeur . '" AND ';
                } else if (strpos((string) $valeur, "->")) { //cas between
                    $tab = explode("->", $valeur);
                    $req .= $colonne . " BETWEEN " . $tab[0] . " AND " . $tab[1] . " AND ";
                } 
                // Cas où l'on veut qu'une colonne soit à null
                else if (is_null($valeur)){
                    $req .= $colonne." IS NULL AND ";
                }
                else { //cas valeur simple
                    $req .= $colonne . " = \"" . $valeur . "\" AND ";
                }
            } elseif($valeur!="") {
                $rechercheFullTexte="";
                $colonnes  = $table::getAttributes();
                foreach ($colonnes as $col) {
                    if(strtolower(substr($col,0,4))!="date")
                    $rechercheFullTexte .= $col .' like "%'.$valeur.'%" OR ';
                }
                $rechercheFullTexte = substr($rechercheFullTexte, 0, strlen($rechercheFullTexte) - 3);
                $req .= "(".$rechercheFullTexte.") AND ";
            }
        }
        //On retire le dernier AND
        $req = substr($req, 0, strlen($req) - 4);
        return $req;
    }

    private static function getProperties(string $classe)
    {
        // Instanciatin de la classe
        $obj = new $classe();

        // récupération des propriétés de la classe
        $properties = (new ReflectionClass($obj))->getProperties();

        $propertiesListe = [];
        // création de la liste des propriétés
        foreach($properties as $property)
        {
            $propertiesListe[] = substr($property->getName(), 1);
        }
        
        // conversion en chaine de caractères
        $propertiesStr = implode(", ", $propertiesListe);
        
        return $propertiesStr;
    }








}