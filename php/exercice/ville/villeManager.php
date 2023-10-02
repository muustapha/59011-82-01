<?php
class VilleManager
{

    static public function add(Ville $ville)
    {
        $db = DbConnect::getDb();
        $requete = $db->prepare("INSERT INTO ville (nomVille, codePostal) VALUES (:nomVille, :codePostal)");
        $requete->bindValue(":nomVille", $ville->getNomVille());
        $requete->bindValue(":codePostal", $ville->getCodePostal());
        $requete->execute();
    }

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
}
