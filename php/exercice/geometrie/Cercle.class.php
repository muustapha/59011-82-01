<?php
class Cercle 
{
    /*****************Attributs***************** */
    private $_diametre;
    private $_rayon;

    /*****************Accesseurs***************** */
    public function get_diametre()
    {
        return $this->_diametre;
    }

    public function set_diametre($_diametre)
    {
        $this->_diametre = $_diametre;
        $this->_rayon = $_diametre / 2; // mise à jour du rayon
        return $this;
    }

    public function get_rayon()
    {
        return $this->_rayon;
    }

    public function set_rayon($_rayon)
    {
        $this->_rayon = $_rayon;
        $this->_diametre = $_rayon * 2; // mise à jour du diamètre
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
            if (is_callable([$this, $methode])) // is_callable verifie que la methode existe
            {
                $this->$methode($value);
            }
        }
    }


    /*****************Autres Méthodes***************** */
    function perimetre()
    {
        return 2 * pi() * $this->get_rayon();
    }

    function aire()
    {
        return pi() * pow($this->get_rayon(), 2);
    }

    function __toString()
    {
        return "diametre:".$this->get_diametre()." perimetre:".$this->perimetre()." aire:".$this->aire();
    }
}


?>