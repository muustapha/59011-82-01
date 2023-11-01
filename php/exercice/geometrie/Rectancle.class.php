<?php
class Rectangle
{
    /*****************Attributs***************** */
    private $_longueur;
    private $_largeur;

    /*****************Accesseurs***************** */
    public function getLongueur()
    {
        return $this->_longueur;
    }

    public function setLongueur($longueur)
    {
        $this->_longueur = $longueur;
    }

    public function getLargeur()
    {
        return $this->_largeur;
    }

    public function setLargeur($largeur)
    {
        $this->_largeur = $largeur;
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
            if (is_callable([$this, $methode])) // is_callable verifie que la methode existe
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
    function perimetre()
    {
        return 2 * ($this->getLargeur() + $this->getLongueur());
    }

    // parametre 
    // return aire
    // @ longeur
    // @ largeur
    function aire()
    {
        return $this->getLargeur() * $this->getLongueur();
    }

    function __toString()
    {
        return "Longeur:".$this->getLongueur()." Largeur:".$this->getLargeur()." Perimetre:".$this->perimetre()." Aire:".$this->aire();
    }
}

    ?>