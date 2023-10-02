<?php
class Equipe
{

    /*****************Attributs***************** */
    private $_nom;
    private $_pays;
    private $_entraineur;   
    private $_joueur = [] ;
    private $_palmares = [];
    private $_points ;
    /*****************Accesseurs***************** */
    /**
     * Get the value of _nom
     */ 
    public function get_nom()
    {
        return $this->_nom;
    }

    /**
     * Set the value of _nom
     *
     * @return  self
     */ 
    public function set_nom($_nom)
    {
        $this->_nom = $_nom;

        return $this;
    }

    /**
     * Get the value of _pays
     */ 
    public function get_pays()
    {
        return $this->_pays;
    }

    /**
     * Set the value of _pays
     *
     * @return  self
     */ 
    public function set_pays($_pays)
    {
        $this->_pays = $_pays;

        return $this;
    }

    /**
     * Get the value of _entraineur
     */ 
    public function get_entraineur()
    {
        return $this->_entraineur;
    }

    /**
     * Set the value of _entraineur
     *
     * @return  self
     */ 
    public function set_entraineur($_entraineur)
    {
        $this->_entraineur = $_entraineur;

        return $this;
    }

    /**
     * Get the value of _joueur
     */ 
    public function get_joueur()
    {
        return $this->_joueur;
    }

    /**
     * Set the value of _joueur
     *
     * @return  self
     */ 
    public function set_joueur($_joueur)
    {
        $this->_joueur = $_joueur;

        return $this;
    }

    /**
     * Get the value of _palmares
     */ 
    public function get_palmares()
    {
        return $this->_palmares;
    }

    /**
     * Set the value of _palmares
     *
     * @return  self
     */ 
    public function set_palmares($_palmares)
    {
        $this->_palmares = $_palmares;

        return $this;
    }

    /**
     * Get the value of _points
     */ 
    public function get_points()
    {
        return $this->_points;
    }

    /**
     * Set the value of _points
     *
     * @return  self
     */ 
    public function set_points($_points)
    {
        $this->_points = $_points;

        return $this;
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


}