<?php

class Voiture
{

    /*****************Attributs***************** */
   private $_couleur;
   private $_marque;
   private $_modèle;
   private $_nbreDeKilometres;
   private $_motorisation;
    
    /*****************Accesseurs***************** */

    public function getCouleur()
    {
        return $this->couleur;
    }

    public function setCouleur($couleur)
    {
        $this->couleur = $couleur;
    }

    public function getMarque()
    {
        return $this->marque;
    }

    public function setMarque($marque)
    {
        $this->marque = $marque;
    }

    public function getModèle()
    {
        return $this->modèle;
    }

    public function setModèle($modèle)
    {
        $this->modèle = $modèle;
    }

    
    public function getNbreDeKilometre()
    {
        return $this->nbreDeKilometre;
    }

    public function setNbreDeKilometres($nbreDeKilometres)
    {
        $this->nbreDeKilometre = $nbreDeKilometre;
    }

    public function getMotorisation()
    {
        return $this->motorisation;
    }

    public function setMotorisation($motorisation)
    {
        $this->motorisation = $motorisation;
    }
}
    /*****************Constructeur***************** */

     function __construct(array $options = [])
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
     * Transforme l'objet en chaine de caractères
     *
     * @return String
     */
 function __toString ()
    {
  
echo "Cette voiture est une" $this->getModele, "de la marque" $this->.getMarque, "de couleur"$this-> getcouleur, "de motorisation"
getMotorisation,$this->getNbreDeKilometres "avec Nb de kilomètres," 
      return "";
    }
    
$objet1 = new voiture ([
'marque'=>"citroen",
"modele"=>"c4",
"nbreDeKilometre"=>10000,


]);
$objet2 = new voiture([
"marque"=>"renauld",
"couleur"=>"rouge"
]);
print r ($objet)

// parametre 
// @ nbreDeKilometre


 function 

    // /**
    //  * Renvoi vrai si l'objet en paramètre est égal à l'objet appelant
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
    // {
    //     return 0;

    //