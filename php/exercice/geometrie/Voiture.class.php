<?php

class Voiture
{

    /*****************Attributs***************** */
   private $_couleur;
   private $_marque;
   private $_modele;
   private $_nbreDeKilometres;
   private $_motorisation;
    
    /*****************Accesseurs***************** */

    public function getCouleur()
    {
        return $this->_couleur;
    }

    public function setCouleur($couleur)
    {
        $this->_couleur = $couleur;
    }

    public function getMarque()
    {
        return $this->_marque;
    }

    public function setMarque($marque)
    {
        $this->_marque = $marque;
    }

    public function getModele()
    {
        return $this->_modele;
    }

    public function setModele($modele)
    {
        $this->_modele = $modele;
    }

    
    public function getNbreDeKilometres()
    {
        return $this->_nbreDeKilometres;
    }

    public function setNbreDeKilometres($nbreDeKilometres)
    {
        $this->_nbreDeKilometres = $nbreDeKilometres;
    }

    public function getMotorisation()
    {
        return $this->_motorisation;
    }

    public function setMotorisation($motorisation)
    {
        $this->_motorisation = $motorisation;
    }

    /*****************Constructeur***************** */

    public function __construct(array $options = [])
    {
        if (!empty($options)) // empty : renvoi vrai si le tableau est vide
        {
            $this->hydrate($options);
        }
    }                                
     function hydrate($data)
    {
        foreach ($data as $key => $value)
        {
            $methode = "set" . ucfirst($key); //ucfirst met la 1ere lettre en majuscule
            if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
            {
                $this->$methode($value);
            }
        }
    }

    /*****************Autres Méthodes***************** */
    
    /**
     * Transforme l'objet en chaine de caracteres
     *
     * @return String
     */

function __toString()
{
    return "Cette voiture est une " . $this->getModele() . " de la marque " . $this->getMarque() . " de couleur " . $this->getCouleur() . " de motorisation " . $this->getMotorisation() . " avec " . $this->getNbreDeKilometres() . " km.";
}
}
    
    
$objet1 = new Voiture ([
"marque"=>"citroen",
"modele"=>"c4",
"nbreDeKilometres"=>10000,
]);

$objet2 = new Voiture([
"marque"=>"renauld",
"couleur"=>"rouge",
]);
print_r ($objet);

?>
// parametre 
// @ nbreDeKilometre




    // /**
    //  * Renvoi vrai si l'objet en parametre est égal à l'objet appelant
    //  *
    //  * @param [type] $obj
    //  * @return bool
    //  */
    // function equalsTo($obj)
    // {
    //     return true;
    //  }
    // /**
    //  * Compare 2 objets
    //  * Renvoi 1 si le 1er est >
    //  *        0 si ils sont égaux
    //  *        -1 si le 1er est <
    //  *
    //  * @param [type] $obj1
    //  * @param [type] $obj2
    //  * @return void
    //  */
    //   public static function compareTo($obj1, $obj2)
    // 
    //     return 0;

    //