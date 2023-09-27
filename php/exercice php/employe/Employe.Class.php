<?php
class Employe
{

    /*****************Attributs***************** */
    private $_nom;
    private $_prenom;
    private $_dateEmbauche;
    private $_fonction;
    private $_salaireAnnuel;
    private $_serviceEmploye;
    static public $_compteur;
    private $_agence;
    /*****************Accesseurs***************** */
    public function getNom()
    {
        return $this->_nom;
    }

    public function setNom($nom)
    {
        $this->_nom = $nom;
    }

    public function getPrenom()
    {
        return $this->_prenom;
    }

    public function setPrenom($prenom)
    {
        $this->_prenom = $prenom;
    }

    public function getDateEmbauche()
    {
        return $this->_dateEmbauche;
    }

    public function setDateEmbauche($dateEmbauche)
    {
        $this->_dateEmbauche = $dateEmbauche;
    }

    public function getFonction()
    {
        return $this->_fonction;
    }

    public function setFonction($fonction)
    {
        $this->_fonction = $fonction;
    }

    public function getSalaireAnnuel()
    {
        return $this->_salaireAnnuel;
    }

    public function setSalaireAnnuel($salaireAnnuel)
    {
        $this->_salaireAnnuel = $salaireAnnuel;
    }

    public function getServiceEmploye()
    {
        return $this->_serviceEmploye;
    }

    public function setServiceEmploye($serviceEmploye)
    {
        $this->_serviceEmploye = $serviceEmploye;
    }

    public function getCompteur()
    {
        return $this->_compteur;
    }

    public function setCompteur($compteur)
    {
        $this->_compteur = $compteur;
    }

    public function getAgence()
    {
        return $this->_agence;
    }

    public function setAgence(Agence $agence)
    {
        $this->_agence = $agence;
    }


    /*****************Constructeur***************** */

    public function __construct(array $options = [])
    {
        if (!empty($options)) // empty : renvoi vrai si le tableau est vide
        {
            $this->hydrate($options);
        }
       self::setCompteur(self::getCompteur() + 1);
    }
 

    public function hydrate($data)
    {
        foreach ($data as $key => $value) {
            $methode = "set" . ucfirst($key); //ucfirst met la 1ere lettre en majuscule
            if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
            {
                $this->$methode($value);
            }
        }
  
    }

    /*****************Autres Méthodes***************** */
  
    
    public static function compareToNomPrenom($obj1, $obj2)
    {
        
            if (strcmp($obj1->getNom(),$obj2->getNom())==0)
            {
                return strcmp($obj1->getPrenom(),$obj2->getPrenom());
            }
            return strcmp($obj1->getNom(),$obj2->getNom());
    }
    
    public static function compareToServiceNomPrenom($obj1, $obj2)
    {
        if ($obj1->getService() < $obj2->getService())
        {
            return -1;
        }
        else if ($obj1->getService() > $obj2->getService())
        {
            return 1;
        }
        else
        {
            return self::compareToNomPrenom($obj1, $obj2);
        }
  
 
     

    function anciennete()
    {
        $dateEmbauche = new DateTime($this->getDateEmbauche());
        $dateDuJour = new DateTime();
        $interval = $dateEmbauche->diff($dateDuJour);
        return $interval->format('%y');
    }




    function PrimeAnnuelle()
    {

        return $this->getSalaireAnnuel()*1000 * 0.05;
    }
    function PrimeAnciennete()
    {
        return ($this->getSalaireAnnuel()*1000 * 0.02) * $this->anciennete();
    }

    function PrimeTotale()
    {
        return $this->PrimeAnnuelle() + $this->PrimeAnciennete();
    }


    function __toString()
    {
        return  "Ordre de transfert envoyé à la banque pour un montant de :" . $this->primeTotale() . "euros.";
    }






    function ordreTransfert()
    {
        $dateVersement = new DateTime('2023-09-26'); // Date de versement
        $dateDuJour = new DateTime();

        $dateDuJour->format('m-d') == $dateVersement->format('m-d');
        return "Ordre de transfert envoyé à la banque pour un montant de : " . $this->primeTotale() . " euros.";
    }
}

?>





// function NombreEploye()
// {
//     return count($ListeEmploye());
// }

// function TrieEmployeNomPrenom()
// {
//     return sort($ListeEmploye(),["Nom","Prenom"]);
// }

// function TrieEmployeServiceNomPrenom()
// {
//     return sort($ListeEmploye(),["$Service","Nom","Prenom"]);

// }
