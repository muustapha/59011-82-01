
<?php
class Ville
{

    /*****************Attributs***************** */
    public $_nomVille;
    public $_codePostal;
    public $_idVille;
    public $_superficie;
    public $_nbHabitant;
    /*****************Accesseurs***************** */

    public function getNomVille()
    {
        return $this->_nomVille;
    }

    public function setNomVille($nomVille)
    {
        $this->_nomVille = $nomVille;
    }
    public function getCodePostal()
    {
        return $this->_codePostal;
    }

    public function setCodePostal($codePostal)
    {
        $this->_codePostal = $codePostal;
    }

    public function getIdVille()
    {
        return $this->_idVille;
    }

    public function setIdVille($idVille)
    {
        $this->_idVille = $idVille;
    }
    /*****************Constructeur***************** */

    public function __construct(array $options = [])
    {
        if (!empty($options)) // empty : renvoi vrai si le tableau est vide
        {
            $this->hydrate($options);
        }
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

    /**
     * Transforme l'objet en chaine de caractères
     *
     * @return String
     */
    public function toString()
    {
        return "";
    }

    /**
     * Renvoi vrai si l'objet en paramètre est égal à l'objet appelant
     *
     * @param [type] $obj
     * @return bool
     */
    public function equalsTo($obj)
    {
        return true;
    }
    /**
     * Compare 2 objets
     * Renvoi 1 si le 1er est >
     *        0 si ils sont égaux
     *        -1 si le 1er est <
     *
     * @param [type] $obj1
     * @param [type] $obj2
     * @return void
     */
    public static function compareTo($obj1, $obj2)
    {
        return 0;
    }

    /**
     * Get the value of _superficie
     */ 
    public function getSuperficie()
    {
        return $this->_superficie;
    }

    /**
     * Set the value of _superficie
     *
     * @return  self
     */ 
    public function setSuperficie($_superficie)
    {
        $this->_superficie = $_superficie;

        return $this;
    }



    /**
     * Get the value of _nbHabitant
     */ 
    public function get_nbHabitant()
    {
        return $this->_nbHabitant;
    }

    /**
     * Set the value of _nbHabitant
     *
     * @return  self
     */ 
    public function set_nbHabitant($_nbHabitant)
    {
        $this->_nbHabitant = $_nbHabitant;

        return $this;
    }
}
