 <?php
 class Rectangle
{

    /*****************Attributs***************** */
    private $_longueur;
    private $_largeur;

    /*****************Accesseurs***************** */

     public function getLongueur()
    {
        return $this->longueur;
    }

    public function setLongueur($longueur)
    {
        $this->longueur = $longueur;
    }

    public function getLargeur()
    {
        return $this->largeur;
    }

    public function setLargeur($largeur)
    {
        $this->largeur = $largeur;
    }}
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
    // parametre 
// return perimetre
    // @ longeur
    // @ largeur
function perimetre(){
2*($this->getLargeur()+$this->getLongueur());
return perimetre;
}
 // parametre 
// return perimetre
    // @ longeur
    // @ largeur

function aire(){
    $this->getLargueur*$this->getLongeur;

return aire;
}
function __toString()
{echo "Longeur:".$this->getLongeur;"Largeur:".$this->getLargeur;"Périmètre:".perimetre();"Aire:".aire();
    
}


//     /**
//      * Transforme l'objet en chaine de caractères
//      *
//      * @return String
//      */
//     public function toString()
//     {
//         return "";
//     }

//     /**
//      * Renvoi vrai si l'objet en paramètre est égal à l'objet appelant
//      *
//      * @param [type] $obj
//      * @return bool
//      */
//     public function equalsTo($obj)
//     {
//         return true;
//     }
//     /**
//      * Compare 2 objets
//      * Renvoi 1 si le 1er est >
//      *        0 si ils sont égaux
//      *        -1 si le 1er est <
//      *
//      * @param [type] $obj1
//      * @param [type] $obj2
//      * @return void
//      */
//     public static function compareTo($obj1, $obj2)
//     {
//         return 0;
//     }

   
// }